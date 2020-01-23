namespace Controle_Veiculos.Classes.Interface
{
    partial class FveiculoStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FveiculoStatus));
            this.EDITVEINOME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EDITVEICODIGO = new System.Windows.Forms.TextBox();
            this.EDITCADNOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDITCADCODIGO = new System.Windows.Forms.TextBox();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.btnCondutor = new System.Windows.Forms.Button();
            this.gripStatusRota = new System.Windows.Forms.DataGridView();
            this.BOTAOLOCALIZAR = new System.Windows.Forms.Button();
            this.MASKDATAFIM = new System.Windows.Forms.DateTimePicker();
            this.MASKDATAINICIO = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.lblVecimentoContrato = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHECKPESQUISA = new System.Windows.Forms.CheckBox();
            this.BOTAOSAIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gripStatusRota)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EDITVEINOME
            // 
            this.EDITVEINOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITVEINOME.Enabled = false;
            this.EDITVEINOME.Location = new System.Drawing.Point(80, 75);
            this.EDITVEINOME.Name = "EDITVEINOME";
            this.EDITVEINOME.Size = new System.Drawing.Size(374, 20);
            this.EDITVEINOME.TabIndex = 19;
            this.EDITVEINOME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "VeiculoModelo";
            // 
            // EDITCODIGO
            // 
            this.EDITVEICODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITVEICODIGO.Enabled = false;
            this.EDITVEICODIGO.Location = new System.Drawing.Point(15, 75);
            this.EDITVEICODIGO.Name = "EDITCODIGO";
            this.EDITVEICODIGO.Size = new System.Drawing.Size(59, 20);
            this.EDITVEICODIGO.TabIndex = 17;
            this.EDITVEICODIGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EDITCADNOME
            // 
            this.EDITCADNOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCADNOME.Enabled = false;
            this.EDITCADNOME.Location = new System.Drawing.Point(80, 26);
            this.EDITCADNOME.Name = "EDITCADNOME";
            this.EDITCADNOME.Size = new System.Drawing.Size(374, 20);
            this.EDITCADNOME.TabIndex = 15;
            this.EDITCADNOME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Condutor";
            // 
            // EDITCADCODIGO
            // 
            this.EDITCADCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDITCADCODIGO.Enabled = false;
            this.EDITCADCODIGO.Location = new System.Drawing.Point(15, 26);
            this.EDITCADCODIGO.Name = "EDITCADCODIGO";
            this.EDITCADCODIGO.Size = new System.Drawing.Size(59, 20);
            this.EDITCADCODIGO.TabIndex = 13;
            this.EDITCADCODIGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.Image = global::Controle_Veiculos.Properties.Resources.Search_icon_v;
            this.btnVeiculo.Location = new System.Drawing.Point(470, 75);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(29, 23);
            this.btnVeiculo.TabIndex = 20;
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // btnCondutor
            // 
            this.btnCondutor.Image = global::Controle_Veiculos.Properties.Resources.Search_icon_v;
            this.btnCondutor.Location = new System.Drawing.Point(470, 26);
            this.btnCondutor.Name = "btnCondutor";
            this.btnCondutor.Size = new System.Drawing.Size(29, 23);
            this.btnCondutor.TabIndex = 16;
            this.btnCondutor.UseVisualStyleBackColor = true;
            this.btnCondutor.Click += new System.EventHandler(this.btnCondutor_Click);
            // 
            // gripStatusRota
            // 
            this.gripStatusRota.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gripStatusRota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gripStatusRota.Location = new System.Drawing.Point(12, 159);
            this.gripStatusRota.Name = "gripStatusRota";
            this.gripStatusRota.ReadOnly = true;
            this.gripStatusRota.Size = new System.Drawing.Size(738, 172);
            this.gripStatusRota.TabIndex = 21;
            // 
            // BOTAOLOCALIZAR
            // 
            this.BOTAOLOCALIZAR.Location = new System.Drawing.Point(583, 125);
            this.BOTAOLOCALIZAR.Name = "BOTAOLOCALIZAR";
            this.BOTAOLOCALIZAR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOLOCALIZAR.TabIndex = 22;
            this.BOTAOLOCALIZAR.Text = "Pesquisar";
            this.BOTAOLOCALIZAR.UseVisualStyleBackColor = true;
            this.BOTAOLOCALIZAR.Click += new System.EventHandler(this.BOTAOLOCALIZAR_Click);
            // 
            // MASKDATAFIM
            // 
            this.MASKDATAFIM.CustomFormat = "yyyy-MM-dd";
            this.MASKDATAFIM.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.MASKDATAFIM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MASKDATAFIM.Location = new System.Drawing.Point(315, 24);
            this.MASKDATAFIM.Name = "MASKDATAFIM";
            this.MASKDATAFIM.Size = new System.Drawing.Size(118, 20);
            this.MASKDATAFIM.TabIndex = 26;
            // 
            // MASKDATAINICIO
            // 
            this.MASKDATAINICIO.CustomFormat = "yyyy-MM-dd";
            this.MASKDATAINICIO.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.MASKDATAINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MASKDATAINICIO.Location = new System.Drawing.Point(126, 24);
            this.MASKDATAINICIO.Name = "MASKDATAINICIO";
            this.MASKDATAINICIO.Size = new System.Drawing.Size(118, 20);
            this.MASKDATAINICIO.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(250, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Data Fim";
            // 
            // lblVecimentoContrato
            // 
            this.lblVecimentoContrato.AutoSize = true;
            this.lblVecimentoContrato.Location = new System.Drawing.Point(62, 26);
            this.lblVecimentoContrato.Name = "lblVecimentoContrato";
            this.lblVecimentoContrato.Size = new System.Drawing.Size(58, 13);
            this.lblVecimentoContrato.TabIndex = 23;
            this.lblVecimentoContrato.Text = "Data Inicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHECKPESQUISA);
            this.groupBox1.Controls.Add(this.MASKDATAFIM);
            this.groupBox1.Controls.Add(this.MASKDATAINICIO);
            this.groupBox1.Controls.Add(this.lblVecimentoContrato);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(15, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 52);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por data";
            // 
            // CHECKPESQUISA
            // 
            this.CHECKPESQUISA.AutoSize = true;
            this.CHECKPESQUISA.Location = new System.Drawing.Point(41, 26);
            this.CHECKPESQUISA.Name = "CHECKPESQUISA";
            this.CHECKPESQUISA.Size = new System.Drawing.Size(15, 14);
            this.CHECKPESQUISA.TabIndex = 0;
            this.CHECKPESQUISA.UseVisualStyleBackColor = true;
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Location = new System.Drawing.Point(675, 125);
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOSAIR.TabIndex = 28;
            this.BOTAOSAIR.Text = "Sair";
            this.BOTAOSAIR.UseVisualStyleBackColor = true;
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // FveiculoStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 343);
            this.Controls.Add(this.BOTAOSAIR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BOTAOLOCALIZAR);
            this.Controls.Add(this.gripStatusRota);
            this.Controls.Add(this.btnVeiculo);
            this.Controls.Add(this.EDITVEINOME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EDITVEICODIGO);
            this.Controls.Add(this.btnCondutor);
            this.Controls.Add(this.EDITCADNOME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EDITCADCODIGO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 382);
            this.Name = "FveiculoStatus";
            this.Text = "Status Rota";
            ((System.ComponentModel.ISupportInitialize)(this.gripStatusRota)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.TextBox EDITVEINOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDITVEICODIGO;
        private System.Windows.Forms.Button btnCondutor;
        private System.Windows.Forms.TextBox EDITCADNOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDITCADCODIGO;
        private System.Windows.Forms.DataGridView gripStatusRota;
        private System.Windows.Forms.Button BOTAOLOCALIZAR;
        private System.Windows.Forms.DateTimePicker MASKDATAFIM;
        private System.Windows.Forms.DateTimePicker MASKDATAINICIO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblVecimentoContrato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CHECKPESQUISA;
        private System.Windows.Forms.Button BOTAOSAIR;
    }
}