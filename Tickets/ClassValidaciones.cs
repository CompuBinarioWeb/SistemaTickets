using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;

namespace Tickets
{
    class ClassValidaciones
    {
        public void Mensajes(int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MessageBox.Show(mensaje, "Mensaje de Informacion - COMPUBINARIO v1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(mensaje, "Mensaje de Error - COMPUBINARIO v1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show(mensaje, "Mensaje de Exito - COMPUBINARIO v1.0.0", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                case 4:
                    MessageBox.Show(mensaje, "Mensaje de Confirmacion - COMPUBINARIO v1.0.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                case 5:
                    MessageBox.Show(mensaje, "Autenticación Exitosa - COMPUBINARIO v1.0.0", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                default:
                    break;
            }
        }
    }
}
