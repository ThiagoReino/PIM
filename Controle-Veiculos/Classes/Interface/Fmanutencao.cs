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
using Controle_Veiculos.Classes.Persistencia;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class Fmanutencao : Form
    {
        public Fmanutencao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        public void limpaTela()
        {
            EDITCODIGO.Clear();
            EDITVEICULOCODIGO.Clear();
            EDITVEICULOPLACA.Clear();
            EDITMARCAMODELODESCRICAO.Clear();
            EDITVEICULOANOFABRICA.Clear();
            EDITVEICULOANOMODELO.Clear();
            EDITVEICULOCHASSI.Clear();
            EDITVLRTOTAL.Clear();
            EDITMANUTENCAOPRODUTOCODIGO.Clear();
            EDITMANUTENCAOPRODUTODESCRICAO.Clear();
            EDITMANUTENCAOPRODUTOQTDE.Clear();
            EDITMANUTENCAOPRODUTOVLRUNITARIO.Clear();
            EDITMANUTENCAOPRODUTOVLRTOTAL.Clear();
            limpaTelaProdutos();
            limpaTelaServicos();
        }

        public bool validaDado()
        {

            bool validaDado;
            validaDado = true;
            if (String.IsNullOrEmpty(EDITMANUTENCAOPRODUTOQTDE.Text) || !EDITMANUTENCAOPRODUTOQTDE.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a quantidade", "Quantidade");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITMANUTENCAOPRODUTODESCRICAO.Text))
            {
                MessageBox.Show("Localizar um produto", "Produto");
                validaDado = false;
            }
            else if (!EDITMANUTENCAOPRODUTOQTDE.Text.All(char.IsNumber))
            {
                MessageBox.Show("Quantidade inválida", "Produto");
                validaDado = false;
            }
            return validaDado;
        }

        public void limpaTelaProdutos()
        {
            EDITMANUTENCAOPRODUTOCODIGO.Clear();
            EDITMANUTENCAOPRODUTODESCRICAO.Clear();
            EDITMANUTENCAOPRODUTOUNIDADE.Clear();
            EDITMANUTENCAOPRODUTOQTDE.Clear();
            EDITMANUTENCAOPRODUTOVLRTOTAL.Clear();
            EDITMANUTENCAOPRODUTOVLRUNITARIO.Clear();
        }
        public void limpaTelaServicos()
        {
            EDITMANUTENCAOSERVICOCODIGO.Clear();
            EDITMANUTENCAOSERVICODESCRICAO.Clear();
            EDITMANUTENCAOSERVICOQTDE.Clear();
            EDITMANUTENCAOPRODUTOVLRUNITARIO.Clear();
            EDITMANUTENCAOSERVICOVLRTOTAL.Clear();
        }

        public void AtualizaGrid()
        {
            String strSQLItem;

            strSQLItem = "select manutencaoitem.produtocodigo,";
            strSQLItem = strSQLItem + " produto.descricao as @produtodescricao, produto.unidade as @produtounidade,";
            strSQLItem = strSQLItem + " manutencaoitem.servicocodigo as @srvdescricao,";
            strSQLItem = strSQLItem + " servico.descricao,";
            strSQLItem = strSQLItem + " manutencaoitem.qtde,manutencaoitem.vlrunitario, manutencaoitem.vlrtotal from manutencaoitem";
            strSQLItem = strSQLItem + " left join produto on produto.codigo = manutencaoitem.produtocodigo";
            strSQLItem = strSQLItem + " left join servico on servico.codigo = manutencaoitem.servicocodigo";
            strSQLItem = strSQLItem + " where manutencaoitem.manutencaocodigo= @manutencaocodigo";

            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQLItem, objConexao);

            objComando.Parameters.AddWithValue("@produtodescricao", "Descricao do produto");
            objComando.Parameters.AddWithValue("@produtounidade", "Unidade");
            objComando.Parameters.AddWithValue("@srvdescricao", "Descricao do serviço");
            objComando.Parameters.AddWithValue("@manutencaocodigo", Convert.ToInt32(EDITCODIGO.Text));

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComando);

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                gridItens.DataSource = dtLista;

            }
            catch (Exception erro)
            {

                throw erro;
            }

            objConexao = new MySqlConnection(conexaoBancoDados);
            objConexao.Open();

            MySqlCommand comando = null;
            MySqlDataReader tabelaDados;
            comando = new MySqlCommand("select vlrtotal from manutencao where codigo = @codigo", objConexao);
            comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(EDITCODIGO.Text));
            tabelaDados = comando.ExecuteReader();

            while (tabelaDados.Read()) // Lendo registro
            {
                if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VLRTOTAL")))
                {
                    EDITVLRTOTAL.Text = Convert.ToString(tabelaDados.GetDecimal("VLRTOTAL"));
                }
            }
            tabelaDados.Close();
        }


        private void Fmanutencao_Load(object sender, EventArgs e)
        {
            BOTAOSALVARMANUTENCAO.Enabled = false;
            BOTAOLOCALIZARVEICULO.Enabled = false;
            BOTAOEXCLUIRMANUTENCAO.Enabled = false;
            BOTAOATUALIZARMANUTENCAO.Enabled = false;
            GroupBoxProdutosManutencao.Enabled = false;
            GroupBoxServicosManutencao.Enabled = false;
        }

        private void EDITQTDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }


        private void BOTAOLIMPATELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }





        private void BOTAOSAIRMANUTENCAO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAONOVOMANUTENCAO_Click(object sender, EventArgs e)
        {
            BOTAOLOCALIZARVEICULO.Enabled = true;
        }

        private void BOTAOEXCLUIRMANUTENCAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manutencao excluida com sucesso");
            limpaTela();
            limpaTelaProdutos();
            limpaTelaServicos();
        }

        private void EDITDATAINICIAL_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATAINICIOMANUTENCAO.Text) == false)
            {
                EDITDATAINICIOMANUTENCAO.Clear();
                EDITDATAINICIOMANUTENCAO.Focus();
            }
        }

        private void EDITDATAFINAL_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATAFINALMANUTENCAO.Text) == false)
            {
                EDITDATAFINALMANUTENCAO.Clear();
                EDITDATAFINALMANUTENCAO.Focus();
            }
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

                    MarcamodeloModelo Marcacontrole = new MarcamodeloModelo();
                    Marcacontrole.codigo = veiculo.marcamodelocodigo;
                    MarcamodeloControle marcamodcontrole = new MarcamodeloControle();
                    Marcacontrole = marcamodcontrole.pesquisaMarca(Marcacontrole);
                    if (Marcacontrole.codigo > 0)
                    {
                        EDITMARCAMODELODESCRICAO.Text = Marcacontrole.descricao;
                        BOTAOLOCALIZARPRODUTO.Enabled = true;
                        EDITDATAINICIOMANUTENCAO.Text = Convert.ToString(DateTime.Now);
                        BOTAOSALVARMANUTENCAO.Enabled = true;
                    }
                }
            }
        }

        private void EDITVEICULOCODIGO_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDITVEICULOANOMODELO_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDITVEICULOANOFABRICA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void EDITVEICULOPLACA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BOTAOLOCALIZARPRODUTO_Click(object sender, EventArgs e)
        {
            FprodutoLoc produtoFrmLoc = new FprodutoLoc();
            produtoFrmLoc.ShowDialog();
            if (produtoFrmLoc.codigoretornado != "" && produtoFrmLoc.codigoretornado != null)
            {
                ProdutoModelo produto = new ProdutoModelo();
                produto.codigo = int.Parse(produtoFrmLoc.codigoretornado);
                ProdutoControle produtocontrole = new ProdutoControle();
                produto = produtocontrole.atualizatela(produto);
                if (produto.codigo > 0)
                {
                    EDITMANUTENCAOPRODUTOCODIGO.Text = Convert.ToString(produto.codigo);
                    EDITMANUTENCAOPRODUTODESCRICAO.Text = produto.descricao;
                    EDITMANUTENCAOPRODUTOUNIDADE.Text = produto.unidade;
                    EDITMANUTENCAOPRODUTOQTDE.Enabled = true;
                    EDITMANUTENCAOPRODUTOVLRUNITARIO.Enabled = true;
                    EDITMANUTENCAOPRODUTOVLRTOTAL.Enabled = true;
                    BOTAOPRODUTOINCLUIR.Enabled = true;
                }
            }
        }

        private void EDITVLRUNITARIO_Leave(object sender, EventArgs e)
        {
            if (EDITMANUTENCAOPRODUTOQTDE.Text != "") //&& (EDITVLRUNITARIO.Text != "")
            {
                float quantidade = float.Parse(EDITMANUTENCAOPRODUTOQTDE.Text);
                float vlrunitario = float.Parse(EDITMANUTENCAOPRODUTOVLRUNITARIO.Text);
                float vlrtotal;
                vlrtotal = quantidade * vlrunitario;
                EDITMANUTENCAOPRODUTOVLRTOTAL.Text = vlrtotal.ToString();
            }
        }

        private void BOTAOSALVARMANUTENCAO_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void botaoincluiros_Click(object sender, EventArgs e)
        {
            int wnumerodaos = 0;
            if (validaDadosManutencao() == true)
            {
                ManutencaoModelo manutencao = new ManutencaoModelo();

                Funcoes funcoes = new Funcoes();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    manutencao.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                if (EDITVEICULOCODIGO.Text != "" && EDITVEICULOCODIGO.Text != null)
                {
                    manutencao.codigo = Convert.ToInt32(EDITVEICULOCODIGO.Text);
                }
                if (EDITDATAINICIOMANUTENCAO.Text != "" && EDITDATAINICIOMANUTENCAO.Text != null)
                {
                    manutencao.datainiciomanutencao = Convert.ToDateTime(EDITDATAINICIOMANUTENCAO.Text);
                }
                if (EDITMANUTENCAOPRODUTOVLRTOTAL.Text != "" && EDITMANUTENCAOPRODUTOVLRTOTAL.Text != null)
                {
                    manutencao.vlrtotal = Convert.ToDecimal(EDITMANUTENCAOPRODUTOVLRTOTAL.Text);
                }

                ManutencaoControle manutencaocontrole = new ManutencaoControle();
                {
                    wnumerodaos = manutencaocontrole.salvar(manutencao);
                    EDITCODIGO.Text = Convert.ToString(wnumerodaos);
                }
                MessageBox.Show("Dados da manutenção salvos com sucesso.  Favor informar o(s) item(ns) da manutenção.");
                groupBoxManutencao.Enabled = false;
                //GroupBoxItens.Enabled = true;
            }

        }
        public Boolean validaDadosManutencao()
        {
            Boolean resultado = true;
            Funcoes funcoes = new Funcoes();

            if (String.IsNullOrEmpty(EDITVEICULOCODIGO.Text) || !EDITVEICULOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O veículo deverá ser informado.!", "Veículo");
                resultado = false;
            }
            if (String.IsNullOrEmpty(funcoes.ApenasNumeros(EDITDATAINICIOMANUTENCAO.Text)))
            {
                MessageBox.Show("A data do início da manutenção deverá ser informada!", "Data início manutenção");
                resultado = false;
            }
            return resultado;
        }



        private void botaoincluiros_Click_1(object sender, EventArgs e)
        {
            int wnumerodamanutencao = 0;
            if (validaDadosManutencao() == true)
            {
                ManutencaoModelo manutencao = new ManutencaoModelo();

                Funcoes funcoes = new Funcoes();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    manutencao.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                if (EDITDATAINICIOMANUTENCAO.Text != "" && EDITDATAINICIOMANUTENCAO.Text != null)
                {
                    manutencao.datainiciomanutencao = Convert.ToDateTime(EDITDATAINICIOMANUTENCAO.Text);
                }
                if (EDITVEICULOCODIGO.Text != "" && EDITVEICULOCODIGO.Text != null)
                {
                    manutencao.veiculocodigo = Convert.ToInt32(EDITVEICULOCODIGO.Text);
                }
                if (EDITVLRTOTAL.Text != "" && EDITVLRTOTAL.Text != null)
                {
                    manutencao.vlrtotal = Convert.ToDecimal(EDITVLRTOTAL.Text);
                }

                ManutencaoControle manutencaocontrole = new ManutencaoControle();
                {
                    wnumerodamanutencao = manutencaocontrole.salvar(manutencao);
                    EDITCODIGO.Text = Convert.ToString(wnumerodamanutencao);
                }
                MessageBox.Show("Dados da manutenção salvos com sucesso.  Favor informar o(s) item(ns) da manutenção.");
                groupBoxManutencao.Enabled = false;
                GroupBoxProdutosManutencao.Enabled = true;
                GroupBoxServicosManutencao.Enabled = true;
            }
        }

        public Boolean validaDadosManutencoaProduto()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITMANUTENCAOPRODUTOCODIGO.Text) || !EDITMANUTENCAOPRODUTOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O produto deverá ser informado!", "Produto");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITMANUTENCAOPRODUTOQTDE.Text) || !EDITMANUTENCAOPRODUTOQTDE.Text.All(char.IsNumber))
            {
                MessageBox.Show("A quantidade do produto não foi informada ou é inválida!", "Qtde produto");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITMANUTENCAOPRODUTOQTDE.Text) <= 0)
                {
                    MessageBox.Show("A quantidade do produto deverá ser maior que zero!", "Quantidade do produto");
                    resultado = false;
                }
            }
            if (String.IsNullOrEmpty(EDITMANUTENCAOPRODUTOVLRUNITARIO.Text) || !EDITMANUTENCAOPRODUTOVLRUNITARIO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O valor unitário do produto não foi informada ou é inválido!", "Qtde");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITMANUTENCAOPRODUTOVLRUNITARIO.Text) <= 0)
                {
                    MessageBox.Show("O valor unitário do produto deverá ser maior que zero!", "Qtde");
                    resultado = false;
                }
            }
            if (String.IsNullOrEmpty(EDITMANUTENCAOPRODUTOVLRTOTAL.Text) || !EDITMANUTENCAOPRODUTOVLRTOTAL.Text.All(char.IsNumber))
            {
                MessageBox.Show("O valor total do produto não foi informada ou é inválido!", "Qtde");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITMANUTENCAOPRODUTOVLRTOTAL.Text) <= 0)
                {
                    MessageBox.Show("O valor total do produto deverá ser maior que zero!", "Qtde");
                    resultado = false;
                }
            }
            return resultado;
        }

        public Boolean validaDadosManutencoaServico()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITMANUTENCAOSERVICOCODIGO.Text) || !EDITMANUTENCAOSERVICOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O serviço deverá ser informado!", "Produto");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITMANUTENCAOSERVICOQTDE.Text) || !EDITMANUTENCAOSERVICOQTDE.Text.All(char.IsNumber))
            {
                MessageBox.Show("A quantidade do serviço não foi informada ou é inválida!", "Qtde serviço");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITMANUTENCAOSERVICOQTDE.Text) <= 0)
                {
                    MessageBox.Show("A quantidade do produto deverá ser maior que zero!", "Quantidade do produto");
                    resultado = false;
                }
            }
            if (String.IsNullOrEmpty(EDITMANUTENCAOSERVICOVLRUNITARIO.Text) || !EDITMANUTENCAOSERVICOVLRUNITARIO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O valor unitário do serviço não foi informada ou é inválido!", "Vlr.unitário");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITMANUTENCAOSERVICOVLRUNITARIO.Text) <= 0)
                {
                    MessageBox.Show("O valor unitário do serviço deverá ser maior que zero!", "Vlr.unitário");
                    resultado = false;
                }
            }
            if (String.IsNullOrEmpty(EDITMANUTENCAOSERVICOVLRTOTAL.Text) || !EDITMANUTENCAOSERVICOVLRTOTAL.Text.All(char.IsNumber))
            {
                MessageBox.Show("O valor total do serviço não foi informada ou é inválido!", "Vlr.total");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITMANUTENCAOSERVICOVLRTOTAL.Text) <= 0)
                {
                    MessageBox.Show("O valor total do serviço deverá ser maior que zero!", "Qtde");
                    resultado = false;
                }
            }
            return resultado;
        }


        private void BOTAOPESQUISACOMPRA_Click(object sender, EventArgs e)
        {
            FmanutencaoLoc manutencaoFrmLoc = new FmanutencaoLoc();
            manutencaoFrmLoc.ShowDialog();
            if (manutencaoFrmLoc.codigoretornado != "" && manutencaoFrmLoc.codigoretornado != null)
            {
                ManutencaoModelo manutencao = new ManutencaoModelo();
                manutencao.codigo = int.Parse(manutencaoFrmLoc.codigoretornado);
                ManutencaoControle manutencaocontrole = new ManutencaoControle();
                manutencao = manutencaocontrole.atualizatela(manutencao);
                if (manutencao.codigo > 0)
                {
                    EDITCODIGO.Text = Convert.ToString(manutencao.codigo);
                    EDITDATAINICIOMANUTENCAO.Text = Convert.ToString(manutencao.datainiciomanutencao);
                    EDITDATAFINALMANUTENCAO.Text = Convert.ToString(manutencao.datafinalmanutencao);
                    EDITVLRTOTAL.Text = Convert.ToString(manutencao.vlrtotal);
                    if (manutencao.veiculocodigo > 0)
                    {
                        VeiculoModelo veiculo = new VeiculoModelo();
                        veiculo.codigo = manutencao.veiculocodigo;
                        VeiculoControle veicontrole = new VeiculoControle();
                        veiculo = veicontrole.atualizatela(veiculo);
                        if (veiculo.codigo > 0)
                        {
                            EDITVEICULOCODIGO.Text = Convert.ToString(veiculo.codigo);
                            EDITVEICULOPLACA.Text = veiculo.placa;
                            EDITVEICULOANOFABRICA.Text = Convert.ToString(veiculo.anofabrica);
                            EDITVEICULOANOMODELO.Text = Convert.ToString(veiculo.anomodelo);
                            EDITVEICULOCHASSI.Text = veiculo.chassi;

                            if (veiculo.codigo > 0)
                            {
                                MarcamodeloModelo marcamodelo = new MarcamodeloModelo();
                                marcamodelo.codigo = manutencao.veiculocodigo;
                                MarcamodeloControle marcamodelocontrole = new MarcamodeloControle();
                                marcamodelo = marcamodelocontrole.pesquisaMarca(marcamodelo);
                                if (marcamodelo.codigo > 0)
                                {
                                    EDITMARCAMODELODESCRICAO.Text = marcamodelo.descricao;
                                }
                                MessageBox.Show("Dados da manutenção localizados com sucesso.  Favor informar o(s) item(ns) da manutenção.");
                                groupBoxManutencao.Enabled = false;
                                GroupBoxProdutosManutencao.Enabled = true;
                                GroupBoxServicosManutencao.Enabled = true;
                                AtualizaGrid();
                            }
                        }
                    }
                }
            }
        }

        private void BOTAOLOCALIZARVEICULO_Click_1(object sender, EventArgs e)
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

                    MarcamodeloModelo Marcacontrole = new MarcamodeloModelo();
                    Marcacontrole.codigo = veiculo.marcamodelocodigo;
                    MarcamodeloControle marcamodcontrole = new MarcamodeloControle();
                    Marcacontrole = marcamodcontrole.pesquisaMarca(Marcacontrole);
                    if (Marcacontrole.codigo > 0)
                    {
                        EDITMARCAMODELODESCRICAO.Text = Marcacontrole.descricao;
                    }
                }
            }
        }

        private void BOTAOPRODUTOINCLUIR_Click(object sender, EventArgs e)
        {
            bool wretornoestoque = true;
            bool wretornovalorcompra = true;
            /*
            int linha;
            linha = gridpro.Rows.Count + 1;

            if (EDITVALOR.Text == "")
            {
                EDITVALOR.Text = "0";
            }
            gridpro.Rows.Insert(0, EDITPRODUTOCODIGO.Text, EDITPRODUTODESCRICAO.Text, EDITQTDE.Text, EDITVLRUNITARIO.Text, EDITVLRTOTAL.Text);

            EDITVALOR.Text = Convert.ToString(Convert.ToDecimal(EDITVALOR.Text) + Convert.ToDecimal(EDITVLRTOTAL.Text));

            EDITQTDE.Clear();
            EDITVLRTOTAL.Clear();
            EDITVLRUNITARIO.Clear();
            EDITPRODUTOCODIGO.Clear();
            EDITPRODUTODESCRICAO.Clear();
            */

            if (validaDadosManutencoaProduto() == true)
            {

                //Movimenta estoque
                ProdutoModelo produto = new ProdutoModelo();
                produto.codigo = Convert.ToInt32(EDITMANUTENCAOPRODUTOCODIGO.Text);

                ProdutoControle produtocontrole = new ProdutoControle();
                wretornoestoque = produtocontrole.atualizaestoque(EDITMANUTENCAOPRODUTOCODIGO.Text, "saida", Convert.ToDecimal(EDITMANUTENCAOPRODUTOQTDE.Text));
                if (wretornoestoque == true)
                {
                    //atualiza valor da manutencao (capa)
                    ManutencaoModelo manutencaoatualizada = new ManutencaoModelo();
                    manutencaoatualizada.codigo = Convert.ToInt32(EDITCODIGO.Text);
                    ManutencaoControle manutencaocontrole = new ManutencaoControle();
                    wretornovalorcompra = manutencaocontrole.atualizavalormanutencao(manutencaoatualizada, "entrada", Convert.ToDecimal(EDITMANUTENCAOPRODUTOVLRTOTAL.Text));
                    if (wretornovalorcompra == true)
                    {
                        ManutencaoitemModelo manutencaoitem = new ManutencaoitemModelo();

                        Funcoes funcoes = new Funcoes();
                        if (EDITMANUTENCAOPRODUTOITEM.Text != "" && EDITMANUTENCAOPRODUTOITEM.Text != null)
                        {
                            manutencaoitem.codigo = Convert.ToInt32(EDITMANUTENCAOPRODUTOITEM.Text);
                        }
                        if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                        {
                            manutencaoitem.manutencaocodigo = Convert.ToInt32(EDITCODIGO.Text);
                        }
                        if (EDITMANUTENCAOPRODUTOCODIGO.Text != "" && EDITMANUTENCAOPRODUTOCODIGO.Text != null)
                        {
                            manutencaoitem.produtocodigo = Convert.ToInt32(EDITMANUTENCAOPRODUTOCODIGO.Text);
                        }
                        if (EDITMANUTENCAOPRODUTOQTDE.Text != "" && EDITMANUTENCAOPRODUTOQTDE.Text != null)
                        {
                            manutencaoitem.qtde = Convert.ToDecimal(EDITMANUTENCAOPRODUTOQTDE.Text);
                        }
                        if (EDITMANUTENCAOPRODUTOVLRUNITARIO.Text != "" && EDITMANUTENCAOPRODUTOVLRUNITARIO.Text != null)
                        {
                            manutencaoitem.vlrunitario = Convert.ToDecimal(EDITMANUTENCAOPRODUTOVLRUNITARIO.Text);
                        }
                        if (EDITMANUTENCAOPRODUTOVLRTOTAL.Text != "" && EDITMANUTENCAOPRODUTOVLRTOTAL.Text != null)
                        {
                            manutencaoitem.vlrtotal = Convert.ToDecimal(EDITMANUTENCAOPRODUTOVLRTOTAL.Text);
                        }

                        ManutencaoItemControle manutencaoitemcontrole = new ManutencaoItemControle();
                        if (EDITMANUTENCAOPRODUTOITEM.Text != "" || (EDITMANUTENCAOPRODUTOITEM.Text == null))
                        {
                            manutencaoitemcontrole.alterar(manutencaoitem);
                        }
                        else
                        {
                            manutencaoitemcontrole.salvar(manutencaoitem);
                        }

                    }
                }
                MessageBox.Show("Item cadastrado com sucesso");
                limpaTelaProdutos();
                limpaTelaServicos();
                AtualizaGrid();
            }
        }

        private void BOTAOSERVICOINCLUIR_Click(object sender, EventArgs e)
        {
            bool wretornovalormanutencao = true;
            if (validaDadosManutencoaServico() == true)
            {

                
                    //atualiza valor da manutencao (capa)
                    ManutencaoModelo manutencaoatualizada = new ManutencaoModelo();
                    manutencaoatualizada.codigo = Convert.ToInt32(EDITCODIGO.Text);
                    ManutencaoControle manutencaocontrole = new ManutencaoControle();
                    wretornovalormanutencao = manutencaocontrole.atualizavalormanutencao(manutencaoatualizada, "entrada", Convert.ToDecimal(EDITMANUTENCAOSERVICOVLRTOTAL.Text));
                    if (wretornovalormanutencao == true)
                    {
                        ManutencaoitemModelo manutencaoitem = new ManutencaoitemModelo();

                        Funcoes funcoes = new Funcoes();
                        if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                        {
                            manutencaoitem.manutencaocodigo = Convert.ToInt32(EDITCODIGO.Text);
                        }
                        if (EDITMANUTENCAOSERVICOCODIGO.Text != "" && EDITMANUTENCAOSERVICOCODIGO.Text != null)
                        {
                            manutencaoitem.servicocodigo = Convert.ToInt32(EDITMANUTENCAOSERVICOCODIGO.Text);
                        }
                        if (EDITMANUTENCAOSERVICOQTDE.Text != "" && EDITMANUTENCAOSERVICOQTDE.Text != null)
                        {
                            manutencaoitem.qtde = Convert.ToDecimal(EDITMANUTENCAOSERVICOQTDE.Text);
                        }
                        if (EDITMANUTENCAOSERVICOVLRUNITARIO.Text != "" && EDITMANUTENCAOSERVICOVLRUNITARIO.Text != null)
                        {
                            manutencaoitem.vlrunitario = Convert.ToDecimal(EDITMANUTENCAOSERVICOVLRUNITARIO.Text);
                        }
                        if (EDITMANUTENCAOSERVICOVLRTOTAL.Text != "" && EDITMANUTENCAOSERVICOVLRTOTAL.Text != null)
                        {
                            manutencaoitem.vlrtotal = Convert.ToDecimal(EDITMANUTENCAOSERVICOVLRTOTAL.Text);
                        }

                        ManutencaoItemControle manutencaoitemcontrole = new ManutencaoItemControle();
                        if (EDITMANUTENCAOSERVICOITEM.Text != "" || (EDITMANUTENCAOSERVICOITEM.Text == null))
                        {
                            manutencaoitemcontrole.alterar(manutencaoitem);
                        }
                        else
                        {
                            manutencaoitemcontrole.salvar(manutencaoitem);
                        }

                    }
                
                MessageBox.Show("Item de serviço cadastrado com sucesso");
                limpaTelaProdutos();
                limpaTelaServicos();
                AtualizaGrid();
            }
        }

        private void BOTAOLOCALIZASERVICO_Click(object sender, EventArgs e)
        {
            FservicosLoc servicosFrmLoc = new FservicosLoc();
            servicosFrmLoc.ShowDialog();
            if (servicosFrmLoc.codigoretornado != "" && servicosFrmLoc.codigoretornado != null)
            {
                ServicoModelo servico = new ServicoModelo();
                servico.codigo = int.Parse(servicosFrmLoc.codigoretornado);
                ServicoControle servicocontrole = new ServicoControle();
                servico = servicocontrole.atualizatela(servico);
                if (servico.codigo > 0)
                {
                    EDITMANUTENCAOSERVICOCODIGO.Text = Convert.ToString(servico.codigo);
                    EDITMANUTENCAOSERVICODESCRICAO.Text = servico.descricao;
                    EDITMANUTENCAOSERVICOQTDE.Enabled = true;
                    EDITMANUTENCAOSERVICOVLRUNITARIO.Enabled = true;
                    EDITMANUTENCAOSERVICOVLRTOTAL.Enabled = true;
                    BOTAOSERVICOINCLUIR.Enabled = true;
                }
            }
        }

        private void EDITMANUTENCAOSERVICOVLRUNITARIO_Leave(object sender, EventArgs e)
        {
            if (EDITMANUTENCAOSERVICOQTDE.Text != "") //&& (EDITVLRUNITARIO.Text != "")
            {
                float quantidade = float.Parse(EDITMANUTENCAOSERVICOQTDE.Text);
                float vlrunitario = float.Parse(EDITMANUTENCAOSERVICOVLRUNITARIO.Text);
                float vlrtotal;
                vlrtotal = quantidade * vlrunitario;
                EDITMANUTENCAOSERVICOVLRTOTAL.Text = vlrtotal.ToString();
            }
        }
    }
}

