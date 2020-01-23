namespace Controle_Veiculos
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRUPODEPRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVIÇOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCAMODELOVEÍCULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEGURADORASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRADEPRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oCORRENÇIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMAILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOEMAILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BOTAOSAIR = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.rELATORIOSToolStripMenuItem,
            this.eMAILToolStripMenuItem,
            this.BOTAOSAIR});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.veiculoToolStripMenuItem,
            this.fORNECEDORToolStripMenuItem,
            this.gRUPODEPRODUTOSToolStripMenuItem,
            this.pRODUTOToolStripMenuItem,
            this.sERVIÇOSToolStripMenuItem,
            this.mARCAMODELOVEÍCULOSToolStripMenuItem,
            this.sEGURADORASToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.Cadastro;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.cadastrosToolStripMenuItem.Text = "CADASTROS";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.Person;
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.pessoaToolStripMenuItem.Text = "MOTORISTA";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.Car;
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.veiculoToolStripMenuItem.Text = "VEICULO";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // fORNECEDORToolStripMenuItem
            // 
            this.fORNECEDORToolStripMenuItem.Name = "fORNECEDORToolStripMenuItem";
            this.fORNECEDORToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.fORNECEDORToolStripMenuItem.Text = "FORNECEDOR";
            this.fORNECEDORToolStripMenuItem.Click += new System.EventHandler(this.fORNECEDORToolStripMenuItem_Click);
            // 
            // gRUPODEPRODUTOSToolStripMenuItem
            // 
            this.gRUPODEPRODUTOSToolStripMenuItem.Name = "gRUPODEPRODUTOSToolStripMenuItem";
            this.gRUPODEPRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.gRUPODEPRODUTOSToolStripMenuItem.Text = "GRUPO DE PRODUTOS";
            this.gRUPODEPRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.gRUPODEPRODUTOSToolStripMenuItem_Click);
            // 
            // pRODUTOToolStripMenuItem
            // 
            this.pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            this.pRODUTOToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.pRODUTOToolStripMenuItem.Text = "PRODUTO";
            this.pRODUTOToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOToolStripMenuItem_Click);
            // 
            // sERVIÇOSToolStripMenuItem
            // 
            this.sERVIÇOSToolStripMenuItem.Name = "sERVIÇOSToolStripMenuItem";
            this.sERVIÇOSToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.sERVIÇOSToolStripMenuItem.Text = "SERVIÇOS";
            this.sERVIÇOSToolStripMenuItem.Click += new System.EventHandler(this.sERVIÇOSToolStripMenuItem_Click);
            // 
            // mARCAMODELOVEÍCULOSToolStripMenuItem
            // 
            this.mARCAMODELOVEÍCULOSToolStripMenuItem.Name = "mARCAMODELOVEÍCULOSToolStripMenuItem";
            this.mARCAMODELOVEÍCULOSToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mARCAMODELOVEÍCULOSToolStripMenuItem.Text = "MARCA / MODELO VEÍCULOS";
            this.mARCAMODELOVEÍCULOSToolStripMenuItem.Click += new System.EventHandler(this.mARCAMODELOVEÍCULOSToolStripMenuItem_Click);
            // 
            // sEGURADORASToolStripMenuItem
            // 
            this.sEGURADORASToolStripMenuItem.Name = "sEGURADORASToolStripMenuItem";
            this.sEGURADORASToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.sEGURADORASToolStripMenuItem.Text = "SEGURADORAS";
            this.sEGURADORASToolStripMenuItem.Click += new System.EventHandler(this.sEGURADORASToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaçãoToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.rotaToolStripMenuItem,
            this.cOMPRADEPRODUTOToolStripMenuItem,
            this.oCORRENÇIASToolStripMenuItem});
            this.relatorioToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.Report;
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.relatorioToolStripMenuItem.Text = "OPERAÇÕES";
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.Location_icon;
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.locaçãoToolStripMenuItem.Text = "LOCAÇÃO";
            this.locaçãoToolStripMenuItem.Click += new System.EventHandler(this.locaçãoToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.System1;
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.manutençãoToolStripMenuItem.Text = "MANUTENCAO";
            this.manutençãoToolStripMenuItem.Click += new System.EventHandler(this.manutençãoToolStripMenuItem_Click);
            // 
            // rotaToolStripMenuItem
            // 
            this.rotaToolStripMenuItem.Name = "rotaToolStripMenuItem";
            this.rotaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.rotaToolStripMenuItem.Text = "ROTA";
            this.rotaToolStripMenuItem.Click += new System.EventHandler(this.rotaToolStripMenuItem_Click_2);
            // 
            // cOMPRADEPRODUTOToolStripMenuItem
            // 
            this.cOMPRADEPRODUTOToolStripMenuItem.Name = "cOMPRADEPRODUTOToolStripMenuItem";
            this.cOMPRADEPRODUTOToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cOMPRADEPRODUTOToolStripMenuItem.Text = "LANÇAMENTO DE COMPRAS";
            this.cOMPRADEPRODUTOToolStripMenuItem.Click += new System.EventHandler(this.cOMPRADEPRODUTOToolStripMenuItem_Click);
            // 
            // oCORRENÇIASToolStripMenuItem
            // 
            this.oCORRENÇIASToolStripMenuItem.Name = "oCORRENÇIASToolStripMenuItem";
            this.oCORRENÇIASToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.oCORRENÇIASToolStripMenuItem.Text = "OCORRENCIAS";
            this.oCORRENÇIASToolStripMenuItem.Click += new System.EventHandler(this.oCORRENÇIASToolStripMenuItem_Click);
            // 
            // rELATORIOSToolStripMenuItem
            // 
            this.rELATORIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRASToolStripMenuItem});
            this.rELATORIOSToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.icons8_report_file_64;
            this.rELATORIOSToolStripMenuItem.Name = "rELATORIOSToolStripMenuItem";
            this.rELATORIOSToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.rELATORIOSToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // eMAILToolStripMenuItem
            // 
            this.eMAILToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOEMAILToolStripMenuItem});
            this.eMAILToolStripMenuItem.Image = global::Controle_Veiculos.Properties.Resources.icons8_correio_50;
            this.eMAILToolStripMenuItem.Name = "eMAILToolStripMenuItem";
            this.eMAILToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.eMAILToolStripMenuItem.Text = "EMAIL";
            // 
            // nOVOEMAILToolStripMenuItem
            // 
            this.nOVOEMAILToolStripMenuItem.Name = "nOVOEMAILToolStripMenuItem";
            this.nOVOEMAILToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.nOVOEMAILToolStripMenuItem.Text = "NOVO EMAIL";
            this.nOVOEMAILToolStripMenuItem.Click += new System.EventHandler(this.nOVOEMAILToolStripMenuItem_Click);
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Image = global::Controle_Veiculos.Properties.Resources.Log_Out_icon;
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(59, 20);
            this.BOTAOSAIR.Text = "SAIR";
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Controle_Veiculos.Properties.Resources.dc5aeab5_ferrari_f8_tributo_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1332, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOMPRASToolStripMenuItem.Text = "COMPRAS";
            this.cOMPRASToolStripMenuItem.Click += new System.EventHandler(this.cOMPRASToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1332, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1348, 669);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1348, 669);
            this.Name = "frmPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BOTAOSAIR;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRUPODEPRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCAMODELOVEÍCULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEGURADORASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRADEPRODUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oCORRENÇIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVIÇOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMAILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATORIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOEMAILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
    }
}

