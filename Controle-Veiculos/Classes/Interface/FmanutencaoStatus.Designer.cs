namespace Controle_Veiculos.Classes.Interface
{
    partial class FmanutencaoStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmanutencaoStatus));
            this.label2 = new System.Windows.Forms.Label();
            this.BOTAOLOCALIZAR = new System.Windows.Forms.Button();
            this.gripStatusManutencao = new System.Windows.Forms.DataGridView();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.EDITVEINOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDITVEICODIGO = new System.Windows.Forms.TextBox();
            this.BOTASAIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gripStatusManutencao)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-64, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "VeiculoModelo";
            // 
            // BOTAOLOCALIZAR
            // 
            this.BOTAOLOCALIZAR.Location = new System.Drawing.Point(592, 34);
            this.BOTAOLOCALIZAR.Name = "BOTAOLOCALIZAR";
            this.BOTAOLOCALIZAR.Size = new System.Drawing.Size(75, 22);
            this.BOTAOLOCALIZAR.TabIndex = 30;
            this.BOTAOLOCALIZAR.Text = "Pesquisar";
            this.BOTAOLOCALIZAR.UseVisualStyleBackColor = true;
            this.BOTAOLOCALIZAR.Click += new System.EventHandler(this.BOTAOLOCALIZAR_Click);
            // 
            // gripStatusManutencao
            // 
            this.gripStatusManutencao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gripStatusManutencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gripStatusManutencao.Location = new System.Drawing.Point(12, 61);
            this.gripStatusManutencao.Name = "gripStatusManutencao";
            this.gripStatusManutencao.ReadOnly = true;
            this.gripStatusManutencao.Size = new System.Drawing.Size(738, 226);
            this.gripStatusManutencao.TabIndex = 29;
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.Image = global::Controle_Veiculos.Properties.Resources.Search_icon_v;
            this.btnVeiculo.Location = new System.Drawing.Point(457, 33);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(29, 22);
            this.btnVeiculo.TabIndex = 28;
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // EDITVEINOME
            // 
            this.EDITVEINOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITVEINOME.Enabled = false;
            this.EDITVEINOME.Location = new System.Drawing.Point(77, 33);
            this.EDITVEINOME.Name = "EDITVEINOME";
            this.EDITVEINOME.Size = new System.Drawing.Size(374, 20);
            this.EDITVEINOME.TabIndex = 27;
            this.EDITVEINOME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "VeiculoModelo";
            // 
            // EDITCODIGO
            // 
            this.EDITVEICODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITVEICODIGO.Enabled = false;
            this.EDITVEICODIGO.Location = new System.Drawing.Point(12, 33);
            this.EDITVEICODIGO.Name = "EDITCODIGO";
            this.EDITVEICODIGO.Size = new System.Drawing.Size(59, 20);
            this.EDITVEICODIGO.TabIndex = 25;
            this.EDITVEICODIGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BOTASAIR
            // 
            this.BOTASAIR.Location = new System.Drawing.Point(675, 34);
            this.BOTASAIR.Name = "BOTASAIR";
            this.BOTASAIR.Size = new System.Drawing.Size(75, 22);
            this.BOTASAIR.TabIndex = 31;
            this.BOTASAIR.Text = "Sair";
            this.BOTASAIR.UseVisualStyleBackColor = true;
            this.BOTASAIR.Click += new System.EventHandler(this.BOTASAIR_Click);
            // 
            // FmanutencaoStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 343);
            this.Controls.Add(this.BOTASAIR);
            this.Controls.Add(this.BOTAOLOCALIZAR);
            this.Controls.Add(this.gripStatusManutencao);
            this.Controls.Add(this.btnVeiculo);
            this.Controls.Add(this.EDITVEINOME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EDITVEICODIGO);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 382);
            this.Name = "FmanutencaoStatus";
            this.Text = "Status Manutencao";
            this.Load += new System.EventHandler(this.FmanutencaoStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gripStatusManutencao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BOTAOLOCALIZAR;
        private System.Windows.Forms.DataGridView gripStatusManutencao;
        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.TextBox EDITVEINOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDITVEICODIGO;
        private System.Windows.Forms.Button BOTASAIR;
    }
}