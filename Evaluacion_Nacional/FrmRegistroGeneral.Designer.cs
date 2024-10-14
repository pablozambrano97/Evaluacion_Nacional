namespace Evaluacion_Nacional
{
    partial class FrmRegistroGeneral
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRutUsuario = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            txtRepetirPassword = new TextBox();
            btnRegistrar = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 37);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 0;
            label1.Text = "Registro de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 94);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 1;
            label2.Text = "Rut";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 163);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtRutUsuario
            // 
            txtRutUsuario.CharacterCasing = CharacterCasing.Upper;
            txtRutUsuario.Location = new Point(265, 90);
            txtRutUsuario.Name = "txtRutUsuario";
            txtRutUsuario.PlaceholderText = "Ingrese su rut";
            txtRutUsuario.Size = new Size(186, 27);
            txtRutUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 159);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Ingrese Contraseña";
            txtPassword.Size = new Size(186, 27);
            txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 214);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 5;
            label4.Text = "Repetir contraseña";
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.Location = new Point(265, 210);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.PasswordChar = '*';
            txtRepetirPassword.PlaceholderText = "Repetir Contraseña";
            txtRepetirPassword.Size = new Size(186, 27);
            txtRepetirPassword.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(200, 274);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 117);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 8;
            label5.Text = "Ejemplo: 22333444-5";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(217, 316);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingresar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmRegistroGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 368);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(txtRepetirPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtRutUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistroGeneral";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRutUsuario;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtRepetirPassword;
        private Button btnRegistrar;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}