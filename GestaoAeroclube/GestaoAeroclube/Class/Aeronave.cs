using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    abstract class Aeronave
    {
        public string fabricante { get; set; }
        public string modelo { get; set; }
        public string matricula { get; set; }
        public int horasVoo { get; set; }
        public DateTime ultimaManutencao { get; set; }


        public Aeronave(string fabricante, string modelo, string matricula, int horasVoo, DateTime ultimaManutencao)
        {
            this.fabricante=fabricante;
            this.modelo=modelo;
            this.matricula=matricula;
            this.horasVoo=horasVoo;
            this.ultimaManutencao=ultimaManutencao;
        }

        virtual public string PrintInfo() { return null; }

        
    }
}
