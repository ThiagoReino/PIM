using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class Fproduto : Form
    {
        public Fproduto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Fproduto_Load(object sender, EventArgs e)
        {
            EDITDESCRICAO.MaxLength = 60;
            EDITUNIDADE.MaxLength = 2;
            EDITSITUACAO.MaxLength = 10;
            limpaTela();
            EDITCODIGO.Enabled = false;
            EDITDESCRICAO.Enabled = false;
            EDITUNIDADE.Enabled = false;
            EDITSITUACAO.Enabled = false;
            EDITGRUPOCODIGO.Enabled = false;
            EDITGRUPODESCRICAO.Enabled = false;
            EDITCUSTO.Enabled = false;
            EDITCUSTOMEDIO.Enabled = false;
            EDITDATAULTIMACOMPRA.Enabled = false;
            EDITDATAULTIMASAIDA.Enabled = false;
            EDITESTOQUE.Enabled = false;
            BOTAOGRUPO.Enabled = false;
            BOTAOEXCLUIR.Enabled = false;
            BOTAOSALVAR.Enabled = false;
            BOTAOATUALIZAR.Enabled = false;
        }

        private void limpaTela()
        {
            EDITCODIGO.Clear();
            EDITDESCRICAO.Clear();
            EDITUNIDADE.Clear();
            EDITSITUACAO.SelectedItem = 0;
            EDITGRUPOCODIGO.Clear();
            EDITGRUPODESCRICAO.Clear();
            EDITCUSTO.Clear();
            EDITCUSTOMEDIO.Clear();
            EDITDATAULTIMACOMPRA.Clear();
            EDITDATAULTIMASAIDA.Clear();
            EDITESTOQUE.Clear();
            EDITSITUACAO.SelectedIndex = -1;
        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaProduto())
            {
                Funcoes funcoes = new Funcoes();

                ProdutoModelo produto = new ProdutoModelo();
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    produto.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    produto.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                produto.descricao = EDITDESCRICAO.Text;
                produto.unidade = EDITUNIDADE.Text;
                produto.situacao = EDITSITUACAO.Text;
                if (EDITGRUPOCODIGO.Text != "" && EDITGRUPOCODIGO.Text != null)
                {
                    produto.grupocodigo = Convert.ToInt32(EDITGRUPOCODIGO.Text);
                }
                if (EDITCUSTO.Text != "" && EDITCUSTO.Text != null)
                {
                    produto.custo = Convert.ToDecimal(EDITCUSTO.Text);
                }
                if (EDITCUSTOMEDIO.Text != "" && EDITCUSTOMEDIO.Text != null)
                {
                    produto.customedio = Convert.ToDecimal(EDITCUSTOMEDIO.Text);
                }
                if (EDITESTOQUE.Text != "" && EDITESTOQUE.Text != null)
                {
                    produto.estoque = Convert.ToDecimal(EDITESTOQUE.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATAULTIMACOMPRA.Text) != "" && funcoes.ApenasNumeros(EDITDATAULTIMACOMPRA.Text) != null)
                {
                    produto.dataultimacompra = Convert.ToDateTime(EDITDATAULTIMACOMPRA.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATAULTIMASAIDA.Text) != "" && funcoes.ApenasNumeros(EDITDATAULTIMASAIDA.Text) != null)
                {
                    produto.dataultimasaida = Convert.ToDateTime(EDITDATAULTIMASAIDA.Text);
                }
                ProdutoControle produtocontrole = new ProdutoControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    produtocontrole.alterar(produto);
                }
                else
                {
                    produtocontrole.salvar(produto);
                }
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro de Produtos");
                limpaTela();
            }

        }

        private void EDITDATAULTIMACOMPRA_DragLeave(object sender, EventArgs e)
        {
            if (EDITDATAULTIMACOMPRA.Text != "" && EDITDATAULTIMACOMPRA.Text != null)
            {
                DateTime wdt;
                try
                {
                    wdt = Convert.ToDateTime(EDITDATAULTIMACOMPRA.Text);
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString(), "Erro com a data informada.");
                    EDITDATAULTIMACOMPRA.Clear();
                    EDITDATAULTIMACOMPRA.Focus();
                }
            }
        }

        private void EDITDATAULTIMASAIDA_DragLeave(object sender, EventArgs e)
        {
            if (EDITDATAULTIMASAIDA.Text != "" && EDITDATAULTIMASAIDA.Text != null)
            {
                DateTime wdt;
                try
                {
                    wdt = Convert.ToDateTime(EDITDATAULTIMASAIDA.Text);
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString(), "Erro com a data informada.");
                    EDITDATAULTIMASAIDA.Clear();
                    EDITDATAULTIMASAIDA.Focus();
                }
            }
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            EDITDESCRICAO.Enabled = true;
            EDITUNIDADE.Enabled = true;
            EDITSITUACAO.Enabled = true;
            EDITGRUPOCODIGO.Enabled = true;
            EDITGRUPODESCRICAO.Enabled = true;
            EDITCUSTO.Enabled = true;
            EDITCUSTOMEDIO.Enabled = true;
            EDITDATAULTIMACOMPRA.Enabled = true;
            EDITDATAULTIMASAIDA.Enabled = true;
            EDITESTOQUE.Enabled = true;
            BOTAOGRUPO.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            ProdutoModelo prod = new ProdutoModelo();

            prod.codigo = Convert.ToInt32(EDITCODIGO.Text);

            ProdutoControle produtocontrole = new ProdutoControle();
            produtocontrole.excluir(prod);

            MessageBox.Show("Cadastro excluído com sucesso", "Cadastro de Produtos");
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            FprodutoLoc produtoLocFrm = new FprodutoLoc();
            produtoLocFrm.ShowDialog();

            if (produtoLocFrm.codigoretornado != "" && produtoLocFrm.codigoretornado != null)
            {
                ProdutoModelo produto = new ProdutoModelo();
                ProdutoControle ProdutoControle = new ProdutoControle();
                produto.codigo = int.Parse(produtoLocFrm.codigoretornado);
                if (produto.codigo > 0)
                {

                    produto = ProdutoControle.atualizatela(produto);

                    EDITCODIGO.Text = Convert.ToString(produto.codigo);

                    EDITDESCRICAO.Text = produto.descricao;
                    EDITSITUACAO.Text = produto.situacao;
                    EDITUNIDADE.Text = produto.unidade;
                    EDITGRUPOCODIGO.Text = Convert.ToString(produto.grupocodigo);
                    EDITCUSTO.Text = Convert.ToString(produto.custo);
                    EDITCUSTOMEDIO.Text = Convert.ToString(produto.customedio);
                    if (Convert.ToString(produto.dataultimacompra) != "01/01/0001 00:00:00" && Convert.ToString(produto.dataultimacompra) != "" && Convert.ToString(produto.dataultimacompra) != null)
                        {
                           EDITDATAULTIMACOMPRA.Text = Convert.ToString(produto.dataultimacompra);
                        }
                    else 
                    {
                        EDITDATAULTIMACOMPRA.Clear();
                    }
                    if (Convert.ToString(produto.dataultimasaida) != "01/01/0001 00:00:00" && Convert.ToString(produto.dataultimasaida) != "" && Convert.ToString(produto.dataultimasaida) != null)
                    {
                        EDITDATAULTIMASAIDA.Text = Convert.ToString(produto.dataultimasaida);
                    }
                    else
                    {
                        EDITDATAULTIMASAIDA.Clear();
                    }
                    EDITESTOQUE.Text = Convert.ToString(produto.estoque);

                    if (produto.grupocodigo > 0)
                    {
                        GrupoModelo grupo = new GrupoModelo();
                        GrupoControle grupocontrole = new GrupoControle();
                        grupo.codigo = produto.grupocodigo;
                        grupo = grupocontrole.atualizatela(grupo);
                        EDITGRUPODESCRICAO.Text = grupo.descricao;
                    }
                }
            }
            BOTAONOVO_Click(sender, e);
        }

        public Boolean validaProduto()
        {
            Boolean resultado = true;

            Funcoes funcoes = new Funcoes();

            if (String.IsNullOrEmpty(EDITDESCRICAO.Text) || EDITDESCRICAO.Text.All(char.IsNumber))
            {
                MessageBox.Show("A descrição do produto deverá ser informada!", "Descrição");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITGRUPOCODIGO.Text) || !EDITGRUPOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O grupo do produto deverá ser informado.", "Grupo do produto");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITSITUACAO.Text) || EDITSITUACAO.Text.All(char.IsNumber))
            {
                MessageBox.Show("A situação do produto deverá ser informada.", "Situação do produto");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITUNIDADE.Text) || EDITUNIDADE.Text.All(char.IsNumber))
            {
                MessageBox.Show("A unidade do produto deverá ser informada.", "Unidade do produto");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOGRUPO_Click(object sender, EventArgs e)
        {
            FGrupoLoc grupoFrmLoc = new FGrupoLoc();
            grupoFrmLoc.ShowDialog();
            if (grupoFrmLoc.codigoretornado != "" && grupoFrmLoc.codigoretornado != null)
            {
                GrupoModelo grupo = new GrupoModelo();
                grupo.codigo = int.Parse(grupoFrmLoc.codigoretornado);
                GrupoControle Grupocontrole = new GrupoControle();
                grupo = Grupocontrole.atualizatela(grupo);
                EDITGRUPOCODIGO.Text = Convert.ToString(grupo.codigo);
                EDITGRUPODESCRICAO.Text = grupo.descricao;
            }
        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaProduto())
            {
                Funcoes funcoes = new Funcoes();

                ProdutoModelo produto = new ProdutoModelo();
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    produto.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    produto.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                produto.descricao = EDITDESCRICAO.Text;
                produto.unidade = EDITUNIDADE.Text;
                produto.situacao = EDITSITUACAO.Text;
                if (EDITGRUPOCODIGO.Text != "" && EDITGRUPOCODIGO.Text != null)
                {
                    produto.grupocodigo = Convert.ToInt32(EDITGRUPOCODIGO.Text);
                }
                if (EDITCUSTO.Text != "" && EDITCUSTO.Text != null)
                {
                    produto.custo = Convert.ToInt32(EDITCUSTO.Text);
                }
                if (EDITCUSTOMEDIO.Text != "" && EDITCUSTOMEDIO.Text != null)
                {
                    produto.customedio = Convert.ToInt32(EDITCUSTOMEDIO.Text);
                }
                if (EDITESTOQUE.Text != "" && EDITESTOQUE.Text != null)
                {
                    produto.estoque = Convert.ToInt32(EDITESTOQUE.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATAULTIMACOMPRA.Text) != "" && funcoes.ApenasNumeros(EDITDATAULTIMACOMPRA.Text) != null)
                {
                    produto.dataultimacompra = Convert.ToDateTime(EDITDATAULTIMACOMPRA.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATAULTIMASAIDA.Text) != "" && funcoes.ApenasNumeros(EDITDATAULTIMASAIDA.Text) != null)
                {
                    produto.dataultimasaida = Convert.ToDateTime(EDITDATAULTIMASAIDA.Text);
                }

                ProdutoControle produtocontrole = new ProdutoControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    produtocontrole.alterar(produto);
                }
                else
                {
                    produtocontrole.salvar(produto);
                }
                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro de Produtos");
                limpaTela();
            }
            
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAOLIMPARTELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }
    }
}

    
