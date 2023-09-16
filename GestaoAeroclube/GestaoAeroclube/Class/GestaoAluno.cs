using GestaoAeroclube.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    internal class GestaoAluno:GestaoPilotos
    {

        public GestaoAluno(List<Piloto> pilotos) : base(pilotos)
        {
        }

        public override void Adicionar(string nome, string CHT, int horasVoo, bool Pendencia)
        {
            if (horasVoo<=0)
            {
                throw new ExcecaoNumeroIncoerente("Numero de horas voo incoerente");
            }
            Aluno aluno = new Aluno(nome, CHT, horasVoo, Pendencia);
            pilotos.Add(aluno);
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
            Piloto aluno = pilotos.Find(x => x.CHT==CHT);
            if (aluno==null)
            {
                throw new ExcecaoCHTInexistente("O CHT inserido não está cadastrado");
            }
            pilotos.Remove(aluno);
        }
        public override void ReceberDados(string caminho)
        {
            StreamReader doc = new StreamReader(caminho);
            string linha;
            string[] celula;

            while ((linha = doc.ReadLine()) != null)
            {
                celula = linha.Split(',');
                Aluno aluno = new Aluno(celula[0], celula[1], int.Parse(celula[2]), bool.Parse(celula[3]));
                pilotos.Add(aluno);

            }

            doc.Close();
        }

        public override Piloto EncontrarPiloto(string CHT)
        {
            Piloto aluno = pilotos.Find(x => x.CHT==CHT);
            if (aluno==null)
            {
                throw new ExcecaoCHTInexistente("O CHT inserido não está cadastrado");
            }
            return aluno;
        }
    }
}
