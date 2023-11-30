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
        // Construtor da classe Form1
        public Form1()
        {
            InitializeComponent();

            // Cria uma instância da classe Login para autenticação
            Login login = new Login(this);

            // Exibe a janela de login modal
            login.ShowDialog();

            // Adiciona um evento ao clique do item de menu "HORÁRIOS"
            hORARIOSToolStripMenuItem.Click += hORARIOSToolStripMenuItem_Click;
        }

        // Método chamado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método está vazio, sem implementação específica para o carregamento do formulário
        }

        // Método chamado quando a Label1 é clicada
        private void label1_Click(object sender, EventArgs e)
        {
            // Este método está vazio, sem implementação específica para o clique na Label1
        }

        // Método chamado quando a Label4 é clicada
        private void label4_Click(object sender, EventArgs e)
        {
            // Este método está vazio, sem implementação específica para o clique na Label4
        }

        // Método chamado quando o item de menu "Logoff" é clicado
        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Limpa as informações do usuário e define o estado como não logado
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            ledLogado.Image = Properties.Resources.vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        // Método chamado quando o item de menu "Logon" é clicado
        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria e exibe uma nova instância do formulário de login
            Login login = new Login(this);
            login.ShowDialog();
        }

        // Método para abrir um formulário com base no nível de acesso do usuário
        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel > 1)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        // Método chamado quando o item de menu "Novo Usuário" é clicado
        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica o acesso do usuário antes de abrir o formulário NovoUsuario
            abreForm(Globais.nivel, new NovoUsuario());
        }

        // Método chamado quando o item de menu "Gestão Usuário" é clicado
        private void gestãoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário GestaoUsuarios
            GestaoUsuarios gestaoUsuariosForm = new GestaoUsuarios();

            // Define a referência ao Form1 no formulário GestaoUsuarios
            gestaoUsuariosForm.Form1Reference = this;

            // Mostra o formulário GestaoUsuarios
            gestaoUsuariosForm.ShowDialog();
        }

        // Método chamado quando o item de menu "HORÁRIOS" é clicado
        private void hORARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chama o método para abrir o formulário de Horarios
            AbrirHorarios();
        }

        // Método para abrir o formulário de Horarios
        private void AbrirHorarios()
        {
            // Cria uma instância do formulário Horarios e define as informações do usuário
            Horarios horariosForm = new Horarios();
            horariosForm.NomeUsuario = lb_nomeUsuario.Text;
            horariosForm.IdUsuario = lb_acesso.Text;

            // Mostra o formulário Horarios
            horariosForm.ShowDialog();
        }
    }
}
