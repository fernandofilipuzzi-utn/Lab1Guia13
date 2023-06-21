
namespace Ej1_Encuesta
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
            this.ltbInforme = new System.Windows.Forms.ListBox();
            this.btnInforme = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPuedeSerContactado = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDistanciaASuDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUsaBicicleta = new System.Windows.Forms.CheckBox();
            this.chkTranspPub = new System.Windows.Forms.CheckBox();
            this.chkUsaAuto = new System.Windows.Forms.CheckBox();
            this.btnAgregarEncuesta = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbInforme
            // 
            this.ltbInforme.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbInforme.FormattingEnabled = true;
            this.ltbInforme.ItemHeight = 18;
            this.ltbInforme.Location = new System.Drawing.Point(5, 26);
            this.ltbInforme.Name = "ltbInforme";
            this.ltbInforme.Size = new System.Drawing.Size(556, 238);
            this.ltbInforme.TabIndex = 14;
            // 
            // btnInforme
            // 
            this.btnInforme.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInforme.Location = new System.Drawing.Point(127, 270);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(91, 23);
            this.btnInforme.TabIndex = 13;
            this.btnInforme.Text = "Resultados";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnAgregarEncuesta);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 303);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ingreso de encuesta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chkPuedeSerContactado);
            this.groupBox3.Location = new System.Drawing.Point(6, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 71);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(116, 42);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(160, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // chkPuedeSerContactado
            // 
            this.chkPuedeSerContactado.AutoSize = true;
            this.chkPuedeSerContactado.Location = new System.Drawing.Point(116, 19);
            this.chkPuedeSerContactado.Name = "chkPuedeSerContactado";
            this.chkPuedeSerContactado.Size = new System.Drawing.Size(143, 17);
            this.chkPuedeSerContactado.TabIndex = 2;
            this.chkPuedeSerContactado.Text = "¿Puede ser contactado?";
            this.chkPuedeSerContactado.UseVisualStyleBackColor = true;
            this.chkPuedeSerContactado.CheckedChanged += new System.EventHandler(this.chkPuedeSerContactado_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDistanciaASuDestino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobre el destino al trabajo/estudio";
            // 
            // tbDistanciaASuDestino
            // 
            this.tbDistanciaASuDestino.Location = new System.Drawing.Point(120, 24);
            this.tbDistanciaASuDestino.Name = "tbDistanciaASuDestino";
            this.tbDistanciaASuDestino.Size = new System.Drawing.Size(87, 20);
            this.tbDistanciaASuDestino.TabIndex = 1;
            this.tbDistanciaASuDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDistanciaASuDestino_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia en (km)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUsaBicicleta);
            this.groupBox1.Controls.Add(this.chkTranspPub);
            this.groupBox1.Controls.Add(this.chkUsaAuto);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 108);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de transporte habitual";
            // 
            // chkUsaBicicleta
            // 
            this.chkUsaBicicleta.AutoSize = true;
            this.chkUsaBicicleta.Location = new System.Drawing.Point(115, 31);
            this.chkUsaBicicleta.Name = "chkUsaBicicleta";
            this.chkUsaBicicleta.Size = new System.Drawing.Size(92, 17);
            this.chkUsaBicicleta.TabIndex = 2;
            this.chkUsaBicicleta.Text = "¿Usa Bicleta?";
            this.chkUsaBicicleta.UseVisualStyleBackColor = true;
            // 
            // chkTranspPub
            // 
            this.chkTranspPub.AutoSize = true;
            this.chkTranspPub.Location = new System.Drawing.Point(115, 77);
            this.chkTranspPub.Name = "chkTranspPub";
            this.chkTranspPub.Size = new System.Drawing.Size(144, 17);
            this.chkTranspPub.TabIndex = 4;
            this.chkTranspPub.Text = "¿Usa transporte público?";
            this.chkTranspPub.UseVisualStyleBackColor = true;
            // 
            // chkUsaAuto
            // 
            this.chkUsaAuto.AutoSize = true;
            this.chkUsaAuto.Location = new System.Drawing.Point(115, 54);
            this.chkUsaAuto.Name = "chkUsaAuto";
            this.chkUsaAuto.Size = new System.Drawing.Size(105, 17);
            this.chkUsaAuto.TabIndex = 3;
            this.chkUsaAuto.Text = "¿Usa automóvil?";
            this.chkUsaAuto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEncuesta
            // 
            this.btnAgregarEncuesta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarEncuesta.Location = new System.Drawing.Point(121, 271);
            this.btnAgregarEncuesta.Name = "btnAgregarEncuesta";
            this.btnAgregarEncuesta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEncuesta.TabIndex = 13;
            this.btnAgregarEncuesta.Text = "Agregar";
            this.btnAgregarEncuesta.UseVisualStyleBackColor = true;
            this.btnAgregarEncuesta.Click += new System.EventHandler(this.btnAgregarEncuesta_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnListado);
            this.groupBox5.Controls.Add(this.btnInforme);
            this.groupBox5.Controls.Add(this.ltbInforme);
            this.groupBox5.Location = new System.Drawing.Point(329, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(567, 303);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informe";
            // 
            // btnListado
            // 
            this.btnListado.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnListado.Location = new System.Drawing.Point(345, 270);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(106, 23);
            this.btnListado.TabIndex = 15;
            this.btnListado.Text = "Contactos";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 320);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormPrincipal";
            this.Text = "Registro De Encuesta";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ltbInforme;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkPuedeSerContactado;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbDistanciaASuDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox chkUsaBicicleta;
        public System.Windows.Forms.CheckBox chkTranspPub;
        public System.Windows.Forms.CheckBox chkUsaAuto;
        private System.Windows.Forms.Button btnAgregarEncuesta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnListado;
    }
}

