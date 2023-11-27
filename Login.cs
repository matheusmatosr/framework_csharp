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

        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuários e/ou senha inválidos");
                tb_username.Focus();
                return;
            }

            string sql = "SELECT * FROM usuarios WHERE T_NOMEUSUARIO='"+username+"' AND T_SENHA='"+senha+"'";
            dt = Banco.consulta(sql);

            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[4].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.ledLogado.Image = Properties.Resources.verde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            } else
            {

                MessageBox.Show("Usuário não encontrado!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
