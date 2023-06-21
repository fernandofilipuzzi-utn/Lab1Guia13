using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2_colectivo
{

    public partial class FormPrincipal : Form
    {
        Viaje viaje;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int hInicio = Convert.ToInt32(tbHInicio.Text);
            int mInicio = Convert.ToInt32(tbMInicio.Text);
            int asientos = Convert.ToInt32(tbAsientos.Text);

            #region verificando
            bool correctoh = hInicio >= 0 && hInicio <= 23;
            if (correctoh==false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctom = mInicio >= 0 && mInicio <= 59;
            if (correctom == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }
            #endregion

            if (correctoh && correctom)
            {
                viaje = new Viaje(hInicio, mInicio, asientos);
                
                #region limpiando controles
                btnFinalizar.Enabled = true;
                tbHLLegada.Enabled = true;
                tbMLLegada.Enabled = true;
                gbParadas.Enabled = true;
                gbFinalizar.Enabled = true;
                gbInicio.Enabled = false;
                #endregion
            }
        }

        private void btnIngresadaParada_Click(object sender, EventArgs e)
        {
            int hLLegadaParada = Convert.ToInt32(tbHLLegadaParada.Text);
            int mLLegadaParada = Convert.ToInt32(tbMLLegadaParada.Text);

            int hSalidaParada = Convert.ToInt32(tbHSalidaParada.Text);
            int mSalidaParada = Convert.ToInt32(tbMSalidaParada.Text);

            int ascienden = Convert.ToInt32(tbAscienden.Text);
            int descienden = Convert.ToInt32(tbDescienden.Text);

            #region verificando
            bool correctohLL = hLLegadaParada >= 0 && hLLegadaParada <= 23;
            if (correctohLL == false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctomLL = mLLegadaParada >= 0 && mLLegadaParada <= 59;
            if (correctomLL == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }

            bool correctohS = hSalidaParada >= 0 && hSalidaParada <= 23;
            if (correctohS == false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctomS = mSalidaParada >= 0 && mSalidaParada <= 59;
            if (correctomS == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }
            #endregion

            if (correctohLL && correctomLL && correctohS  && correctomS)
            {
                
                viaje.RealizarParada(hLLegadaParada, mLLegadaParada,
                                    hSalidaParada, mSalidaParada,
                                    ascienden, descienden);

                #region limpiando controles
                tbHLLegadaParada.Clear();
                tbMLLegadaParada.Clear();

                tbHSalidaParada.Clear();
                tbMSalidaParada.Clear();

                tbAscienden.Clear();
                tbDescienden.Clear();
                #endregion 
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int hLLegada = Convert.ToInt32(tbHLLegada.Text);
            int mLLegada = Convert.ToInt32(tbMLLegada.Text);

            #region verificando
            bool correctoh = hLLegada >= 0 && hLLegada <= 23;
            if (correctoh == false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctom = mLLegada >= 0 && mLLegada <= 59;
            if (correctom == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }
            #endregion

            if (correctoh && correctom)
            {
                viaje.Finalizar(hLLegada, mLLegada);

                #region informando resultados
                ltbResultados.Items.Clear();
                ltbResultados.Items.Add($"Cantidad de pasajeros transportados: {viaje.PasajerosTrasnportados}");
                ltbResultados.Items.Add($"Tiempo total de recorrido: {viaje.HDuracionViaje,00}:{viaje.MDuracionViaje,00}");
                ltbResultados.Items.Add($"Cantidad de paradas: {viaje.CantParadas}");
                ltbResultados.Items.Add($"Tiempo total de demora en las paradas: {viaje.HDemora,00}:{viaje.MDemora,00}");
                #endregion

                #region limpiando controles
                btnFinalizar.Enabled = false;
                tbHLLegada.Enabled = false;
                tbMLLegada.Enabled = false;
                gbParadas.Enabled = false;
                gbInicio.Enabled = true;
                #endregion
            }
        }

        private void tbPositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)  || char.IsControl(e.KeyChar))
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
