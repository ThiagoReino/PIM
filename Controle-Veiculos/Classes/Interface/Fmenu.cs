using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Interface;


namespace Controle_Veiculos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMotorista Pessoafrm = new frmMotorista();
            Pessoafrm.ShowDialog();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculo Veiculofrm = new frmVeiculo();
            Veiculofrm.ShowDialog();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLocacao Locacaofrm = new FLocacao();
            Locacaofrm.ShowDialog();
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ffornecedor fornecedor = new Ffornecedor();
            fornecedor.ShowDialog();
        }

        private void gRUPODEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGrupo grupo = new FGrupo();
            grupo.ShowDialog();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fproduto produto = new Fproduto();
            produto.ShowDialog();
        }

        private void rotaToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            FRota rota = new FRota();
            rota.ShowDialog();
        }

        private void mARCAMODELOVEÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMarcamodelo marcamodelo = new FMarcamodelo();
            marcamodelo.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
          
        }

        private void sEGURADORASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSeguradora seguradora = new FSeguradora();
            seguradora.ShowDialog();
        }

        private void cOMPRADEPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcompra compra = new Fcompra();
            compra.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oCORRENÇIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Focorrencia ocorrencia = new Focorrencia();
            ocorrencia.ShowDialog();
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmanutencao frmmanutencao = new Fmanutencao();
            frmmanutencao.ShowDialog();
        }

        private void sERVIÇOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fservicos servicos = new Fservicos();
            servicos.ShowDialog();
        }

        private void nOVOEMAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Femail email = new Femail();
            email.ShowDialog();
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FcompraRel relatorioCompra = new FcompraRel();
            relatorioCompra.ShowDialog();
        }
    }
}
