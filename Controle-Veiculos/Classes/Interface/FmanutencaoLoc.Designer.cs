namespace Controle_Veiculos.Classes.Interface
{
    partial class FmanutencaoLoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmanutencaoLoc));
            this.LABELPESQUISA = new System.Windows.Forms.Label();
            this.BOTAOSAIR = new System.Windows.Forms.Button();
            this.EDITPROCODIGO = new System.Windows.Forms.TextBox();
            this.gridManutencao = new System.Windows.Forms.DataGridView();
            this.BOTAOPESQUISA = new System.Windows.Forms.Button();
            this.EDITPESQUISA = new System.Windows.Forms.TextBox();
            this.COMBOTIPOPESQUISA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridManutencao)).BeginInit();
            this.SuspendLayout();
            // 
            // LABELPESQUISA
            // 
            this.LABELPESQUISA.AutoSize = true;
            this.LABELPESQUISA.Location = new System.Drawing.Point(9, 11);
            this.LABELPESQUISA.Name = "LABELPESQUISA";
            this.LABELPESQUISA.Size = new System.Drawing.Size(127, 13);
            this.LABELPESQUISA.TabIndex = 30;
            this.LABELPESQUISA.Text = "Selecione Tipo Pesquisa:";
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Location = new System.Drawing.Point(673, 8);
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOSAIR.TabIndex = 29;
            this.BOTAOSAIR.Text = "Sair";
            this.BOTAOSAIR.UseVisualStyleBackColor = true;
            // 
            // EDITPROCODIGO
            // 
            this.EDITPROCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPROCODIGO.Location = new System.Drawing.Point(703, 304);
            this.EDITPROCODIGO.Name = "EDITPROCODIGO";
            this.EDITPROCODIGO.Size = new System.Drawing.Size(31, 20);
            this.EDITPROCODIGO.TabIndex = 28;
            this.EDITPROCODIGO.Visible = false;
            // 
            // gridManutencao
            // 
            this.gridManutencao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridManutencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManutencao.Location = new System.Drawing.Point(12, 39);
            this.gridManutencao.Name = "gridManutencao";
            this.gridManutencao.ReadOnly = true;
            this.gridManutencao.Size = new System.Drawing.Size(738, 292);
            this.gridManutencao.TabIndex = 27;
            this.gridManutencao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLocLoc_CellClick);
            // 
            // BOTAOPESQUISA
            // 
            this.BOTAOPESQUISA.Location = new System.Drawing.Point(592, 7);
            this.BOTAOPESQUISA.Name = "BOTAOPESQUISA";
            this.BOTAOPESQUISA.Size = new System.Drawing.Size(75, 23);
            this.BOTAOPESQUISA.TabIndex = 26;
            this.BOTAOPESQUISA.Text = "Pesquisar";
            this.BOTAOPESQUISA.UseVisualStyleBackColor = true;
            this.BOTAOPESQUISA.Click += new System.EventHandler(this.BOTAOPESQUISA_Click);
            // 
            // EDITPESQUISA
            // 
            this.EDITPESQUISA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPESQUISA.Location = new System.Drawing.Point(269, 9);
            this.EDITPESQUISA.Name = "EDITPESQUISA";
            this.EDITPESQUISA.Size = new System.Drawing.Size(317, 20);
            this.EDITPESQUISA.TabIndex = 25;
            // 
            // COMBOTIPOPESQUISA
            // 
            this.COMBOTIPOPESQUISA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOTIPOPESQUISA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.COMBOTIPOPESQUISA.FormattingEnabled = true;
            this.COMBOTIPOPESQUISA.Items.AddRange(new object[] {
            "Código",
            "Placa"});
            this.COMBOTIPOPESQUISA.Location = new System.Drawing.Point(142, 8);
            this.COMBOTIPOPESQUISA.Name = "COMBOTIPOPESQUISA";
            this.COMBOTIPOPESQUISA.Size = new System.Drawing.Size(121, 21);
            this.COMBOTIPOPESQUISA.TabIndex = 24;
            // 
            // FmanutencaoLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 343);
            this.Controls.Add(this.LABELPESQUISA);
            this.Controls.Add(this.BOTAOSAIR);
            this.Controls.Add(this.EDITPROCODIGO);
            this.Controls.Add(this.gridManutencao);
            this.Controls.Add(this.BOTAOPESQUISA);
            this.Controls.Add(this.EDITPESQUISA);
            this.Controls.Add(this.COMBOTIPOPESQUISA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 382);
            this.Name = "FmanutencaoLoc";
            this.Text = "Localizar Manutencao";
            ((System.ComponentModel.ISupportInitialize)(this.gridManutencao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABELPESQUISA;
        private System.Windows.Forms.Button BOTAOSAIR;
        private System.Windows.Forms.TextBox EDITPROCODIGO;
        private System.Windows.Forms.DataGridView gridManutencao;
        private System.Windows.Forms.Button BOTAOPESQUISA;
        private System.Windows.Forms.TextBox EDITPESQUISA;
        private System.Windows.Forms.ComboBox COMBOTIPOPESQUISA;
    }
}