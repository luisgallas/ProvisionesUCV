namespace ProvisionesUCV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            msgerror = new Label();
            textBoxusuario = new TextBox();
            textBoxcontrasena = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 69);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 151);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // msgerror
            // 
            msgerror.AutoSize = true;
            msgerror.Location = new Point(197, 245);
            msgerror.Name = "msgerror";
            msgerror.Size = new Size(155, 20);
            msgerror.TabIndex = 2;
            msgerror.Text = "Credenciales invalidas";
            msgerror.Visible = false;
            // 
            // textBoxusuario
            // 
            textBoxusuario.Location = new Point(191, 112);
            textBoxusuario.Name = "textBoxusuario";
            textBoxusuario.Size = new Size(125, 27);
            textBoxusuario.TabIndex = 3;
            // 
            // textBoxcontrasena
            // 
            textBoxcontrasena.Location = new Point(197, 199);
            textBoxcontrasena.Name = "textBoxcontrasena";
            textBoxcontrasena.PasswordChar = '*';
            textBoxcontrasena.PlaceholderText = "Ingrese se contrasena";
            textBoxcontrasena.Size = new Size(161, 27);
            textBoxcontrasena.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(197, 296);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxcontrasena);
            Controls.Add(textBoxusuario);
            Controls.Add(msgerror);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label msgerror;
        private TextBox textBoxusuario;
        private TextBox textBoxcontrasena;
        private Button button1;
    }
}
