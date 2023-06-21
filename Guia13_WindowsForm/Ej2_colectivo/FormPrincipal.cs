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

            bool correctoh = hInicio >= 0 && hInicio <= 23;
            if (correctoh==false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctom = mInicio >= 0 && mInicio <= 23;
            if (correctom == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }

            if (correctoh && correctom)
            {
                viaje = new Viaje(hInicio, mInicio, asientos);

                gbParadas.Enabled = true;
                gbFinalizar.Enabled = true;
                gbInicio.Enabled = false;
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


            bool duracionValida =( (hSalidaParada * 60 + mSalidaParada) - (hLLegadaParada * 60 + mLLegadaParada))>0;
            if (duracionValida ==false)
            {
                MessageBox.Show("El tiempo de partida debe ser mayor o igual al de llegada");
            }

            bool ocupacionValida = (viaje.Ocupados + ascienden - descienden)>=0;
            if(ocupacionValida==false)
            {
                MessageBox.Show("Cantidad de asientos incorrecta!");
            }
        
            if (ocupacionValida && duracionValida)
            {
                
                viaje.RealizarParada(hLLegadaParada, mLLegadaParada,
                                    hSalidaParada, mSalidaParada,
                                    ascienden, descienden);

                tbHLLegadaParada.Clear();
                tbMLLegadaParada.Clear();

                tbHSalidaParada.Clear();
                tbMSalidaParada.Clear();

                tbAscienden.Clear();
                tbDescienden.Clear();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int hLLegada = Convert.ToInt32(tbHLLegada.Text);
            int mLLegada = Convert.ToInt32(tbMLLegada.Text);

            viaje.Finalizar(hLLegada, mLLegada);

            ltbResultados.Items.Clear();

            ltbResultados.Items.Add($"Cantidad de pasajeros transportados: {viaje.PasajerosTrasnportados}");
            ltbResultados.Items.Add($"Tiempo total de recorrido: {viaje.HDuracionViaje,00}:{viaje.MDuracionViaje,00}");
            ltbResultados.Items.Add($"Cantidad de paradas: {viaje.CantParadas}");
            ltbResultados.Items.Add($"Tiempo total de demora en las paradas: {viaje.HDemora,00}:{viaje.MDemora,00}");

            gbInicio.Enabled = true;
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
