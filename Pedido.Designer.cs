namespace ProvisionesUCV
{
    partial class Pedido
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
            dataGridPedido = new DataGridView();
            ColumnaUsuario = new DataGridViewTextBoxColumn();
            ColumnaDescripcion = new DataGridViewTextBoxColumn();
            ColumnaCantidad = new DataGridViewTextBoxColumn();
            ColumnaEstado = new DataGridViewTextBoxColumn();
            ColumnaFecha = new DataGridViewTextBoxColumn();
            Columnaver = new DataGridViewButtonColumn();
            button1agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPedido).BeginInit();
            SuspendLayout();
            // 
            // dataGridPedido
            // 
            dataGridPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedido.Columns.AddRange(new DataGridViewColumn[] { ColumnaUsuario, ColumnaDescripcion, ColumnaCantidad, ColumnaEstado, ColumnaFecha, Columnaver });
            dataGridPedido.Location = new Point(31, 22);
            dataGridPedido.Name = "dataGridPedido";
            dataGridPedido.RowHeadersWidth = 51;
            dataGridPedido.Size = new Size(784, 203);
            dataGridPedido.TabIndex = 0;
            dataGridPedido.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnaUsuario
            // 
            ColumnaUsuario.HeaderText = "Usuario";
            ColumnaUsuario.MinimumWidth = 6;
            ColumnaUsuario.Name = "ColumnaUsuario";
            ColumnaUsuario.ReadOnly = true;
            ColumnaUsuario.Width = 125;
            // 
            // ColumnaDescripcion
            // 
            ColumnaDescripcion.HeaderText = "Descripción";
            ColumnaDescripcion.MinimumWidth = 6;
            ColumnaDescripcion.Name = "ColumnaDescripcion";
            ColumnaDescripcion.ReadOnly = true;
            ColumnaDescripcion.Width = 125;
            // 
            // ColumnaCantidad
            // 
            ColumnaCantidad.HeaderText = "Cantidad";
            ColumnaCantidad.MinimumWidth = 6;
            ColumnaCantidad.Name = "ColumnaCantidad";
            ColumnaCantidad.ReadOnly = true;
            ColumnaCantidad.Width = 125;
            // 
            // ColumnaEstado
            // 
            ColumnaEstado.HeaderText = "Estado";
            ColumnaEstado.MinimumWidth = 6;
            ColumnaEstado.Name = "ColumnaEstado";
            ColumnaEstado.ReadOnly = true;
            ColumnaEstado.Width = 125;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.HeaderText = "Fecha";
            ColumnaFecha.MinimumWidth = 6;
            ColumnaFecha.Name = "ColumnaFecha";
            ColumnaFecha.ReadOnly = true;
            ColumnaFecha.Width = 125;
            // 
            // Columnaver
            // 
            Columnaver.HeaderText = "Editar";
            Columnaver.MinimumWidth = 6;
            Columnaver.Name = "Columnaver";
            Columnaver.Width = 125;
            // 
            // button1agregar
            // 
            button1agregar.Location = new Point(31, 266);
            button1agregar.Name = "button1agregar";
            button1agregar.Size = new Size(94, 29);
            button1agregar.TabIndex = 1;
            button1agregar.Text = "Agregar";
            button1agregar.UseVisualStyleBackColor = true;
            button1agregar.Click += button1agregar_Click;
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(button1agregar);
            Controls.Add(dataGridPedido);
            Name = "Pedido";
            Text = "Pedido";
            Load += Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPedido;
        private DataGridViewTextBoxColumn ColumnaUsuario;
        private DataGridViewTextBoxColumn ColumnaDescripcion;
        private DataGridViewTextBoxColumn ColumnaCantidad;
        private DataGridViewTextBoxColumn ColumnaEstado;
        private DataGridViewTextBoxColumn ColumnaFecha;
        private DataGridViewButtonColumn Columnaver;
        private Button button1agregar;
    }
}