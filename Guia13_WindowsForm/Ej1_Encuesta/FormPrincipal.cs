using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1_Encuesta
{
    public partial class FormPrincipal : Form
    {
        ProcesoEncuestas proceso = new ProcesoEncuestas();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarEncuesta_Click(object sender, EventArgs e)
        {
            Encuesta nuevo = new Encuesta();

            nuevo.UsaBicicleta = chkUsaBicicleta.Checked;
            nuevo.UsaAuto = chkUsaAuto.Checked;
            nuevo.UsaTransportePublico = chkTranspPub.Checked;
            nuevo.DistanciaASuDestino = Convert.ToDouble(tbDistanciaASuDestino.Text);

            nuevo.Email =tbEmail.Text;

            bool puedeSerContactado = chkPuedeSerContactado.Checked;

            proceso.RegistrarEncuesta(nuevo, puedeSerContactado);

            #region limpiando el formulario
            chkUsaBicicleta.Checked = false;
            chkUsaAuto.Checked = false;
            chkTranspPub.Checked = false;
            tbDistanciaASuDestino.Clear();
            tbEmail.Clear();
            chkPuedeSerContactado.Checked = false;
            #endregion
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            ltbInforme.Items.Clear();

            ltbInforme.Items.Add("\t\t Informe de resultados");
            ltbInforme.Items.Add("");
            ltbInforme.Items.Add("Modo de transporte habitual");
            ltbInforme.Items.Add($"\t{"Bicicleta:",-20}  {proceso.PorcBicleta,10:f2}%");
            ltbInforme.Items.Add($"\t{"Automóvil:",-20}  {proceso.PorcAuto,10:f2}%");
            ltbInforme.Items.Add($"\t{"Transporte público:",-20}  {proceso.PorcTranspPublico,10:f2}%");
        }


        private void btnListado_Click(object sender, EventArgs e)
        {
            ltbInforme.Items.Clear();

            ltbInforme.Items.Add("\t\t Informe de encuestados contactables");
            ltbInforme.Items.Add("");

            proceso.OrdernarEncuestables();
            ltbInforme.Items.Add($"\t{"Email",-30} {"Distancia",10}");
            for (int n = 0; n < proceso.CantContactables; n++)
            {
                ltbInforme.Items.Add($"\t{proceso.VerContactable(n).Email,-30} {proceso.VerContactable(n).DistanciaASuDestino,10:f2}");
            }
        }

        private void chkPuedeSerContactado_CheckedChanged(object sender, EventArgs e)
        {
            tbEmail.Enabled = chkPuedeSerContactado.Checked;
        }

        private void tbDistanciaASuDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' ||
               char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
