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
    public class RNCategoria
    {
        private readonly static string cadenaConexion = @"server=localhost;port=3306;user id=root;password=;database=progiii2022-ii";

        public List<Categoria> ListarVigentes()
        {
            List<Categoria> categorias = null;
            MySqlConnection cn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("", cn);
            MySqlDataReader dr = null;
            string sql = @"select c.Codigo, c.Nombre, c.Descripcion, c.Vigente
                            from Categoria as c
                            where c.Vigente = 1
                            order by c.Nombre";
            cmd.CommandText = sql;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                categorias = new List<Categoria>();
                while (dr.Read() == true)
                {
                    categorias.Add(new Categoria()
                    {
                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                        Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                        Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
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

            return categorias;
        }

        public void Registrar(Categoria categoria)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            string sql = $@"INSERT INTO Categoria(Nombre, Descripcion, Vigente)
                      VALUES('{categoria.Nombre}', '{categoria.Descripcion}', 1)";

            try
            {
                cn = new MySqlConnection();
                cn.ConnectionString = cadenaConexion;
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

        public void Actualizar(Categoria categoria)
        {
            MySqlConnection cn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("", cn);
            string sql = $@"UPDATE Categoria 
                        SET Nombre = '{categoria.Nombre}', Descripcion = '{categoria.Descripcion}',
                            Vigente = {(categoria.Vigente == true ? 1 : 0)}
                        WHERE Codigo = {categoria.Codigo}";
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

        public Categoria Leer(int codigo)
        {
            Categoria categoria = null;
            MySqlConnection cn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("", cn);
            MySqlDataReader dr = null;
            string sql = $@"SELECT  c.Codigo, c.Nombre, c.Descripcion, c.Vigente
                        from Categoria as c
                        WHERE c.Codigo = {codigo}";
            cmd.CommandText = sql;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    categoria = new Categoria()
                    {
                        Codigo = codigo,
                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                        Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
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

            return categoria;
        }
    }
}
