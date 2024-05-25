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
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\login2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void buttonregistrar_Click(object sender, EventArgs e)
        {
            string usuarioNuevo = textBoxusuarionuevo.Text;
            string contrasenaNueva = textBoxcontrasenanuevo.Text;
             if (string.IsNullOrEmpty(usuarioNuevo) || string.IsNullOrEmpty(contrasenaNueva))// 
             {
                 MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //textBoxcontrasenanuevo.Focus(); 
                 //textBoxcontrasenanuevo.Focus() ;    
                 return;
             }
            /*if (string.IsNullOrEmpty(textBoxusuarionuevo.Text))
            {
                MessageBox.Show("Debe rellenar el campo de nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxusuarionuevo.Focus(); // Selecciona el campo de nombre para que el usuario lo rellene
                return;
            }*/
            else
            {
                //msgregistrado.Visible = true;
                MessageBox.Show("Usuario Registrado","Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxusuarionuevo.Clear();    
            textBoxcontrasenanuevo.Clear ();
        }
    }
}
