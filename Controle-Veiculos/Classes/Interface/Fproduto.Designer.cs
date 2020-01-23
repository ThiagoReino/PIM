namespace Controle_Veiculos.Classes.Interface
{
    partial class Fproduto
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
            this.BOTAOSAIR = new System.Windows.Forms.ToolStripButton();
            this.EDITGRUPOCODIGO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EDITESTOQUE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EDITCUSTOMEDIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDITCUSTO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EDITDATAULTIMASAIDA = new System.Windows.Forms.MaskedTextBox();
            this.EDITDATAULTIMACOMPRA = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.EDITCODIGO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EDITSITUACAO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EDITDESCRICAO = new System.Windows.Forms.TextBox();
            this.BOTAOGRUPO = new System.Windows.Forms.Button();
            this.EDITGRUPODESCRICAO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EDITUNIDADE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeRazao = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // EDITGRUPOCODIGO
            // 
            this.EDITGRUPOCODIGO.Location = new System.Drawing.Point(366, 41);
            this.EDITGRUPOCODIGO.Name = "EDITGRUPOCODIGO";
            this.EDITGRUPOCODIGO.Size = new System.Drawing.Size(100, 20);
            this.EDITGRUPOCODIGO.TabIndex = 35;
            this.EDITGRUPOCODIGO.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Codigo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EDITESTOQUE);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.EDITCUSTOMEDIO);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.EDITCUSTO);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.EDITDATAULTIMASAIDA);
            this.groupBox3.Controls.Add(this.EDITDATAULTIMACOMPRA);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 166);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS QUANTITATIVOS DO PRODUTO";
            // 
            // EDITESTOQUE
            // 
            this.EDITESTOQUE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITESTOQUE.Location = new System.Drawing.Point(137, 135);
            this.EDITESTOQUE.MaxLength = 8;
            this.EDITESTOQUE.Name = "EDITESTOQUE";
            this.EDITESTOQUE.Size = new System.Drawing.Size(97, 20);
            this.EDITESTOQUE.TabIndex = 49;
            this.EDITESTOQUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Quantidade estoque:";
            // 
            // EDITCUSTOMEDIO
            // 
            this.EDITCUSTOMEDIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCUSTOMEDIO.Location = new System.Drawing.Point(430, 34);
            this.EDITCUSTOMEDIO.MaxLength = 8;
            this.EDITCUSTOMEDIO.Name = "EDITCUSTOMEDIO";
            this.EDITCUSTOMEDIO.Size = new System.Drawing.Size(128, 20);
            this.EDITCUSTOMEDIO.TabIndex = 47;
            this.EDITCUSTOMEDIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Valor do custo médio:";
            // 
            // EDITCUSTO
            // 
            this.EDITCUSTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCUSTO.Location = new System.Drawing.Point(95, 34);
            this.EDITCUSTO.MaxLength = 8;
            this.EDITCUSTO.Name = "EDITCUSTO";
            this.EDITCUSTO.Size = new System.Drawing.Size(128, 20);
            this.EDITCUSTO.TabIndex = 45;
            this.EDITCUSTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Valor do custo:";
            // 
            // EDITDATAULTIMASAIDA
            // 
            this.EDITDATAULTIMASAIDA.Location = new System.Drawing.Point(458, 90);
            this.EDITDATAULTIMASAIDA.Mask = "00/00/0000";
            this.EDITDATAULTIMASAIDA.Name = "EDITDATAULTIMASAIDA";
            this.EDITDATAULTIMASAIDA.Size = new System.Drawing.Size(100, 20);
            this.EDITDATAULTIMASAIDA.TabIndex = 44;
            this.EDITDATAULTIMASAIDA.ValidatingType = typeof(System.DateTime);
            this.EDITDATAULTIMASAIDA.DragLeave += new System.EventHandler(this.EDITDATAULTIMASAIDA_DragLeave);
            // 
            // EDITDATAULTIMACOMPRA
            // 
            this.EDITDATAULTIMACOMPRA.Location = new System.Drawing.Point(134, 90);
            this.EDITDATAULTIMACOMPRA.Mask = "00/00/0000";
            this.EDITDATAULTIMACOMPRA.Name = "EDITDATAULTIMACOMPRA";
            this.EDITDATAULTIMACOMPRA.Size = new System.Drawing.Size(100, 20);
            this.EDITDATAULTIMACOMPRA.TabIndex = 43;
            this.EDITDATAULTIMACOMPRA.ValidatingType = typeof(System.DateTime);
            this.EDITDATAULTIMACOMPRA.DragLeave += new System.EventHandler(this.EDITDATAULTIMACOMPRA_DragLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(344, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Data da ultima saída:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Data da ultima compra:";
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
            this.toolStrip1.Size = new System.Drawing.Size(633, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // EDITCODIGO
            // 
            this.EDITCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCODIGO.Enabled = false;
            this.EDITCODIGO.Location = new System.Drawing.Point(531, 41);
            this.EDITCODIGO.Name = "EDITCODIGO";
            this.EDITCODIGO.Size = new System.Drawing.Size(86, 20);
            this.EDITCODIGO.TabIndex = 33;
            this.EDITCODIGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EDITSITUACAO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.EDITDESCRICAO);
            this.groupBox1.Controls.Add(this.BOTAOGRUPO);
            this.groupBox1.Controls.Add(this.EDITGRUPODESCRICAO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EDITUNIDADE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNomeRazao);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 175);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS CADASTRAIS DO  PRODUTO";
            // 
            // EDITSITUACAO
            // 
            this.EDITSITUACAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EDITSITUACAO.FormattingEnabled = true;
            this.EDITSITUACAO.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.EDITSITUACAO.Location = new System.Drawing.Point(16, 135);
            this.EDITSITUACAO.Name = "EDITSITUACAO";
            this.EDITSITUACAO.Size = new System.Drawing.Size(128, 21);
            this.EDITSITUACAO.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Situacao";
            // 
            // EDITDESCRICAO
            // 
            this.EDITDESCRICAO.Location = new System.Drawing.Point(16, 39);
            this.EDITDESCRICAO.Name = "EDITDESCRICAO";
            this.EDITDESCRICAO.Size = new System.Drawing.Size(543, 20);
            this.EDITDESCRICAO.TabIndex = 36;
            // 
            // BOTAOGRUPO
            // 
            this.BOTAOGRUPO.Image = global::Controle_Veiculos.Properties.Resources.Search_icon_v;
            this.BOTAOGRUPO.Location = new System.Drawing.Point(390, 88);
            this.BOTAOGRUPO.Name = "BOTAOGRUPO";
            this.BOTAOGRUPO.Size = new System.Drawing.Size(29, 23);
            this.BOTAOGRUPO.TabIndex = 20;
            this.BOTAOGRUPO.UseVisualStyleBackColor = true;
            this.BOTAOGRUPO.Click += new System.EventHandler(this.BOTAOGRUPO_Click);
            // 
            // EDITGRUPODESCRICAO
            // 
            this.EDITGRUPODESCRICAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITGRUPODESCRICAO.Location = new System.Drawing.Point(16, 90);
            this.EDITGRUPODESCRICAO.MaxLength = 16;
            this.EDITGRUPODESCRICAO.Name = "EDITGRUPODESCRICAO";
            this.EDITGRUPODESCRICAO.Size = new System.Drawing.Size(368, 20);
            this.EDITGRUPODESCRICAO.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grupo do produto:";
            // 
            // EDITUNIDADE
            // 
            this.EDITUNIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITUNIDADE.Location = new System.Drawing.Point(512, 135);
            this.EDITUNIDADE.MaxLength = 8;
            this.EDITUNIDADE.Name = "EDITUNIDADE";
            this.EDITUNIDADE.Size = new System.Drawing.Size(47, 20);
            this.EDITUNIDADE.TabIndex = 7;
            this.EDITUNIDADE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unidade:";
            // 
            // lblNomeRazao
            // 
            this.lblNomeRazao.AutoSize = true;
            this.lblNomeRazao.Location = new System.Drawing.Point(12, 25);
            this.lblNomeRazao.Name = "lblNomeRazao";
            this.lblNomeRazao.Size = new System.Drawing.Size(112, 13);
            this.lblNomeRazao.TabIndex = 0;
            this.lblNomeRazao.Text = "Descrição do produto:";
            // 
            // Fproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 427);
            this.Controls.Add(this.EDITGRUPOCODIGO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EDITCODIGO);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(649, 466);
            this.MinimumSize = new System.Drawing.Size(649, 466);
            this.Name = "Fproduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Fproduto_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton BOTAOSAIR;
        private System.Windows.Forms.TextBox EDITGRUPOCODIGO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox EDITDATAULTIMASAIDA;
        private System.Windows.Forms.MaskedTextBox EDITDATAULTIMACOMPRA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        internal System.Windows.Forms.TextBox EDITCODIGO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EDITDESCRICAO;
        private System.Windows.Forms.Button BOTAOGRUPO;
        private System.Windows.Forms.TextBox EDITGRUPODESCRICAO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EDITUNIDADE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeRazao;
        private System.Windows.Forms.TextBox EDITCUSTO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox EDITSITUACAO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EDITCUSTOMEDIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDITESTOQUE;
        private System.Windows.Forms.Label label2;
    }
}