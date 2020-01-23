namespace Controle_Veiculos.Classes.Interface
{
    partial class FproLoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FproLoc));
            this.gridProLoc = new System.Windows.Forms.DataGridView();
            this.BOTAOPESQUISA = new System.Windows.Forms.Button();
            this.EDITPESQUISA = new System.Windows.Forms.TextBox();
            this.COMBOTIPOPESQUISA = new System.Windows.Forms.ComboBox();
            this.EDITPROCODIGO = new System.Windows.Forms.TextBox();
            this.BOTAOSAIR = new System.Windows.Forms.Button();
            this.LABELPESQUISA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProLoc
            // 
            this.gridProLoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridProLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProLoc.Location = new System.Drawing.Point(12, 39);
            this.gridProLoc.Name = "gridProLoc";
            this.gridProLoc.ReadOnly = true;
            this.gridProLoc.Size = new System.Drawing.Size(738, 292);
            this.gridProLoc.TabIndex = 13;
            this.gridProLoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProLoc_CellClick);
            // 
            // BOTAOPESQUISA
            // 
            this.BOTAOPESQUISA.Location = new System.Drawing.Point(600, 12);
            this.BOTAOPESQUISA.Name = "BOTAOPESQUISA";
            this.BOTAOPESQUISA.Size = new System.Drawing.Size(75, 23);
            this.BOTAOPESQUISA.TabIndex = 12;
            this.BOTAOPESQUISA.Text = "Pesquisar";
            this.BOTAOPESQUISA.UseVisualStyleBackColor = true;
            this.BOTAOPESQUISA.Click += new System.EventHandler(this.BOTAOPESQUISA_Click);
            // 
            // EDITPESQUISA
            // 
            this.EDITPESQUISA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPESQUISA.Location = new System.Drawing.Point(277, 15);
            this.EDITPESQUISA.Name = "EDITPESQUISA";
            this.EDITPESQUISA.Size = new System.Drawing.Size(317, 20);
            this.EDITPESQUISA.TabIndex = 11;
            this.EDITPESQUISA.Click += new System.EventHandler(this.EDITPESQUISA_Click);
            // 
            // COMBOTIPOPESQUISA
            // 
            this.COMBOTIPOPESQUISA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOTIPOPESQUISA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.COMBOTIPOPESQUISA.FormattingEnabled = true;
            this.COMBOTIPOPESQUISA.Items.AddRange(new object[] {
            "CODIGO",
            "DESCRICAO"});
            this.COMBOTIPOPESQUISA.Location = new System.Drawing.Point(150, 14);
            this.COMBOTIPOPESQUISA.Name = "COMBOTIPOPESQUISA";
            this.COMBOTIPOPESQUISA.Size = new System.Drawing.Size(121, 21);
            this.COMBOTIPOPESQUISA.TabIndex = 10;
            // 
            // EDITPROCODIGO
            // 
            this.EDITPROCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPROCODIGO.Location = new System.Drawing.Point(681, 50);
            this.EDITPROCODIGO.Name = "EDITPROCODIGO";
            this.EDITPROCODIGO.Size = new System.Drawing.Size(31, 20);
            this.EDITPROCODIGO.TabIndex = 14;
            this.EDITPROCODIGO.Visible = false;
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Location = new System.Drawing.Point(681, 12);
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOSAIR.TabIndex = 15;
            this.BOTAOSAIR.Text = "Sair";
            this.BOTAOSAIR.UseVisualStyleBackColor = true;
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // LABELPESQUISA
            // 
            this.LABELPESQUISA.AutoSize = true;
            this.LABELPESQUISA.Location = new System.Drawing.Point(9, 18);
            this.LABELPESQUISA.Name = "LABELPESQUISA";
            this.LABELPESQUISA.Size = new System.Drawing.Size(127, 13);
            this.LABELPESQUISA.TabIndex = 16;
            this.LABELPESQUISA.Text = "Selecione Tipo Pesquisa:";
            // 
            // FproLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 343);
            this.Controls.Add(this.LABELPESQUISA);
            this.Controls.Add(this.BOTAOSAIR);
            this.Controls.Add(this.EDITPROCODIGO);
            this.Controls.Add(this.gridProLoc);
            this.Controls.Add(this.BOTAOPESQUISA);
            this.Controls.Add(this.EDITPESQUISA);
            this.Controls.Add(this.COMBOTIPOPESQUISA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 382);
            this.Name = "FproLoc";
            this.Text = "Locazixao Produto";
            this.Load += new System.EventHandler(this.FproLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProLoc;
        private System.Windows.Forms.Button BOTAOPESQUISA;
        private System.Windows.Forms.TextBox EDITPESQUISA;
        private System.Windows.Forms.ComboBox COMBOTIPOPESQUISA;
        private System.Windows.Forms.TextBox EDITPROCODIGO;
        private System.Windows.Forms.Button BOTAOSAIR;
        private System.Windows.Forms.Label LABELPESQUISA;
    }
}