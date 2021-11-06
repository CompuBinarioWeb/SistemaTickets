using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        //EVITA VENTANAS JUNTAS A LA VEZ
        private static Listado m_FormDefInstance;
        public static Listado DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Listado();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        ClassValidaciones util = new ClassValidaciones();
        ClassSoporte sop = new ClassSoporte();

        private void Listado_Load(object sender, EventArgs e)
        {
            sop.listarSoporteHecho(dgListado);
            no_edicion();
            dgListado.AllowUserToAddRows = false;
            lblCantidad.Text = dgListado.RowCount.ToString();
            //dgSoporte.Rows[1].Cells[0].Selected = false;
            dgListado.Columns[1].Visible = false;
            dgListado.Columns[3].Visible = false;
            dgListado.Columns[5].Visible = false;
            dgListado.Columns[6].Visible = false;
            radioButton1.Checked = true;
        }

        private void dgListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                dgListado.Rows[e.RowIndex].Selected = true;
            }
            else
            {
                return;
            }
            if (e.ColumnIndex == 0) //Si es la columna donde esta el Eliminar
            {
                
            }
            else
            //Si es el resto de las Columnas
            {
                lblCodigo.Text = dgListado.CurrentRow.Cells["CODIGO_SOP"].Value.ToString();
                lblCodigo.Text = dgListado.CurrentRow.Cells["CODIGO_CLI"].Value.ToString();
                txtNombresS.Text = dgListado.CurrentRow.Cells["NOMBRES"].Value.ToString();
                txtCorreoS.Text = dgListado.CurrentRow.Cells["CORREO"].Value.ToString();
                txtDescripcion.Text = dgListado.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                dtFechaS.Value = Convert.ToDateTime(dgListado.Rows[e.RowIndex].Cells["FECHA"].Value);

                //habilitar();
                //button1.Enabled = false;
                //btneditar.Visible = true;
                //btneditar.Enabled = true;
                //txtBuscarC.Clear();
            }
        }

        private void dgListado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgListado.ClearSelection();
        }

        void no_edicion()
        {
            dgListado.Columns["CODIGO_SOP"].ReadOnly = true;
            dgListado.Columns["CODIGO_CLI"].ReadOnly = true;
            dgListado.Columns["NOMBRES"].ReadOnly = true;
            dgListado.Columns["CORREO"].ReadOnly = true;
            dgListado.Columns["DESCRIPCION"].ReadOnly = true;
            dgListado.Columns["BAJA"].ReadOnly = true;
        }

        private void txtBuscarC_TextChanged(object sender, EventArgs e)
        {
            var aux3 = new ClassSoporte();

            if (radioButton1.Checked == true)
            {
                aux3.buscarapellidosoportehecho(dgListado, this.txtBuscarC.Text.Trim());
            }
        }
    }
}
