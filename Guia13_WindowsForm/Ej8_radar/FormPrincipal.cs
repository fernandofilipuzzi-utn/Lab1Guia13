using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej8_radar
{
    public partial class FormPrincipal : Form
    {
        ControlRadar control = new ControlRadar();

        public FormPrincipal()
        {
            InitializeComponent();

            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            #region pre inicialización inicialización
            control.AgregarControl("OXD456", 30, false);
            control.AgregarControl("OXD457", 30, false);
            control.AgregarControl("OXD110", 30, false);
            control.AgregarControl("OXD477", 120, false);
            control.AgregarControl("OXD557", 100, false);
            btnListarInfractores.PerformClick();
            #endregion
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            string patente = tbPatente.Text;
            double velocidad = Convert.ToDouble(tbVelocidad.Text);
            bool esOficial = rbEsOficial.Checked;
            control.AgregarControl(patente, velocidad, esOficial);

            #region limpieza de controles
            tbPatente.Clear();
            tbVelocidad.Clear();
            rbEsOficial.Checked = false;
            rbEsCivil.Checked = false;
            #endregion
        }

        private void btnBuscarInfractor_Click(object sender, EventArgs e)
        {
            string patente = tbPatenteBuscar.Text;

            control.Ordenar();
            Vehiculo controlado=control.BuscarPorPatente(patente);
            
            lbtInforme.Items.Clear();

            if(controlado!=null)
                lbtInforme.Items.Add($"{controlado.Patente}");
            else
                lbtInforme.Items.Add($"{patente} no encontrado.");
        }

        private void btnListarInfractores_Click(object sender, EventArgs e)
        {
            lbtInforme.Items.Clear();

            for(int n=0;n<control.CantidadVehiculo;n++)
                lbtInforme.Items.Add($"{control.VerVehiculosInfractores(n).Patente}");
        }
        
    }
}
