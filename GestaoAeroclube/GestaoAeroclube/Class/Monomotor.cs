using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    internal class Monomotor :Aeronave
    {
        public string motor { get; set; }

        public Monomotor(string motor, string fabricante, string modelo, string matricula, int horasVoo, DateTime ultimaManutencao) 
            : base(fabricante, modelo, matricula, horasVoo, ultimaManutencao)
        {
            this.motor = motor;
        }

        public override string ToString()
        {
            string info = fabricante.ToString()+","+modelo.ToString()+","+matricula.ToString()+","+horasVoo.ToString()+","+motor.ToString()+","+ultimaManutencao.ToString()+","+"Monomotor";
            return info;
        }

        public override string PrintInfo()
        {
            return "Aeronave:\n"+"Fabricante: "+fabricante.ToString()+"\n"
                +"Modelo: "+modelo.ToString()+"\n"
                +"Matricula: "+matricula.ToString()+"\n"
                +"Horas voo:"+horasVoo.ToString()+"\n"
                +"Motor:"+motor.ToString()+"\n"
                +"Ultima manutenção: "+ultimaManutencao.ToString()+"\n"
                +"Categoria: Monomotor";
            
        }
    }
}
