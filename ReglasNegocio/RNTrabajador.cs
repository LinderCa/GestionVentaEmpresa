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

    public class RNTrabajador
    {

        private readonly static string cadenaConexion = "server=localhost;port=3306;user id=root;password=;database=prograiii2022-ii";

        public void Registrar(Trabajador trabajador)
        {
            string sql = $@"INSERT INTO Trabajador ( CodigoEmpresa, Nombres, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Genero, 
                            EstadoCivil, Sueldo)
                        VALUES( {trabajador.Empresa.Codigo},  '{trabajador.Nombres}', '{trabajador.ApellidoPaterno}', 
                            '{trabajador.ApellidoMaterno}', '{trabajador.FechaNacimiento.ToString("yyyyMMdd")}', '{trabajador.Genero}',
                            '{trabajador.EstadoCivil}', {trabajador.Sueldo})";

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
        public void Actualizar(Trabajador trabajador)
        {
            string sql = $@"UPDATE Trabajador  
                        SET CodigoEmpresa = {trabajador.Empresa.Codigo}, Nombres = '{trabajador.Nombres}', 
                            ApellidoPaterno = '{trabajador.ApellidoPaterno}', ApellidoMaterno = '{trabajador.ApellidoMaterno}', 
                            FechaNacimiento = '{trabajador.FechaNacimiento.ToString("yyyyMMdd")}', Genero = '{trabajador.Genero}', 
                            EstadoCivil = '{trabajador.EstadoCivil}', Sueldo = {trabajador.Sueldo}
                        WHERE Codigo = {trabajador.Codigo}";

            try
            {
                using (var cn = new MySqlConnection(RNTrabajador.cadenaConexion))
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
        public Trabajador Leer(int codigo)
        {
            Trabajador trabajador = null;
            string sql = $@"SELECT T.CodigoEmpresa, T.ApellidoPaterno, T.ApellidoMaterno, T.Nombres, T.FechaNacimiento, 
                          T.Genero, T.EstadoCivil, T.Sueldo
                        FROM Trabajador T
                        WHERE T.Codigo = {codigo}";

            try
            {
                using (var cn = new MySqlConnection(RNTrabajador.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                trabajador = new Trabajador()
                                {
                                    Codigo = codigo,
                                    ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                    ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento")),
                                    Genero = dr.GetString(dr.GetOrdinal("Genero")),
                                    EstadoCivil = dr.GetString(dr.GetOrdinal("EstadoCivil")),
                                    Sueldo = (double)dr.GetDecimal(dr.GetOrdinal("Sueldo")),
                                    Empresa = new Empresa()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEmpresa"))
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

            return trabajador;
        }

        public List<Trabajador> Listar(string nombre)
        {
            List<Trabajador> trabajadores = null;
            string sql = $@"SELECT T.Codigo, T.ApellidoPaterno, T.ApellidoMaterno, T.Nombres, T.Sueldo, E.RazonSocial
                        FROM Empresa E JOIN Trabajador T ON T.CodigoEmpresa = E.Codigo
                        WHERE T.ApellidoPaterno + ' ' + T.ApellidoMaterno + ' ' + T.Nombres LIKE '{nombre}%'
                        ORDER BY E.RazonSocial";

            try
            {
                using (var cn = new MySqlConnection(RNTrabajador.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            trabajadores = new List<Trabajador>();
                            while (dr.Read() == true)
                            {
                                trabajadores.Add(new Trabajador()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                    ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Sueldo = (double)dr.GetDecimal(dr.GetOrdinal("Sueldo")),
                                    Empresa = new Empresa()
                                    {
                                        RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial"))
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

            return trabajadores;
        }


        public List<Trabajador> ListarVigentes()
        {
            List<Trabajador> trabajadores = null;
            string sql = $@"SELECT T.Codigo, T.ApellidoPaterno, T.ApellidoMaterno, T.Nombres
                        FROM Trabajador T
                        ORDER BY T.ApellidoPaterno";

            try
            {
                using (var cn = new MySqlConnection(RNTrabajador.cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            trabajadores = new List<Trabajador>();
                            while (dr.Read() == true)
                            {
                                trabajadores.Add(new Trabajador()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                    ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
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

            return trabajadores;
        }

    }
}
