using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAeroclube.Class
{
    abstract class GestaoPilotos
    {
        public List<Piloto> pilotos;

        protected GestaoPilotos(List<Piloto> pilotos)
        {
            this.pilotos=pilotos;
        }

        virtual public void Adicionar(string nome, string CHT,int horasVoo, bool Asssociado) { }
        virtual public void Remover(string CHT) { }
        virtual public void ReceberDados(string caminho) { }
        virtual public void AtualizarDoc(string caminho) { }
        virtual public Piloto EncontrarPiloto(string CHT) { return null; }

    }
}
