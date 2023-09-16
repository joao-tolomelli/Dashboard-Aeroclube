using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    internal class Aluno:Piloto
    {
        public bool Pendencia { get; set; }

        public Aluno(string nome, string CHT, int horasVoo, bool Pendencia)
            :base(nome, CHT, horasVoo)
        {
            this.Pendencia=Pendencia;
        }

        public override string ToString()
        {
            string info = Nome+','+CHT+','+HorasVoo+','+Pendencia.ToString();
            return info;
        }
    }
}
