namespace Evaluacion_Nacional
{
    partial class FrmListarTrabajadores
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
            comboBox1 = new ComboBox();
            lvSueldos = new ListView();
            column = new ColumnHeader();
            columnRutEmpleado = new ColumnHeader();
            columnAFP = new ColumnHeader();
            columnPrevision = new ColumnHeader();
            columnSueldoBruto = new ColumnHeader();
            columnSueldoLiquido = new ColumnHeader();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 34);
            label1.Name = "label1";
            label1.Size = new Size(228, 31);
            label1.TabIndex = 0;
            label1.Text = "Listas de empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 98);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "TRABAJADOR:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TODOS" });
            comboBox1.Location = new Point(386, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // lvSueldos
            // 
            lvSueldos.Columns.AddRange(new ColumnHeader[] { column, columnRutEmpleado, columnAFP, columnPrevision, columnSueldoBruto, columnSueldoLiquido });
            lvSueldos.Location = new Point(2, 143);
            lvSueldos.Name = "lvSueldos";
            lvSueldos.Size = new Size(795, 258);
            lvSueldos.TabIndex = 3;
            lvSueldos.UseCompatibleStateImageBehavior = false;
            lvSueldos.View = View.Details;
            // 
            // column
            // 
            column.Text = "";
            column.Width = 1;
            // 
            // columnRutEmpleado
            // 
            columnRutEmpleado.Text = "RUT EMPLEADO";
            columnRutEmpleado.Width = 120;
            // 
            // columnAFP
            // 
            columnAFP.Text = "AFP";
            columnAFP.Width = 120;
            // 
            // columnPrevision
            // 
            columnPrevision.Text = "PREVISION SALUD";
            columnPrevision.Width = 120;
            // 
            // columnSueldoBruto
            // 
            columnSueldoBruto.Text = "SUELDO BRUTO";
            columnSueldoBruto.Width = 120;
            // 
            // columnSueldoLiquido
            // 
            columnSueldoLiquido.Text = "SUELDO LÍQUIDO";
            columnSueldoLiquido.Width = 120;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(189, 434);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(453, 434);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmListarTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(lvSueldos);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmListarTrabajadores";
            Text = "Listrar empleados";
            Load += FrmListarTrabajadores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ListView lvSueldos;
        private ColumnHeader column;
        private ColumnHeader columnRutEmpleado;
        private ColumnHeader columnAFP;
        private ColumnHeader columnSueldoLiquido;
        private Button btnModificar;
        private Button btnEliminar;
        private ColumnHeader columnSueldoBruto;
        private ColumnHeader columnPrevision;
    }
}