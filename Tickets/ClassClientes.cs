using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tickets
{
    class ClassClientes
    {
        #region PARAMETROS Y CONTRUCTORES

        public int Codigo
        {
            get;
            set;
        }
        public string Nombres
        {
            get;
            set;
        }
        public string Correo
        {
            get;
            set;
        }
        public string Pais
        {
            get;
            set;
        }
        public string Sistema
        {
            get;
            set;
        }
        public DateTime Fecha
        {
            get;
            set;
        }
  
        public ClassClientes(int cod, string nom, string co, string pa, string sis, DateTime fe)
        {
            Codigo = cod;
            Nombres = nom;
            Correo = co;
            Pais = pa;
            Sistema = sis;
            Fecha = fe;
        }

        public ClassClientes()
        {
            Codigo = 0;
            Nombres = "";
            Correo = "";
            Pais = "";
            Sistema = "";
            Fecha = DateTime.Now; 
        }
        #endregion

        //METODO AGREGAR CLIENTE
        public static bool Agregar(ClassClientes cli)
        {
            SqlCommand sql = new SqlCommand("MANTE_CLIENTES", ClassConexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@CODIGO_CLI", SqlDbType.Int).Value = cli.Codigo;
            sql.Parameters.Add("@NOMBRES", SqlDbType.VarChar, 100).Value = cli.Nombres;
            sql.Parameters.Add("@CORREO", SqlDbType.VarChar, 100).Value = cli.Correo;
            sql.Parameters.Add("@PAIS", SqlDbType.VarChar, 100).Value = cli.Pais;
            sql.Parameters.Add("@SISTEMA", SqlDbType.VarChar, 100).Value = cli.Sistema;
            sql.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = cli.Fecha;
            sql.Parameters.Add("@OPC", SqlDbType.Int, 1).Value = 1;

            try
            {
                int r = sql.ExecuteNonQuery();
                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ClassConexion.CerrarConexion();
            }
        }

        //METODO EDITAR CLIENTE
        public static bool Editar(ClassClientes cli)
        {
            SqlCommand sql = new SqlCommand("MANTE_CLIENTES", ClassConexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@CODIGO_CLI", SqlDbType.Int).Value = cli.Codigo;
            sql.Parameters.Add("@NOMBRES", SqlDbType.VarChar, 100).Value = cli.Nombres;
            sql.Parameters.Add("@CORREO", SqlDbType.VarChar, 100).Value = cli.Correo;
            sql.Parameters.Add("@PAIS", SqlDbType.VarChar, 100).Value = cli.Pais;
            sql.Parameters.Add("@SISTEMA", SqlDbType.VarChar, 100).Value = cli.Sistema;
            sql.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = cli.Fecha;
            sql.Parameters.Add("@OPC", SqlDbType.Int, 1).Value = 2;

            try
            {
                int r = sql.ExecuteNonQuery();
                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ClassConexion.CerrarConexion();
            }
        }

        public static bool Eliminar(ClassClientes cli)
        {
            SqlCommand sql = new SqlCommand("MANTE_CLIENTES", ClassConexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@CODIGO_CLI", SqlDbType.Int).Value = cli.Codigo;
            sql.Parameters.Add("@NOMBRES", SqlDbType.VarChar, 100).Value = cli.Nombres;
            sql.Parameters.Add("@CORREO", SqlDbType.VarChar, 100).Value = cli.Correo;
            sql.Parameters.Add("@PAIS", SqlDbType.VarChar, 100).Value = cli.Pais;
            sql.Parameters.Add("@SISTEMA", SqlDbType.VarChar, 100).Value = cli.Sistema;
            sql.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = cli.Fecha;
            sql.Parameters.Add("@OPC", SqlDbType.Int, 1).Value = 3;

            try
            {
                int r = sql.ExecuteNonQuery();
                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ClassConexion.CerrarConexion();
            }
        }

        //LISTAR CLIENTES
        public void listar(DataGridView data)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("LISTAR_CLIENTES", ClassConexion.ObtenerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                //data.Columns[0].Width = 60;
                data.Columns[0].Width = 40;
                data.Columns[0].HeaderCell.Value = "ID";
                data.Columns[1].Width = 260;
                data.Columns[1].HeaderCell.Value = "NOMBRES";
                data.Columns[2].Width = 320;
                data.Columns[2].HeaderCell.Value = "E-MAIL";
                data.Columns[3].Width = 185;
                data.Columns[3].HeaderCell.Value = "PAIS";
                data.Columns[4].Width = 200;
                data.Columns[4].HeaderCell.Value = "PRODUCTO";
                data.Columns[5].Width = 180;
                data.Columns[5].HeaderCell.Value = "FECHA";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ClassConexion.CerrarConexion();
            }

        }

        //BUSCAR CLIENTES
        public void buscarapellidocliente(DataGridView data, string apellido)
        {
            try
            {
                SqlCommand sql = new SqlCommand("FILTRO_BUSCA_CLIENTE", ClassConexion.ObtenerConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 100).Value = apellido;

                sql.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ClassConexion.CerrarConexion();
            }
        }

        public void buscarcorreocliente(DataGridView data, string correo)
        {
            try
            {
                SqlCommand sql = new SqlCommand("FILTRO_BUSCA_CLIENTE_DOS", ClassConexion.ObtenerConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@MAIL", SqlDbType.VarChar, 100).Value = correo;

                sql.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ClassConexion.CerrarConexion();
            }
        }
    }
}
