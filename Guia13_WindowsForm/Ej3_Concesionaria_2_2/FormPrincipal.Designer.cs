
namespace Ej3_Concesionaria_2_2
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
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.tbAñoActual = new System.Windows.Forms.TextBox();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.gbAltaEmbarque = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarEmbarque = new System.Windows.Forms.Button();
            this.tbNroEmbarque = new System.Windows.Forms.TextBox();
            this.btnRechazarEmbarque = new System.Windows.Forms.Button();
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMontoFabricacion = new System.Windows.Forms.TextBox();
            this.btnIngresarVehiculo = new System.Windows.Forms.Button();
            this.tbAñoFabricacion = new System.Windows.Forms.TextBox();
            this.btnIngresarEmbarque = new System.Windows.Forms.Button();
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.btnListadoEmbarques = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmbarquePorNumero = new System.Windows.Forms.Button();
            this.tbNumeroEmbBusq = new System.Windows.Forms.TextBox();
            this.btnEmbarqueMayor = new System.Windows.Forms.Button();
            this.ltbInforme = new System.Windows.Forms.ListBox();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.gbInicio.SuspendLayout();
            this.gbRegistro.SuspendLayout();
            this.gbAltaEmbarque.SuspendLayout();
            this.gbVehiculo.SuspendLayout();
            this.gbInforme.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.Controls.Add(this.btnInicio);
            this.gbInicio.Controls.Add(this.tbAñoActual);
            this.gbInicio.Location = new System.Drawing.Point(12, 12);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(347, 78);
            this.gbInicio.TabIndex = 0;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio Sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año actual";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(245, 33);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(90, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // tbAñoActual
            // 
            this.tbAñoActual.Location = new System.Drawing.Point(130, 36);
            this.tbAñoActual.Name = "tbAñoActual";
            this.tbAñoActual.Size = new System.Drawing.Size(100, 20);
            this.tbAñoActual.TabIndex = 0;
            this.tbAñoActual.Text = "2023";
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.gbAltaEmbarque);
            this.gbRegistro.Controls.Add(this.btnRechazarEmbarque);
            this.gbRegistro.Controls.Add(this.gbVehiculo);
            this.gbRegistro.Controls.Add(this.btnIngresarEmbarque);
            this.gbRegistro.Enabled = false;
            this.gbRegistro.Location = new System.Drawing.Point(12, 96);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(347, 224);
            this.gbRegistro.TabIndex = 1;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro de Embarque";
            // 
            // gbAltaEmbarque
            // 
            this.gbAltaEmbarque.Controls.Add(this.label2);
            this.gbAltaEmbarque.Controls.Add(this.btnIniciarEmbarque);
            this.gbAltaEmbarque.Controls.Add(this.tbNroEmbarque);
            this.gbAltaEmbarque.Enabled = false;
            this.gbAltaEmbarque.Location = new System.Drawing.Point(11, 26);
            this.gbAltaEmbarque.Name = "gbAltaEmbarque";
            this.gbAltaEmbarque.Size = new System.Drawing.Size(330, 62);
            this.gbAltaEmbarque.TabIndex = 3;
            this.gbAltaEmbarque.TabStop = false;
            this.gbAltaEmbarque.Text = "Dato del embarque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número embarque";
            // 
            // btnIniciarEmbarque
            // 
            this.btnIniciarEmbarque.Location = new System.Drawing.Point(242, 11);
            this.btnIniciarEmbarque.Name = "btnIniciarEmbarque";
            this.btnIniciarEmbarque.Size = new System.Drawing.Size(82, 41);
            this.btnIniciarEmbarque.TabIndex = 3;
            this.btnIniciarEmbarque.Text = "Alta Embarque";
            this.btnIniciarEmbarque.UseVisualStyleBackColor = true;
            this.btnIniciarEmbarque.Click += new System.EventHandler(this.btnIniciarEmbarque_Click);
            // 
            // tbNroEmbarque
            // 
            this.tbNroEmbarque.Location = new System.Drawing.Point(119, 22);
            this.tbNroEmbarque.Name = "tbNroEmbarque";
            this.tbNroEmbarque.Size = new System.Drawing.Size(100, 20);
            this.tbNroEmbarque.TabIndex = 2;
            // 
            // btnRechazarEmbarque
            // 
            this.btnRechazarEmbarque.Location = new System.Drawing.Point(208, 179);
            this.btnRechazarEmbarque.Name = "btnRechazarEmbarque";
            this.btnRechazarEmbarque.Size = new System.Drawing.Size(75, 40);
            this.btnRechazarEmbarque.TabIndex = 7;
            this.btnRechazarEmbarque.Text = "Rechazar";
            this.btnRechazarEmbarque.UseVisualStyleBackColor = true;
            this.btnRechazarEmbarque.Click += new System.EventHandler(this.btnRechazarEmbarque_Click);
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.Controls.Add(this.label4);
            this.gbVehiculo.Controls.Add(this.label3);
            this.gbVehiculo.Controls.Add(this.tbMontoFabricacion);
            this.gbVehiculo.Controls.Add(this.btnIngresarVehiculo);
            this.gbVehiculo.Controls.Add(this.tbAñoFabricacion);
            this.gbVehiculo.Enabled = false;
            this.gbVehiculo.Location = new System.Drawing.Point(11, 96);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(330, 77);
            this.gbVehiculo.TabIndex = 3;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Vehículo del embarque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto de fabricación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año de fabricación";
            // 
            // tbMontoFabricacion
            // 
            this.tbMontoFabricacion.Location = new System.Drawing.Point(119, 44);
            this.tbMontoFabricacion.Name = "tbMontoFabricacion";
            this.tbMontoFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbMontoFabricacion.TabIndex = 5;
            // 
            // btnIngresarVehiculo
            // 
            this.btnIngresarVehiculo.Location = new System.Drawing.Point(234, 18);
            this.btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            this.btnIngresarVehiculo.Size = new System.Drawing.Size(90, 49);
            this.btnIngresarVehiculo.TabIndex = 6;
            this.btnIngresarVehiculo.Text = "Ingresar Vehiculo";
            this.btnIngresarVehiculo.UseVisualStyleBackColor = true;
            this.btnIngresarVehiculo.Click += new System.EventHandler(this.btnIngresarVehiculo_Click);
            // 
            // tbAñoFabricacion
            // 
            this.tbAñoFabricacion.Location = new System.Drawing.Point(119, 19);
            this.tbAñoFabricacion.Name = "tbAñoFabricacion";
            this.tbAñoFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbAñoFabricacion.TabIndex = 4;
            // 
            // btnIngresarEmbarque
            // 
            this.btnIngresarEmbarque.Location = new System.Drawing.Point(81, 179);
            this.btnIngresarEmbarque.Name = "btnIngresarEmbarque";
            this.btnIngresarEmbarque.Size = new System.Drawing.Size(77, 40);
            this.btnIngresarEmbarque.TabIndex = 8;
            this.btnIngresarEmbarque.Text = "Aceptar";
            this.btnIngresarEmbarque.UseVisualStyleBackColor = true;
            this.btnIngresarEmbarque.Click += new System.EventHandler(this.btnIngresarEmbarque_Click);
            // 
            // gbInforme
            // 
            this.gbInforme.Controls.Add(this.btnListadoEmbarques);
            this.gbInforme.Controls.Add(this.groupBox5);
            this.gbInforme.Controls.Add(this.btnEmbarqueMayor);
            this.gbInforme.Controls.Add(this.ltbInforme);
            this.gbInforme.Controls.Add(this.btnRecaudacion);
            this.gbInforme.Enabled = false;
            this.gbInforme.Location = new System.Drawing.Point(365, 12);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(546, 308);
            this.gbInforme.TabIndex = 2;
            this.gbInforme.TabStop = false;
            this.gbInforme.Text = "Informe";
            // 
            // btnListadoEmbarques
            // 
            this.btnListadoEmbarques.Location = new System.Drawing.Point(465, 169);
            this.btnListadoEmbarques.Name = "btnListadoEmbarques";
            this.btnListadoEmbarques.Size = new System.Drawing.Size(75, 36);
            this.btnListadoEmbarques.TabIndex = 14;
            this.btnListadoEmbarques.Text = "Todos los embarues";
            this.btnListadoEmbarques.UseVisualStyleBackColor = true;
            this.btnListadoEmbarques.Click += new System.EventHandler(this.btnListadoEmbarques_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnEmbarquePorNumero);
            this.groupBox5.Controls.Add(this.tbNumeroEmbBusq);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(534, 56);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver Embarque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número embarque";
            // 
            // btnEmbarquePorNumero
            // 
            this.btnEmbarquePorNumero.Location = new System.Drawing.Point(369, 15);
            this.btnEmbarquePorNumero.Name = "btnEmbarquePorNumero";
            this.btnEmbarquePorNumero.Size = new System.Drawing.Size(150, 31);
            this.btnEmbarquePorNumero.TabIndex = 10;
            this.btnEmbarquePorNumero.Text = "Buscar Embarque";
            this.btnEmbarquePorNumero.UseVisualStyleBackColor = true;
            this.btnEmbarquePorNumero.Click += new System.EventHandler(this.btnEmbarquePorNumero_Click);
            // 
            // tbNumeroEmbBusq
            // 
            this.tbNumeroEmbBusq.Location = new System.Drawing.Point(117, 21);
            this.tbNumeroEmbBusq.Name = "tbNumeroEmbBusq";
            this.tbNumeroEmbBusq.Size = new System.Drawing.Size(231, 20);
            this.tbNumeroEmbBusq.TabIndex = 9;
            // 
            // btnEmbarqueMayor
            // 
            this.btnEmbarqueMayor.Location = new System.Drawing.Point(465, 126);
            this.btnEmbarqueMayor.Name = "btnEmbarqueMayor";
            this.btnEmbarqueMayor.Size = new System.Drawing.Size(75, 36);
            this.btnEmbarqueMayor.TabIndex = 13;
            this.btnEmbarqueMayor.Text = "Embarque Mayor";
            this.btnEmbarqueMayor.UseVisualStyleBackColor = true;
            this.btnEmbarqueMayor.Click += new System.EventHandler(this.btnEmbarqueMayor_Click);
            // 
            // ltbInforme
            // 
            this.ltbInforme.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbInforme.FormattingEnabled = true;
            this.ltbInforme.ItemHeight = 16;
            this.ltbInforme.Location = new System.Drawing.Point(6, 84);
            this.ltbInforme.Name = "ltbInforme";
            this.ltbInforme.Size = new System.Drawing.Size(453, 212);
            this.ltbInforme.TabIndex = 11;
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(465, 84);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(75, 36);
            this.btnRecaudacion.TabIndex = 12;
            this.btnRecaudacion.Text = "Resumen del día";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 327);
            this.Controls.Add(this.gbInforme);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.gbInicio);
            this.Name = "FormPrincipal";
            this.Text = "Mi concesionaria";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            this.gbRegistro.ResumeLayout(false);
            this.gbAltaEmbarque.ResumeLayout(false);
            this.gbAltaEmbarque.PerformLayout();
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            this.gbInforme.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox tbAñoActual;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Button btnIniciarEmbarque;
        private System.Windows.Forms.GroupBox gbVehiculo;
        private System.Windows.Forms.TextBox tbMontoFabricacion;
        private System.Windows.Forms.Button btnIngresarVehiculo;
        private System.Windows.Forms.TextBox tbAñoFabricacion;
        private System.Windows.Forms.Button btnIngresarEmbarque;
        private System.Windows.Forms.TextBox tbNroEmbarque;
        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.Button btnListadoEmbarques;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEmbarquePorNumero;
        private System.Windows.Forms.TextBox tbNumeroEmbBusq;
        private System.Windows.Forms.Button btnEmbarqueMayor;
        private System.Windows.Forms.ListBox ltbInforme;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRechazarEmbarque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbAltaEmbarque;
    }
}

