namespace Evaluacion_Nacional
{
    partial class FrmRegistrarSueldo
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
            txtRut = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHorasTrabajadas = new TextBox();
            txtHorasExtras = new TextBox();
            cbbAFP = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cbbSalud = new ComboBox();
            btnCalcular = new Button();
            btnGuardar = new Button();
            btnLimpiarCampos = new Button();
            btnListar = new Button();
            label7 = new Label();
            label8 = new Label();
            txtSueldoBruto = new TextBox();
            txtSueldoLiquido = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 36);
            label1.Name = "label1";
            label1.Size = new Size(299, 31);
            label1.TabIndex = 0;
            label1.Text = "Registrar sueldo empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 99);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Rut empleado:";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(409, 95);
            txtRut.Name = "txtRut";
            txtRut.PlaceholderText = "Ingrese rut empleado";
            txtRut.Size = new Size(152, 27);
            txtRut.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 149);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 3;
            label3.Text = "Horas trabajadas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 201);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 4;
            label4.Text = "Horas extras:";
            // 
            // txtHorasTrabajadas
            // 
            txtHorasTrabajadas.Location = new Point(204, 149);
            txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            txtHorasTrabajadas.PlaceholderText = "Ingrese horas trabajadas";
            txtHorasTrabajadas.Size = new Size(169, 27);
            txtHorasTrabajadas.TabIndex = 5;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(204, 197);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.PlaceholderText = "Ingrese horas extras";
            txtHorasExtras.Size = new Size(169, 27);
            txtHorasExtras.TabIndex = 6;
            // 
            // cbbAFP
            // 
            cbbAFP.FormattingEnabled = true;
            cbbAFP.Items.AddRange(new object[] { "CUPRUM", "MODELO", "CAPITAL", "PROVIDA" });
            cbbAFP.Location = new Point(575, 144);
            cbbAFP.Name = "cbbAFP";
            cbbAFP.Size = new Size(151, 28);
            cbbAFP.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(409, 149);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 8;
            label5.Text = "AFP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(409, 201);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 9;
            label6.Text = "Prevision Salud:";
            // 
            // cbbSalud
            // 
            cbbSalud.FormattingEnabled = true;
            cbbSalud.Items.AddRange(new object[] { "FONASA", "CONSALUD", "MASVIDA", "BANMEDICA" });
            cbbSalud.Location = new Point(575, 196);
            cbbSalud.Name = "cbbSalud";
            cbbSalud.Size = new Size(151, 28);
            cbbSalud.TabIndex = 10;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(38, 261);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(38, 314);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.Location = new Point(38, 367);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(94, 29);
            btnLimpiarCampos.TabIndex = 13;
            btnLimpiarCampos.Text = "Limpiar";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(38, 425);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 29);
            btnListar.TabIndex = 14;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(351, 296);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 15;
            label7.Text = "Sueldo Bruto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(351, 367);
            label8.Name = "label8";
            label8.Size = new Size(136, 23);
            label8.TabIndex = 16;
            label8.Text = "Sueldo Líquido:";
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Location = new Point(575, 292);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.ReadOnly = true;
            txtSueldoBruto.Size = new Size(151, 27);
            txtSueldoBruto.TabIndex = 17;
            // 
            // txtSueldoLiquido
            // 
            txtSueldoLiquido.Location = new Point(575, 363);
            txtSueldoLiquido.Name = "txtSueldoLiquido";
            txtSueldoLiquido.ReadOnly = true;
            txtSueldoLiquido.Size = new Size(151, 27);
            txtSueldoLiquido.TabIndex = 18;
            // 
            // FrmRegistrarSueldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(txtSueldoLiquido);
            Controls.Add(txtSueldoBruto);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnListar);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnGuardar);
            Controls.Add(btnCalcular);
            Controls.Add(cbbSalud);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbbAFP);
            Controls.Add(txtHorasExtras);
            Controls.Add(txtHorasTrabajadas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtRut);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistrarSueldo";
            Text = "Registrar sueldo empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRut;
        private Label label3;
        private Label label4;
        private TextBox txtHorasTrabajadas;
        private TextBox txtHorasExtras;
        private ComboBox cbbAFP;
        private Label label5;
        private Label label6;
        private ComboBox cbbSalud;
        private Button btnCalcular;
        private Button btnGuardar;
        private Button btnLimpiarCampos;
        private Button btnListar;
        private Label label7;
        private Label label8;
        private TextBox txtSueldoBruto;
        private TextBox txtSueldoLiquido;
    }
}