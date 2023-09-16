using GestaoAeroclube.Class;
using GestaoAeroclube.Exceptions;
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

namespace GestaoAeroclube.Forms
{
    public partial class formAlunos : Form
    {
        public formAlunos()
        {
            InitializeComponent();
        }

        private void formAlunos_Load(object sender, EventArgs e)
        {
            StreamReader doc = new StreamReader(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Alunos.txt");
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
                GestaoAluno gestaoAluno = new GestaoAluno(pilotos);
                bool pendencia;
                if (tbPendencia.Text=="Sim")
                {
                    pendencia = true;
                }
                else
                {
                    pendencia = false;
                }

                gestaoAluno.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Alunos.txt");
                gestaoAluno.Adicionar(tbNome.Text, tbCHT.Text, int.Parse(tbHorasVoo.Text), pendencia);
                gestaoAluno.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Alunos.txt");

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
                GestaoAluno gestaoAluno = new GestaoAluno(pilotos);
                gestaoAluno.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Alunos.txt");
                gestaoAluno.Remover(tbCHTRemove.Text);
                gestaoAluno.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Alunos.txt");

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
                GestaoAluno gestaoAluno = new GestaoAluno(pilotos);
                bool pendencia;
                if (tbPendencia.Text=="Sim")
                {
                    pendencia = true;
                }
                else
                {
                    pendencia = false;
                }
                gestaoAluno.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Alunos.txt");
                gestaoAluno.Remover(tbCHT.Text);
                gestaoAluno.Adicionar(tbNome.Text, tbCHT.Text, int.Parse(tbHorasVoo.Text), pendencia);
                gestaoAluno.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Alunos.txt");

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
