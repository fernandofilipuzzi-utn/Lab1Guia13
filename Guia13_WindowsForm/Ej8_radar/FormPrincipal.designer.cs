
namespace Ej8_radar
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
            this.lbtInforme = new System.Windows.Forms.ListBox();
            this.btnListarInfractores = new System.Windows.Forms.Button();
            this.tbPatenteBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarInfractor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.tbVelocidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbEsCivil = new System.Windows.Forms.RadioButton();
            this.rbEsOficial = new System.Windows.Forms.RadioButton();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtInforme
            // 
            this.lbtInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtInforme.FormattingEnabled = true;
            this.lbtInforme.ItemHeight = 20;
            this.lbtInforme.Location = new System.Drawing.Point(6, 108);
            this.lbtInforme.Name = "lbtInforme";
            this.lbtInforme.Size = new System.Drawing.Size(276, 164);
            this.lbtInforme.TabIndex = 1;
            // 
            // btnListarInfractores
            // 
            this.btnListarInfractores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarInfractores.Location = new System.Drawing.Point(295, 108);
            this.btnListarInfractores.Name = "btnListarInfractores";
            this.btnListarInfractores.Size = new System.Drawing.Size(113, 52);
            this.btnListarInfractores.TabIndex = 2;
            this.btnListarInfractores.Text = "Listar Infractores";
            this.btnListarInfractores.UseVisualStyleBackColor = true;
            this.btnListarInfractores.Click += new System.EventHandler(this.btnListarInfractores_Click);
            // 
            // tbPatenteBuscar
            // 
            this.tbPatenteBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatenteBuscar.Location = new System.Drawing.Point(90, 19);
            this.tbPatenteBuscar.Name = "tbPatenteBuscar";
            this.tbPatenteBuscar.Size = new System.Drawing.Size(139, 31);
            this.tbPatenteBuscar.TabIndex = 3;
            // 
            // btnBuscarInfractor
            // 
            this.btnBuscarInfractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInfractor.Location = new System.Drawing.Point(289, 11);
            this.btnBuscarInfractor.Name = "btnBuscarInfractor";
            this.btnBuscarInfractor.Size = new System.Drawing.Size(113, 53);
            this.btnBuscarInfractor.TabIndex = 4;
            this.btnBuscarInfractor.Text = "Buscar Infractor";
            this.btnBuscarInfractor.UseVisualStyleBackColor = true;
            this.btnBuscarInfractor.Click += new System.EventHandler(this.btnBuscarInfractor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPatenteBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarInfractor);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de infractores por patente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPatente);
            this.groupBox2.Controls.Add(this.tbVelocidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 92);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del vehículo";
            // 
            // tbPatente
            // 
            this.tbPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatente.Location = new System.Drawing.Point(93, 24);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(116, 26);
            this.tbPatente.TabIndex = 2;
            // 
            // tbVelocidad
            // 
            this.tbVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVelocidad.Location = new System.Drawing.Point(93, 57);
            this.tbVelocidad.Name = "tbVelocidad";
            this.tbVelocidad.Size = new System.Drawing.Size(116, 26);
            this.tbVelocidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Velocidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbEsCivil);
            this.groupBox3.Controls.Add(this.rbEsOficial);
            this.groupBox3.Location = new System.Drawing.Point(6, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 95);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de vehículo";
            // 
            // rbEsCivil
            // 
            this.rbEsCivil.AutoSize = true;
            this.rbEsCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEsCivil.Location = new System.Drawing.Point(23, 49);
            this.rbEsCivil.Name = "rbEsCivil";
            this.rbEsCivil.Size = new System.Drawing.Size(153, 24);
            this.rbEsCivil.TabIndex = 7;
            this.rbEsCivil.TabStop = true;
            this.rbEsCivil.Text = "¿Es vehículo civil?";
            this.rbEsCivil.UseVisualStyleBackColor = true;
            // 
            // rbEsOficial
            // 
            this.rbEsOficial.AutoSize = true;
            this.rbEsOficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEsOficial.Location = new System.Drawing.Point(23, 19);
            this.rbEsOficial.Name = "rbEsOficial";
            this.rbEsOficial.Size = new System.Drawing.Size(169, 24);
            this.rbEsOficial.TabIndex = 6;
            this.rbEsOficial.TabStop = true;
            this.rbEsOficial.Text = "¿Es vehículo oficial?";
            this.rbEsOficial.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(72, 221);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(92, 49);
            this.btnAgregarVehiculo.TabIndex = 9;
            this.btnAgregarVehiculo.Text = "Agregar Vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btnAgregarVehiculo);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 276);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de vehículo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.lbtInforme);
            this.groupBox5.Controls.Add(this.btnListarInfractores);
            this.groupBox5.Location = new System.Drawing.Point(252, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 276);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de vehículo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 283);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Control radarizado ";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbtInforme;
        private System.Windows.Forms.Button btnListarInfractores;
        private System.Windows.Forms.TextBox tbPatenteBuscar;
        private System.Windows.Forms.Button btnBuscarInfractor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbPatente;
        public System.Windows.Forms.TextBox tbVelocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton rbEsCivil;
        public System.Windows.Forms.RadioButton rbEsOficial;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

