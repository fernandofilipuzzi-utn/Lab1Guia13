using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej6_SistemaPeaje
{
    public partial class FormPrincipal : Form
    {
        Peaje peaje = new Peaje();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresarDia_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\t\tIngrese el número de día y luego la cantidad de vehículos\n");
            int dia = cmbDias.SelectedIndex + 1;
            int cant = Convert.ToInt32( tbCantVehiculos.Text );

            if (dia > 0)
            {
                peaje.RegistrarResumenDia(dia, cant);
            }

            #region limpiando controles
            cmbDias.SelectedIndex = -1;
            tbCantVehiculos.Clear();
            #endregion
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            ltbInforme.Items.Clear();

            ltbInforme.Items.Add("\t\tDías que superaron el promedio.\n");


            ltbInforme.Items.Add($"Promedio: {peaje.PromCantVehiculosDelMes:f2}");
            string linea="Días: ";
            int cant;
            int[] dias = peaje.LosDiasMayoresAlPromedio(out cant);
            if (cant > 0)
            {
                for (int n = 0; n < cant; n++)
                {
                    linea+=$"{dias[n]}";
                    if (n < cant - 1)
                        linea+=", ";
                }
            }
            else
            {
                linea+="No hubo días que superaron al promedio ingresado";
            }
            ltbInforme.Items.Add(linea);
            
        }

        private void btnMayorPeriodo_Click(object sender, EventArgs e)
        {
            ltbInforme.Items.Clear();

            ltbInforme.Items.Add("\t\tPeriodo del mes con mayor movimiento: ");
            ltbInforme.Items.Add($"Periodo {peaje.TercioDelMesMayor()}");
        }
    }
}
