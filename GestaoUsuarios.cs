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
    public partial class GestaoUsuarios : Form
    {
        public GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIdNomes();
            dgv_usuarios.Columns[0].Width = 60;
            dgv_usuarios.Columns[1].Width = 170;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if(contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuários(vid);

                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_name.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHA").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUsuario = new NovoUsuario();
            novoUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIdNomes();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index; // grava a linha que ta selecionada

            // pegando os dados atualizados
            Usuario u = new Usuario();
            u.id = Convert.ToInt32(tb_id.Text);
            u.nome = tb_name.Text;
            u.senha = tb_senha.Text;
            u.status = cb_status.Text;
            u.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0));

            Banco.AtualizarUsuario(u);
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIdNomes();
            dgv_usuarios.CurrentCell = dgv_usuarios[0, linha]; // mantem na seleçao que ta sendo modificada o usuario.

            MessageBox.Show("Alterações salvas com sucesso!");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir este usuário?", "Excluir?", MessageBoxButtons.YesNo); // confirmar exclusao

            if (res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }

            MessageBox.Show("Usuário excluido com sucesso!");

        }

        private void btn_fechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
