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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        //EVITA VENTANAS JUNTAS A LA VEZ
        private static Clientes m_FormDefInstance;
        public static Clientes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Clientes();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        ClassValidaciones util = new ClassValidaciones();
        ClassClientes cli = new ClassClientes();

        private void Clientes_Load(object sender, EventArgs e)
        {
            habilitar();
            radioButton1.Checked = true;
            cli.listar(dgClientes);
            dgClientes.Columns[0].Visible = false;
            dgClientes.AllowUserToAddRows = false;
            lblCantidad.Text = dgClientes.RowCount.ToString();
            dgClientes.Rows[1].Cells[0].Selected = false;
            no_edicion();
            button1.Enabled = true;
            btneditar.Enabled = false;
            btneditar.Visible = false;
            cli.listar(dgClientes);
            btnEliminar.Enabled = true;
        }

        //AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                util.Mensajes(2, "Ingrese Nombres del Cliente");
                this.txtNombres.Select();
                return;
            }

            if (txtCorreo.Text == "")
            {
                util.Mensajes(2, "Ingrese Correo del Cliente");
                this.txtCorreo.Select();
                return;
            }

            if (cboPais.Text == "")
            {
                util.Mensajes(2, "Seleccione Pais");
                this.cboPais.Select();
                return;
            }

            if (cboSistema.Text == "")
            {
                util.Mensajes(2, "Seleccione Producto");
                this.cboSistema.Select();
                return;
            }

            var nom = txtNombres.Text.Trim();
            var cos = txtCorreo.Text.Trim();
            var pai = cboPais.Text.Trim();
            var pro = cboSistema.Text.Trim();
            var fec = dtFechaC.Value;

            var aux = new ClassClientes(0, nom, cos, pai, pro, fec);

            if (ClassClientes.Agregar(aux)) //si la funcion agregar pudo insertar
            {
                util.Mensajes(3, "Cliente Registrado Correctamente");
                inhabilitar();
                button1.Enabled = false;
                btneditar.Enabled = false;
                btneditar.Visible = false;
                cli.listar(dgClientes);
                lblCantidad.Text = dgClientes.RowCount.ToString();
                txtBuscarC.Clear();
                btnEliminar.Enabled = true;

            }
            else//si no pudo insertar
            {
                util.Mensajes(2, "Cliente no se pudo Registrar");
            }
        }

        //EDITAR
        private void btneditar_Click(object sender, EventArgs e)
        {         
            try
            {
                var nom = txtNombres.Text.Trim();
                var cor = txtCorreo.Text.Trim();
                var pai = cboPais.Text.Trim();
                var sis = cboSistema.Text.Trim();
                //var fecha = dtFechaC.Value();
                dtFechaC.Value = Convert.ToDateTime(dtFechaC.Value);
                var cod = int.Parse(lblcodigo.Text.Trim());

                var aux = new ClassClientes(cod, nom, cor, pai, sis, dtFechaC.Value);

                if (txtNombres.Text == "")
                {
                    util.Mensajes(2, "Ingrese Nombres del Cliente");
                    this.txtNombres.Select();
                    return;
                }

                if (txtCorreo.Text == "")
                {
                    util.Mensajes(2, "Ingrese Correo del Cliente");
                    this.txtCorreo.Select();
                    return;
                }

                if (cboPais.Text == "")
                {
                    util.Mensajes(2, "Seleccione Pais");
                    this.cboPais.Select();
                    return;
                }

                if (cboSistema.Text == "")
                {
                    util.Mensajes(2, "Seleccione Sistema");
                    this.cboSistema.Select();
                    return;
                }

                if (ClassClientes.Editar(aux)) //si la funcion editar pudo insertar
                {
                    util.Mensajes(3, "Cliente Editado Correctamente");
                    cli.listar(dgClientes);
                    inhabilitar();
                    button1.Enabled = false;
                    btneditar.Enabled = false;
                    cli.listar(dgClientes);
                    btnEliminar.Enabled = true;
                }
                else//si no pudo editar
                {
                    util.Mensajes(2, "Cliente no se pudo Editar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                util.Mensajes(2, "Seleccione un Cliente de la Lista para Eliminarlo");
                this.txtNombres.Select();
                return;
            }

            if (txtCorreo.Text == "")
            {
                util.Mensajes(2, "Prohibido Campos Vacios");
                this.txtCorreo.Select();
                return;
            }

            if (cboPais.Text == "")
            {
                util.Mensajes(2, "Seleccione Pais");
                this.cboPais.Select();
                return;
            }

            if (cboSistema.Text == "")
            {
                util.Mensajes(2, "Seleccione Sistema");
                this.cboSistema.Select();
                return;
            }

            if (dgClientes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgClientes.SelectedRows[0].Index;

                ClassConexion.ObtenerConexion();
                SqlCommand delcmd = new SqlCommand();

                delcmd.CommandText = "DELETE FROM CLIENTES WHERE CODIGO_CLI=" + dgClientes.SelectedRows[0].Cells[0].Value.ToString() + "";
                ClassConexion.ObtenerConexion();
                delcmd.Connection = ClassConexion.ObtenerConexion();
                delcmd.ExecuteNonQuery();
                ClassConexion.CerrarConexion();
                dgClientes.Rows.RemoveAt(dgClientes.SelectedRows[0].Index);
                util.Mensajes(3, "Cliente Eliminado Correctamente");
                cli.listar(dgClientes);
                inhabilitar();
                button1.Enabled = false;
                btneditar.Enabled = false;
                cli.listar(dgClientes);
                lblcodigo.Visible = true;
                lblcodigo.Text = "Este Cliente fue Eliminado:";
                btnEliminar.Enabled = false;
            }
            else
            {
                util.Mensajes(2, "Cliente no se pudo Eliminar");
            }
        }

        //NUEVO
        private void btnuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            limpiar();
            button1.Enabled = true;
            btneditar.Enabled = false;
            btneditar.Visible = false;
            btnEliminar.Enabled = true;
        }

        //SELECCIONAR
        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;

            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                dgClientes.Rows[e.RowIndex].Selected = true;
            }
            else
            {
                return;
            }
            if (e.ColumnIndex == 0) //Si es la columna donde esta el Eliminar
            {
                int code = int.Parse(dgClientes.CurrentRow.Cells["CODIGO_CLI"].Value.ToString());
                var nom = dgClientes.CurrentRow.Cells["NOMBRES"].Value.ToString();
                var cor = dgClientes.CurrentRow.Cells["CORREO"].Value.ToString();
                var pai = dgClientes.CurrentRow.Cells["PAIS"].Value.ToString();
                var sis = dgClientes.CurrentRow.Cells["SISTEMA"].Value.ToString();
                dtFechaC.Value = Convert.ToDateTime(dgClientes.CurrentRow.Cells["FECHA"]);

                var aux = new ClassClientes(code, nom, cor, pai, sis, dtFechaC.Value);
            }
            else
            //Si es el resto de las Columnas
            {
                lblcodigo.Text = dgClientes.CurrentRow.Cells["CODIGO_CLI"].Value.ToString();
                txtNombres.Text = dgClientes.CurrentRow.Cells["NOMBRES"].Value.ToString();
                txtCorreo.Text = dgClientes.CurrentRow.Cells["CORREO"].Value.ToString();
                cboPais.Text = dgClientes.CurrentRow.Cells["PAIS"].Value.ToString();
                cboSistema.Text = dgClientes.CurrentRow.Cells["SISTEMA"].Value.ToString();
                dtFechaC.Value = Convert.ToDateTime(dgClientes.Rows[e.RowIndex].Cells["FECHA"].Value);

                habilitar();
                button1.Enabled = false;
                btneditar.Visible = true;
                btneditar.Enabled = true;
                txtBuscarC.Clear();
            }
        }

        //EXPORTA A EXCEL
        private void button2_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgClientes);
        }

        //METODO EXPORTA A EXCEL
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                aplicacion.Visible = true;
                hoja_trabajo = libros_trabajo.ActiveSheet;
                hoja_trabajo.Name = "Clientes de CompuBinario";

                for (int i = 1; i < dgClientes.Columns.Count + 1; i++)
                {
                    aplicacion.Cells[1, i] = dgClientes.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgClientes.Rows.Count; i++)
                {
                    for (int j = 0; j < dgClientes.Columns.Count; j++)
                    {
                        aplicacion.Cells[i + 2, j + 1] = dgClientes.Rows[i].Cells[j].Value.ToString();
                    }
                }

                aplicacion.Columns.AutoFit();
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                //libros_trabajo.Close(true);
                //aplicacion.Quit();
            }
        }

        //DAR FORMATO A UNA FILA POR CONDICION
        private void dgClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == this.dgClientes.Columns["PAIS"].Index)
            {
                string PAIS = e.Value.ToString();
                if (PAIS != null)
                {
                    if (PAIS == "PERU" || PAIS == "Fair")
                    {
                        this.dgClientes.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.dgClientes.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        //DESACTIVA LA SELECCION DE LA PRIMERA FILA AL CARGAR DATOS
        private void dgClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgClientes.ClearSelection();
        }

        //FILTROS DE BUSQUEDA
        private void txtBuscarC_TextChanged(object sender, EventArgs e)
        {
            var aux3 = new ClassClientes();

            if (radioButton1.Checked == true)
            {
                aux3.buscarapellidocliente(dgClientes, this.txtBuscarC.Text.Trim());
            }
            else if (radioButton2.Checked == true)
            {
                aux3.buscarcorreocliente(dgClientes, this.txtBuscarC.Text.Trim());
            }           
        }

        //METODOS DE VALIDACIONES
        void limpiar()
        {
            txtNombres.Clear();
            txtCorreo.Clear();
            cboSistema.SelectedIndex = -1;
            cboPais.SelectedIndex = -1;
            dtFechaC.Value = DateTime.Now;
            txtBuscarC.Clear();
            lblcodigo.Visible = false;
        }

        void inhabilitar()
        {
            txtNombres.Enabled = false;
            txtCorreo.Enabled = false;
            cboPais.Enabled = false;
            cboSistema.Enabled = false;
            dtFechaC.Enabled = false;
            lblcodigo.Visible = false;
        }

        void habilitar()
        {
            txtNombres.Enabled = true;
            txtCorreo.Enabled = true;
            cboPais.Enabled = true;
            cboSistema.Enabled = true;
            dtFechaC.Enabled = true;
            lblcodigo.Visible = false;
        }

        void no_edicion()
        {
            dgClientes.Columns["NOMBRES"].ReadOnly = true;
            dgClientes.Columns["CORREO"].ReadOnly = true;
            dgClientes.Columns["PAIS"].ReadOnly = true;
            dgClientes.Columns["SISTEMA"].ReadOnly = true;
            dgClientes.Columns["FECHA"].ReadOnly = false;
        }

        private void cboPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void cboSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }
    }
}

