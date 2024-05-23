using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProvisionesUCV
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void buttonregistrar_Click(object sender, EventArgs e)
        {
            string usuarioNuevo = textBoxusuarionuevo.Text;
            string contrasenaNueva = textBoxcontrasenanuevo.Text;
            if (string.IsNullOrEmpty(usuarioNuevo) || string.IsNullOrEmpty(contrasenaNueva))// || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                msgregistrado.Visible = true;

            }
        }
    }
}
