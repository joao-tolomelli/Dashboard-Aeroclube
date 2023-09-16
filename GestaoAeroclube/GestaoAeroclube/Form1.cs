using GestaoAeroclube.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoAeroclube
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metods

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlAux.Controls.Add(childForm);
            this.pnlAux.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Buttons

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAeronaves_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Aeronaves";
            openChildForm(new Forms.formAeronaves());
        }

        private void btnInstrutores_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Instrutores";
            openChildForm(new Forms.formInstrutores());
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Alunos";
            openChildForm(new Forms.formAlunos());
        }

        private void btnCombustivel_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Aluguel";
            openChildForm(new Forms.formAluguel());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
