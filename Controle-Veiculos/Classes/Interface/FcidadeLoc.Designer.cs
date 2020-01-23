namespace Controle_Veiculos.Classes.Interface
{
    partial class FcidadeLoc
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
            this.LABELPESQUISA = new System.Windows.Forms.Label();
            this.EDITPROCODIGO = new System.Windows.Forms.TextBox();
            this.gridMotoristaLoc = new System.Windows.Forms.DataGridView();
            this.EDITPESQUISA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMotoristaLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // LABELPESQUISA
            // 
            this.LABELPESQUISA.AutoSize = true;
            this.LABELPESQUISA.Location = new System.Drawing.Point(9, 11);
            this.LABELPESQUISA.Name = "LABELPESQUISA";
            this.LABELPESQUISA.Size = new System.Drawing.Size(142, 13);
            this.LABELPESQUISA.TabIndex = 28;
            this.LABELPESQUISA.Text = "DIGITE NOME DA CIDADE:";
            // 
            // EDITPROCODIGO
            // 
            this.EDITPROCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPROCODIGO.Location = new System.Drawing.Point(719, 34);
            this.EDITPROCODIGO.Name = "EDITPROCODIGO";
            this.EDITPROCODIGO.Size = new System.Drawing.Size(31, 20);
            this.EDITPROCODIGO.TabIndex = 27;
            this.EDITPROCODIGO.Visible = false;
            // 
            // gridMotoristaLoc
            // 
            this.gridMotoristaLoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMotoristaLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMotoristaLoc.Location = new System.Drawing.Point(12, 32);
            this.gridMotoristaLoc.Name = "gridMotoristaLoc";
            this.gridMotoristaLoc.ReadOnly = true;
            this.gridMotoristaLoc.Size = new System.Drawing.Size(738, 292);
            this.gridMotoristaLoc.TabIndex = 26;
            this.gridMotoristaLoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMotoristaLoc_CellClick);
            // 
            // EDITPESQUISA
            // 
            this.EDITPESQUISA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITPESQUISA.Location = new System.Drawing.Point(154, 6);
            this.EDITPESQUISA.Name = "EDITPESQUISA";
            this.EDITPESQUISA.Size = new System.Drawing.Size(593, 20);
            this.EDITPESQUISA.TabIndex = 24;
            this.EDITPESQUISA.TextChanged += new System.EventHandler(this.EDITPESQUISA_TextChanged);
            // 
            // FcidadeLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 343);
            this.Controls.Add(this.LABELPESQUISA);
            this.Controls.Add(this.EDITPROCODIGO);
            this.Controls.Add(this.gridMotoristaLoc);
            this.Controls.Add(this.EDITPESQUISA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 382);
            this.Name = "FcidadeLoc";
            this.Text = "Localizar Cidade";
            this.Load += new System.EventHandler(this.FmotoristaLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMotoristaLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABELPESQUISA;
        private System.Windows.Forms.TextBox EDITPROCODIGO;
        private System.Windows.Forms.DataGridView gridMotoristaLoc;
        private System.Windows.Forms.TextBox EDITPESQUISA;

    }
}