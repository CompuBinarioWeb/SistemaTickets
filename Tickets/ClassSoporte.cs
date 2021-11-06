using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    class ClassSoporte
    {
        #region PARAMETROS Y CONTRUCTORES

        public string CodigoSop
        {
            get;
            set;
        }

        public int CodigoCli
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public DateTime Fecha
        {
            get;
            set;
        }

        public ClassSoporte(string codsop, int codcli, string descripcion, DateTime fe)
        {
            CodigoSop = codsop;
            CodigoCli = codcli;
            Descripcion = descripcion;
            Fecha = fe;
        }

        public ClassSoporte()
        {
            CodigoSop = "";
            CodigoCli = 0;
            Descripcion = "";
            Fecha = DateTime.Now;
        }
        #endregion

        //METODO AGREGAR SERVICIO
        public static bool Agregar(ClassSoporte sop)
        {
            SqlCommand sql = new SqlCommand("MANTE_SOPORTE", ClassConexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@CODIGO_SOP", SqlDbType.VarChar, 9).Value = sop.CodigoSop;
            sql.Parameters.Add("@CODIGO_CLI", SqlDbType.Int).Value = sop.CodigoCli;
            sql.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 500).Value = sop.Descripcion;
            sql.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = sop.Fecha;
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

        //METODO EDITAR SERVICIO
        public static bool Editar(ClassSoporte sop)
        {
            SqlCommand sql = new SqlCommand("MANTE_SOPORTE", ClassConexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@CODIGO_SOP", SqlDbType.VarChar, 9).Value = sop.CodigoSop;
            sql.Parameters.Add("@CODIGO_CLI", SqlDbType.Int).Value = sop.CodigoCli;
            sql.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 500).Value = sop.Descripcion;
            sql.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = sop.Fecha;
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

        //METODO DAR DE BAJA SERVICIO
        public static bool Baja(ClassSoporte sop)
        {
            SqlCommand sql = new SqlCommand("MANTE_SOPORTE", ClassConexion.ObtenerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@CODIGO_SOP", SqlDbType.VarChar, 9).Value = sop.CodigoSop;
            sql.Parameters.Add("@CODIGO_CLI", SqlDbType.Int).Value = sop.CodigoCli;
            sql.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 500).Value = sop.Descripcion;
            sql.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = sop.Fecha;
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

        //METODO LISTAR CLIENTES
        public void listar(DataGridView data)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("LISTAR_CLIENTES_BUSQUEDA", ClassConexion.ObtenerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                data.Columns[1].Width = 40;
                data.Columns[1].HeaderCell.Value = "Codigo";
                data.Columns[2].Width = 250;
                data.Columns[2].HeaderCell.Value = "Nombres";
                data.Columns[3].Width = 250;
                data.Columns[3].HeaderCell.Value = "Correo";
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

        //METODO LISTAR SOPORTE
        public void listarSoporte(DataGridView data)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("LISTAR_SOPORTE", ClassConexion.ObtenerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                data.Columns[0].Width = 100;
                data.Columns[1].Width = 100;
                data.Columns[1].HeaderCell.Value = "Cod Soporte";
                data.Columns[2].Width = 250;
                data.Columns[2].HeaderCell.Value = "Cod Cliente";
                data.Columns[3].Width = 270;
                data.Columns[3].HeaderCell.Value = "Nombres";
                data.Columns[4].Width = 250;
                data.Columns[4].HeaderCell.Value = "Correo";
                data.Columns[5].Width = 500;
                data.Columns[5].HeaderCell.Value = "Descripcion";
                data.Columns[6].Width = 250;
                data.Columns[6].HeaderCell.Value = "Fecha";
                data.Columns[7].Width = 250;
                data.Columns[7].HeaderCell.Value = "Estado";
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

        //METODO LISTAR SOPORTE HECHO
        public void listarSoporteHecho(DataGridView data)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("LISTAR_SOPORTE_HECHO", ClassConexion.ObtenerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                data.Columns[0].Width = 100;
                data.Columns[0].HeaderCell.Value = "Cod Soporte";
                data.Columns[1].Width = 250;
                data.Columns[1].HeaderCell.Value = "Cod Cliente";
                data.Columns[2].Width = 270;
                data.Columns[2].HeaderCell.Value = "Nombres";
                data.Columns[3].Width = 250;
                data.Columns[3].HeaderCell.Value = "Correo";
                data.Columns[4].Width = 500;
                data.Columns[4].HeaderCell.Value = "Descripcion";
                data.Columns[5].Width = 250;
                data.Columns[5].HeaderCell.Value = "Fecha";
                data.Columns[6].Width = 250;
                data.Columns[6].HeaderCell.Value = "Estado";
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
                SqlCommand sql = new SqlCommand("FILTRO_BUSCA_CLIENTE_SOP", ClassConexion.ObtenerConexion());
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
                SqlCommand sql = new SqlCommand("FILTRO_BUSCA_CLIENTE_DOS_SOP", ClassConexion.ObtenerConexion());
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

        public void buscarapellidosoportehecho(DataGridView data, string apellido)
        {
            try
            {
                SqlCommand sql = new SqlCommand("FILTRO_BUSCA_SOPORTE_HECHO", ClassConexion.ObtenerConexion());
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
    }
}
