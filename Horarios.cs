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
    public partial class Horarios : Form
    {
        public string NomeUsuario { get; set; }
        public string IdUsuario { get; set; }

        private Label lblNomeUsuario;

        // Construtor que aceita um objeto Usuario
        public Horarios()
        {
            InitializeComponent();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            string sql = "SELECT N_IDHORARIO AS ID, T_DSCHORARIO AS HORARIOS, T_ROTINAS AS ROTINAS FROM horarios ORDER BY T_DSCHORARIO";

            dgv_horarios.DataSource = Banco.dql(sql);
            dgv_horarios.Columns[0].Width = 120;
            dgv_horarios.Columns[1].Width = 200;
            dgv_horarios.Columns[2].Width = 200;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string sql = "SELECT * FROM horarios WHERE N_IDHORARIO=" + vid;

                dt = Banco.dql(sql);
                tb_idHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_dscHorario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
                tb_rotinas.Text = dt.Rows[0].Field<string>("T_ROTINAS");
            }
        }

        private void btn_novo_horario_Click(object sender, EventArgs e)
        {
            tb_idHorario.Clear();
            mtb_dscHorario.Clear();
            mtb_dscHorario.Focus();
            tb_rotinas.Clear();
        }

        private void btn_salvar_horario_Click(object sender, EventArgs e)
        {
            string sql;
            if (tb_idHorario.Text == "")
            {
                sql = "INSERT INTO horarios (T_DSCHORARIO, T_ROTINAS) VALUES (@dschorario, @rotinas)";
            }
            else
            {
                sql = "UPDATE horarios SET T_DSCHORARIO=@dschorario, T_ROTINAS=@rotinas WHERE N_IDHORARIO=@idHorario";
            }

            // Adicione os parâmetros
            var parametros = new Dictionary<string, object>
            {
                { "@dschorario", mtb_dscHorario.Text },
                { "@rotinas", tb_rotinas.Text },
                { "@idHorario", tb_idHorario.Text }
            };

            // Chame a função dml com os parâmetros
            Banco.dml(sql, parametros);

            // Atualize apenas o DataSource sem chamar dql novamente
            dgv_horarios.DataSource = Banco.dql("SELECT N_IDHORARIO AS ID, T_DSCHORARIO AS HORARIOS, T_ROTINAS AS ROTINAS FROM horarios ORDER BY T_DSCHORARIO");
        }


        private void btn_excluir_horario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string q = "DELETE FROM horarios WHERE N_IDHORARIO=" + tb_idHorario.Text;
                Banco.dml(q);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
                MessageBox.Show("Horário excluído com sucesso!");
            }
        }

        private void btn_fechar_horario_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
