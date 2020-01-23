namespace Controle_Veiculos.Classes.Interface
{
    partial class frmVeiculoLoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculoLoc));
            this.COMBOTIPOPESQUISA = new System.Windows.Forms.ComboBox();
            this.BOTAOPESQUISA = new System.Windows.Forms.Button();
            this.gridVeiculoLoc = new System.Windows.Forms.DataGridView();
            this.EDITCODIGO = new System.Windows.Forms.TextBox();
            this.BOTAOSAIR = new System.Windows.Forms.Button();
            this.EDITPESQUISA = new System.Windows.Forms.TextBox();
            this.LABELPESQUISA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculoLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // COMBOTIPOPESQUISA
            // 
            this.COMBOTIPOPESQUISA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOTIPOPESQUISA.FormattingEnabled = true;
            this.COMBOTIPOPESQUISA.Items.AddRange(new object[] {
            "NOME",
            "PLACA"});
            this.COMBOTIPOPESQUISA.Location = new System.Drawing.Point(144, 14);
            this.COMBOTIPOPESQUISA.Name = "COMBOTIPOPESQUISA";
            this.COMBOTIPOPESQUISA.Size = new System.Drawing.Size(121, 21);
            this.COMBOTIPOPESQUISA.TabIndex = 1;
            // 
            // BOTAOPESQUISA
            // 
            this.BOTAOPESQUISA.Location = new System.Drawing.Point(594, 12);
            this.BOTAOPESQUISA.Name = "BOTAOPESQUISA";
            this.BOTAOPESQUISA.Size = new System.Drawing.Size(75, 23);
            this.BOTAOPESQUISA.TabIndex = 4;
            this.BOTAOPESQUISA.Text = "Pesquisar";
            this.BOTAOPESQUISA.UseVisualStyleBackColor = true;
            this.BOTAOPESQUISA.Click += new System.EventHandler(this.BOTAOPESQUISA_Click);
            // 
            // gridVeiculoLoc
            // 
            this.gridVeiculoLoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridVeiculoLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVeiculoLoc.Location = new System.Drawing.Point(12, 41);
            this.gridVeiculoLoc.Name = "gridVeiculoLoc";
            this.gridVeiculoLoc.ReadOnly = true;
            this.gridVeiculoLoc.Size = new System.Drawing.Size(738, 290);
            this.gridVeiculoLoc.TabIndex = 5;
            this.gridVeiculoLoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVeiculoLoc_CellClick);
            // 
            // EDITCODIGO
            // 
            this.EDITCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCODIGO.Location = new System.Drawing.Point(714, 61);
            this.EDITCODIGO.Name = "EDITCODIGO";
            this.EDITCODIGO.Size = new System.Drawing.Size(36, 20);
            this.EDITCODIGO.TabIndex = 7;
            this.EDITCODIGO.Visible = false;
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Location = new System.Drawing.Point(675, 12);
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOSAIR.TabIndex = 8;
            this.BOTAOSAIR.Text = "Sair";
            this.BOTAOSAIR.UseVisualStyleBackColor = true;
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // EDITPESQUISA
            // 
            this.EDITPESQUISA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPESQUISA.Location = new System.Drawing.Point(271, 14);
            this.EDITPESQUISA.Name = "EDITPESQUISA";
            this.EDITPESQUISA.Size = new System.Drawing.Size(317, 20);
            this.EDITPESQUISA.TabIndex = 3;
            this.EDITPESQUISA.Click += new System.EventHandler(this.EDITPESQUISA_Click);
            // 
            // LABELPESQUISA
            // 
            this.LABELPESQUISA.AutoSize = true;
            this.LABELPESQUISA.Location = new System.Drawing.Point(12, 14);
            this.LABELPESQUISA.Name = "LABELPESQUISA";
            this.LABELPESQUISA.Size = new System.Drawing.Size(127, 13);
            this.LABELPESQUISA.TabIndex = 13;
            this.LABELPESQUISA.Text = "Selecione Tipo Pesquisa:";
            // 
            // frmVeiculoLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 343);
            this.Controls.Add(this.LABELPESQUISA);
            this.Controls.Add(this.BOTAOSAIR);
            this.Controls.Add(this.EDITCODIGO);
            this.Controls.Add(this.gridVeiculoLoc);
            this.Controls.Add(this.BOTAOPESQUISA);
            this.Controls.Add(this.EDITPESQUISA);
            this.Controls.Add(this.COMBOTIPOPESQUISA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 382);
            this.Name = "frmVeiculoLoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Localiza VeiculoModelo";
            this.Load += new System.EventHandler(this.frmVeiculoLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculoLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COMBOTIPOPESQUISA;
        private System.Windows.Forms.Button BOTAOPESQUISA;
        private System.Windows.Forms.DataGridView gridVeiculoLoc;
        private System.Windows.Forms.TextBox EDITCODIGO;
        private System.Windows.Forms.Button BOTAOSAIR;
        private System.Windows.Forms.TextBox EDITPESQUISA;
        private System.Windows.Forms.Label LABELPESQUISA;
    }
}