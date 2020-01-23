namespace Controle_Veiculos.Classes.Interface
{
    partial class FcompraLoc
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
            this.EDITCODIGO = new System.Windows.Forms.TextBox();
            this.LABELPESQUISA = new System.Windows.Forms.Label();
            this.BOTAOSAIR = new System.Windows.Forms.Button();
            this.gridLocacaoLoc = new System.Windows.Forms.DataGridView();
            this.BOTAOPESQUISA = new System.Windows.Forms.Button();
            this.EDITPESQUISA = new System.Windows.Forms.TextBox();
            this.COMBOTIPOPESQUISA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocacaoLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // EDITCODIGO
            // 
            this.EDITCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCODIGO.Location = new System.Drawing.Point(725, 57);
            this.EDITCODIGO.Name = "EDITCODIGO";
            this.EDITCODIGO.Size = new System.Drawing.Size(31, 20);
            this.EDITCODIGO.TabIndex = 44;
            this.EDITCODIGO.Visible = false;
            // 
            // LABELPESQUISA
            // 
            this.LABELPESQUISA.AutoSize = true;
            this.LABELPESQUISA.Location = new System.Drawing.Point(9, 19);
            this.LABELPESQUISA.Name = "LABELPESQUISA";
            this.LABELPESQUISA.Size = new System.Drawing.Size(127, 13);
            this.LABELPESQUISA.TabIndex = 43;
            this.LABELPESQUISA.Text = "Selecione Tipo Pesquisa:";
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Location = new System.Drawing.Point(681, 16);
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOSAIR.TabIndex = 42;
            this.BOTAOSAIR.Text = "Sair";
            this.BOTAOSAIR.UseVisualStyleBackColor = true;
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // gridLocacaoLoc
            // 
            this.gridLocacaoLoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridLocacaoLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocacaoLoc.Location = new System.Drawing.Point(12, 40);
            this.gridLocacaoLoc.Name = "gridLocacaoLoc";
            this.gridLocacaoLoc.ReadOnly = true;
            this.gridLocacaoLoc.Size = new System.Drawing.Size(744, 292);
            this.gridLocacaoLoc.TabIndex = 41;
            this.gridLocacaoLoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLocacaoLoc_CellClick_1);
            // 
            // BOTAOPESQUISA
            // 
            this.BOTAOPESQUISA.Location = new System.Drawing.Point(600, 16);
            this.BOTAOPESQUISA.Name = "BOTAOPESQUISA";
            this.BOTAOPESQUISA.Size = new System.Drawing.Size(75, 23);
            this.BOTAOPESQUISA.TabIndex = 40;
            this.BOTAOPESQUISA.Text = "Pesquisar";
            this.BOTAOPESQUISA.UseVisualStyleBackColor = true;
            this.BOTAOPESQUISA.Click += new System.EventHandler(this.BOTAOPESQUISA_Click);
            // 
            // EDITPESQUISA
            // 
            this.EDITPESQUISA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPESQUISA.Location = new System.Drawing.Point(277, 16);
            this.EDITPESQUISA.Name = "EDITPESQUISA";
            this.EDITPESQUISA.Size = new System.Drawing.Size(317, 20);
            this.EDITPESQUISA.TabIndex = 39;
            // 
            // COMBOTIPOPESQUISA
            // 
            this.COMBOTIPOPESQUISA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOTIPOPESQUISA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.COMBOTIPOPESQUISA.FormattingEnabled = true;
            this.COMBOTIPOPESQUISA.Items.AddRange(new object[] {
            "Nº compra",
            "Data da compra",
            "Código do fornecedor"});
            this.COMBOTIPOPESQUISA.Location = new System.Drawing.Point(150, 15);
            this.COMBOTIPOPESQUISA.Name = "COMBOTIPOPESQUISA";
            this.COMBOTIPOPESQUISA.Size = new System.Drawing.Size(121, 21);
            this.COMBOTIPOPESQUISA.TabIndex = 38;
            // 
            // FcompraLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 346);
            this.Controls.Add(this.EDITCODIGO);
            this.Controls.Add(this.LABELPESQUISA);
            this.Controls.Add(this.BOTAOSAIR);
            this.Controls.Add(this.gridLocacaoLoc);
            this.Controls.Add(this.BOTAOPESQUISA);
            this.Controls.Add(this.EDITPESQUISA);
            this.Controls.Add(this.COMBOTIPOPESQUISA);
            this.MaximumSize = new System.Drawing.Size(787, 385);
            this.MinimumSize = new System.Drawing.Size(787, 385);
            this.Name = "FcompraLoc";
            this.Text = "Pesquisa Compras";
            this.Load += new System.EventHandler(this.FcompraLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocacaoLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EDITCODIGO;
        private System.Windows.Forms.Label LABELPESQUISA;
        private System.Windows.Forms.Button BOTAOSAIR;
        private System.Windows.Forms.DataGridView gridLocacaoLoc;
        private System.Windows.Forms.Button BOTAOPESQUISA;
        private System.Windows.Forms.TextBox EDITPESQUISA;
        private System.Windows.Forms.ComboBox COMBOTIPOPESQUISA;
    }
}