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
    public partial class VerRotina : Form
    {
        public VerRotina()
        {
            InitializeComponent();
        }

        private void dgv_horarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerRotina_Load(object sender, EventArgs e)
        {
            string sql = "SELECT N_IDHORARIO AS ID, T_DSCHORARIO AS HORARIOS, T_ROTINAS AS ROTINAS FROM horarios ORDER BY T_DSCHORARIO";

            dgv_horarios.DataSource = Banco.dql(sql);
            dgv_horarios.Columns[0].Width = 120;
            dgv_horarios.Columns[1].Width = 200;
            dgv_horarios.Columns[2].Width = 200;
        }

        private void btn_fechar_horario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
