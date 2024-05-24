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
            buttonaceptar = new Button();
            button2 = new Button();
            buttoncancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 80);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 149);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // msgerror
            // 
            msgerror.AutoSize = true;
            msgerror.ForeColor = Color.Red;
            msgerror.Location = new Point(131, 196);
            msgerror.Name = "msgerror";
            msgerror.Size = new Size(161, 20);
            msgerror.TabIndex = 2;
            msgerror.Text = "*Credenciales invalidas";
            msgerror.Visible = false;
            // 
            // textBoxusuario
            // 
            textBoxusuario.Location = new Point(191, 80);
            textBoxusuario.Name = "textBoxusuario";
            textBoxusuario.Size = new Size(125, 27);
            textBoxusuario.TabIndex = 3;
            // 
            // textBoxcontrasena
            // 
            textBoxcontrasena.Location = new Point(188, 146);
            textBoxcontrasena.Name = "textBoxcontrasena";
            textBoxcontrasena.PasswordChar = '*';
            textBoxcontrasena.PlaceholderText = "Ingrese su contrasena";
            textBoxcontrasena.Size = new Size(161, 27);
            textBoxcontrasena.TabIndex = 4;
            // 
            // buttonaceptar
            // 
            buttonaceptar.Location = new Point(99, 272);
            buttonaceptar.Name = "buttonaceptar";
            buttonaceptar.Size = new Size(94, 29);
            buttonaceptar.TabIndex = 5;
            buttonaceptar.Text = "Aceptar";
            buttonaceptar.UseVisualStyleBackColor = true;
            buttonaceptar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(651, 393);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttoncancelar
            // 
            buttoncancelar.Location = new Point(222, 272);
            buttoncancelar.Name = "buttoncancelar";
            buttoncancelar.Size = new Size(94, 29);
            buttoncancelar.TabIndex = 7;
            buttoncancelar.Text = "Cancelar";
            buttoncancelar.UseVisualStyleBackColor = true;
            buttoncancelar.Click += buttoncancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttoncancelar);
            Controls.Add(button2);
            Controls.Add(buttonaceptar);
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
        private Button buttonaceptar;
        private Button button2;
        private Button buttoncancelar;
    }
}
