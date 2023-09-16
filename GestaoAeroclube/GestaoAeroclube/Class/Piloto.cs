using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    abstract class Piloto
    {
        public string Nome { get; set; }
        public string CHT { get; set; }
        public int HorasVoo { get; set; }

        public Piloto(string nome, string CHT, int horasVoo)
        {
            Nome=nome;
            this.CHT=CHT;
            HorasVoo=horasVoo;
        }
    }
}
