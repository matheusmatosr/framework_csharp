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
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            // criando um usuario e atribuindo os dados do banco de dados nele

            Usuario usuario = new Usuario();
            usuario.nome = tb_name.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0));

            Banco.NovoUsuario(usuario);
        }

        private void btn_cancelar_Click(object sender, EventArgs e) // açao de clicar do botao cancelar
        {
            tb_name.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
        }

        private void btn_fechar_Click(object sender, EventArgs e) // açao de clicar do botao fechar
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e) // açao de clicar do botao novo
        {
            tb_name.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
