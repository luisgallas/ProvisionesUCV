using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvisionesUCV
{
    public partial class HomeMenu : Form
    {
        public HomeMenu()
        {
            InitializeComponent();
            /*Bitmap img = new Bitmap(Application.StartupPath + @"\img\login2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;*/
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarPedidoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoDeCompras pedidoDeCompras = new PedidoDeCompras();
            pedidoDeCompras.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();  
        }
    }
}
    

