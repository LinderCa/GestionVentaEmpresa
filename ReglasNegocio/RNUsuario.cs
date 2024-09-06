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
    public class RNUsuario
    {
        private readonly static string cadenaConexion = @"server=localhost;port=3306;user id=root;password=;database=prograiii2022-ii";

        public void Actualizar(Usuario usuario)
        {
            string sql = $@"UPDATE usuario
                            SET CodigoTrabajador={usuario.Trabajador.Codigo}, Nombre='{usuario.Nombre}', Clave='{usuario.Clave}', 
                                Vigente={(usuario.Vigente == true ? 1 : 0)}
                            WHERE Codigo={usuario.Codigo}";

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

        public Usuario Leer(int codigo)
        {
            Usuario usuario = null;
            string sql = $@"select u.Nombre, u.Vigente, t.Nombres as nombreTrabajador, 
                                    t.ApellidoPaterno, t.ApellidoMaterno, t.Codigo as CodigoTrabajador, u.Clave  
                            from usuario u 
                            inner join trabajador t 
                            on u.CodigoTrabajador = t.Codigo 
                            WHERE u.Codigo = {codigo}";

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
                                usuario = new Usuario()
                                {
                                    Codigo = codigo,
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Vigente = dr.GetInt16(dr.GetOrdinal("Vigente")) == 1,
                                    Clave = dr.GetString(dr.GetOrdinal("Clave")),
                                    Trabajador = new Trabajador()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTrabajador")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                        Nombres = dr.GetString(dr.GetOrdinal("nombreTrabajador")),
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

            return usuario;
        }

        public List<Usuario> Listar()
        {
            List <Usuario> usuarios = null;
            string sql = $@"select u.Nombre, u.Vigente, t.Nombres as nombreTrabajador, 
                                    t.ApellidoPaterno, t.ApellidoMaterno, t.Codigo as CodigoTrabajador, u.Codigo
                            from usuario u 
                            inner join trabajador t 
                            on u.CodigoTrabajador = t.Codigo ";

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            usuarios = new List<Usuario>();
                            while (dr.Read() == true)
                            {
                                usuarios.Add(new Usuario()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Vigente = dr.GetInt16(dr.GetOrdinal("Vigente")) == 1,
                                    Trabajador = new Trabajador()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTrabajador")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                        Nombres = dr.GetString(dr.GetOrdinal("nombreTrabajador")),
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

            return usuarios;
        }

        public Usuario Login(string nombre, string clave)
        {
            Usuario usuario = null;
            string sql = $@"SELECT u.Codigo, u.Nombre as NombreUsuario,
	                               t.Codigo as CodigoTrabajador, 
	                               t.Nombres as NombreTrabajador,
	                               t.ApellidoPaterno, t.ApellidoMaterno
                            FROM Usuario as u
                            inner join Trabajador as t 
                            on u.CodigoTrabajador = t.Codigo
                            WHERE Nombre = '{nombre}' AND Clave = '{clave}' AND Vigente = 1";

            try
            {
                using (var cn = new MySqlConnection(cadenaConexion))
                {
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                usuario = new Usuario() {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreUsuario")),
                                    Trabajador = new Trabajador()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTrabajador")),
                                        Nombres = dr.GetString(dr.GetOrdinal("NombreTrabajador")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno"))
                                    },
                                    Vigente = true
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
            return usuario;
        }

        public void Registrar(Usuario usuario)
        {
            string sql = $@"INSERT INTO usuario
                            (CodigoTrabajador, Nombre, Clave, Vigente)
                            VALUES({usuario.Trabajador.Codigo}, '{usuario.Nombre}', '{usuario.Clave}', 1)";
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
    }
}
