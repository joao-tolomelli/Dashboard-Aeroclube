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
    public partial class formAeronaves : Form
    {

        public formAeronaves()
        {
            InitializeComponent();
        }

        private void formAeronaves_Load(object sender, EventArgs e)
        {
            StreamReader doc = new StreamReader(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
            string linha;
            string[] celula;
            
            while((linha = doc.ReadLine()) != null)
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
                List<Aeronave> aeronaves = new List<Aeronave>();
                GestaoAeronaves gestaoAeronaves = new GestaoAeronaves(aeronaves);
                gestaoAeronaves.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
                gestaoAeronaves.Adicionar(tbFabricante.Text, tbModelo.Text, tbMatricula.Text, int.Parse(tbHorasVoo.Text), tbMotor.Text, dtManutencao.Value.ToUniversalTime(), tbCategoriaMotor.Text);
                gestaoAeronaves.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
            }
            catch (ExcecaoNumeroIncoerente excecaoNumeroIncoerente)
            {
                MessageBox.Show(excecaoNumeroIncoerente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcecaoCategoriaInexistente excecaoCategoriaInexistente)
            {
                MessageBox.Show(excecaoCategoriaInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                List<Aeronave> aeronaves = new List<Aeronave>();
                GestaoAeronaves gestaoAeronaves = new GestaoAeronaves(aeronaves);
                gestaoAeronaves.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
                gestaoAeronaves.Remover(tbMatricula.Text);
                gestaoAeronaves.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
            }
            catch (FormatException)
            {
                MessageBox.Show("Complete o campo 'matricula' para remover", "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(ExcecaoMatriculaInexistente excecaoMatriculaInexistente)
            {
                MessageBox.Show(excecaoMatriculaInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Aeronave> aeronaves = new List<Aeronave>();
                GestaoAeronaves gestaoAeronaves = new GestaoAeronaves(aeronaves);
                gestaoAeronaves.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
                gestaoAeronaves.Remover(tbMatricula.Text);
                gestaoAeronaves.Adicionar(tbFabricante.Text, tbModelo.Text, tbMatricula.Text, int.Parse(tbHorasVoo.Text), tbMotor.Text, dtManutencao.Value.ToUniversalTime(), tbCategoriaMotor.Text);
                gestaoAeronaves.AtualizarDoc(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
            }
            catch (FormatException)
            {
                MessageBox.Show("Complete o campo 'matricula' para remover", "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ExcecaoNumeroIncoerente excecaoNumeroIncoerente)
            {
                MessageBox.Show(excecaoNumeroIncoerente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcecaoCategoriaInexistente excecaoCategoriaInexistente)
            {
                MessageBox.Show(excecaoCategoriaInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ExcecaoMatriculaInexistente excecaoMatriculaInexistente)
            {
                MessageBox.Show(excecaoMatriculaInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
