using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novo_projeto_anker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            ledLogado.Image = Properties.Resources.vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel > 1)
                {
                    // NovoUsuario novoUsuario = new NovoUsuario();
                    // novoUsuario.ShowDialog();
                } else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado!");
            }
        }
    }
}
