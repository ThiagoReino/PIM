using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Interface;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FLocacao : Form
    {
        public FLocacao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BOTAOLOCALIZARVEICULO_Click(object sender, EventArgs e)
        {
            frmVeiculoLoc veiculoFrmLoc = new frmVeiculoLoc();
            veiculoFrmLoc.ShowDialog();
            if (veiculoFrmLoc.codigoretornado != "" && veiculoFrmLoc.codigoretornado != null)
            {
                VeiculoModelo veiculo = new VeiculoModelo();
                veiculo.codigo = int.Parse(veiculoFrmLoc.codigoretornado);
                VeiculoControle veiccontrole = new VeiculoControle();
                veiculo = veiccontrole.atualizatela(veiculo);
                if (veiculo.codigo > 0)
                {
                    EDITVEICULOCODIGO.Text = Convert.ToString(veiculo.codigo);
                    EDITVEICULOPLACA.Text = veiculo.placa;
                    EDITVEICULOANOFABRICA.Text = Convert.ToString(veiculo.anomodelo);
                    EDITVEICULOANOMODELO.Text = Convert.ToString(veiculo.anomodelo);
                    EDITVEICULOCHASSI.Text = veiculo.chassi;
                    EDITVEICULOCOMBUSTIVEL.Text = veiculo.combustivel;

                    MarcamodeloModelo Marcacontrole = new MarcamodeloModelo();
                    Marcacontrole.codigo = veiculo.marcamodelocodigo;
                    MarcamodeloControle marcamodcontrole = new MarcamodeloControle();
                    Marcacontrole = marcamodcontrole.pesquisaMarca(Marcacontrole);
                    if (Marcacontrole.codigo > 0)
                    {
                        EDITMARCAMODELOCODIGO.Text = Convert.ToString(Marcacontrole.codigo);
                        EDITMARCAMODELODESCRICAO.Text = Marcacontrole.descricao;
                    }
                }
            }

        }

        public void limpaTela()
        {
            EDITCONTROLE.Clear();
            EDITVEICULOCODIGO.Clear();
            EDITVEICULOPLACA.Clear();
            EDITVEICULOANOFABRICA.Clear();
            EDITVEICULOANOMODELO.Clear();
            EDITVEICULOCHASSI.Clear();
            EDITVEICULOCOMBUSTIVEL.Clear();
            EDITMARCAMODELOCODIGO.Clear();
            EDITMARCAMODELODESCRICAO.Clear();
            EDITDATAINICIOLOCACAO.Clear();
            EDITDATAFIMLOCACAO.Clear();
        }

        private void EDITDATAFIMLOCACAO_DragLeave(object sender, EventArgs e)
        {
            if (EDITDATAFIMLOCACAO.Text != "" && EDITDATAFIMLOCACAO.Text != null)
            {
                DateTime wdt;
                try
                {
                    wdt = Convert.ToDateTime(EDITDATAFIMLOCACAO.Text);
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString(), "Erro com a data informada.");
                    EDITDATAFIMLOCACAO.Clear();
                    EDITDATAFIMLOCACAO.Focus();
                }
            }
        }

        private void BOTAONOVOMANUTENCAO_Click(object sender, EventArgs e)
        {
            BOTAOSALVAR.Enabled = true;
            BOTAOLOCALIZAR.Enabled = true;
            BOTAONOVO.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
            limpaTela();
        }

        private void BOTAOLIMPATELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            FLocacaoLoc locacaoFrmLoc = new FLocacaoLoc();
            locacaoFrmLoc.ShowDialog();

            if (locacaoFrmLoc.codigoretornado != "" && locacaoFrmLoc.codigoretornado != null)
            {
                LocacaoModelo locacao = new LocacaoModelo();
                locacao.controle = Convert.ToInt32(locacaoFrmLoc.codigoretornado);
                LocacaoControle locacaocontrole = new LocacaoControle();
                locacao = locacaocontrole.atualizatela(locacao);

                if (locacao.controle > 0)
                {
                    EDITCONTROLE.Text = Convert.ToString(locacao.controle);
                    EDITDATAINICIOLOCACAO.Text = Convert.ToString(locacao.datainiciolocacao);
                    EDITDATAFIMLOCACAO.Text = Convert.ToString(locacao.datafimlocacao);
                    //Convert.ToDecimal(EDITVALORLOCACAO.Text = Convert.ToString(locacao.valorlocacao));
                    EDITVALORLOCACAO.Text = Convert.ToDecimal(locacao.valorlocacao).ToString("C");

                    if (locacao.veiculocodigo > 0)
                    {
                        VeiculoModelo veiculo = new VeiculoModelo();
                        VeiculoControle veiculoControle = new VeiculoControle();
                        veiculo.codigo = locacao.veiculocodigo;

                        veiculo = veiculoControle.atualizatela(veiculo);
                        EDITVEICULOCODIGO.Text = Convert.ToString(veiculo.codigo);
                        EDITMARCAMODELOCODIGO.Text = Convert.ToString(veiculo.marcamodelocodigo);
                        EDITVEICULOPLACA.Text = veiculo.placa;
                        EDITVEICULOCHASSI.Text = veiculo.chassi;
                        EDITVEICULOCOMBUSTIVEL.Text = veiculo.combustivel;
                        EDITVEICULOANOFABRICA.Text = Convert.ToString(veiculo.anofabrica);
                        EDITVEICULOANOMODELO.Text = Convert.ToString(veiculo.anomodelo);
                        if (veiculo.marcamodelocodigo > 0)
                        {
                            MarcamodeloModelo marca = new MarcamodeloModelo();
                            marca.codigo = veiculo.marcamodelocodigo;
                            MarcamodeloControle marcaControle = new MarcamodeloControle();
                            marca = marcaControle.pesquisaMarca(marca);
                            EDITMARCAMODELOCODIGO.Text = Convert.ToString(marca.codigo);
                            EDITMARCAMODELODESCRICAO.Text = marca.descricao;
                        }
                    }
                }
            }
        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                LocacaoModelo locacao = new LocacaoModelo();
                Funcoes funcoes = new Funcoes();

                if (EDITCONTROLE.Text != "" && EDITCONTROLE.Text != null)
                {
                    locacao.controle = Convert.ToInt32(EDITCONTROLE.Text);
                }
                if (EDITVEICULOCODIGO.Text != "" && EDITVEICULOCODIGO.Text != null)
                {
                    locacao.veiculocodigo = Convert.ToInt32(EDITVEICULOCODIGO.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATAINICIOLOCACAO.Text) != "" && funcoes.ApenasNumeros(EDITDATAINICIOLOCACAO.Text) != null)
                {
                    locacao.datainiciolocacao = Convert.ToDateTime(EDITDATAINICIOLOCACAO.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATAFIMLOCACAO.Text) != "" && funcoes.ApenasNumeros(EDITDATAFIMLOCACAO.Text) != null)
                {
                    locacao.datafimlocacao = Convert.ToDateTime(EDITDATAFIMLOCACAO.Text);
                }
                if (funcoes.ApenasNumeros(EDITVALORLOCACAO.Text) != "" && funcoes.ApenasNumeros(EDITVALORLOCACAO.Text) != null)
                {
                    locacao.valorlocacao = Convert.ToInt32(EDITVALORLOCACAO.Text);
                }

                LocacaoControle locacaocontrole = new LocacaoControle();
                if (EDITCONTROLE.Text != "" || (EDITCONTROLE.Text == null))
                {
                    locacaocontrole.alterar(locacao);
                }
                else
                {
                    locacaocontrole.salvar(locacao);
                }
                MessageBox.Show("Cadastro realizado com sucesso");
                limpaTela();
            }
        }

        private void EDITDATAINICIOLOCACAO_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("entrada do campo");
        }

        private void EDITDATAINICIOLOCACAO_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATAINICIOLOCACAO.Text) == false)
            {
                EDITDATAINICIOLOCACAO.Clear();
                EDITDATAINICIOLOCACAO.Focus();
            }
        }

        private void EDITDATAFIMLOCACAO_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATAFIMLOCACAO.Text) == false)
            {
                EDITDATAFIMLOCACAO.Clear();
                EDITDATAFIMLOCACAO.Focus();
            }
        }

        public Boolean validaDados()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITVEICULOCODIGO.Text) || !EDITVEICULOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O veículo não foi informado.!", "Veículo");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITDATAINICIOLOCACAO.Text))
            {
                MessageBox.Show("A data início da locação deverá ser informada!", "Data início locação");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITDATAFIMLOCACAO.Text))
            {
                MessageBox.Show("A data do fim da locação deverá ser informada!", "Data início locação");
                resultado = false;
            }
            if (!String.IsNullOrEmpty(EDITDATAINICIOLOCACAO.Text) || !String.IsNullOrEmpty(EDITDATAFIMLOCACAO.Text))
            {
                DateTime wdti, wdtf;
                wdti = Convert.ToDateTime(EDITDATAINICIOLOCACAO.Text);
                wdtf = Convert.ToDateTime(EDITDATAFIMLOCACAO.Text);
                TimeSpan ts = wdtf.Subtract(wdti);
                if (ts.Days < 0)
                {
                    MessageBox.Show("A data final deverá ser maior que a data inicial!", "Data início e fim da locação");
                    resultado = false;
                }
            }
            return resultado;
        }

        private void FLocacao_Load(object sender, EventArgs e)
        {

        }

    }
}

