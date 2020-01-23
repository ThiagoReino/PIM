namespace Controle_Veiculos.Classes.Interface
{
    partial class Fservicos
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
            this.gbxServicos = new System.Windows.Forms.GroupBox();
            this.EDITDESCRICAO = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.EDITCODIGO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.BOTAONOVO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BOTAOSALVAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BOTAOEXCLUIR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BOTAOATUALIZAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BOTAOLIMPARTELA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.BOTAOLOCALIZAR = new System.Windows.Forms.ToolStripButton();
            this.BOTAOSAIR = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxServicos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxServicos
            // 
            this.gbxServicos.Controls.Add(this.EDITDESCRICAO);
            this.gbxServicos.Controls.Add(this.lblRazao);
            this.gbxServicos.Location = new System.Drawing.Point(12, 40);
            this.gbxServicos.Name = "gbxServicos";
            this.gbxServicos.Size = new System.Drawing.Size(604, 72);
            this.gbxServicos.TabIndex = 38;
            this.gbxServicos.TabStop = false;
            this.gbxServicos.Text = "SERVIÇOS";
            // 
            // EDITDESCRICAO
            // 
            this.EDITDESCRICAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITDESCRICAO.Location = new System.Drawing.Point(72, 26);
            this.EDITDESCRICAO.Name = "EDITDESCRICAO";
            this.EDITDESCRICAO.Size = new System.Drawing.Size(433, 20);
            this.EDITDESCRICAO.TabIndex = 1;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Location = new System.Drawing.Point(8, 29);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(58, 13);
            this.lblRazao.TabIndex = 0;
            this.lblRazao.Text = "Descrição:";
            // 
            // EDITCODIGO
            // 
            this.EDITCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCODIGO.Location = new System.Drawing.Point(547, 14);
            this.EDITCODIGO.Name = "EDITCODIGO";
            this.EDITCODIGO.Size = new System.Drawing.Size(69, 20);
            this.EDITCODIGO.TabIndex = 40;
            this.EDITCODIGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "CODIGO:";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator10,
            this.BOTAONOVO,
            this.toolStripSeparator1,
            this.BOTAOSALVAR,
            this.toolStripSeparator2,
            this.BOTAOEXCLUIR,
            this.toolStripSeparator4,
            this.BOTAOATUALIZAR,
            this.toolStripSeparator6,
            this.BOTAOLIMPARTELA,
            this.toolStripSeparator7,
            this.BOTAOLOCALIZAR,
            this.toolStripSeparator5,
            this.BOTAOSAIR,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(636, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // BOTAONOVO
            // 
            this.BOTAONOVO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BOTAONOVO.Image = global::Controle_Veiculos.Properties.Resources.New_file_icon;
            this.BOTAONOVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOTAONOVO.Name = "BOTAONOVO";
            this.BOTAONOVO.Size = new System.Drawing.Size(23, 22);
            this.BOTAONOVO.Text = "Novo";
            this.BOTAONOVO.Click += new System.EventHandler(this.BOTAONOVO_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BOTAOSALVAR
            // 
            this.BOTAOSALVAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BOTAOSALVAR.Image = global::Controle_Veiculos.Properties.Resources.Save_icon;
            this.BOTAOSALVAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOTAOSALVAR.Name = "BOTAOSALVAR";
            this.BOTAOSALVAR.Size = new System.Drawing.Size(23, 22);
            this.BOTAOSALVAR.Text = "Salvar";
            this.BOTAOSALVAR.Click += new System.EventHandler(this.BOTAOSALVAR_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BOTAOEXCLUIR
            // 
            this.BOTAOEXCLUIR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BOTAOEXCLUIR.Image = global::Controle_Veiculos.Properties.Resources.icons8_excluir_64;
            this.BOTAOEXCLUIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOTAOEXCLUIR.Name = "BOTAOEXCLUIR";
            this.BOTAOEXCLUIR.Size = new System.Drawing.Size(23, 22);
            this.BOTAOEXCLUIR.Text = "Excluir";
            this.BOTAOEXCLUIR.Click += new System.EventHandler(this.BOTAOEXCLUIR_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // BOTAOATUALIZAR
            // 
            this.BOTAOATUALIZAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BOTAOATUALIZAR.Image = global::Controle_Veiculos.Properties.Resources.Refresh_icon;
            this.BOTAOATUALIZAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOTAOATUALIZAR.Name = "BOTAOATUALIZAR";
            this.BOTAOATUALIZAR.Size = new System.Drawing.Size(23, 22);
            this.BOTAOATUALIZAR.Text = "Atualizar";
            this.BOTAOATUALIZAR.Click += new System.EventHandler(this.BOTAOATUALIZAR_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // BOTAOLIMPARTELA
            // 
            this.BOTAOLIMPARTELA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BOTAOLIMPARTELA.Image = global::Controle_Veiculos.Properties.Resources.Actions_edit_clear_icon;
            this.BOTAOLIMPARTELA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOTAOLIMPARTELA.Name = "BOTAOLIMPARTELA";
            this.BOTAOLIMPARTELA.Size = new System.Drawing.Size(23, 22);
            this.BOTAOLIMPARTELA.Text = "Limpar Tela";
            this.BOTAOLIMPARTELA.Click += new System.EventHandler(this.BOTAOLIMPARTELA_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // BOTAOLOCALIZAR
            // 
            this.BOTAOLOCALIZAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BOTAOLOCALIZAR.Image = global::Controle_Veiculos.Properties.Resources.Search_icon_v;
            this.BOTAOLOCALIZAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOTAOLOCALIZAR.Name = "BOTAOLOCALIZAR";
            this.BOTAOLOCALIZAR.Size = new System.Drawing.Size(23, 22);
            this.BOTAOLOCALIZAR.Text = "Pesquisar";
            this.BOTAOLOCALIZAR.Click += new System.EventHandler(this.BOTAOLOCALIZAR_Click);
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BOTAOSAIR.Image = global::Controle_Veiculos.Properties.Resources.Log_Out_icon;
            this.BOTAOSAIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(23, 22);
            this.BOTAOSAIR.Text = "Sair";
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Fservicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 139);
            this.Controls.Add(this.gbxServicos);
            this.Controls.Add(this.EDITCODIGO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Fservicos";
            this.Text = "Form1";
            this.gbxServicos.ResumeLayout(false);
            this.gbxServicos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxServicos;
        private System.Windows.Forms.TextBox EDITDESCRICAO;
        private System.Windows.Forms.Label lblRazao;
        internal System.Windows.Forms.TextBox EDITCODIGO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton BOTAONOVO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BOTAOSALVAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BOTAOEXCLUIR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BOTAOATUALIZAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BOTAOLIMPARTELA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BOTAOLOCALIZAR;
        private System.Windows.Forms.ToolStripButton BOTAOSAIR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}