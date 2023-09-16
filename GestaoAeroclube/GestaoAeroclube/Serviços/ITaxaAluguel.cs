using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Serviços
{
    internal interface ITaxaAluguel
    {
        double Taxar(int horas);
    }
}
