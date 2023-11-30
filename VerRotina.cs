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

        // Evento disparado quando há clique em uma célula do DataGridView
        private void dgv_horarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementação específica pode ser adicionada aqui se necessário
        }

        // Evento disparado ao carregar o formulário
        private void VerRotina_Load(object sender, EventArgs e)
        {
            // Consulta SQL para recuperar dados da tabela horarios
            string sql = "SELECT N_IDHORARIO AS ID, T_DSCHORARIO AS HORARIOS, T_ROTINAS AS ROTINAS FROM horarios ORDER BY T_DSCHORARIO";

            // Carregar os dados no DataGridView usando o método dql da classe Banco
            dgv_horarios.DataSource = Banco.dql(sql);

            // Definir larguras das colunas no DataGridView
            dgv_horarios.Columns[0].Width = 120;
            dgv_horarios.Columns[1].Width = 200;
            dgv_horarios.Columns[2].Width = 200;
        }

        // Evento disparado ao clicar no botão "Fechar Horário"
        private void btn_fechar_horario_Click(object sender, EventArgs e)
        {
            // Fechar o formulário
            Close();
        }
    }
}
