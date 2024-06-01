using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvisionesUCV
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1agregar_Click(object sender, EventArgs e)
        {
            PedidoDeCompras pedidoDeCompras = new PedidoDeCompras();
            pedidoDeCompras.Show();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos("1","24/05/2025","Aprobado","Se solicita Art.","Felipe","10");
            string fileName = "Pedido.json";
            string jsonString = JsonSerializer.Serialize(p);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine($"JSON file created at {Path.GetFullPath(fileName)}");
            Console.WriteLine(File.ReadAllText(fileName));
            MessageBox.Show($"JSON file created at {Path.GetFullPath(fileName)}");
        }
    }
}
