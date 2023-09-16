using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Exceptions
{
    internal class ExcecaoCHTInexistente:ApplicationException
    {
        public ExcecaoCHTInexistente(string message) : base(message)
        {

        }
    }
}
