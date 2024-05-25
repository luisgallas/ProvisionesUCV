namespace ProvisionesUCV
{
    partial class Registrar
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
            buttonregistrar = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxusuarionuevo = new TextBox();
            textBoxcontrasenanuevo = new TextBox();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // buttonregistrar
            // 
            buttonregistrar.Location = new Point(183, 300);
            buttonregistrar.Name = "buttonregistrar";
            buttonregistrar.Size = new Size(94, 29);
            buttonregistrar.TabIndex = 0;
            buttonregistrar.Text = "Registrar";
            buttonregistrar.UseVisualStyleBackColor = true;
            buttonregistrar.Click += buttonregistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 70);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 181);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // textBoxusuarionuevo
            // 
            textBoxusuarionuevo.Location = new Point(185, 119);
            textBoxusuarionuevo.Name = "textBoxusuarionuevo";
            textBoxusuarionuevo.Size = new Size(125, 27);
            textBoxusuarionuevo.TabIndex = 3;
            // 
            // textBoxcontrasenanuevo
            // 
            textBoxcontrasenanuevo.Location = new Point(185, 228);
            textBoxcontrasenanuevo.Name = "textBoxcontrasenanuevo";
            textBoxcontrasenanuevo.Size = new Size(125, 27);
            textBoxcontrasenanuevo.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(338, 303);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxcontrasenanuevo);
            Controls.Add(textBoxusuarionuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonregistrar);
            Name = "Registrar";
            Text = "Registrar";
            Load += Registrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonregistrar;
        private Label label1;
        private Label label2;
        private TextBox textBoxusuarionuevo;
        private TextBox textBoxcontrasenanuevo;
        private Button buttonCancelar;
    }
}