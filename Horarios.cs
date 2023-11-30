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
        // Propriedades para armazenar informações do usuário
        public string NomeUsuario { get; set; }
        public string IdUsuario { get; set; }

        // Controles do formulário
        private Label lblNomeUsuario;

        // Construtor padrão
        public Horarios()
        {
            InitializeComponent();
        }

        // Método público para configurar as informações do usuário nos controles
        public void SetUserInfo()
        {
            // Atualiza as informações do usuário nos labels
            lb_nomeUsuario.Text = NomeUsuario;
            lb_acesso.Text = IdUsuario;

            // Define a imagem do LED com base na existência do nome do usuário
            if (NomeUsuario != null)
            {
                ledLogado.Image = Properties.Resources.verde;
            }
            else
            {
                ledLogado.Image = Properties.Resources.vermelho;
            }
        }

        // Evento de carregamento do formulário
        private void Horarios_Load(object sender, EventArgs e)
        {
            // Configura as informações do usuário
            SetUserInfo();

            // Consulta SQL para carregar os horários no DataGridView
            string sql = "SELECT N_IDHORARIO AS ID, T_DSCHORARIO AS HORARIOS, T_ROTINAS AS ROTINAS FROM horarios ORDER BY T_DSCHORARIO";

            // Preenche o DataGridView com os resultados da consulta
            dgv_horarios.DataSource = Banco.dql(sql);
            dgv_horarios.Columns[0].Width = 120;
            dgv_horarios.Columns[1].Width = 200;
            dgv_horarios.Columns[2].Width = 200;

            // Atualiza os labels com as informações do usuário
            lb_nomeUsuario.Text = NomeUsuario;
            lb_acesso.Text = IdUsuario;
        }

        // Evento de seleção de linha no DataGridView
        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            // Obtém informações da linha selecionada e preenche os controles correspondentes
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

        // Evento de clique no botão Novo Horário
        private void btn_novo_horario_Click(object sender, EventArgs e)
        {
            // Limpa os controles para inserção de um novo horário
            tb_idHorario.Clear();
            mtb_dscHorario.Clear();
            mtb_dscHorario.Focus();
            tb_rotinas.Clear();
        }

        // Evento de clique no botão Salvar Horário
        private void btn_salvar_horario_Click(object sender, EventArgs e)
        {
            string sql;

            // Verifica se é uma inserção ou atualização
            if (tb_idHorario.Text == "")
            {
                sql = "INSERT INTO horarios (T_DSCHORARIO, T_ROTINAS) VALUES (@dschorario, @rotinas)";
            }
            else
            {
                sql = "UPDATE horarios SET T_DSCHORARIO=@dschorario, T_ROTINAS=@rotinas WHERE N_IDHORARIO=@idHorario";
            }

            // Adiciona parâmetros para a consulta SQL
            var parametros = new Dictionary<string, object>
            {
                { "@dschorario", mtb_dscHorario.Text },
                { "@rotinas", tb_rotinas.Text },
                { "@idHorario", tb_idHorario.Text }
            };

            // Executa a consulta SQL de manipulação de dados
            Banco.dml(sql, parametros);

            // Atualiza apenas o DataSource sem chamar dql novamente
            dgv_horarios.DataSource = Banco.dql("SELECT N_IDHORARIO AS ID, T_DSCHORARIO AS HORARIOS, T_ROTINAS AS ROTINAS FROM horarios ORDER BY T_DSCHORARIO");
        }

        // Evento de clique no botão Excluir Horário
        private void btn_excluir_horario_Click(object sender, EventArgs e)
        {
            // Confirmação antes de excluir
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                // Consulta SQL para excluir o horário
                string q = "DELETE FROM horarios WHERE N_IDHORARIO=" + tb_idHorario.Text;
                Banco.dml(q);

                // Remove a linha selecionada do DataGridView
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);

                // Exibe mensagem de sucesso
                MessageBox.Show("Horário excluído com sucesso!");
            }
        }

        // Evento de clique no botão Fechar
        private void btn_fechar_horario_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            Close();
        }

        // Evento de clique em célula do DataGridView (não implementado)
        private void dgv_horarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Não há implementação neste momento
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
