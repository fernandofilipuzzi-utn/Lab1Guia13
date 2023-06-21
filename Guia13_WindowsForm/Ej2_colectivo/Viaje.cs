using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_colectivo
{
    class Viaje
    {
        public int Ocupados { get; set; }
        public int PasajerosTrasnportados { get; private set; }

        public int Asientos { get; private set; }

        public int demoraEnM;
        public int HDemora 
        { 
            get
            {
                return demoraEnM / 60;
            }
        }
        public int MDemora
        {
            get
            {
                return demoraEnM % 60;
            }
        }

        public int CantParadas { get; private set; }

        int hInicio;
        int mInicio;

        int hLLegada;
        int mLLegada;
        private int DuracionViajeEnM 
        {
            get 
            {
                return hLLegada * 60 + mLLegada- (hInicio * 60 + mInicio);
            }
        }
        public int HDuracionViaje
        {
            get 
            {
                return DuracionViajeEnM / 60;
            }
        }
        public int MDuracionViaje
        {
            get
            {
                return DuracionViajeEnM % 60;
            }
        }

        public Viaje(int hInicio, int mInicio, int asientos)
        {
            this.hInicio = hInicio;
            this.mInicio = mInicio;
            this.Asientos = asientos;
        }

        public void RealizarParada(int hLLegadaParada,int mLLegadaParada,
                                    int hSalidaParada, int mSalidaParada, 
                                    int ascienden,int descienden)
        { 
            int LLegadaEnM= 30*hLLegadaParada+mLLegadaParada;
            int SalidaEnM = 30 * hSalidaParada + mSalidaParada;

           

            demoraEnM += SalidaEnM - LLegadaEnM;
            CantParadas++;
            
            Ocupados += ascienden - descienden;

            PasajerosTrasnportados += ascienden;
        }

        public void Finalizar(int hLLegada,int mLLegada)
        {
            this.hLLegada = hLLegada;
            this.mLLegada = mLLegada;
        }
    }
}
