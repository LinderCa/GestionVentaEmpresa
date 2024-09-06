using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class RNProducto
    {

        private readonly static string cadenaConexion = "server=localhost;port=3306;user id=root;password=;database=prograiii2022-ii";

        public List<Producto> ListarVigentes()
        {
            List<Producto> productos = null;
            string sql = $@"SELECT P.Codigo, P.Nombre, P.Precio
                        FROM Producto P
                        WHERE P.Vigente = 1
                        ORDER BY P.Nombre";

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            productos = new List<Producto>();
                            while (dr.Read() == true)
                            {
                                productos.Add(new Producto()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Precio = (Double)dr.GetDecimal(dr.GetOrdinal("Precio"))
                                });
                            }
                            dr.Close();
                        }
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productos;
        }

        public List<Producto> Listar(string nombre)
        {
            List<Producto> productos = null;
            string sql = $@"SELECT p.Codigo, p.CodigoCategoria, c.Nombre as NombreCategoria, 
	                               p.Nombre, p.Precio, p.PrecioMinimo, p.Vigente
                            FROM producto as p
                            inner join categoria as c 
                            on p.CodigoCategoria = c.Codigo
                            where p.Nombre LIKE '{nombre}%' and p.vigente = 1";

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            productos = new List<Producto>();
                            while (dr.Read() == true)
                            {
                                productos.Add(new Producto()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Precio = dr.GetDouble(dr.GetOrdinal("Precio")),
                                    PrecioMinimo = dr.GetDouble(dr.GetOrdinal("PrecioMinimo")),
                                    Vigente = true,
                                    Categoria = new Categoria
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoCategoria")),
                                        Nombre = dr.GetString(dr.GetOrdinal("NombreCategoria")),
                                    }
                                });
                            }
                            dr.Close();
                        }
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productos;
        }

        public void Registrar(Producto producto)
        {
            string sql = $@"INSERT INTO Producto
                            (CodigoCategoria, Nombre, Descripcion, Precio, PrecioMinimo, Vigente)
                            VALUES({producto.Categoria.Codigo}, '{producto.Nombre}', '{producto.Descripcion}', 
                                   {producto.Precio}, {producto.PrecioMinimo}, 1)";

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Actualizar(Producto producto)
        {
            string sql = $@"UPDATE Producto
                            SET CodigoCategoria={producto.Categoria.Codigo}, Nombre='{producto.Nombre}', Descripcion='{producto.Descripcion}', 
                                Precio={producto.Precio}, PrecioMinimo={producto.PrecioMinimo}, Vigente={(producto.Vigente == true ? 1 : 0)}
                            WHERE Codigo={producto.Codigo}";

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Producto Leer(int codigo)
        {
            Producto producto = null;
            string sql = $@"SELECT p.Codigo, p.CodigoCategoria, c.Nombre as NombreCategoria, 
	                               p.Nombre, p.Precio, p.PrecioMinimo, p.Vigente, p.Descripcion
                            FROM producto as p
                            inner join categoria as c 
                            on p.CodigoCategoria = c.Codigo
                            WHERE p.Codigo = {codigo}";

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                producto = new Producto()
                                {
                                    Codigo = codigo,
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                                    Precio = dr.GetDouble(dr.GetOrdinal("Precio")),
                                    PrecioMinimo = dr.GetDouble(dr.GetOrdinal("PrecioMinimo")),
                                    Vigente = dr.GetInt16(dr.GetOrdinal("Vigente")) == 1,
                                    Categoria = new Categoria
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoCategoria")),
                                        Nombre = dr.GetString(dr.GetOrdinal("NombreCategoria")),
                                    }

                                };
                            }
                            dr.Close();
                        }
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return producto;
        }

        


    }

}
