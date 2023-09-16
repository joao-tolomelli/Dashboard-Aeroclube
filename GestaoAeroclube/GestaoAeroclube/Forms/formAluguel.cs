using GestaoAeroclube.Class;
using GestaoAeroclube.Serviços;
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
using GestaoAeroclube.Exceptions;

namespace GestaoAeroclube.Forms
{
    public partial class formAluguel : Form
    {
        List<Aeronave> Aeronaves = new List<Aeronave>();
        List<Instrutor> Instrutores = new List<Instrutor>();
        
        public formAluguel()
        {
            InitializeComponent();
        }

        private void formAluguel_Load(object sender, EventArgs e)
        {
            
            
        }

        private void bntValorFinal_Click(object sender, EventArgs e)
        {
            try
            {
                List<Aeronave> Aeronaves = new List<Aeronave>();
                List<Piloto> Instrutores = new List<Piloto>();
                GestaoAeronaves gestaoAeronaves = new GestaoAeronaves(Aeronaves);
                GestaoInstrutores gestaoInstrutores = new GestaoInstrutores(Instrutores);
                gestaoAeronaves.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Aeronaves.txt");
                gestaoInstrutores.ReceberDados(@"C:\Users\twins\source\repos\GestaoAeroclube\GestaoAeroclube\Docs\Tabelas\Instrutores.txt");
                Aeronave aeronave = gestaoAeronaves.EncontrarAeronave(tbMatricula.Text);
                Instrutor instrutor = (Instrutor)gestaoInstrutores.EncontrarPiloto(tbCHTInstrutor.Text);

                if (instrutor.Associado==true)
                {
                    GestaoAluguel gestaoAluguel = new GestaoAluguel(instrutor, aeronave, new TaxaAluguelAssociado());
                    lblValorFinal.Text = "R$"+gestaoAluguel.CalcularAluguel(int.Parse(tbHorasTotais.Text)).ToString()+",00";
                    lblInfoAero.Text = aeronave.PrintInfo();
                }
                else
                {
                    GestaoAluguel gestaoAluguel = new GestaoAluguel(instrutor, aeronave, new TaxaAluguelConvidado());
                    lblValorFinal.Text = "R$"+gestaoAluguel.CalcularAluguel(int.Parse(tbHorasTotais.Text)).ToString()+",00";
                    lblInfoAero.Text = aeronave.PrintInfo();

                }
            }
            catch (ExcecaoNumeroIncoerente excecaoNumeroIncoerente)
            {
                MessageBox.Show(excecaoNumeroIncoerente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Complete todos os campos", "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcecaoMatriculaInexistente excecaoMatriculaInexistente)
            {
                MessageBox.Show(excecaoMatriculaInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Complete todos os campos", "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ExcecaoCHTInexistente excecaoCHTInexistente)
            {
                MessageBox.Show(excecaoCHTInexistente.Message, "Erro na entrada de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
