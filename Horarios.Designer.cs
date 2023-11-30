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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar_horario = new System.Windows.Forms.Button();
            this.btn_excluir_horario = new System.Windows.Forms.Button();
            this.btn_salvar_horario = new System.Windows.Forms.Button();
            this.btn_novo_horario = new System.Windows.Forms.Button();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_idHorario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_rotinas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_fechar_horario);
            this.panel1.Controls.Add(this.btn_excluir_horario);
            this.panel1.Controls.Add(this.btn_salvar_horario);
            this.panel1.Controls.Add(this.btn_novo_horario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 387);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 27;
            // 
            // btn_fechar_horario
            // 
            this.btn_fechar_horario.BackColor = System.Drawing.Color.Maroon;
            this.btn_fechar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_fechar_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar_horario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fechar_horario.Location = new System.Drawing.Point(614, 13);
            this.btn_fechar_horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fechar_horario.Name = "btn_fechar_horario";
            this.btn_fechar_horario.Size = new System.Drawing.Size(151, 39);
            this.btn_fechar_horario.TabIndex = 3;
            this.btn_fechar_horario.Text = "Fechar Janela";
            this.btn_fechar_horario.UseVisualStyleBackColor = false;
            this.btn_fechar_horario.Click += new System.EventHandler(this.btn_fechar_horario_Click);
            // 
            // btn_excluir_horario
            // 
            this.btn_excluir_horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_excluir_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_horario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_excluir_horario.Location = new System.Drawing.Point(336, 13);
            this.btn_excluir_horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir_horario.Name = "btn_excluir_horario";
            this.btn_excluir_horario.Size = new System.Drawing.Size(151, 39);
            this.btn_excluir_horario.TabIndex = 2;
            this.btn_excluir_horario.Text = "Excluir Horário";
            this.btn_excluir_horario.UseVisualStyleBackColor = false;
            this.btn_excluir_horario.Click += new System.EventHandler(this.btn_excluir_horario_Click);
            // 
            // btn_salvar_horario
            // 
            this.btn_salvar_horario.BackColor = System.Drawing.Color.Green;
            this.btn_salvar_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar_horario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salvar_horario.Location = new System.Drawing.Point(179, 13);
            this.btn_salvar_horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar_horario.Name = "btn_salvar_horario";
            this.btn_salvar_horario.Size = new System.Drawing.Size(151, 39);
            this.btn_salvar_horario.TabIndex = 1;
            this.btn_salvar_horario.Text = "Salvar Horário";
            this.btn_salvar_horario.UseVisualStyleBackColor = false;
            this.btn_salvar_horario.Click += new System.EventHandler(this.btn_salvar_horario_Click);
            // 
            // btn_novo_horario
            // 
            this.btn_novo_horario.BackColor = System.Drawing.Color.Navy;
            this.btn_novo_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo_horario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_novo_horario.Location = new System.Drawing.Point(12, 13);
            this.btn_novo_horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_novo_horario.Name = "btn_novo_horario";
            this.btn_novo_horario.Size = new System.Drawing.Size(151, 39);
            this.btn_novo_horario.TabIndex = 0;
            this.btn_novo_horario.Text = "Novo Horário";
            this.btn_novo_horario.UseVisualStyleBackColor = false;
            this.btn_novo_horario.Click += new System.EventHandler(this.btn_novo_horario_Click);
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            this.dgv_horarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
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
            // tb_idHorario
            // 
            this.tb_idHorario.Location = new System.Drawing.Point(29, 40);
            this.tb_idHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_idHorario.Name = "tb_idHorario";
            this.tb_idHorario.ReadOnly = true;
            this.tb_idHorario.Size = new System.Drawing.Size(91, 22);
            this.tb_idHorario.TabIndex = 30;
            this.tb_idHorario.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Rotinas";
            // 
            // tb_rotinas
            // 
            this.tb_rotinas.Location = new System.Drawing.Point(289, 40);
            this.tb_rotinas.Name = "tb_rotinas";
            this.tb_rotinas.Size = new System.Drawing.Size(223, 22);
            this.tb_rotinas.TabIndex = 34;
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_rotinas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_dscHorario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_idHorario);
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
        private System.Windows.Forms.Button btn_fechar_horario;
        private System.Windows.Forms.Button btn_excluir_horario;
        private System.Windows.Forms.Button btn_salvar_horario;
        private System.Windows.Forms.Button btn_novo_horario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_idHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_dscHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_rotinas;
    }
}