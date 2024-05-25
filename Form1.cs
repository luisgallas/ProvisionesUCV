namespace ProvisionesUCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\login2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("\"C:\\Users\\pedfe\\OneDrive\\Pictures\\logouc.png\"");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxusuario.Text == "luis" && textBoxcontrasena.Text == "psd")
            {
                Home ventana = new Home();
                ventana.Show();
            }
            else
            {
                msgerror.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar ventana1 = new Registrar();
            ventana1.Show();
            /*PedidoDeCompras ventanaPedidoCompras = new PedidoDeCompras();
            ventanaPedidoCompras.Show(); */   
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            textBoxusuario.Clear();
            textBoxcontrasena.Clear();
        }
    }
}
