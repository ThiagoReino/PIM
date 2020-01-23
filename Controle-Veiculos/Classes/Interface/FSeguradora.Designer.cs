namespace Controle_Veiculos.Classes.Interface
{
    partial class FSeguradora
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EDITCODIGO = new System.Windows.Forms.TextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.gbxMotorista = new System.Windows.Forms.GroupBox();
            this.EDITDDD = new System.Windows.Forms.MaskedTextBox();
            this.EDITTELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.LABELTELEFONEFIXO = new System.Windows.Forms.Label();
            this.EDITNOME = new System.Windows.Forms.TextBox();
            this.LABELRAZAO = new System.Windows.Forms.Label();
            this.LABELCODIGO = new System.Windows.Forms.Label();
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BOTAOSAIR = new System.Windows.Forms.ToolStripButton();
            this.gbxMotorista.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EDITCODIGO
            // 
            this.EDITCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCODIGO.Location = new System.Drawing.Point(544, 17);
            this.EDITCODIGO.Name = "EDITCODIGO";
            this.EDITCODIGO.Size = new System.Drawing.Size(69, 20);
            this.EDITCODIGO.TabIndex = 32;
            this.EDITCODIGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // gbxMotorista
            // 
            this.gbxMotorista.Controls.Add(this.EDITDDD);
            this.gbxMotorista.Controls.Add(this.EDITTELEFONE);
            this.gbxMotorista.Controls.Add(this.LABELTELEFONEFIXO);
            this.gbxMotorista.Controls.Add(this.EDITNOME);
            this.gbxMotorista.Controls.Add(this.LABELRAZAO);
            this.gbxMotorista.Location = new System.Drawing.Point(9, 43);
            this.gbxMotorista.Name = "gbxMotorista";
            this.gbxMotorista.Size = new System.Drawing.Size(604, 102);
            this.gbxMotorista.TabIndex = 28;
            this.gbxMotorista.TabStop = false;
            this.gbxMotorista.Text = "SEGURADORA";
            // 
            // EDITDDD
            // 
            this.EDITDDD.Location = new System.Drawing.Point(107, 57);
            this.EDITDDD.Mask = "00";
            this.EDITDDD.Name = "EDITDDD";
            this.EDITDDD.Size = new System.Drawing.Size(33, 20);
            this.EDITDDD.TabIndex = 16;
            this.EDITDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EDITTELEFONE
            // 
            this.EDITTELEFONE.Location = new System.Drawing.Point(146, 57);
            this.EDITTELEFONE.Mask = "00000-0000";
            this.EDITTELEFONE.Name = "EDITTELEFONE";
            this.EDITTELEFONE.Size = new System.Drawing.Size(115, 20);
            this.EDITTELEFONE.TabIndex = 15;
            this.EDITTELEFONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LABELTELEFONEFIXO
            // 
            this.LABELTELEFONEFIXO.AutoSize = true;
            this.LABELTELEFONEFIXO.Location = new System.Drawing.Point(8, 60);
            this.LABELTELEFONEFIXO.Name = "LABELTELEFONEFIXO";
            this.LABELTELEFONEFIXO.Size = new System.Drawing.Size(66, 13);
            this.LABELTELEFONEFIXO.TabIndex = 13;
            this.LABELTELEFONEFIXO.Text = "TELEFONE:";
            // 
            // EDITNOME
            // 
            this.EDITNOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITNOME.Location = new System.Drawing.Point(107, 29);
            this.EDITNOME.Name = "EDITNOME";
            this.EDITNOME.Size = new System.Drawing.Size(433, 20);
            this.EDITNOME.TabIndex = 1;
            // 
            // LABELRAZAO
            // 
            this.LABELRAZAO.AutoSize = true;
            this.LABELRAZAO.Location = new System.Drawing.Point(51, 32);
            this.LABELRAZAO.Name = "LABELRAZAO";
            this.LABELRAZAO.Size = new System.Drawing.Size(42, 13);
            this.LABELRAZAO.TabIndex = 0;
            this.LABELRAZAO.Text = "NOME:";
            // 
            // LABELCODIGO
            // 
            this.LABELCODIGO.AutoSize = true;
            this.LABELCODIGO.Location = new System.Drawing.Point(486, 20);
            this.LABELCODIGO.Name = "LABELCODIGO";
            this.LABELCODIGO.Size = new System.Drawing.Size(52, 13);
            this.LABELCODIGO.TabIndex = 33;
            this.LABELCODIGO.Text = "CODIGO:";
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
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
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
            // FSeguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 155);
            this.Controls.Add(this.EDITCODIGO);
            this.Controls.Add(this.gbxMotorista);
            this.Controls.Add(this.LABELCODIGO);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(641, 194);
            this.MinimumSize = new System.Drawing.Size(641, 194);
            this.Name = "FSeguradora";
            this.Text = "Cadastro de Seguradoras";
            this.Load += new System.EventHandler(this.FSeguradora_Load);
            this.gbxMotorista.ResumeLayout(false);
            this.gbxMotorista.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox EDITCODIGO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.GroupBox gbxMotorista;
        private System.Windows.Forms.TextBox EDITNOME;
        private System.Windows.Forms.Label LABELRAZAO;
        private System.Windows.Forms.Label LABELCODIGO;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BOTAOSAIR;
        private System.Windows.Forms.MaskedTextBox EDITTELEFONE;
        internal System.Windows.Forms.Label LABELTELEFONEFIXO;
        private System.Windows.Forms.MaskedTextBox EDITDDD;
    }
}