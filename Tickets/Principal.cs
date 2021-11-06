using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tickets
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //EVITA VENTANAS JUNTAS A LA VEZ
        private static Principal m_FormDefInstance;
        public static Principal DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Principal();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        ClassValidaciones util = new ClassValidaciones();
        ClassSoporte sop = new ClassSoporte();

        private void Principal_Load(object sender, EventArgs e)
        {
            sop.listarSoporte(dgSoporte);
            no_edicion();
            dgSoporte.AllowUserToAddRows = false;
            lblCantidad.Text = dgSoporte.RowCount.ToString();
            //dgSoporte.Rows[1].Cells[0].Selected = false;
            dgSoporte.Columns[2].Visible = false;
            dgSoporte.Columns[4].Visible = false;
            dgSoporte.Columns[6].Visible = false;
            dgSoporte.Columns[7].Visible = false;
            radioButton1.Checked = true;
            inhabilitar();
            btneditar.Enabled = false;
            btnGrabarS.Enabled = true;
            btneditar.Visible = false;
            btnGrabarS.Visible = true;
        }

        private void btnGrabarS_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblCodigo.Text = "S01" + ClassClaveUno.Generate(5, 5);
            }
            if (radioButton2.Checked == true)
            {
                lblCodigo.Text = "S02" + ClassClaveUno.Generate(5, 5);
            }

            var codisopo = lblCodigo.Text.Trim();
            var codicli = int.Parse(lblCodigoCli.Text);
            var descri = txtDescripcion.Text.Trim();
            var cos = txtCorreoS.Text.Trim();
            var fec = dtFechaS.Value;

            var aux = new ClassSoporte(codisopo, codicli, descri, fec);

            if (ClassSoporte.Agregar(aux)) //si la funcion agregar pudo insertar
            {
                util.Mensajes(3, "Cliente Registrado Correctamente");
                sop.listarSoporte(dgSoporte);
                no_edicion();
                dgSoporte.AllowUserToAddRows = false;
                lblCantidad.Text = dgSoporte.RowCount.ToString();
                dgSoporte.Columns[2].Visible = false;
                dgSoporte.Columns[4].Visible = false;
                dgSoporte.Columns[6].Visible = false;
                dgSoporte.Columns[7].Visible = false;
                inhabilitar();

            }
            else//si no pudo insertar
            {
                util.Mensajes(2, "Cliente no se pudo Registrar");
            }
        }

        private void btnBuscarCS_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
            BusquedaClientes frm = new BusquedaClientes();
            frm.ShowDialog();

            if (frm.databoletab.Rows.Count == 0)
            {
                this.Close();
            }
            else
            {
                this.lblCodigoCli.Text = frm.codigocliente.ToString();
                this.txtNombresS.Text = frm.nombres;
                this.txtCorreoS.Text = frm.correo;
            }
        }

        private void btnNuevoS_Click(object sender, EventArgs e)
        {
            btneditar.Enabled = false;
            btnGrabarS.Enabled = true;
            btneditar.Visible = false;
            btnGrabarS.Visible = true;
            limpiar();
            habilitar();
        }

        private void dgSoporte_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgSoporte.ClearSelection();
        }

        private void dgSoporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inhabilitar();
            btnGrabarS.Enabled = false;
            txtDescripcion.Enabled = true;
            dtFechaS.Enabled = true;
            btneditar.Enabled = true;

            btneditar.Visible = true;
            btnGrabarS.Visible = false;

            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                dgSoporte.Rows[e.RowIndex].Selected = true;
            }
            else
            {
                return;
            }
            if (e.ColumnIndex == 0) //Si es la columna donde esta el Eliminar
            {
                var codsop = dgSoporte.CurrentRow.Cells["CODIGO_SOP"].Value.ToString();
                int code = int.Parse(dgSoporte.CurrentRow.Cells["CODIGO_CLI"].Value.ToString());
                var nom = dgSoporte.CurrentRow.Cells["NOMBRES"].Value.ToString();
                var cor = dgSoporte.CurrentRow.Cells["CORREO"].Value.ToString();
                var des = dgSoporte.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                dtFechaS.Value = Convert.ToDateTime(dgSoporte.CurrentRow.Cells["FECHA"].Value);

                var aux = new ClassSoporte(codsop, code, des, dtFechaS.Value);

                if (ClassSoporte.Baja(aux))
                {
                    util.Mensajes(3, "Servicio Tecnico Realizado con Exito");
                    sop.listarSoporte(dgSoporte);
                    no_edicion();
                    dgSoporte.AllowUserToAddRows = false;
                    lblCantidad.Text = dgSoporte.RowCount.ToString();
                    //dgSoporte.Rows[1].Cells[0].Selected = false;
                    dgSoporte.Columns[2].Visible = false;
                    dgSoporte.Columns[4].Visible = false;
                    dgSoporte.Columns[6].Visible = false;
                    dgSoporte.Columns[7].Visible = false;
                    limpiar();

                    btneditar.Visible = false;
                    btnGrabarS.Visible = false;
                }
                else
                {
                    MessageBox.Show("Servicio Tecnico aun NO esta Realizado", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            //Si es el resto de las Columnas
            {
                lblCodigo.Text = dgSoporte.CurrentRow.Cells["CODIGO_SOP"].Value.ToString();
                lblCodigoCli.Text = dgSoporte.CurrentRow.Cells["CODIGO_CLI"].Value.ToString();
                txtNombresS.Text = dgSoporte.CurrentRow.Cells["NOMBRES"].Value.ToString();
                txtCorreoS.Text = dgSoporte.CurrentRow.Cells["CORREO"].Value.ToString();
                txtDescripcion.Text = dgSoporte.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                dtFechaS.Value = Convert.ToDateTime(dgSoporte.Rows[e.RowIndex].Cells["FECHA"].Value);

                //habilitar();
                //button1.Enabled = false;
                //btneditar.Visible = true;
                //btneditar.Enabled = true;
                //txtBuscarC.Clear();
            }
        }

        //METODOS DE VALIDACIONES
        void limpiar()
        {
            lblCodigoCli.Text = "";
            txtNombresS.Clear();
            txtCorreoS.Clear();
            txtDescripcion.Clear();
            lblCodigo.Text = "S0";
            dtFechaS.Value = DateTime.Now;
            txtBuscarC.Clear();
        }

        void no_edicion()
        {
            dgSoporte.Columns["CODIGO_SOP"].ReadOnly = true;
            dgSoporte.Columns["CODIGO_CLI"].ReadOnly = true;
            dgSoporte.Columns["NOMBRES"].ReadOnly = true;
            dgSoporte.Columns["CORREO"].ReadOnly = true;
            dgSoporte.Columns["DESCRIPCION"].ReadOnly = true;
            dgSoporte.Columns["FECHA"].ReadOnly = true;
            dgSoporte.Columns["BAJA"].ReadOnly = true;
        }

        void habilitar()
        {
            txtNombresS.Enabled = true;
            txtCorreoS.Enabled = true;
            txtDescripcion.Enabled = true;
            dtFechaS.Enabled = true;
            btnGrabarS.Enabled = true;
        }

        void inhabilitar()
        {
            txtNombresS.Enabled = false;
            txtCorreoS.Enabled = false;
            dtFechaS.Enabled = false;
            btnGrabarS.Enabled = false;
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
           
            var codisopo = lblCodigo.Text.Trim();
            var codicli = int.Parse(lblCodigoCli.Text);
            var descri = txtDescripcion.Text.Trim();
            var cos = txtCorreoS.Text.Trim();
            dtFechaS.Value = Convert.ToDateTime(dtFechaS.Value);

            var aux = new ClassSoporte(codisopo, codicli, descri, dtFechaS.Value);

            if (ClassSoporte.Editar(aux)) //si la funcion agregar pudo insertar
            {
                util.Mensajes(3, "Soporte Editado Correctamente");
                sop.listarSoporte(dgSoporte);
                no_edicion();
                dgSoporte.AllowUserToAddRows = false;
                lblCantidad.Text = dgSoporte.RowCount.ToString();
                dgSoporte.Columns[2].Visible = false;
                dgSoporte.Columns[4].Visible = false;
                dgSoporte.Columns[6].Visible = false;
                dgSoporte.Columns[7].Visible = false;
                inhabilitar();
                btneditar.Enabled = false;
                txtDescripcion.Enabled = false;
                btneditar.Visible = true;
                btnGrabarS.Visible = true;
                dtFechaS.Enabled = false;

                lblCodigoCli.Text = "Este Soporte Fue Editado";

            }
            else//si no pudo insertar
            {
                util.Mensajes(2, "Cliente no se pudo Registrar");
            }
        }
    }
}
