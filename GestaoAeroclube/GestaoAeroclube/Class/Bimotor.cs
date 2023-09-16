using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    internal class Bimotor : Aeronave
    {
        public string motores { get; set; }

        public Bimotor(string motores, string fabricante, string modelo, string matricula, int horasVoo, DateTime ultimaManutencao)
            : base(fabricante, modelo, matricula, horasVoo, ultimaManutencao)
        {
            this.motores = motores;
        }

        public override string ToString()
        {
            string info = fabricante.ToString()+","+modelo.ToString()+","+matricula.ToString()+","+horasVoo.ToString()+","+motores.ToString()+","+ultimaManutencao.ToString()+","+"Bimotor";
            return info;
        }
        public override string PrintInfo()
        {
            return "Aeronave:\n"+"Fabricante: "+fabricante.ToString()+"\n"
                +"Modelo: "+modelo.ToString()+"\n"
                +"Matricula: "+matricula.ToString()+"\n"
                +"Horas voo:"+horasVoo.ToString()+"\n"
                +"Motor:"+motores.ToString()+"\n"
                +"Ultima manutenção: "+ultimaManutencao.ToString()+"\n"
                +"Categoria: Bimotor";

        }
    }
}
