using GestaoAeroclube.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoAeroclube.Exceptions;

namespace GestaoAeroclube.Class
{
    internal class GestaoAluguel
    {
        public Instrutor instrutor { get; set; }
        public Aeronave aeronave { get; set; }
        private ITaxaAluguel taxaAluguel;

        public GestaoAluguel(Instrutor instrutor, Aeronave aeronave, ITaxaAluguel taxaAluguel)
        {
            this.instrutor=instrutor;
            this.aeronave=aeronave;
            this.taxaAluguel=taxaAluguel;
        }

        public double CalcularAluguel(int horas_totais)
        {
            if (horas_totais <= 0)
            {
                throw new ExcecaoNumeroIncoerente("Valor de horas incoerente");
            }
            double valor_total;
            double multiplicador=0;

            if (aeronave.GetType()==typeof(Monomotor))
            {
                multiplicador = 1;
            }
            else if (aeronave.GetType()==typeof(Bimotor))
            {
                multiplicador = 2;
            }

            valor_total = multiplicador*taxaAluguel.Taxar(horas_totais);
            return valor_total;
        }

    }
}
