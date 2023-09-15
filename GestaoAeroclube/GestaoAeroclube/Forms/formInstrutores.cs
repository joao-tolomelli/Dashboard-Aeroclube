using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoAeroclube.Class;
using GestaoAeroclube.Exceptions;

namespace GestaoAeroclube.Forms
{
    public partial class formInstrutores : Form
    {
        public formInstrutores()
        {
            InitializeComponent();
        }

        private void formInstrutores_Load(object sender, EventArgs e)
        {
            StreamReader doc = new StreamReader(@"..\..\Docs\Tabelas\Instrutores.txt");
            string linha;
            string[] celula;

            while ((linha = doc.ReadLine()) != null)
            {
                celula = linha.Split(',');
                tabelaAeronaves.Rows.Add(celula);
            }

            doc.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Piloto> pilotos = new List<Piloto>();
                GestaoInstrutores gestaoInstrutores = new GestaoInstrutores(pilotos);
                bool associado;
                if (tbAssociado.Text=="sim")
                {
                    associado = true;
                }
                else
                {
                    associado = false;
                }

                gestaoInstrutores.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Instrutores.txt");
                gestaoInstrutores.Adicionar(tbNome.Text, tbCHT.Text, int.Parse(tbHorasVoo.Text), associado);
                gestaoInstrutores.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Instrutores.txt");

            }
            catch (ExcecaoNumeroIncoerente excecaoNumeroIncoerente)
            {
                MessageBox.Show(excecaoNumeroIncoerente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Complete todos os campos", "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                List<Piloto> pilotos = new List<Piloto>();
                GestaoInstrutores gestaoInstrutores = new GestaoInstrutores(pilotos);
                gestaoInstrutores.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Instrutores.txt");
                gestaoInstrutores.Remover(tbCHTRemove.Text);
                gestaoInstrutores.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Instrutores.txt");

            }
            catch (FormatException)
            {
                MessageBox.Show("Complete o campo 'matricula' para remover", "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ExcecaoCHTInexistente excecaoCHTInexistente)
            {
                MessageBox.Show(excecaoCHTInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Piloto> pilotos = new List<Piloto>();
                GestaoInstrutores gestaoInstrutores = new GestaoInstrutores(pilotos);
                bool associado;
                if (tbAssociado.Text=="sim")
                {
                    associado = true;
                }
                else
                {
                    associado = false;
                }
                gestaoInstrutores.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Instrutores.txt");
                gestaoInstrutores.Remover(tbCHT.Text);
                gestaoInstrutores.Adicionar(tbNome.Text, tbCHT.Text, int.Parse(tbHorasVoo.Text), associado);
                gestaoInstrutores.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Instrutores.txt");

            }
            catch (FormatException)
            {
                MessageBox.Show("Complete o campo 'matricula' para remover", "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ExcecaoNumeroIncoerente excecaoNumeroIncoerente)
            {
                MessageBox.Show(excecaoNumeroIncoerente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcecaoCHTInexistente excecaoCHTInexistente)
            {
                MessageBox.Show(excecaoCHTInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
