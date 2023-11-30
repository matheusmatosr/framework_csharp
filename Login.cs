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
    public partial class Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();

        // Construtor da classe Login
        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        // Evento do clique no botão de login
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtenção do nome de usuário e senha inseridos
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            // Verificação se o nome de usuário ou senha estão em branco
            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuários e/ou senha inválidos");
                tb_username.Focus();
                return;
            }

            // Construção da consulta SQL para verificar credenciais no banco de dados
            string sql = "SELECT * FROM usuarios WHERE T_NOMEUSUARIO='" + username + "' AND T_SENHA='" + senha + "'";
            dt = Banco.dql(sql);

            // Verificação se o usuário foi encontrado
            if (dt.Rows.Count == 1)
            {
                // Atualização de informações na tela principal (form1) após o login bem-sucedido
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[4].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.ledLogado.Image = Properties.Resources.verde;

                // Definição de variáveis globais para controlar o estado do usuário logado
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;

                // Fechamento da janela de login após o login bem-sucedido
                this.Close();
            }
            else
            {
                // Exibição de mensagem se o usuário não foi encontrado
                MessageBox.Show("Usuário não encontrado!");
            }
        }

        // Evento do clique no botão de cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Fechamento da janela de login
            this.Close();
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
