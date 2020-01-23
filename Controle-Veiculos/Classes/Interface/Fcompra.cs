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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class Fcompra : Form
    {
        public Fcompra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        string conexaoBancoDados = ConfigurationManager.ConnectionStrings["conexaoPim"].ToString();

        MySqlConnection objConexao = null;

        MySqlCommand objComando = null;

        private void BOTAOLOCALIZARVEICULO_Click_1(object sender, EventArgs e)
        {
            FfornecedorLoc fornecedorFrmLoc = new FfornecedorLoc();
            fornecedorFrmLoc.ShowDialog();
            if (fornecedorFrmLoc.codigoretornado != "" && fornecedorFrmLoc.codigoretornado != null)
            {
                FornecedorModelo fornecedor = new FornecedorModelo();
                fornecedor.codigo = int.Parse(fornecedorFrmLoc.codigoretornado);
                FornecedorControle forncontrole = new FornecedorControle();
                fornecedor = forncontrole.atualizatela(fornecedor);
                if (fornecedor.codigo > 0)
                {
                    EDITFORNECEDORCODIGO.Text = Convert.ToString(fornecedor.codigo);
                    EDITFORNECEDORNOMERAZAO.Text = fornecedor.nomerazao;
                }
            }
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
                    EDITCOMPRAITEMPRODUTOCODIGO.Text = Convert.ToString(produto.codigo);
                    EDITCOMPRAITEMPRODUTODESCRICAO.Text = produto.descricao;
                    EDITCOMPRAITEMPRODUTOUNIDADE.Text = produto.unidade;
                }
            }
        }


        public Boolean validaDadosCompra()
        {
            Boolean resultado = true;
            Funcoes funcoes = new Funcoes();

            if (String.IsNullOrEmpty(EDITFORNECEDORCODIGO.Text) || !EDITFORNECEDORCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O fornecedor da compra deverá ser informado.!", "Fornecedor");
                resultado = false;
            }
            if (String.IsNullOrEmpty(funcoes.ApenasNumeros(EDITDATADACOMPRA.Text)))
            {
                MessageBox.Show("A data da compra deverá ser informada!", "Data da compra");
                resultado = false;
            }
            /*
            if (String.IsNullOrEmpty(EDITVALORCOMPRA.Text) || !EDITVALORCOMPRA.Text.All(char.IsNumber))
            {
                MessageBox.Show("O valor total está em branco!", "Valor total compra");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITVALORCOMPRA.Text) <= 0)
                {
                    MessageBox.Show("O valor total da compra está zerado.   Esta informação é gerada a partir da entrada dos itens da compra.!", "Valor total da compra");
                    resultado = false;
                }
            }*/
            return resultado;
        }

        public Boolean validaDadosCompraItem()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITCOMPRAITEMPRODUTOCODIGO.Text) || !EDITCOMPRAITEMPRODUTOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O produto deverá ser informado!", "Produto");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITCOMPRAITEMQTDE.Text) || !EDITCOMPRAITEMQTDE.Text.All(char.IsNumber))
            {
                MessageBox.Show("A quantidade não foi informada ou é inválida!", "Qtde");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITCOMPRAITEMQTDE.Text) || !EDITCOMPRAITEMQTDE.Text.All(char.IsNumber))
            {
                MessageBox.Show("A quantidade não foi informada ou é inválida!", "Qtde");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITCOMPRAITEMQTDE.Text) <= 0)
                {
                    MessageBox.Show("A quantidade do item deverá ser maior que zero!", "Qtde");
                    resultado = false;
                }
            }
            if (String.IsNullOrEmpty(EDITCOMPRAITEMVLRUNITARIO.Text) || !EDITCOMPRAITEMVLRUNITARIO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O valor unitário do item não foi informada ou é inválido!", "Qtde");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITCOMPRAITEMVLRUNITARIO.Text) <= 0)
                {
                    MessageBox.Show("O valor unitário do item deverá ser maior que zero!", "Qtde");
                    resultado = false;
                }
            }
            if (String.IsNullOrEmpty(EDITCOMPRAITEMVLRTOTAL.Text) || !EDITCOMPRAITEMVLRTOTAL.Text.All(char.IsNumber))
            {
                MessageBox.Show("O valor total do item não foi informada ou é inválido!", "Qtde");
                resultado = false;
            }
            else
            {
                if (Convert.ToDecimal(EDITCOMPRAITEMVLRTOTAL.Text) <= 0)
                {
                    MessageBox.Show("O valor total do item deverá ser maior que zero!", "Qtde");
                    resultado = false;
                }
            }
            return resultado;
        }

        
        private void BOTAOGRAVARCOMPRA_Click(object sender, EventArgs e)
        {
            int wnumerodacompra = 0;
            if (validaDadosCompra() == true)
            {
                CompraModelo compra = new CompraModelo();
 
                Funcoes funcoes = new Funcoes();

                if (EDITCONTROLE.Text != "" && EDITCONTROLE.Text != null)
                {
                    compra.controle = Convert.ToInt32(EDITCONTROLE.Text);
                }
                if (EDITDATADACOMPRA.Text != "" && EDITDATADACOMPRA.Text != null)
                {
                    compra.datacompra = Convert.ToDateTime(EDITDATADACOMPRA.Text);
                }
                if (EDITFORNECEDORCODIGO.Text != "" && EDITFORNECEDORCODIGO.Text != null)
                {
                    compra.fornecedorcodigo = Convert.ToInt32(EDITFORNECEDORCODIGO.Text);
                }
                if (EDITVALORCOMPRA.Text != "" && EDITVALORCOMPRA.Text != null)
                {
                    compra.valorcompra = Convert.ToDecimal(EDITVALORCOMPRA.Text);
                }
                
                CompraControle compracontrole = new CompraControle();
                {
                    wnumerodacompra = compracontrole.salvar(compra);
                    EDITCONTROLE.Text = Convert.ToString(wnumerodacompra);
                }
                MessageBox.Show("Dados da compra salvos com sucesso.  Favor informar o(s) item(ns) da compra.");
                groupBoxCompra.Enabled = false;
                GroupBoxItens.Enabled = true;
            }
            }

        private void Fcompra_Load(object sender, EventArgs e)
        {
            GroupBoxItens.Enabled = false;
            limpaTelaCompra();
            limpaTelaCompraItem();
        }

        public void limpaTelaCompra()
        {
            EDITCONTROLE.Clear();
            EDITDATADACOMPRA.Clear();
            EDITVALORCOMPRA.Clear();
            EDITFORNECEDORCODIGO.Clear();
            EDITFORNECEDORNOMERAZAO.Clear();
        }
        public void limpaTelaCompraItem()
        {
            EDITCOMPRAITEMPRODUTOCODIGO.Clear();
            EDITCOMPRAITEMPRODUTOCODIGO.Clear();
            EDITCOMPRAITEMPRODUTOUNIDADE.Clear();
            EDITCOMPRAITEMQTDE.Clear();
            EDITCOMPRAITEMVLRUNITARIO.Clear();
            EDITCOMPRAITEMVLRTOTAL.Clear();
        }

        private void BOTAOGRAVARITEM_Click(object sender, EventArgs e)
        {
           bool wretornoestoque = false;
           bool wretornocusto = false;
            bool wretornovalorcompra = false;
            if (validaDadosCompraItem() == true)
            {
            
                //Movimenta estoque
                ProdutoModelo produto = new ProdutoModelo();
                produto.codigo = Convert.ToInt32(EDITCOMPRAITEMPRODUTOCODIGO.Text);

                ProdutoControle produtocontrole = new ProdutoControle();
                wretornocusto = produtocontrole.atualizacusto(EDITCOMPRAITEMPRODUTOCODIGO.Text, Convert.ToDateTime(EDITDATADACOMPRA.Text), Convert.ToDecimal(EDITCOMPRAITEMQTDE.Text), Convert.ToDecimal(EDITCOMPRAITEMVLRUNITARIO.Text));
                wretornoestoque = produtocontrole.atualizaestoque(EDITCOMPRAITEMPRODUTOCODIGO.Text, "entrada", Convert.ToDecimal(EDITCOMPRAITEMQTDE.Text));
                if (wretornoestoque == true)
                {
                    //atualiza valor da compra (capa)
                    CompraModelo compraatualizada = new CompraModelo();
                    compraatualizada.controle = Convert.ToInt32(EDITCONTROLE.Text);
                    CompraControle compracontrole = new CompraControle();
                    wretornovalorcompra = compracontrole.atualizavalorcompra(compraatualizada,"entrada",Convert.ToDecimal(EDITCOMPRAITEMVLRTOTAL.Text));
                    if (wretornovalorcompra == true)
                    {
                    CompraitemModelo compraitem = new CompraitemModelo();

                    Funcoes funcoes = new Funcoes();

                    if (EDITCOMPRAITEMCONTROLE.Text != "" && EDITCOMPRAITEMCONTROLE.Text != null)
                    {
                        compraitem.controle = Convert.ToInt32(EDITCOMPRAITEMCONTROLE.Text);
                    }
                    if (EDITCONTROLE.Text != "" && EDITCONTROLE.Text != null)
                    {
                        compraitem.compracontrole = Convert.ToInt32(EDITCONTROLE.Text);
                    }
                    if (EDITCOMPRAITEMPRODUTOCODIGO.Text != "" && EDITCOMPRAITEMPRODUTOCODIGO.Text != null)
                    {
                        compraitem.produtocodigo = Convert.ToInt32(EDITCOMPRAITEMPRODUTOCODIGO.Text);
                    }
                    if (EDITCOMPRAITEMQTDE.Text != "" && EDITCOMPRAITEMQTDE.Text != null)
                    {
                        compraitem.qtde = Convert.ToDecimal(EDITCOMPRAITEMQTDE.Text);
                    }
                    if (EDITCOMPRAITEMVLRUNITARIO.Text != "" && EDITCOMPRAITEMVLRUNITARIO.Text != null)
                    {
                        compraitem.vlrunitario = Convert.ToDecimal(EDITCOMPRAITEMVLRUNITARIO.Text);
                    }
                    if (EDITCOMPRAITEMVLRTOTAL.Text != "" && EDITCOMPRAITEMVLRTOTAL.Text != null)
                    {
                        compraitem.vlrtotal = Convert.ToDecimal(EDITCOMPRAITEMVLRTOTAL.Text);
                    }

                    CompraItemControle compraitemcontrole = new CompraItemControle();
                    if (EDITCOMPRAITEMCONTROLE.Text != "" || (EDITCOMPRAITEMCONTROLE.Text == null))
                    {
                        compraitemcontrole.alterar(compraitem);
                    }
                    else
                    {
                        compraitemcontrole.salvar(compraitem);
                    }

                    }
                }
                MessageBox.Show("Item cadastrado com sucesso");
                limpaTelaCompraItem();
                AtualizaGridItens();
            }

        }

        private void EDITDATADACOMPRA_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATADACOMPRA.Text) == false)
            {
                EDITDATADACOMPRA.Clear();
                EDITDATADACOMPRA.Focus();
            }
        }

        private void BOTAOPESQUISACOMPRA_Click(object sender, EventArgs e)
        {
            FcompraLoc compraFrmLoc = new FcompraLoc();
            compraFrmLoc.ShowDialog();
            if (compraFrmLoc.codigoretornado != "" && compraFrmLoc.codigoretornado != null)
            {
                CompraModelo compra = new CompraModelo();
                compra.controle = int.Parse(compraFrmLoc.codigoretornado);
                CompraControle compracontrole = new CompraControle();
                compra = compracontrole.atualizatela(compra);
                if (compra.controle > 0)
                {
                    EDITCONTROLE.Text = Convert.ToString(compra.controle);
                    EDITFORNECEDORCODIGO.Text = Convert.ToString(compra.fornecedorcodigo);
                    EDITDATADACOMPRA.Text = Convert.ToString(compra.datacompra);
                    EDITVALORCOMPRA.Text = Convert.ToString(compra.valorcompra);
                    if (compra.fornecedorcodigo > 0)
                    { 
                       FornecedorModelo fornecedor = new FornecedorModelo();
                       fornecedor.codigo = compra.fornecedorcodigo;
                       FornecedorControle forncontrole = new FornecedorControle();
                       fornecedor = forncontrole.atualizatela(fornecedor);
                        if (fornecedor.codigo > 0)
                        {
                            EDITFORNECEDORNOMERAZAO.Text = fornecedor.nomerazao;
                        }
                        MessageBox.Show("Dados da compra localizados com sucesso.  Favor informar o(s) item(ns) da compra.");
                        groupBoxCompra.Enabled = false;
                        GroupBoxItens.Enabled = true;
                        AtualizaGridItens();
                    }
                }
            }
        }

        private void EDITCOMPRAITEMVLRUNITARIO_Leave(object sender, EventArgs e)
        {
            if ( ( EDITCOMPRAITEMVLRUNITARIO.Text != "" && EDITCOMPRAITEMVLRUNITARIO.Text != null ) && (EDITCOMPRAITEMQTDE.Text != "" && EDITCOMPRAITEMQTDE.Text != null) )
            {
            EDITCOMPRAITEMVLRTOTAL.Text = Convert.ToString( (Convert.ToDecimal(EDITCOMPRAITEMQTDE.Text) * Convert.ToDecimal(EDITCOMPRAITEMVLRUNITARIO.Text) ));
            }
        }

        public void AtualizaGridItens()
        {
            String strSQLItem;

            strSQLItem = "select compraitem.*,";
            strSQLItem = strSQLItem + " produto.descricao as @prodescricao, produto.unidade as @prounidade from compraitem";
            strSQLItem = strSQLItem + " inner join produto on produto.codigo = compraitem.produtocodigo";
            strSQLItem = strSQLItem + " where compraitem.compracontrole = @compracontrole";
            strSQLItem = strSQLItem + " order by compraitem.controle desc";
            
            objConexao = new MySqlConnection(conexaoBancoDados);

            objComando = new MySqlCommand(strSQLItem, objConexao);

            objComando.Parameters.AddWithValue("@prodescricao", "Descricao do produto");
            objComando.Parameters.AddWithValue("@prounidade", "Unidade");
            objComando.Parameters.AddWithValue("@compracontrole",Convert.ToInt32(EDITCONTROLE.Text));

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
            comando = new MySqlCommand("select valorcompra from compra where controle = @controle", objConexao);
            comando.Parameters.AddWithValue("@controle", Convert.ToInt32(EDITCONTROLE.Text));
            tabelaDados = comando.ExecuteReader();

            while (tabelaDados.Read()) // Lendo registro
            {
                if (!tabelaDados.IsDBNull(tabelaDados.GetOrdinal("VALORCOMPRA")))
                {
                    EDITVALORCOMPRA.Text = Convert.ToString(tabelaDados.GetDecimal("VALORCOMPRA"));
                }
            }
            tabelaDados.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Fcompracp Forncompracp = new Fcompracp();
            Forncompracp.Wcompracontrole = EDITCONTROLE.Text;
            Forncompracp.Wdatacompra = EDITDATADACOMPRA.Text;
            Forncompracp.Wfornecedorcodigo = EDITFORNECEDORCODIGO.Text;
            Forncompracp.Wfornecedornome = EDITFORNECEDORNOMERAZAO.Text;
            Forncompracp.Wvalorcompra = EDITVALORCOMPRA.Text;

            Forncompracp.ShowDialog();

            this.Close();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {

        }


        }
    }

