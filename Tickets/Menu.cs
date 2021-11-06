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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.DefInstance.MdiParent = this;
            Clientes.DefInstance.Show();

            Principal.DefInstance.Close();
            Listado.DefInstance.Close();
        }

        private void sOPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal.DefInstance.MdiParent = this;
            Principal.DefInstance.Show();

            Clientes.DefInstance.Close();
            Listado.DefInstance.Close();
        }

        private void lISTADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado.DefInstance.MdiParent = this;
            Listado.DefInstance.Show();

            Clientes.DefInstance.Close();
            Principal.DefInstance.Close();
        }

        private void aPAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
