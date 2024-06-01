namespace ProvisionesUCV
{
    partial class HomeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            registrarPedidoDeComprasToolStripMenuItem = new ToolStripMenuItem();
            consultarPedidoDeComprasToolStripMenuItem = new ToolStripMenuItem();
            verificarPeididoDeComprasToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, atrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarPedidoDeComprasToolStripMenuItem, consultarPedidoDeComprasToolStripMenuItem, verificarPeididoDeComprasToolStripMenuItem, pedidosToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // registrarPedidoDeComprasToolStripMenuItem
            // 
            registrarPedidoDeComprasToolStripMenuItem.Name = "registrarPedidoDeComprasToolStripMenuItem";
            registrarPedidoDeComprasToolStripMenuItem.Size = new Size(288, 26);
            registrarPedidoDeComprasToolStripMenuItem.Text = "Registrar pedido de compras";
            registrarPedidoDeComprasToolStripMenuItem.Click += registrarPedidoDeComprasToolStripMenuItem_Click;
            // 
            // consultarPedidoDeComprasToolStripMenuItem
            // 
            consultarPedidoDeComprasToolStripMenuItem.Name = "consultarPedidoDeComprasToolStripMenuItem";
            consultarPedidoDeComprasToolStripMenuItem.Size = new Size(288, 26);
            consultarPedidoDeComprasToolStripMenuItem.Text = "Consultar pedido de compras";
            // 
            // verificarPeididoDeComprasToolStripMenuItem
            // 
            verificarPeididoDeComprasToolStripMenuItem.Name = "verificarPeididoDeComprasToolStripMenuItem";
            verificarPeididoDeComprasToolStripMenuItem.Size = new Size(288, 26);
            verificarPeididoDeComprasToolStripMenuItem.Text = "Verificar pedido de compras";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(288, 26);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(52, 24);
            atrasToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // HomeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "HomeMenu";
            Text = "HomeMenu";
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem registrarPedidoDeComprasToolStripMenuItem;
        private ToolStripMenuItem consultarPedidoDeComprasToolStripMenuItem;
        private ToolStripMenuItem verificarPeididoDeComprasToolStripMenuItem;
        private ToolStripMenuItem atrasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
    }
}