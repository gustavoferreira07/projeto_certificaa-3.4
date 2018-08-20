namespace projeto_certifica.telas
{
    partial class tela_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ocorrênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNovaOcorrênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarStatusDeOcorrênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosOrçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeEdiçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocorrênciasToolStripMenuItem,
            this.orçamentosToolStripMenuItem,
            this.históricoDeEdiçãoToolStripMenuItem1,
            this.usuárioToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ocorrênciasToolStripMenuItem
            // 
            this.ocorrênciasToolStripMenuItem.BackgroundImage = global::projeto_certifica.Properties.Resources.aami2_71_24;
            this.ocorrênciasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ocorrênciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNovaOcorrênciaToolStripMenuItem,
            this.consultarStatusDeOcorrênciaToolStripMenuItem});
            this.ocorrênciasToolStripMenuItem.Name = "ocorrênciasToolStripMenuItem";
            this.ocorrênciasToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.ocorrênciasToolStripMenuItem.Text = "   Ocorrências";
            this.ocorrênciasToolStripMenuItem.Click += new System.EventHandler(this.ocorrênciasToolStripMenuItem_Click);
            // 
            // registrarNovaOcorrênciaToolStripMenuItem
            // 
            this.registrarNovaOcorrênciaToolStripMenuItem.Name = "registrarNovaOcorrênciaToolStripMenuItem";
            this.registrarNovaOcorrênciaToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.registrarNovaOcorrênciaToolStripMenuItem.Text = "Registrar nova ocorrência";
            this.registrarNovaOcorrênciaToolStripMenuItem.Click += new System.EventHandler(this.registrarNovaOcorrênciaToolStripMenuItem_Click);
            // 
            // consultarStatusDeOcorrênciaToolStripMenuItem
            // 
            this.consultarStatusDeOcorrênciaToolStripMenuItem.Name = "consultarStatusDeOcorrênciaToolStripMenuItem";
            this.consultarStatusDeOcorrênciaToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.consultarStatusDeOcorrênciaToolStripMenuItem.Text = "Consultar ocorrência";
            this.consultarStatusDeOcorrênciaToolStripMenuItem.Click += new System.EventHandler(this.consultarStatusDeOcorrênciaToolStripMenuItem_Click);
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.BackgroundImage = global::projeto_certifica.Properties.Resources.aami18_48_24;
            this.orçamentosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orçamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosOrçamentosToolStripMenuItem});
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.orçamentosToolStripMenuItem.Text = "   Orçamentos";
            // 
            // listarTodosOrçamentosToolStripMenuItem
            // 
            this.listarTodosOrçamentosToolStripMenuItem.Name = "listarTodosOrçamentosToolStripMenuItem";
            this.listarTodosOrçamentosToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.listarTodosOrçamentosToolStripMenuItem.Text = "Listar todos orçamentos";
            this.listarTodosOrçamentosToolStripMenuItem.Click += new System.EventHandler(this.listarTodosOrçamentosToolStripMenuItem_Click);
            // 
            // históricoDeEdiçãoToolStripMenuItem1
            // 
            this.históricoDeEdiçãoToolStripMenuItem1.BackgroundImage = global::projeto_certifica.Properties.Resources.simple_60_24;
            this.históricoDeEdiçãoToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.históricoDeEdiçãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem});
            this.históricoDeEdiçãoToolStripMenuItem1.Name = "históricoDeEdiçãoToolStripMenuItem1";
            this.históricoDeEdiçãoToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.históricoDeEdiçãoToolStripMenuItem1.Text = "   Histórico de edição";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.BackgroundImage = global::projeto_certifica.Properties.Resources.simple_06_24;
            this.usuárioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNovoUsuárioToolStripMenuItem,
            this.consultarUsuáriosToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.usuárioToolStripMenuItem.Text = "   Usuário";
            // 
            // registrarNovoUsuárioToolStripMenuItem
            // 
            this.registrarNovoUsuárioToolStripMenuItem.Name = "registrarNovoUsuárioToolStripMenuItem";
            this.registrarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.registrarNovoUsuárioToolStripMenuItem.Text = "Registrar novo usuário";
            this.registrarNovoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.registrarNovoUsuárioToolStripMenuItem_Click);
            // 
            // consultarUsuáriosToolStripMenuItem
            // 
            this.consultarUsuáriosToolStripMenuItem.Name = "consultarUsuáriosToolStripMenuItem";
            this.consultarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.consultarUsuáriosToolStripMenuItem.Text = "Listar usuários";
            this.consultarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuáriosToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.BackgroundImage = global::projeto_certifica.Properties.Resources.thin_426_database_drives_raid_db_storage_nas_backup_24;
            this.backupToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.backupToolStripMenuItem.Text = "   Backup";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1263, 641);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Desenvolvedor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 18);
            this.toolStripStatusLabel1.Text = "Usuario:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolUsuario
            // 
            this.toolUsuario.Name = "toolUsuario";
            this.toolUsuario.Size = new System.Drawing.Size(0, 18);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(62, 667);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 18);
            this.lblUser.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 633);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tela_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::projeto_certifica.Properties.Resources.logo_original;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1354, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tela_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tela_principal_FormClosing);
            this.Load += new System.EventHandler(this.tela_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem registrarNovaOcorrênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarStatusDeOcorrênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNovoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolUsuario;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ocorrênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeEdiçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosOrçamentosToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
    }
}