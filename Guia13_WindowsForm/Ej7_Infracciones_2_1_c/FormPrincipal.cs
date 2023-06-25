using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej7_Infracciones_2_1_c
{
    public partial class FormPrincipal : Form
    {
        Sistema sistema;
        Acta nuevo;

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciarSistema_Click(object sender, EventArgs e)
        {
            double baseMonetaria = Convert.ToDouble( tbBaseMonetaria.Text );
            sistema = new Sistema( baseMonetaria);

            for (int n = 0; n < sistema.CantInfracciones; n++)
            {
                Infraccion infr = sistema.VerInfraccion(n);
                cbmInfracciones.Items.Add( $"{infr.Descripcion} + ({infr.Codigo})" ); 
            }

            #region 
            gbInicioSistema.Enabled = false;
            gbActa.Enabled = true;
            #endregion
        }

        private void btnRegistrarActa_Click(object sender, EventArgs e)
        {
            nuevo.Finalizar(chbPagaLugar.Checked);
            sistema.Agregar(nuevo);

            #region impresion de ticket
            lbxInforme.Items.Clear();
            lbxInforme.Items.Add("Ticket:");
            lbxInforme.Items.Add("--------------------------------------------");

            int lineas;
            string[] ticket = nuevo.VerTicket(out lineas);
            for (int n = 0; n < lineas; n++)
            {
                lbxInforme.Items.Add(ticket[n]);
            }

            lbxInforme.Items.Add("--------------------------------------------");
            #endregion

            #region  limpiando controles
            nuevo = null;
            gbConductor.Enabled = true;
            tbDni.Clear();
            tbNombre.Clear();
            gbTipoInfraccion.Enabled = false;
            gbTipoVehiculo.Enabled = true;
            rbEje1.Checked = false;
            rbEje2.Checked = false;
            rbEje3.Checked = false;
            gbPago.Enabled = false;
            chbPagaLugar.Checked = false;
            #endregion
        }

        private void btnAgregarInfraccion_Click(object sender, EventArgs e)
        {
            if (cbmInfracciones.SelectedIndex != -1)
            {
                int idx = cbmInfracciones.SelectedIndex;
                Infraccion selected = sistema.VerInfraccion(idx);

                nuevo.Agregar(selected);

                cbmInfracciones.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item!");
            }
        }

        private void btnIniciarActa_Click(object sender, EventArgs e)
        {
            #region levantando datos de la ventana
            int dni = Convert.ToInt32(tbDni.Text);
            string nombre = tbNombre.Text;

            int tipo = 0;
            if (rbEje1.Checked == true)
                tipo = 1;
            else if (rbEje2.Checked == true)
                tipo = 2;
            else if (rbEje1.Checked == true)
                tipo = 3;
            #endregion

            nuevo = new Acta(dni, nombre, tipo, sistema.BaseMonetaria);

            #region  limpiando controles
            gbConductor.Enabled = false;
            gbTipoVehiculo.Enabled = false;
            gbTipoInfraccion.Enabled = true;
            gbPago.Enabled = true;
            #endregion
        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            lbxInforme.Items.Clear();

            lbxInforme.Items.Add("Resumen del día\n");
            lbxInforme.Items.Add("--------------------------------------------");
            lbxInforme.Items.Add(string.Format("Recaudación: {0:f2}", sistema.Recaudacion));
            lbxInforme.Items.Add("--------------------------------------------");
        }

        private void btnMayorMonto_Click(object sender, EventArgs e)
        {
            lbxInforme.Items.Clear();

            lbxInforme.Items.Add("Acta con mayor monto pagado\n");
            lbxInforme.Items.Add("--------------------------------------------");
            if (sistema.MayorMonto != null)
            {
                int lineas;
                string[] ticket = sistema.MayorMonto.VerTicket(out lineas);
                for (int n = 0; n < lineas; n++)
                {
                    lbxInforme.Items.Add(ticket[n]);
                }
            }
            else
            {
                lbxInforme.Items.Add("no hay registro de un acta");
            }
            lbxInforme.Items.Add("--------------------------------------------");           
        }

        private void btnListadoPagoEnLugar_Click(object sender, EventArgs e)
        {
            lbxInforme.Items.Clear();

            sistema.OrdenarActasPorMonto();

            lbxInforme.Items.Add("Listado de actas que han pagado en el lugar");
            lbxInforme.Items.Add("--------------------------------------------");
            int nro = 1;
            for (int m = 0; m < sistema.CantActasRevisar; m++)
            {
                lbxInforme.Items.Add($"------ticket nro:{nro++}------------------------------");

                int lineas;
                string[] ticket = sistema.MayorMonto.VerTicket(out lineas);
                for (int n = 0; n < lineas; n++)
                {
                    lbxInforme.Items.Add(ticket[n]);
                }

                lbxInforme.Items.Add("-----------------------------------------------------");
                lbxInforme.Items.Add("");
            }
        }
    }
}
