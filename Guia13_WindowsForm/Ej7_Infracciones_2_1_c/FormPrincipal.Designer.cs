
namespace Ej7_Infracciones_2_1_c
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarSistema = new System.Windows.Forms.Button();
            this.tbBaseMonetaria = new System.Windows.Forms.TextBox();
            this.gbActa = new System.Windows.Forms.GroupBox();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.chbPagaLugar = new System.Windows.Forms.CheckBox();
            this.gbTipoInfraccion = new System.Windows.Forms.GroupBox();
            this.cbmInfracciones = new System.Windows.Forms.ComboBox();
            this.btnAgregarInfraccion = new System.Windows.Forms.Button();
            this.gbTipoVehiculo = new System.Windows.Forms.GroupBox();
            this.rbEje2 = new System.Windows.Forms.RadioButton();
            this.rbEje3 = new System.Windows.Forms.RadioButton();
            this.rbEje1 = new System.Windows.Forms.RadioButton();
            this.btnRegistrarActa = new System.Windows.Forms.Button();
            this.gbConductor = new System.Windows.Forms.GroupBox();
            this.btnIniciarActa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.gbInformes = new System.Windows.Forms.GroupBox();
            this.btnListadoPagoEnLugar = new System.Windows.Forms.Button();
            this.btnMayorMonto = new System.Windows.Forms.Button();
            this.lbxInforme = new System.Windows.Forms.ListBox();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.gbInicioSistema.SuspendLayout();
            this.gbActa.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.gbTipoInfraccion.SuspendLayout();
            this.gbTipoVehiculo.SuspendLayout();
            this.gbConductor.SuspendLayout();
            this.gbInformes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicioSistema
            // 
            this.gbInicioSistema.Controls.Add(this.label3);
            this.gbInicioSistema.Controls.Add(this.btnIniciarSistema);
            this.gbInicioSistema.Controls.Add(this.tbBaseMonetaria);
            this.gbInicioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInicioSistema.Location = new System.Drawing.Point(12, 12);
            this.gbInicioSistema.Name = "gbInicioSistema";
            this.gbInicioSistema.Size = new System.Drawing.Size(400, 71);
            this.gbInicioSistema.TabIndex = 0;
            this.gbInicioSistema.TabStop = false;
            this.gbInicioSistema.Text = "Inicio del Sistema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor $/Litro nafta";
            // 
            // btnIniciarSistema
            // 
            this.btnIniciarSistema.Location = new System.Drawing.Point(296, 22);
            this.btnIniciarSistema.Name = "btnIniciarSistema";
            this.btnIniciarSistema.Size = new System.Drawing.Size(92, 39);
            this.btnIniciarSistema.TabIndex = 1;
            this.btnIniciarSistema.Text = "Iniciar";
            this.btnIniciarSistema.UseVisualStyleBackColor = true;
            this.btnIniciarSistema.Click += new System.EventHandler(this.btnIniciarSistema_Click);
            // 
            // tbBaseMonetaria
            // 
            this.tbBaseMonetaria.Location = new System.Drawing.Point(139, 32);
            this.tbBaseMonetaria.Name = "tbBaseMonetaria";
            this.tbBaseMonetaria.Size = new System.Drawing.Size(151, 23);
            this.tbBaseMonetaria.TabIndex = 0;
            // 
            // gbActa
            // 
            this.gbActa.Controls.Add(this.gbPago);
            this.gbActa.Controls.Add(this.gbTipoInfraccion);
            this.gbActa.Controls.Add(this.gbTipoVehiculo);
            this.gbActa.Controls.Add(this.btnRegistrarActa);
            this.gbActa.Controls.Add(this.gbConductor);
            this.gbActa.Enabled = false;
            this.gbActa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActa.Location = new System.Drawing.Point(12, 87);
            this.gbActa.Name = "gbActa";
            this.gbActa.Size = new System.Drawing.Size(400, 406);
            this.gbActa.TabIndex = 1;
            this.gbActa.TabStop = false;
            this.gbActa.Text = "Acta";
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.chbPagaLugar);
            this.gbPago.Enabled = false;
            this.gbPago.Location = new System.Drawing.Point(6, 294);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(388, 46);
            this.gbPago.TabIndex = 10;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // chbPagaLugar
            // 
            this.chbPagaLugar.AutoSize = true;
            this.chbPagaLugar.Location = new System.Drawing.Point(79, 18);
            this.chbPagaLugar.Name = "chbPagaLugar";
            this.chbPagaLugar.Size = new System.Drawing.Size(147, 21);
            this.chbPagaLugar.TabIndex = 0;
            this.chbPagaLugar.Text = "¿Paga en el lugar?";
            this.chbPagaLugar.UseVisualStyleBackColor = true;
            // 
            // gbTipoInfraccion
            // 
            this.gbTipoInfraccion.Controls.Add(this.cbmInfracciones);
            this.gbTipoInfraccion.Controls.Add(this.btnAgregarInfraccion);
            this.gbTipoInfraccion.Enabled = false;
            this.gbTipoInfraccion.Location = new System.Drawing.Point(6, 212);
            this.gbTipoInfraccion.Name = "gbTipoInfraccion";
            this.gbTipoInfraccion.Size = new System.Drawing.Size(388, 76);
            this.gbTipoInfraccion.TabIndex = 7;
            this.gbTipoInfraccion.TabStop = false;
            this.gbTipoInfraccion.Text = "Tipo de Infracción";
            // 
            // cbmInfracciones
            // 
            this.cbmInfracciones.FormattingEnabled = true;
            this.cbmInfracciones.Location = new System.Drawing.Point(24, 29);
            this.cbmInfracciones.Name = "cbmInfracciones";
            this.cbmInfracciones.Size = new System.Drawing.Size(260, 24);
            this.cbmInfracciones.TabIndex = 9;
            // 
            // btnAgregarInfraccion
            // 
            this.btnAgregarInfraccion.Location = new System.Drawing.Point(290, 13);
            this.btnAgregarInfraccion.Name = "btnAgregarInfraccion";
            this.btnAgregarInfraccion.Size = new System.Drawing.Size(92, 55);
            this.btnAgregarInfraccion.TabIndex = 8;
            this.btnAgregarInfraccion.Text = "Agregar Infracción";
            this.btnAgregarInfraccion.UseVisualStyleBackColor = true;
            this.btnAgregarInfraccion.Click += new System.EventHandler(this.btnAgregarInfraccion_Click);
            // 
            // gbTipoVehiculo
            // 
            this.gbTipoVehiculo.Controls.Add(this.rbEje2);
            this.gbTipoVehiculo.Controls.Add(this.rbEje3);
            this.gbTipoVehiculo.Controls.Add(this.rbEje1);
            this.gbTipoVehiculo.Location = new System.Drawing.Point(12, 99);
            this.gbTipoVehiculo.Name = "gbTipoVehiculo";
            this.gbTipoVehiculo.Size = new System.Drawing.Size(278, 97);
            this.gbTipoVehiculo.TabIndex = 6;
            this.gbTipoVehiculo.TabStop = false;
            this.gbTipoVehiculo.Text = "Tipo de vehículo";
            // 
            // rbEje2
            // 
            this.rbEje2.AutoSize = true;
            this.rbEje2.Location = new System.Drawing.Point(90, 42);
            this.rbEje2.Name = "rbEje2";
            this.rbEje2.Size = new System.Drawing.Size(139, 21);
            this.rbEje2.TabIndex = 2;
            this.rbEje2.TabStop = true;
            this.rbEje2.Text = "2 Ejes (automovil)";
            this.rbEje2.UseVisualStyleBackColor = true;
            // 
            // rbEje3
            // 
            this.rbEje3.AutoSize = true;
            this.rbEje3.Location = new System.Drawing.Point(90, 65);
            this.rbEje3.Name = "rbEje3";
            this.rbEje3.Size = new System.Drawing.Size(122, 21);
            this.rbEje3.TabIndex = 1;
            this.rbEje3.TabStop = true;
            this.rbEje3.Text = "3 o más (otros)";
            this.rbEje3.UseVisualStyleBackColor = true;
            // 
            // rbEje1
            // 
            this.rbEje1.AutoSize = true;
            this.rbEje1.Location = new System.Drawing.Point(90, 19);
            this.rbEje1.Name = "rbEje1";
            this.rbEje1.Size = new System.Drawing.Size(103, 21);
            this.rbEje1.TabIndex = 0;
            this.rbEje1.TabStop = true;
            this.rbEje1.Text = "1 Eje (moto)";
            this.rbEje1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarActa
            // 
            this.btnRegistrarActa.Location = new System.Drawing.Point(147, 348);
            this.btnRegistrarActa.Name = "btnRegistrarActa";
            this.btnRegistrarActa.Size = new System.Drawing.Size(105, 52);
            this.btnRegistrarActa.TabIndex = 1;
            this.btnRegistrarActa.Text = "Registrar Acta";
            this.btnRegistrarActa.UseVisualStyleBackColor = true;
            this.btnRegistrarActa.Click += new System.EventHandler(this.btnRegistrarActa_Click);
            // 
            // gbConductor
            // 
            this.gbConductor.Controls.Add(this.btnIniciarActa);
            this.gbConductor.Controls.Add(this.label1);
            this.gbConductor.Controls.Add(this.tbNombre);
            this.gbConductor.Controls.Add(this.label2);
            this.gbConductor.Controls.Add(this.tbDni);
            this.gbConductor.Location = new System.Drawing.Point(6, 22);
            this.gbConductor.Name = "gbConductor";
            this.gbConductor.Size = new System.Drawing.Size(388, 184);
            this.gbConductor.TabIndex = 5;
            this.gbConductor.TabStop = false;
            this.gbConductor.Text = "Conductor:";
            // 
            // btnIniciarActa
            // 
            this.btnIniciarActa.Location = new System.Drawing.Point(290, 119);
            this.btnIniciarActa.Name = "btnIniciarActa";
            this.btnIniciarActa.Size = new System.Drawing.Size(92, 52);
            this.btnIniciarActa.TabIndex = 5;
            this.btnIniciarActa.Text = "Iniciar Acta";
            this.btnIniciarActa.UseVisualStyleBackColor = true;
            this.btnIniciarActa.Click += new System.EventHandler(this.btnIniciarActa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(124, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(160, 23);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(124, 19);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(160, 23);
            this.tbDni.TabIndex = 0;
            // 
            // gbInformes
            // 
            this.gbInformes.Controls.Add(this.btnListadoPagoEnLugar);
            this.gbInformes.Controls.Add(this.btnMayorMonto);
            this.gbInformes.Controls.Add(this.lbxInforme);
            this.gbInformes.Controls.Add(this.btnRecaudacion);
            this.gbInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformes.Location = new System.Drawing.Point(418, 12);
            this.gbInformes.Name = "gbInformes";
            this.gbInformes.Size = new System.Drawing.Size(368, 481);
            this.gbInformes.TabIndex = 2;
            this.gbInformes.TabStop = false;
            this.gbInformes.Text = "Informes";
            // 
            // btnListadoPagoEnLugar
            // 
            this.btnListadoPagoEnLugar.Location = new System.Drawing.Point(249, 20);
            this.btnListadoPagoEnLugar.Name = "btnListadoPagoEnLugar";
            this.btnListadoPagoEnLugar.Size = new System.Drawing.Size(96, 49);
            this.btnListadoPagoEnLugar.TabIndex = 4;
            this.btnListadoPagoEnLugar.Text = "Pagos En el lugar";
            this.btnListadoPagoEnLugar.UseVisualStyleBackColor = true;
            this.btnListadoPagoEnLugar.Click += new System.EventHandler(this.btnListadoPagoEnLugar_Click);
            // 
            // btnMayorMonto
            // 
            this.btnMayorMonto.Location = new System.Drawing.Point(129, 20);
            this.btnMayorMonto.Name = "btnMayorMonto";
            this.btnMayorMonto.Size = new System.Drawing.Size(104, 49);
            this.btnMayorMonto.TabIndex = 3;
            this.btnMayorMonto.Text = "Mayor monto";
            this.btnMayorMonto.UseVisualStyleBackColor = true;
            this.btnMayorMonto.Click += new System.EventHandler(this.btnMayorMonto_Click);
            // 
            // lbxInforme
            // 
            this.lbxInforme.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInforme.FormattingEnabled = true;
            this.lbxInforme.ItemHeight = 16;
            this.lbxInforme.Location = new System.Drawing.Point(6, 75);
            this.lbxInforme.Name = "lbxInforme";
            this.lbxInforme.Size = new System.Drawing.Size(356, 388);
            this.lbxInforme.TabIndex = 2;
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(6, 22);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(106, 49);
            this.btnRecaudacion.TabIndex = 1;
            this.btnRecaudacion.Text = "Recaudacion";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 500);
            this.Controls.Add(this.gbInformes);
            this.Controls.Add(this.gbActa);
            this.Controls.Add(this.gbInicioSistema);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de infracciones";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gbInicioSistema.ResumeLayout(false);
            this.gbInicioSistema.PerformLayout();
            this.gbActa.ResumeLayout(false);
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.gbTipoInfraccion.ResumeLayout(false);
            this.gbTipoVehiculo.ResumeLayout(false);
            this.gbTipoVehiculo.PerformLayout();
            this.gbConductor.ResumeLayout(false);
            this.gbConductor.PerformLayout();
            this.gbInformes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicioSistema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciarSistema;
        private System.Windows.Forms.TextBox tbBaseMonetaria;
        private System.Windows.Forms.GroupBox gbActa;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.CheckBox chbPagaLugar;
        private System.Windows.Forms.GroupBox gbTipoInfraccion;
        private System.Windows.Forms.ComboBox cbmInfracciones;
        private System.Windows.Forms.Button btnAgregarInfraccion;
        private System.Windows.Forms.GroupBox gbTipoVehiculo;
        private System.Windows.Forms.RadioButton rbEje2;
        private System.Windows.Forms.RadioButton rbEje3;
        private System.Windows.Forms.RadioButton rbEje1;
        private System.Windows.Forms.Button btnRegistrarActa;
        private System.Windows.Forms.GroupBox gbConductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.GroupBox gbInformes;
        private System.Windows.Forms.Button btnListadoPagoEnLugar;
        private System.Windows.Forms.Button btnMayorMonto;
        private System.Windows.Forms.ListBox lbxInforme;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Button btnIniciarActa;
    }
}

