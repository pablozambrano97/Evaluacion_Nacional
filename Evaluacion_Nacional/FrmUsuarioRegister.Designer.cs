namespace Evaluacion_Nacional
{
    partial class FrmUsuarioRegister
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtRutUsuario = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            btnRegistrar = new Button();
            txtValorHora = new MaskedTextBox();
            txtHoraExtra = new MaskedTextBox();
            txtTelefono = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 32);
            label1.Name = "label1";
            label1.Size = new Size(300, 31);
            label1.TabIndex = 0;
            label1.Text = "Registrar nuevo trabajador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 89);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 1;
            label2.Text = "Rut Trabajador:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 150);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(171, 200);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(171, 249);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 4;
            label5.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(171, 310);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 5;
            label6.Text = "Valor hora:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(171, 360);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 6;
            label7.Text = "Valor extra:";
            // 
            // txtRutUsuario
            // 
            txtRutUsuario.CharacterCasing = CharacterCasing.Upper;
            txtRutUsuario.Location = new Point(371, 85);
            txtRutUsuario.Name = "txtRutUsuario";
            txtRutUsuario.PlaceholderText = "Ingrese número de Rut";
            txtRutUsuario.Size = new Size(182, 27);
            txtRutUsuario.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(371, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingresar Nombre";
            txtNombre.Size = new Size(182, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(371, 196);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese Dirección";
            txtDireccion.Size = new Size(182, 27);
            txtDireccion.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(280, 406);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(165, 29);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar empleado";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(371, 306);
            txtValorHora.Mask = "99999";
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(182, 27);
            txtValorHora.TabIndex = 14;
            txtValorHora.ValidatingType = typeof(int);
            // 
            // txtHoraExtra
            // 
            txtHoraExtra.Location = new Point(371, 356);
            txtHoraExtra.Mask = "99999";
            txtHoraExtra.Name = "txtHoraExtra";
            txtHoraExtra.Size = new Size(182, 27);
            txtHoraExtra.TabIndex = 15;
            txtHoraExtra.ValidatingType = typeof(int);
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(371, 245);
            txtTelefono.Mask = "(+99) 0 0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(182, 27);
            txtTelefono.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 115);
            label8.Name = "label8";
            label8.Size = new Size(149, 20);
            label8.TabIndex = 17;
            label8.Text = "Ejemplo: 22333444-5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(371, 275);
            label9.Name = "label9";
            label9.Size = new Size(181, 20);
            label9.TabIndex = 18;
            label9.Text = "Ejemplo: +56 9 9999 9999";
            // 
            // FrmUsuarioRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 478);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(txtHoraExtra);
            Controls.Add(txtValorHora);
            Controls.Add(btnRegistrar);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtRutUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUsuarioRegister";
            Text = "Registrar Trabajador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtRutUsuario;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Button btnRegistrar;
        private MaskedTextBox txtValorHora;
        private MaskedTextBox txtHoraExtra;
        private MaskedTextBox txtTelefono;
        private Label label8;
        private Label label9;
    }
}