using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoAeroclube.Serviços;

namespace GestaoAeroclube.Class
{
    internal class Instrutor:Piloto
    {
        public bool Associado { get; set; }
        

        public Instrutor(string nome, string CHT, int horasVoo, bool associado)
            :base(nome, CHT, horasVoo)
        {
            Associado=associado;
        }

        public override string ToString()
        {
            string info = Nome+','+CHT+','+HorasVoo+','+Associado.ToString();
            return info;
        }
    }
}
