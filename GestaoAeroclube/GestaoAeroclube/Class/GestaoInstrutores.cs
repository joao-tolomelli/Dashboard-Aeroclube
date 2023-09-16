using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoAeroclube.Exceptions;

namespace GestaoAeroclube.Class
{
    internal class GestaoInstrutores : GestaoPilotos
    {
        public GestaoInstrutores(List<Piloto> pilotos) : base(pilotos)
        {
        }

        public override void Adicionar(string nome, string CHT, int horasVoo, bool Asssociado)
        {
            if (horasVoo<=0)
            {
                throw new ExcecaoNumeroIncoerente("Numero de horas voo incoerente");
            }
            Instrutor instrutor = new Instrutor(nome, CHT, horasVoo, Asssociado);   
            pilotos.Add(instrutor);
        }

        public override void AtualizarDoc(string caminho)
        {
            string info = "";
            foreach (Piloto piloto in pilotos)
            {
                info = info+piloto.ToString()+"\n";
            }
            File.WriteAllText(caminho, info);
        }

        public override void Remover(string CHT)
        {
            Piloto instrutor = pilotos.Find(x => x.CHT==CHT);
            if (instrutor==null)
            {
                throw new ExcecaoCHTInexistente("O CHT inserido não está cadastrado");
            }
            pilotos.Remove(instrutor);
        }
        public override void ReceberDados(string caminho)
        {
            StreamReader doc = new StreamReader(caminho);
            string linha;
            string[] celula;

            while ((linha = doc.ReadLine()) != null)
            {
                celula = linha.Split(',');
                Instrutor instrutor = new Instrutor(celula[0], celula[1], int.Parse(celula[2]), bool.Parse(celula[3]));
                pilotos.Add(instrutor);
                
            }

            doc.Close();
        }

        public override Piloto EncontrarPiloto(string CHT)
        {
            Piloto instrutor = pilotos.Find(x => x.CHT==CHT);
            if (instrutor==null)
            {
                throw new ExcecaoCHTInexistente("O CHT inserido não está cadastrado");
            }
            return instrutor;
        }
    }
}
