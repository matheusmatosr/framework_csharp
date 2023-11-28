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
            /*
            string vquery = @"
                SELECT 
                    N_IDHORARIO AS 'ID',
                    T_DSCHORARIO AS 'Horário
                FROM
                    usuarios
            ";

            dgv_horarios.DataSource = Banco.dgv(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[0].Width = 150;
            */
        }
    }
}
