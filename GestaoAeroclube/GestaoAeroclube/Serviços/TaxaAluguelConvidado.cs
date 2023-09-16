using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Serviços
{
    internal class TaxaAluguelConvidado:ITaxaAluguel
    {
        public double Taxar(int horas)
        {
            int valor_hora;
            if (horas >10)
            {
                valor_hora = 700;
            }
            else
            {
                valor_hora = 850;
            }

            return valor_hora*horas;
        }
    }
}
