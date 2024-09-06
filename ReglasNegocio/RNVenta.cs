using Entidades;
using Gestion;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReglasNegocio
{
    public class RNVenta
    {

        private readonly static string cadenaConexion = "server=localhost;port=3306;user id=root;password=;database=prograiii2022-ii";

        public void DarDeBaja(int codigo)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            String sql = $@"update Venta 
                            set Vigente = case Vigente
			                              when 1 then 0
			                              else 1 end
                            where Codigo = {codigo}";

            try
            {
                cn = new MySqlConnection();
                cn.ConnectionString = RNVenta.cadenaConexion;
                cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
                cn = null;
            }
        }

        public void Registrar(Venta venta)
        {
            MySqlTransaction tr = null;
            string sql = $@"INSERT INTO Venta( TipoDocumento, Serie, Numero, Fecha, Vigente, CodigoTrabajador)
                        VALUES( '{venta.TipoDocumento}', '{venta.Serie}', {venta.Numero}, '{venta.Fecha.ToString("yyyy-MM-dd H:mm:ss")}', 1, {venta.Trabajador.Codigo})";
            int codigo;

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (tr = cn.BeginTransaction())
                    {
                        using (var cmd = new MySqlCommand(sql, cn))
                        {
                            cmd.Transaction = tr;
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "SELECT @@IDENTITY AS Codigo";
                            codigo = Int16.Parse(cmd.ExecuteScalar().ToString());

                            foreach (var det in venta.Detalles)
                            {
                                cmd.CommandText = $@"INSERT INTO DetalleVenta( CodigoVenta, CodigoProducto, Cantidad, PrecioUnitario)
                            VALUES( {codigo}, {det.Producto.Codigo}, {det.Cantidad}, {det.Precio})";

                                cmd.ExecuteNonQuery();
                            }
                        }

                        tr.Commit(); // finalizar transaccion confirmando
                    }
                }
            }
            catch (Exception ex)
            {
                tr.Rollback(); //finalizar transacción cancelando
                throw ex;
            }
        }

        public List<Venta> ListarPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> ventas = null;
            string sql = $@"SELECT V.TipoDocumento, V.Serie, V.Numero, SUM( DV.Cantidad * DV.PrecioUnitario) AS Total
	                      FROM Venta V JOIN DetalleVenta DV ON V.Codigo = DV.CodigoVenta
	                      WHERE V.Vigente = 1 AND TIMESTAMPDIFF( DAY, V.Fecha, '{fechaInicio.ToString("yyyyMMdd")}') <= 0 AND TIMESTAMPDIFF( DAY, V.Fecha, '{fechaFin.ToString("yyyyMMdd")}') >= 0
	                      GROUP BY V.TipoDocumento, V.Serie, V.Numero";

            try
            {
                using (var cn = new MySqlConnection(RNVenta.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            ventas = new List<Venta>();
                            while (dr.Read() == true)
                            {
                                ventas.Add(new Venta()
                                {
                                    TipoDocumento = dr.GetString(dr.GetOrdinal("TipoDocumento")),
                                    Serie = dr.GetString(dr.GetOrdinal("Serie")),
                                    Numero = dr.GetInt16(dr.GetOrdinal("Numero")),
                                    TotalBD = (double)dr.GetDecimal(dr.GetOrdinal("Total")),
                                    Vigente = true
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ventas;
        }

        public List<Venta> ListarTodoPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> ventas = null;
            string sql = $@"SELECT V.TipoDocumento, V.Serie, V.Numero, SUM( DV.Cantidad * DV.PrecioUnitario) AS Total, V.Vigente, V.Codigo 
	                      FROM Venta V JOIN DetalleVenta DV ON V.Codigo = DV.CodigoVenta
	                      WHERE TIMESTAMPDIFF( DAY, V.Fecha, '{fechaInicio.ToString("yyyyMMdd")}') <= 0 AND TIMESTAMPDIFF( DAY, V.Fecha, '{fechaFin.ToString("yyyyMMdd")}') >= 0
	                      GROUP BY V.TipoDocumento, V.Serie, V.Numero";

            try
            {
                using (var cn = new MySqlConnection(RNVenta.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            ventas = new List<Venta>();
                            while (dr.Read() == true)
                            {
                                ventas.Add(new Venta()
                                {
                                    TipoDocumento = dr.GetString(dr.GetOrdinal("TipoDocumento")),
                                    Serie = dr.GetString(dr.GetOrdinal("Serie")),
                                    Numero = dr.GetInt16(dr.GetOrdinal("Numero")),
                                    TotalBD = (double)dr.GetDecimal(dr.GetOrdinal("Total")),
                                    Vigente = dr.GetInt16(dr.GetOrdinal("Vigente")) == 1,
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ventas;
        }

        public List<Venta> ListarPorDocumentoFecha(DateTime fecha, string documento)
        {
            List<Venta> ventas = null;
            string sql = $@"SELECT V.TipoDocumento, V.Serie, V.Numero, SUM( DV.Cantidad * DV.PrecioUnitario) AS Total 
	                      FROM Venta V JOIN DetalleVenta DV ON V.Codigo = DV.CodigoVenta
	                      WHERE TIMESTAMPDIFF( DAY, V.Fecha, '{fecha.ToString("yyyyMMdd")}') <= 0 and V.TipoDocumento = '{documento}'
	                      GROUP BY V.TipoDocumento, V.Serie, V.Numero";
            try
            {
                using (var cn = new MySqlConnection(RNVenta.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            ventas = new List<Venta>();
                            while (dr.Read() == true)
                            {
                                ventas.Add(new Venta()
                                {
                                    TipoDocumento = dr.GetString(dr.GetOrdinal("TipoDocumento")),
                                    Serie = dr.GetString(dr.GetOrdinal("Serie")),
                                    Numero = dr.GetInt16(dr.GetOrdinal("Numero")),
                                    TotalBD = (double)dr.GetDecimal(dr.GetOrdinal("Total")),
                                    Vigente = true
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ventas;
        }

        public List<ReporteListadoProductosVendidosPorAnio> ListarProductosVendidosPorAnio(DateTime fecha)
        {
            List<ReporteListadoProductosVendidosPorAnio> encontrados = null;
            string sql = $@"select p.Nombre ,SUM(d.Cantidad) as Cantidad, SUM( d.Cantidad * d.PrecioUnitario) AS Total 
                            from venta v
                            inner join detalleventa d 
                            on v.Codigo  = d.CodigoVenta 
                            inner join producto p 
                            on p.Codigo  = d.CodigoProducto 
                            where year(Fecha) = '{fecha.ToString("yyyy")}'
                            group by d.CodigoProducto ";
            try
            {
                using (var cn = new MySqlConnection(RNVenta.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            encontrados = new List<ReporteListadoProductosVendidosPorAnio>();
                            while (dr.Read() == true)
                            {
                                encontrados.Add(new ReporteListadoProductosVendidosPorAnio()
                                {
                                    Producto = new Producto
                                    {
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                    },
                                    Cantidad = dr.GetInt16(dr.GetOrdinal("Cantidad")),
                                    TotalVendido = (double)dr.GetDecimal(dr.GetOrdinal("Total"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return encontrados;
        }
    }


}
