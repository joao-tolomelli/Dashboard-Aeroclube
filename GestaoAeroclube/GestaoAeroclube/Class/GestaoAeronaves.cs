using GestaoAeroclube.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    internal class GestaoAeronaves
    {
        public List<Aeronave> aeronaves;

        public GestaoAeronaves(List<Aeronave> aeronaves)
        {
            this.aeronaves=aeronaves;
        }

        public void Adicionar(string fabricante, string modelo,string matricula, int horasVoo,string motor, DateTime ultimaManutencao,string categoria) 
        {
            if (horasVoo<=0)
            {
                throw new ExcecaoNumeroIncoerente("Numero de horas voo incoerente");
            }

            if (categoria!="Monomotor"&&categoria!="Bimotor")
            {
                throw new ExcecaoCategoriaInexistente("A categoria selecionada não existe");
            }

            if (categoria=="Monomotor"){
                Aeronave aeronave = new Monomotor(motor, fabricante, modelo, matricula, horasVoo, ultimaManutencao);
                aeronaves.Add(aeronave);
            }
            else
            {
                Aeronave aeronave = new Bimotor(motor, fabricante, modelo, matricula, horasVoo, ultimaManutencao);
                aeronaves.Add(aeronave);
            }
            
        }
        public void Remover(string matricula) 
        {
            Aeronave aeronave = aeronaves.Find(x => x.matricula==matricula);
            if (aeronave==null)
            {
                throw new ExcecaoMatriculaInexistente("A matrícula inserida não está cadastrada");
            }
            aeronaves.Remove(aeronave);
        }
        public void ReceberDados(string caminho) 
        {
            StreamReader doc = new StreamReader(caminho);
            string linha;
            string[] celula;

            while ((linha = doc.ReadLine()) != null)
            {
                celula = linha.Split(',');
                if (celula[6]=="Monomotor")
                {
                    Aeronave aeronave = new Monomotor(celula[4], celula[0], celula[1], celula[2], int.Parse(celula[3]),new DateTime());
                    aeronaves.Add(aeronave);
                }
                else
                {
                    Aeronave aeronave = new Bimotor(celula[4], celula[0], celula[1], celula[2], int.Parse(celula[3]), new DateTime());
                    aeronaves.Add(aeronave);
                }

            }

            doc.Close();
        }
        public void AtualizarDoc(string caminho) 
        {
            string info = "";
            foreach (Aeronave aeronave in aeronaves)
            {
                info = info+aeronave.ToString()+"\n";
            }
            File.WriteAllText(caminho, info);
        }

        public Aeronave EncontrarAeronave(string matricula)
        {
            Aeronave aeronave = aeronaves.Find(x => x.matricula==matricula);
            if (aeronave==null)
            {
                throw new ExcecaoMatriculaInexistente("A matrícula inserida não está cadastrada");
            }
            return aeronave;
        }

    }
}
