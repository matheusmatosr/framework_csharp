namespace novo_projeto_anker
{
    partial class Horarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 387);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 27;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Maroon;
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fechar.Location = new System.Drawing.Point(614, 13);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(151, 39);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar Janela";
            this.btn_fechar.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_excluir.Location = new System.Drawing.Point(349, 13);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(151, 39);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir Horário";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salvar.Location = new System.Drawing.Point(179, 13);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(151, 39);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar Horário";
            this.btn_salvar.UseVisualStyleBackColor = false;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Navy;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_novo.Location = new System.Drawing.Point(12, 13);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(151, 39);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo Horário";
            this.btn_novo.UseVisualStyleBackColor = false;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(32, 77);
            this.dgv_horarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.RowHeadersWidth = 51;
            this.dgv_horarios.RowTemplate.Height = 24;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(734, 285);
            this.dgv_horarios.TabIndex = 28;
            //this.dgv_horarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horarios_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Horário";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(29, 40);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(91, 22);
            this.tb_name.TabIndex = 30;
            this.tb_name.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // mtb_dscHorario
            // 
            this.mtb_dscHorario.Location = new System.Drawing.Point(152, 40);
            this.mtb_dscHorario.Mask = "99:99 \\- 99:99";
            this.mtb_dscHorario.Name = "mtb_dscHorario";
            this.mtb_dscHorario.Size = new System.Drawing.Size(98, 22);
            this.mtb_dscHorario.TabIndex = 32;
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtb_dscHorario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.Horarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_dscHorario;
    }
}