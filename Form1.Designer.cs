namespace novo_projeto_anker
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.acesso = new System.Windows.Forms.Panel();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ledLogado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hORARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledLogado)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // acesso
            // 
            this.acesso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.acesso.Controls.Add(this.lb_nomeUsuario);
            this.acesso.Controls.Add(this.label3);
            this.acesso.Controls.Add(this.lb_acesso);
            this.acesso.Controls.Add(this.label1);
            this.acesso.Controls.Add(this.ledLogado);
            this.acesso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.acesso.Location = new System.Drawing.Point(0, 389);
            this.acesso.Name = "acesso";
            this.acesso.Size = new System.Drawing.Size(800, 61);
            this.acesso.TabIndex = 0;
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(226, 33);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(19, 16);
            this.lb_nomeUsuario.TabIndex = 1;
            this.lb_nomeUsuario.Text = "---";
            this.lb_nomeUsuario.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuário:";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(138, 33);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(14, 16);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ledLogado
            // 
            this.ledLogado.Image = global::novo_projeto_anker.Properties.Resources.vermelho;
            this.ledLogado.Location = new System.Drawing.Point(22, 15);
            this.ledLogado.Name = "ledLogado";
            this.ledLogado.Size = new System.Drawing.Size(48, 34);
            this.ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledLogado.TabIndex = 0;
            this.ledLogado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.uSUÁRIOSToolStripMenuItem,
            this.hORARIOSToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.loginToolStripMenuItem.Text = "LOGIN";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // uSUÁRIOSToolStripMenuItem
            // 
            this.uSUÁRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.gestãoUsuárioToolStripMenuItem});
            this.uSUÁRIOSToolStripMenuItem.Name = "uSUÁRIOSToolStripMenuItem";
            this.uSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.uSUÁRIOSToolStripMenuItem.Text = "USUÁRIOS";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // gestãoUsuárioToolStripMenuItem
            // 
            this.gestãoUsuárioToolStripMenuItem.Name = "gestãoUsuárioToolStripMenuItem";
            this.gestãoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.gestãoUsuárioToolStripMenuItem.Text = "Gestão Usuário";
            this.gestãoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.gestãoUsuárioToolStripMenuItem_Click);
            // 
            // hORARIOSToolStripMenuItem
            // 
            this.hORARIOSToolStripMenuItem.Name = "hORARIOSToolStripMenuItem";
            this.hORARIOSToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hORARIOSToolStripMenuItem.Text = "ROTINAS";
            this.hORARIOSToolStripMenuItem.Click += new System.EventHandler(this.hORARIOSToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::novo_projeto_anker.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(217, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.acesso);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "projeto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.acesso.ResumeLayout(false);
            this.acesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledLogado)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel acesso;
        public System.Windows.Forms.PictureBox ledLogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lb_acesso;
        public System.Windows.Forms.Label lb_nomeUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoUsuárioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem hORARIOSToolStripMenuItem;
    }
}

