
namespace Ej2_colectivo
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tbAsientos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMInicio = new System.Windows.Forms.TextBox();
            this.tbHInicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbParadas = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescienden = new System.Windows.Forms.TextBox();
            this.tbAscienden = new System.Windows.Forms.TextBox();
            this.tbMSalidaParada = new System.Windows.Forms.TextBox();
            this.tbHLLegadaParada = new System.Windows.Forms.TextBox();
            this.tbHSalidaParada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMLLegadaParada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresadaParada = new System.Windows.Forms.Button();
            this.gbFinalizar = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMLLegada = new System.Windows.Forms.TextBox();
            this.tbHLLegada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbInicio.SuspendLayout();
            this.gbParadas.SuspendLayout();
            this.gbFinalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.label5);
            this.gbInicio.Controls.Add(this.btnIniciar);
            this.gbInicio.Controls.Add(this.tbAsientos);
            this.gbInicio.Controls.Add(this.label2);
            this.gbInicio.Controls.Add(this.tbMInicio);
            this.gbInicio.Controls.Add(this.tbHInicio);
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.Location = new System.Drawing.Point(3, 12);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(245, 211);
            this.gbInicio.TabIndex = 0;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio Recorrido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(81, 179);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // tbAsientos
            // 
            this.tbAsientos.Location = new System.Drawing.Point(143, 45);
            this.tbAsientos.Name = "tbAsientos";
            this.tbAsientos.Size = new System.Drawing.Size(37, 20);
            this.tbAsientos.TabIndex = 3;
            this.tbAsientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asientos";
            // 
            // tbMInicio
            // 
            this.tbMInicio.Location = new System.Drawing.Point(202, 19);
            this.tbMInicio.Name = "tbMInicio";
            this.tbMInicio.Size = new System.Drawing.Size(37, 20);
            this.tbMInicio.TabIndex = 1;
            this.tbMInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbHInicio
            // 
            this.tbHInicio.Location = new System.Drawing.Point(143, 19);
            this.tbHInicio.Name = "tbHInicio";
            this.tbHInicio.Size = new System.Drawing.Size(37, 20);
            this.tbHInicio.TabIndex = 0;
            this.tbHInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Partida (HH:MM)";
            // 
            // gbParadas
            // 
            this.gbParadas.Controls.Add(this.label10);
            this.gbParadas.Controls.Add(this.label9);
            this.gbParadas.Controls.Add(this.label7);
            this.gbParadas.Controls.Add(this.label6);
            this.gbParadas.Controls.Add(this.tbDescienden);
            this.gbParadas.Controls.Add(this.tbAscienden);
            this.gbParadas.Controls.Add(this.tbMSalidaParada);
            this.gbParadas.Controls.Add(this.tbHLLegadaParada);
            this.gbParadas.Controls.Add(this.tbHSalidaParada);
            this.gbParadas.Controls.Add(this.label4);
            this.gbParadas.Controls.Add(this.tbMLLegadaParada);
            this.gbParadas.Controls.Add(this.label3);
            this.gbParadas.Controls.Add(this.btnIngresadaParada);
            this.gbParadas.Enabled = false;
            this.gbParadas.Location = new System.Drawing.Point(254, 12);
            this.gbParadas.Name = "gbParadas";
            this.gbParadas.Size = new System.Drawing.Size(217, 211);
            this.gbParadas.TabIndex = 1;
            this.gbParadas.TabStop = false;
            this.gbParadas.Text = "Paradas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Descienden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ascienden";
            // 
            // tbDescienden
            // 
            this.tbDescienden.Location = new System.Drawing.Point(111, 118);
            this.tbDescienden.Name = "tbDescienden";
            this.tbDescienden.Size = new System.Drawing.Size(37, 20);
            this.tbDescienden.TabIndex = 9;
            this.tbDescienden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbAscienden
            // 
            this.tbAscienden.Location = new System.Drawing.Point(111, 93);
            this.tbAscienden.Name = "tbAscienden";
            this.tbAscienden.Size = new System.Drawing.Size(37, 20);
            this.tbAscienden.TabIndex = 5;
            this.tbAscienden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbMSalidaParada
            // 
            this.tbMSalidaParada.Location = new System.Drawing.Point(170, 50);
            this.tbMSalidaParada.Name = "tbMSalidaParada";
            this.tbMSalidaParada.Size = new System.Drawing.Size(37, 20);
            this.tbMSalidaParada.TabIndex = 8;
            this.tbMSalidaParada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbHLLegadaParada
            // 
            this.tbHLLegadaParada.Location = new System.Drawing.Point(111, 19);
            this.tbHLLegadaParada.Name = "tbHLLegadaParada";
            this.tbHLLegadaParada.Size = new System.Drawing.Size(37, 20);
            this.tbHLLegadaParada.TabIndex = 5;
            this.tbHLLegadaParada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbHSalidaParada
            // 
            this.tbHSalidaParada.Location = new System.Drawing.Point(111, 50);
            this.tbHSalidaParada.Name = "tbHSalidaParada";
            this.tbHSalidaParada.Size = new System.Drawing.Size(37, 20);
            this.tbHSalidaParada.TabIndex = 7;
            this.tbHSalidaParada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salida (HH:MM)";
            // 
            // tbMLLegadaParada
            // 
            this.tbMLLegadaParada.Location = new System.Drawing.Point(170, 19);
            this.tbMLLegadaParada.Name = "tbMLLegadaParada";
            this.tbMLLegadaParada.Size = new System.Drawing.Size(37, 20);
            this.tbMLLegadaParada.TabIndex = 5;
            this.tbMLLegadaParada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LLegada (HH:MM)";
            // 
            // btnIngresadaParada
            // 
            this.btnIngresadaParada.Location = new System.Drawing.Point(49, 179);
            this.btnIngresadaParada.Name = "btnIngresadaParada";
            this.btnIngresadaParada.Size = new System.Drawing.Size(115, 23);
            this.btnIngresadaParada.TabIndex = 5;
            this.btnIngresadaParada.Text = "Ingresada Parada";
            this.btnIngresadaParada.UseVisualStyleBackColor = true;
            this.btnIngresadaParada.Click += new System.EventHandler(this.btnIngresadaParada_Click);
            // 
            // gbFinalizar
            // 
            this.gbFinalizar.Controls.Add(this.label11);
            this.gbFinalizar.Controls.Add(this.tbMLLegada);
            this.gbFinalizar.Controls.Add(this.tbHLLegada);
            this.gbFinalizar.Controls.Add(this.label8);
            this.gbFinalizar.Controls.Add(this.ltbResultados);
            this.gbFinalizar.Controls.Add(this.btnFinalizar);
            this.gbFinalizar.Enabled = false;
            this.gbFinalizar.Location = new System.Drawing.Point(477, 12);
            this.gbFinalizar.Name = "gbFinalizar";
            this.gbFinalizar.Size = new System.Drawing.Size(278, 211);
            this.gbFinalizar.TabIndex = 1;
            this.gbFinalizar.TabStop = false;
            this.gbFinalizar.Text = "Finalizar Parada";
            this.gbFinalizar.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = ":";
            // 
            // tbMLLegada
            // 
            this.tbMLLegada.Location = new System.Drawing.Point(220, 19);
            this.tbMLLegada.Name = "tbMLLegada";
            this.tbMLLegada.Size = new System.Drawing.Size(37, 20);
            this.tbMLLegada.TabIndex = 11;
            this.tbMLLegada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbHLLegada
            // 
            this.tbHLLegada.Location = new System.Drawing.Point(161, 19);
            this.tbHLLegada.Name = "tbHLLegada";
            this.tbHLLegada.Size = new System.Drawing.Size(37, 20);
            this.tbHLLegada.TabIndex = 12;
            this.tbHLLegada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hora de Finalización (HH:MM)";
            // 
            // ltbResultados
            // 
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.Location = new System.Drawing.Point(6, 81);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(266, 121);
            this.ltbResultados.TabIndex = 7;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(170, 48);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 226);
            this.Controls.Add(this.gbFinalizar);
            this.Controls.Add(this.gbParadas);
            this.Controls.Add(this.gbInicio);
            this.Name = "FormPrincipal";
            this.Text = "Empresa de viajes";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            this.gbParadas.ResumeLayout(false);
            this.gbParadas.PerformLayout();
            this.gbFinalizar.ResumeLayout(false);
            this.gbFinalizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tbAsientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMInicio;
        private System.Windows.Forms.TextBox tbHInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbParadas;
        private System.Windows.Forms.TextBox tbMSalidaParada;
        private System.Windows.Forms.TextBox tbHSalidaParada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMLLegadaParada;
        private System.Windows.Forms.TextBox tbHLLegadaParada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresadaParada;
        private System.Windows.Forms.GroupBox gbFinalizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescienden;
        private System.Windows.Forms.TextBox tbAscienden;
        private System.Windows.Forms.TextBox tbMLLegada;
        private System.Windows.Forms.TextBox tbHLLegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ltbResultados;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

