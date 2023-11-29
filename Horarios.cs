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
        public Horarios()
        {
            InitializeComponent();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            string sql = "SELECT N_IDHORARIO AS ID, T_DSCHORARIO AS HORARIOS FROM horarios ORDER BY T_DSCHORARIO";

            dgv_horarios.DataSource = Banco.dql(sql);
            dgv_horarios.Columns[0].Width = 120;
            dgv_horarios.Columns[1].Width = 300;
            
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string sql = "SELECT * FROM horarios WHERE N_IDHORARIO=" + vid;

                dt = Banco.dql(sql);
                tb_idHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_dscHorario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
            }
        }

        private void btn_novo_horario_Click(object sender, EventArgs e)
        {
            tb_idHorario.Clear();
            mtb_dscHorario.Clear();
            mtb_dscHorario.Focus();
        }

        private void btn_salvar_horario_Click(object sender, EventArgs e)
        {
            string sql;
            if (tb_idHorario.Text == "")
            {
                sql = "INSERT INTO horarios (T_DSCHORARIO) VALUES ('" + mtb_dscHorario.Text + "')";
            } else
            {
                sql = "UPDATE horarios SET T_DSCHORARIO='" + mtb_dscHorario.Text + "' WHERE N_IDHORARIO="+tb_idHorario.Text;
            }
            
            Banco.dml(sql);
            
            sql = "SELECT N_IDHORARIO, T_DSCHORARIO FROM horarios ORDER BY T_DSCHORARIO";
            dgv_horarios.DataSource = Banco.dql(sql);
        }

        private void btn_excluir_horario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string q = "DELETE FROM horarios WHERE N_IDHORARIO="+tb_idHorario.Text;
                Banco.dml(q);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
            }
            MessageBox.Show("Horário excluído com sucesso!");
        }

        private void btn_fechar_horario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
