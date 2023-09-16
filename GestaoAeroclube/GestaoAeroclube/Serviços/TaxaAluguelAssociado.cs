using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Serviços
{
    internal class TaxaAluguelAssociado:ITaxaAluguel
    {
        public double Taxar(int horas)
        {
            int valor_hora;
            if (horas >10)
            {
                valor_hora = 600;
            }
            else
            {
                valor_hora = 750;
            }

            return valor_hora*horas;
        }
    }
}
