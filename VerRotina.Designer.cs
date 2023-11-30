namespace novo_projeto_anker
{
    partial class VerRotina
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
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar_horario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_horarios.Location = new System.Drawing.Point(37, 64);
            this.dgv_horarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.RowHeadersWidth = 51;
            this.dgv_horarios.RowTemplate.Height = 24;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(733, 225);
            this.dgv_horarios.TabIndex = 29;
            this.dgv_horarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horarios_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Visualizar Rotinas:";
            // 
            // btn_fechar_horario
            // 
            this.btn_fechar_horario.BackColor = System.Drawing.Color.Maroon;
            this.btn_fechar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_fechar_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar_horario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fechar_horario.Location = new System.Drawing.Point(619, 326);
            this.btn_fechar_horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fechar_horario.Name = "btn_fechar_horario";
            this.btn_fechar_horario.Size = new System.Drawing.Size(151, 39);
            this.btn_fechar_horario.TabIndex = 31;
            this.btn_fechar_horario.Text = "Fechar Janela";
            this.btn_fechar_horario.UseVisualStyleBackColor = false;
            this.btn_fechar_horario.Click += new System.EventHandler(this.btn_fechar_horario_Click);
            // 
            // VerRotina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.btn_fechar_horario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_horarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerRotina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerRotina";
            this.Load += new System.EventHandler(this.VerRotina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fechar_horario;
    }
}