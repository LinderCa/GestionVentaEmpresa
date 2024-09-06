using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ReglasNegocio
{
    public class RNEmpresa
    {

        private readonly static string cadenaConexion = "server=localhost;port=3306;user id=root;password=;database=prograiii2022-ii";

        public void Registrar(Empresa empresa)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            string sql = $@"INSERT INTO Empresa( RazonSocial, RUC, Direccion, Telefono, Correo, Vigente)
                      VALUES('{empresa.RazonSocial}', '{empresa.RUC}', '{empresa.Dirección}', '{empresa.Telefono}', '{empresa.Correo}', 1)";

            try
            {
                cn = new MySqlConnection();
                cn.ConnectionString = RNEmpresa.cadenaConexion;
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

        public void Actualizar(Empresa empresa)
        {
            MySqlConnection cn = new MySqlConnection(RNEmpresa.cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("", cn);
            string sql = $@"UPDATE Empresa 
                        SET RazonSocial = '{empresa.RazonSocial}', RUC = '{empresa.RUC}', Direccion = '{empresa.Dirección}',
                            Telefono = '{empresa.Telefono}', Correo = '{empresa.Correo}',
                            Vigente = {(empresa.Vigente == true ? 1 : 0)}
                        WHERE Codigo = {empresa.Codigo}";
            cmd.CommandText = sql;

            try
            {
                cn.Open();
                cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                    cmd = null;
                }
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
                cn = null;
            }
        }

        public Empresa Leer(int Codigo)
        {
            Empresa empresa = null;
            MySqlConnection cn = new MySqlConnection(RNEmpresa.cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("", cn);
            MySqlDataReader dr = null;
            string sql = $@"SELECT  E.RazonSocial, E.RUC, E.Telefono, E.Direccion, E.Correo, E.Vigente
                        FROM Empresa E
                        WHERE E.Codigo = {Codigo}";
            cmd.CommandText = sql;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    empresa = new Empresa()
                    {
                        Codigo = Codigo,
                        RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                        RUC = dr.GetString(dr.GetOrdinal("RUC")),
                        Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                        Dirección = dr.GetString(dr.GetOrdinal("Direccion")),
                        Correo = dr.GetString(dr.GetOrdinal("Correo")),
                        Vigente = dr.GetInt16(dr.GetOrdinal("Vigente")) == 1
                    };
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dr != null && dr.IsClosed == false)
                {
                    dr.Close();
                }
                dr = null;
                if (cmd != null)
                {
                    cmd.Dispose();
                    cmd = null;
                }
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
                cn = null;
            }

            return empresa;
        }

        public List<Empresa> Listar()
        {
            List<Empresa> empresas = null;
            MySqlConnection cn = new MySqlConnection(RNEmpresa.cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("", cn);
            MySqlDataReader dr = null;
            string sql = @"SELECT  E.Codigo, E.RazonSocial, E.RUC, E.Vigente
                        FROM Empresa E
                        ORDER BY E.RazonSocial";
            cmd.CommandText = sql;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                empresas = new List<Empresa>();
                while (dr.Read() == true)
                {
                    empresas.Add(new Empresa()
                    {
                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                        RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                        RUC = dr.GetString(dr.GetOrdinal("RUC")),
                        Vigente = dr.GetInt16(dr.GetOrdinal("Vigente")) == 1
                    });
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dr != null && dr.IsClosed == false)
                {
                    dr.Close();
                }
                dr = null;
                if (cmd != null)
                {
                    cmd.Dispose();
                    cmd = null;
                }
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
                cn = null;
            }

            return empresas;
        }

        public List<Empresa> ListarVigentes()
        {
            List<Empresa> empresas = null;
            string sql = @"SELECT E.Codigo, E.RazonSocial 
                        FROM Empresa E 
                        WHERE E.Vigente = 1 
                        ORDER BY E.RazonSocial";

            try
            {
                using (var cn = new MySqlConnection(RNEmpresa.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            empresas = new List<Empresa>();
                            while (dr.Read() == true)
                            {
                                empresas.Add(new Empresa()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial"))
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

            return empresas;
        }

    }
}
