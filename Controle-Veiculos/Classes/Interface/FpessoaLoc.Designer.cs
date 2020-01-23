namespace Controle_Veiculos.Classes.View
{
    partial class FpessoaLoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FpessoaLoc));
            this.gridPessoaLoc = new System.Windows.Forms.DataGridView();
            this.BOTAOPESQUISA = new System.Windows.Forms.Button();
            this.EDITPESQUISA = new System.Windows.Forms.TextBox();
            this.COMBOTIPOPESQUISA = new System.Windows.Forms.ComboBox();
            this.EDITCODIGO = new System.Windows.Forms.TextBox();
            this.BOTAOSAIR = new System.Windows.Forms.Button();
            this.LABELPESQUISA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoaLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPessoaLoc
            // 
            this.gridPessoaLoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPessoaLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPessoaLoc.Location = new System.Drawing.Point(12, 39);
            this.gridPessoaLoc.Name = "gridPessoaLoc";
            this.gridPessoaLoc.ReadOnly = true;
            this.gridPessoaLoc.Size = new System.Drawing.Size(738, 292);
            this.gridPessoaLoc.TabIndex = 9;
            this.gridPessoaLoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPessoaLoc_CellClick_1);
            // 
            // BOTAOPESQUISA
            // 
            this.BOTAOPESQUISA.Location = new System.Drawing.Point(595, 10);
            this.BOTAOPESQUISA.Name = "BOTAOPESQUISA";
            this.BOTAOPESQUISA.Size = new System.Drawing.Size(75, 23);
            this.BOTAOPESQUISA.TabIndex = 8;
            this.BOTAOPESQUISA.Text = "Pesquisar";
            this.BOTAOPESQUISA.UseVisualStyleBackColor = true;
            //this.BOTAOPESQUISA.Click += new System.EventHandler(this.BOTAOPESQUISA_Click);
            // 
            // EDITPESQUISA
            // 
            this.EDITPESQUISA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPESQUISA.Location = new System.Drawing.Point(272, 13);
            this.EDITPESQUISA.Name = "EDITPESQUISA";
            this.EDITPESQUISA.Size = new System.Drawing.Size(317, 20);
            this.EDITPESQUISA.TabIndex = 7;
            this.EDITPESQUISA.Click += new System.EventHandler(this.EDITPESQUISA_Click);
            // 
            // COMBOTIPOPESQUISA
            // 
            this.COMBOTIPOPESQUISA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOTIPOPESQUISA.FormattingEnabled = true;
            this.COMBOTIPOPESQUISA.Items.AddRange(new object[] {
            "CODIGO",
            "NOME",
            "CPF",
            "CNPJ"});
            this.COMBOTIPOPESQUISA.Location = new System.Drawing.Point(145, 13);
            this.COMBOTIPOPESQUISA.Name = "COMBOTIPOPESQUISA";
            this.COMBOTIPOPESQUISA.Size = new System.Drawing.Size(121, 21);
            this.COMBOTIPOPESQUISA.TabIndex = 6;
            // 
            // EDITCODIGO
            // 
            this.EDITCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCODIGO.Location = new System.Drawing.Point(724, 89);
            this.EDITCODIGO.Name = "EDITCODIGO";
            this.EDITCODIGO.Size = new System.Drawing.Size(12, 20);
            this.EDITCODIGO.TabIndex = 10;
            this.EDITCODIGO.Visible = false;
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Location = new System.Drawing.Point(676, 10);
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOSAIR.TabIndex = 11;
            this.BOTAOSAIR.Text = "Sair";
            this.BOTAOSAIR.UseVisualStyleBackColor = true;
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // LABELPESQUISA
            // 
            this.LABELPESQUISA.AutoSize = true;
            this.LABELPESQUISA.Location = new System.Drawing.Point(12, 15);
            this.LABELPESQUISA.Name = "LABELPESQUISA";
            this.LABELPESQUISA.Size = new System.Drawing.Size(127, 13);
            this.LABELPESQUISA.TabIndex = 12;
            this.LABELPESQUISA.Text = "Selecione Tipo Pesquisa:";
            // 
            // FpessoaLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 343);
            this.Controls.Add(this.LABELPESQUISA);
            this.Controls.Add(this.BOTAOSAIR);
            this.Controls.Add(this.EDITCODIGO);
            this.Controls.Add(this.gridPessoaLoc);
            this.Controls.Add(this.BOTAOPESQUISA);
            this.Controls.Add(this.EDITPESQUISA);
            this.Controls.Add(this.COMBOTIPOPESQUISA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 382);
            this.Name = "FpessoaLoc";
            this.Text = "Localiza Pessoa";
            this.Load += new System.EventHandler(this.FpessoaLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoaLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPessoaLoc;
        private System.Windows.Forms.Button BOTAOPESQUISA;
        private System.Windows.Forms.TextBox EDITPESQUISA;
        private System.Windows.Forms.ComboBox COMBOTIPOPESQUISA;
        private System.Windows.Forms.TextBox EDITCODIGO;
        private System.Windows.Forms.Button BOTAOSAIR;
        private System.Windows.Forms.Label LABELPESQUISA;
    }
}