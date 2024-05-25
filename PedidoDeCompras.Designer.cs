namespace ProvisionesUCV
{
    partial class PedidoDeCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoDeCompras));
            fechaActualizada = new DateTimePicker();
            labelpresente = new Label();
            richTextBoxpresentacion = new RichTextBox();
            richTextBoxmensaje = new RichTextBox();
            labeldescripArt = new Label();
            labelCantidadnro = new Label();
            richTextBoxdecripArt = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // fechaActualizada
            // 
            fechaActualizada.Location = new Point(479, 12);
            fechaActualizada.Name = "fechaActualizada";
            fechaActualizada.Size = new Size(291, 27);
            fechaActualizada.TabIndex = 1;
            // 
            // labelpresente
            // 
            labelpresente.AutoSize = true;
            labelpresente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelpresente.Location = new Point(20, 126);
            labelpresente.Name = "labelpresente";
            labelpresente.Size = new Size(86, 25);
            labelpresente.TabIndex = 2;
            labelpresente.Text = "Presente";
            // 
            // richTextBoxpresentacion
            // 
            richTextBoxpresentacion.Location = new Point(20, 58);
            richTextBoxpresentacion.Name = "richTextBoxpresentacion";
            richTextBoxpresentacion.Size = new Size(381, 65);
            richTextBoxpresentacion.TabIndex = 3;
            richTextBoxpresentacion.Text = "Señora \nLic. Marta Leticia Miranda Acosta\nDirectora Administrativa y Financiera UC NSA - CUG\n\n\n";
            // 
            // richTextBoxmensaje
            // 
            richTextBoxmensaje.Location = new Point(12, 154);
            richTextBoxmensaje.Name = "richTextBoxmensaje";
            richTextBoxmensaje.Size = new Size(758, 49);
            richTextBoxmensaje.TabIndex = 4;
            richTextBoxmensaje.Text = resources.GetString("richTextBoxmensaje.Text");
            // 
            // labeldescripArt
            // 
            labeldescripArt.AutoSize = true;
            labeldescripArt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labeldescripArt.Location = new Point(555, 217);
            labeldescripArt.Name = "labeldescripArt";
            labeldescripArt.Size = new Size(215, 25);
            labeldescripArt.TabIndex = 5;
            labeldescripArt.Text = "Descripción de Artículos";
            // 
            // labelCantidadnro
            // 
            labelCantidadnro.AutoSize = true;
            labelCantidadnro.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelCantidadnro.Location = new Point(12, 217);
            labelCantidadnro.Name = "labelCantidadnro";
            labelCantidadnro.Size = new Size(112, 25);
            labelCantidadnro.TabIndex = 6;
            labelCantidadnro.Text = "Cantidad N°";
            // 
            // richTextBoxdecripArt
            // 
            richTextBoxdecripArt.Location = new Point(479, 245);
            richTextBoxdecripArt.Name = "richTextBoxdecripArt";
            richTextBoxdecripArt.Size = new Size(314, 193);
            richTextBoxdecripArt.TabIndex = 7;
            richTextBoxdecripArt.Text = "";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(20, 257);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // PedidoDeCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBoxdecripArt);
            Controls.Add(labelCantidadnro);
            Controls.Add(labeldescripArt);
            Controls.Add(richTextBoxmensaje);
            Controls.Add(richTextBoxpresentacion);
            Controls.Add(labelpresente);
            Controls.Add(fechaActualizada);
            Name = "PedidoDeCompras";
            Text = "PedidoDeCompras";
            Load += PedidoDeCompras_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fechaActualizada;
        private Label labelpresente;
        private RichTextBox richTextBoxpresentacion;
        private RichTextBox richTextBoxmensaje;
        private Label labeldescripArt;
        private Label labelCantidadnro;
        private RichTextBox richTextBoxdecripArt;
        private NumericUpDown numericUpDown1;
    }
}