namespace ProvisionesUCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
