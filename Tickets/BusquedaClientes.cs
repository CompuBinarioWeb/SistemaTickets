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
    public partial class BusquedaClientes : Form
    {
        public BusquedaClientes()
        {
            InitializeComponent();
        }

        public int codigocliente;
        public string nombres;
        public string correo;

        private void databoletab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                databoletab.Rows[e.RowIndex].Selected = true;
            }
            else
            {
                return;
            }

            try
            {
                if (e.ColumnIndex == 0)
                {
                    codigocliente = int.Parse(this.databoletab.CurrentRow.Cells[1].Value.ToString());
                    nombres = this.databoletab.CurrentRow.Cells[2].Value.ToString();
                    correo = this.databoletab.CurrentRow.Cells[3].Value.ToString();
                    this.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void BusquedaClientes_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            var aux = new ClassSoporte();
            aux.listar(databoletab);
            databoletab.AllowUserToAddRows = false;
            databoletab.Columns[1].Visible = false;
            if (databoletab.Rows.Count == 0)
            {
                MessageBox.Show("No Existen Clientes en el Sistema", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

            }
        }

        private void txtBuscarC_TextChanged(object sender, EventArgs e)
        {
            var aux3 = new ClassSoporte();

            if (radioButton1.Checked == true)
            {
                aux3.buscarapellidocliente(databoletab, this.txtBuscarC.Text.Trim());
                databoletab.AllowUserToAddRows = false;
                databoletab.Columns[1].Visible = false;
            }
            else if (radioButton2.Checked == true)
            {
                aux3.buscarcorreocliente(databoletab, this.txtBuscarC.Text.Trim());
                databoletab.AllowUserToAddRows = false;
                databoletab.Columns[1].Visible = false;
            }
        }
    }
}
