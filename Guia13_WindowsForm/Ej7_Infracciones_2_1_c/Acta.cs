using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7_Infracciones_2_1_c
{
    class Acta
    {
        public double BaseUsada { get; private set; }
        public int Dni { get; private set; }
        public string Nombre { get; private set; }
        public double TipoVehiculo { get; private set; }
        public double SubTotal { get; private set; }
        public double AjusteTipoVehiculo { get; private set; }
        public double SubTotalAjustado { get; private set; }
        public bool PagoEnLugar { get; private set; }
        public double DescuentoPago { get; private set; }
        public double TotalAPagar { get; private set; }

        Infraccion[] infracciones;
        int cantInfracciones;

        public Acta(int dni, string nombre, int tipoVehiculo,  double baseUsada)
        {
            Dni = dni;
            Nombre = nombre;
            TipoVehiculo = tipoVehiculo;
            BaseUsada = baseUsada;

            infracciones = new Infraccion[100];
            cantInfracciones = 0;

        }

        public void Agregar(Infraccion infraccion)
        {
            infracciones[cantInfracciones++] = infraccion;

            SubTotal += infraccion.CalcularMontoInfraccion(BaseUsada);
        }

        public void Finalizar(bool pagaEnElLugar)
        {
            PagoEnLugar = pagaEnElLugar;

            AjusteTipoVehiculo = SubTotal * CalcularReajuste() / 100d;
            
            SubTotalAjustado = SubTotal + AjusteTipoVehiculo;

            if (PagoEnLugar==true) 
                DescuentoPago = SubTotalAjustado * 50 / 100d;

            TotalAPagar = SubTotalAjustado - DescuentoPago;
        }

        public double CalcularReajuste()
        {
            double porc = 0;
            switch (TipoVehiculo)
            {
                case 1: porc = 1; break;
                case 2: porc = 50; break;
                case 3: porc = 200; break;
            }
            return porc;
        }

        //lo tengo que modificar
        public string[] VerTicket(out int cant)
        {
            string[] ticket = new string[100];

            ticket[0] = $"  {Dni,-10}{Nombre,40}";
            ticket[1] = $"  {"Tipo vehículo: "}{TipoVehiculo} ejes - Base 1L/{BaseUsada:f2} $ar";

            ticket[2] = "------------------------------";

            for (int n = 0; n < cantInfracciones; n++)
            {
                Infraccion selected = infracciones[n];
                ticket[3+n] = $"  {selected.Descripcion.ToString() + "(" + selected.Uds.ToString() + ")",-50}{selected.CalcularMontoInfraccion(BaseUsada),10:f2}";
            }
            ticket[3+cantInfracciones] = "------------------------------";

            ticket[4 + cantInfracciones] = $"  {"     Subtotal",-50}{SubTotal,10:f2}\n";
            ticket[5 + cantInfracciones] = $"  {"Por tipo de vehículo:(50%)",-50}{AjusteTipoVehiculo,10:f2}";
            ticket[6 + cantInfracciones] = $"  {"     subtotal      $ar",-50}{SubTotalAjustado,10:f2}";
            ticket[7 + cantInfracciones] = $"  {"Pago en efectivo (-50%)",-50}{DescuentoPago,10:f2}";
            ticket[8 + cantInfracciones] = $"  {"     Total de la multa  $ar",-50}{TotalAPagar,10:f2}";
            
            cant = 8 + cantInfracciones;

            return ticket;
        }
    }
}
