
namespace Ej6_SistemaPeaje
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInicioSistema = new System.Windows.Forms.GroupBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCantVehiculos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresarDia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMayorPeriodo = new System.Windows.Forms.Button();
            this.ltbInforme = new System.Windows.Forms.ListBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.gbInicioSistema.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicioSistema
            // 
            this.gbInicioSistema.Controls.Add(this.cmbDias);
            this.gbInicioSistema.Controls.Add(this.label1);
            this.gbInicioSistema.Controls.Add(this.tbCantVehiculos);
            this.gbInicioSistema.Controls.Add(this.label3);
            this.gbInicioSistema.Controls.Add(this.btnIngresarDia);
            this.gbInicioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInicioSistema.Location = new System.Drawing.Point(13, 12);
            this.gbInicioSistema.Name = "gbInicioSistema";
            this.gbInicioSistema.Size = new System.Drawing.Size(514, 116);
            this.gbInicioSistema.TabIndex = 1;
            this.gbInicioSistema.TabStop = false;
            this.gbInicioSistema.Text = "Información diaria de vehículos";
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            ""});
            this.cmbDias.Location = new System.Drawing.Point(252, 34);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(60, 24);
            this.cmbDias.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de Vehículos";
            // 
            // tbCantVehiculos
            // 
            this.tbCantVehiculos.Location = new System.Drawing.Point(252, 64);
            this.tbCantVehiculos.Name = "tbCantVehiculos";
            this.tbCantVehiculos.Size = new System.Drawing.Size(60, 23);
            this.tbCantVehiculos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Día";
            // 
            // btnIngresarDia
            // 
            this.btnIngresarDia.Location = new System.Drawing.Point(398, 24);
            this.btnIngresarDia.Name = "btnIngresarDia";
            this.btnIngresarDia.Size = new System.Drawing.Size(92, 63);
            this.btnIngresarDia.TabIndex = 1;
            this.btnIngresarDia.Text = "Ingresar Peajes";
            this.btnIngresarDia.UseVisualStyleBackColor = true;
            this.btnIngresarDia.Click += new System.EventHandler(this.btnIngresarDia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMayorPeriodo);
            this.groupBox1.Controls.Add(this.ltbInforme);
            this.groupBox1.Controls.Add(this.btnPromedio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe";
            // 
            // btnMayorPeriodo
            // 
            this.btnMayorPeriodo.Location = new System.Drawing.Point(399, 91);
            this.btnMayorPeriodo.Name = "btnMayorPeriodo";
            this.btnMayorPeriodo.Size = new System.Drawing.Size(92, 63);
            this.btnMayorPeriodo.TabIndex = 3;
            this.btnMayorPeriodo.Text = "Periodo mayor movimiento";
            this.btnMayorPeriodo.UseVisualStyleBackColor = true;
            this.btnMayorPeriodo.Click += new System.EventHandler(this.btnMayorPeriodo_Click);
            // 
            // ltbInforme
            // 
            this.ltbInforme.FormattingEnabled = true;
            this.ltbInforme.ItemHeight = 16;
            this.ltbInforme.Location = new System.Drawing.Point(10, 22);
            this.ltbInforme.Name = "ltbInforme";
            this.ltbInforme.Size = new System.Drawing.Size(383, 148);
            this.ltbInforme.TabIndex = 2;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(399, 22);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(92, 63);
            this.btnPromedio.TabIndex = 1;
            this.btnPromedio.Text = "Promedio del mes";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInicioSistema);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de peaje";
            this.gbInicioSistema.ResumeLayout(false);
            this.gbInicioSistema.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicioSistema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresarDia;
        private System.Windows.Forms.TextBox tbCantVehiculos;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMayorPeriodo;
        private System.Windows.Forms.ListBox ltbInforme;
        private System.Windows.Forms.Button btnPromedio;
    }
}

