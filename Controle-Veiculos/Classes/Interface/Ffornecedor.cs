using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Model;


namespace Controle_Veiculos.Classes.Interface
{
    public partial class Ffornecedor : Form
    {
        public Ffornecedor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaFornecedor())
            {

                FornecedorModelo fornecedor = new FornecedorModelo();
                if (EDITCODICO.Text != "" && EDITCODICO.Text != null)
                {
                    fornecedor.codigo = Convert.ToInt32(EDITCODICO.Text);
                }

                fornecedor.nomerazao = EDITNOMERAZAO.Text;
                fornecedor.nomefantasia = EDITNOMEFANTASIA.Text;
                fornecedor.cpf = EDITCPF.Text.Replace(',', '.');
                fornecedor.rg = EDITRG.Text;
                fornecedor.cnpj = EDITCNPJ.Text.Replace(',', '.');
                fornecedor.ie = EDITIE.Text;
                fornecedor.logradouro = EDITLOGRADOURO.Text;
                fornecedor.numero = EDITNUMERO.Text;
                fornecedor.complemento = EDITCOMPLEMENTO.Text;
                fornecedor.bairro = EDITBAIRRO.Text;
                fornecedor.cidadecontrole = Convert.ToInt32(EDITCIDADECONTROLE.Text);
                fornecedor.cep = EDITCEP.Text;
                fornecedor.ddd = EDITDDD.Text;
                fornecedor.telefone = EDITTELEFONE.Text;
                fornecedor.dddcelular = EDITDDDCELULAR.Text;
                fornecedor.celular = EDITCELULAR.Text;
                fornecedor.contato = EDITCONTATO.Text;
                fornecedor.email = EDITEMAIL.Text;

                FornecedorControle fornecedorcontrole = new FornecedorControle();
                if (EDITCODICO.Text != "" || (EDITCODICO.Text == null))
                {
                    fornecedorcontrole.alterar(fornecedor);
                }
                else 
                {
                    fornecedorcontrole.salvar(fornecedor);
                }
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Fornecedor");
                limpaTela();
            }
        }

        private void limpaTela()
        {
            EDITCODICO.Clear();
            EDITNOMERAZAO.Clear();
            EDITNOMEFANTASIA.Clear();
            EDITCPF.Clear();
            EDITRG.Clear();
            EDITCNPJ.Clear();
            EDITIE.Clear();
            EDITLOGRADOURO.Clear();
            EDITNUMERO.Clear();
            EDITCOMPLEMENTO.Clear();
            EDITBAIRRO.Clear();
            EDITCIDADECONTROLE.Clear();
            EDITCIDADE.Clear();
            EDITCEP.Clear();
            EDITDDD.Clear();
            EDITTELEFONE.Clear();
            EDITDDDCELULAR.Clear();
            EDITCELULAR.Clear();
            EDITCONTATO.Clear();
            EDITEMAIL.Clear();
        }

        private void BOTAOCIDADE_Click(object sender, EventArgs e)
        {
            FcidadeLoc motoristaLocFrm = new FcidadeLoc();
            motoristaLocFrm.ShowDialog();

            if (motoristaLocFrm.codigoretornado != "" && motoristaLocFrm.codigoretornado != null)
            {
                CidadeModelo cidade = new CidadeModelo();
                CidadePersistencia cidcontrole = new CidadePersistencia();
                cidade.controle = int.Parse(motoristaLocFrm.codigoretornado);
                cidade = cidcontrole.atualizatela(cidade);

                EDITCIDADE.Text = cidade.nome;
                EDITESTADO.Text = cidade.uf;
                EDITCIDADECONTROLE.Text = Convert.ToString(cidade.controle);
            }
        }

        public Boolean validaFornecedor()
        {
            Boolean resultado = true;
            
            Funcoes funcoes = new Funcoes();
            
            if (String.IsNullOrEmpty(EDITNOMERAZAO.Text) || EDITNOMERAZAO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Nome/Razão social invalido!", "NOME");
                resultado = false;
            }
            if ( (String.IsNullOrEmpty(EDITCPF.Text) || EDITCPF.Text.All(char.IsNumber)) && (String.IsNullOrEmpty(EDITCNPJ.Text) || EDITCNPJ.Text.All(char.IsNumber)) )
            {
                MessageBox.Show("O CNPJ ou o CPF deverá ser informado!", "NOME");
                resultado = false;
            }
            if (!String.IsNullOrEmpty(funcoes.ApenasNumeros(EDITCPF.Text)) && funcoes.ApenasNumeros(EDITCPF.Text) != null)
            {
                if (funcoes.validarCpf(funcoes.ApenasNumeros(EDITCPF.Text)) == false)
                {
                    MessageBox.Show("O CPF informado não é válido!", "CPF");
                    resultado = false;
                }
            }
            if (!String.IsNullOrEmpty(funcoes.ApenasNumeros(EDITCNPJ.Text)) && funcoes.ApenasNumeros(EDITCNPJ.Text) != null)
            {
                if (funcoes.ValidaCnpj(funcoes.ApenasNumeros(EDITCNPJ.Text)) == false)
                {
                    MessageBox.Show("O CNPJ informado não é válido!", "CNPJ");
                    resultado = false;
                }
            }
            if ((!String.IsNullOrEmpty(EDITEMAIL.Text)) && (funcoes.validarEmail(EDITEMAIL.Text) == false))
            { 
                MessageBox.Show("Informe um EMAIL válido", "EMAIL");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITCIDADE.Text) || EDITCIDADE.Text.All(char.IsNumber))
            {
                MessageBox.Show("A cidade deverá ser informada.", "CIDADE");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITLOGRADOURO.Text) || EDITLOGRADOURO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe um endereço", "ENDERECO");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITNUMERO.Text))
            {
                MessageBox.Show("Informe um número do endereço", "NUMERO");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITBAIRRO.Text)) 
            {
                MessageBox.Show("Informe um bairro", "BAIRRO");
                resultado = false;
            }
            if (String.IsNullOrEmpty(EDITCEP.Text) )
            {
                MessageBox.Show("Informe um CEP", "CEP");
                resultado = false;
            }
            return resultado;   
          }

        private void Ffornecedor_Load(object sender, EventArgs e)
        {
            EDITCIDADECONTROLE.Visible = false;
            EDITCODICO.Enabled = false;
            EDITNOMEFANTASIA.Enabled = false;
            EDITNOMERAZAO.Enabled = false;
            EDITCNPJ.Enabled = false;
            EDITIE.Enabled = false;
            EDITCPF.Enabled = false;
            EDITRG.Enabled = false;
            EDITLOGRADOURO.Enabled = false;
            EDITNUMERO.Enabled = false;
            EDITCOMPLEMENTO.Enabled = false;
            EDITBAIRRO.Enabled = false;
            BOTAOCIDADE.Enabled = false;
            EDITCEP.Enabled = false;
            BOTAOCEP.Enabled = false;
            EDITDDD.Enabled = false;
            EDITTELEFONE.Enabled = false;
            EDITDDDCELULAR.Enabled = false;
            EDITCELULAR.Enabled = false;
            EDITEMAIL.Enabled = false;
            EDITCONTATO.Enabled = false;
            BOTAOSALVAR.Enabled = false;
            BOTAOEXCLUIR.Enabled = false;
            BOTAOATUALIZAR.Enabled = false;
        }

        private void EDITCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            FornecedorModelo fornec = new FornecedorModelo();

            fornec.codigo = Convert.ToInt32(EDITCODICO.Text);

            FornecedorControle fornecedorcontrole = new FornecedorControle();
            fornecedorcontrole.excluir(fornec);

            MessageBox.Show("Cadastro excluido com sucesso", "Cadastro Fornecedor");
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            FfornecedorLoc fornecedorLocFrm = new FfornecedorLoc();
            fornecedorLocFrm.ShowDialog();

            if (fornecedorLocFrm.codigoretornado != "" && fornecedorLocFrm.codigoretornado != null)
            {
                FornecedorModelo fornecedor = new FornecedorModelo();
                FornecedorControle FornecedorControle = new FornecedorControle();
                fornecedor.codigo = int.Parse(fornecedorLocFrm.codigoretornado);
                if (fornecedor.codigo > 0)
                {

                    fornecedor = FornecedorControle.atualizatela(fornecedor);

                    EDITCODICO.Text = Convert.ToString(fornecedor.codigo);

                    EDITNOMERAZAO.Text = fornecedor.nomerazao;
                    EDITNOMEFANTASIA.Text = fornecedor.nomefantasia;
                    EDITCPF.Text = fornecedor.cpf;
                    EDITRG.Text = fornecedor.rg;
                    EDITCNPJ.Text = fornecedor.cnpj;
                    EDITIE.Text = fornecedor.ie;
                    EDITLOGRADOURO.Text = fornecedor.logradouro;
                    EDITNUMERO.Text = fornecedor.numero;
                    EDITCOMPLEMENTO.Text = fornecedor.complemento;
                    EDITBAIRRO.Text = fornecedor.bairro;
                    EDITCIDADECONTROLE.Text = Convert.ToString(fornecedor.cidadecontrole);
                    EDITCEP.Text = fornecedor.cep;
                    EDITDDD.Text = fornecedor.ddd;
                    EDITTELEFONE.Text = fornecedor.telefone;
                    EDITDDDCELULAR.Text = fornecedor.dddcelular;
                    EDITCELULAR.Text = fornecedor.celular;
                    EDITCONTATO.Text = fornecedor.contato;
                    EDITEMAIL.Text = fornecedor.email;

                    if (fornecedor.cidadecontrole > 0)
                    {
                        CidadeModelo cidade = new CidadeModelo();
                        cidade.controle = fornecedor.cidadecontrole;
                        CidadePersistencia cidcontrole = new CidadePersistencia();
                        cidade = cidcontrole.atualizatela(cidade);
                        EDITCIDADECONTROLE.Text = Convert.ToString(cidade.controle);
                        EDITCIDADE.Text = cidade.nome;
                        EDITESTADO.Text = cidade.uf;
                    }

                }
            }
            BOTAONOVO_Click(sender, e);

        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            EDITNOMEFANTASIA.Enabled = true;
            EDITNOMERAZAO.Enabled = true;
            EDITCNPJ.Enabled = true;
            EDITIE.Enabled = true;
            EDITCPF.Enabled = true;
            EDITRG.Enabled = true;
            EDITLOGRADOURO.Enabled = true;
            EDITNUMERO.Enabled = true;
            EDITCOMPLEMENTO.Enabled = true;
            EDITBAIRRO.Enabled = true;
            BOTAOCIDADE.Enabled = true;
            EDITCEP.Enabled = true;
            BOTAOCEP.Enabled = true;
            EDITDDD.Enabled = true;
            EDITTELEFONE.Enabled = true;
            EDITDDDCELULAR.Enabled = true;
            EDITCELULAR.Enabled = true;
            EDITEMAIL.Enabled = true;
            EDITCONTATO.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
        }

        private void BOTAOCEP_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    if (EDITCEP.Text != "")
                    {
                        var resultado = ws.consultaCEP(EDITCEP.Text);
                        EDITLOGRADOURO.Text = resultado.end;
                        EDITCIDADE.Text = resultado.cidade;
                        EDITESTADO.Text = resultado.uf;
                        EDITBAIRRO.Text = resultado.bairro;

                        if (EDITCIDADE.Text != "")
                        {
                            CidadeModelo cidade = new CidadeModelo();
                            cidade.nome = EDITCIDADE.Text;
                            CidadePersistencia cidcontrole = new CidadePersistencia();
                            cidade = cidcontrole.atualizatela(cidade);
                            EDITCIDADECONTROLE.Text = Convert.ToString(cidade.controle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe um CEP válido", "CEP");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um CEP valido", "CEP");
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

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaFornecedor())
            {

                FornecedorModelo fornecedor = new FornecedorModelo();
                if (EDITCODICO.Text != "" && EDITCODICO.Text != null)
                {
                    fornecedor.codigo = Convert.ToInt32(EDITCODICO.Text);
                }

                fornecedor.nomerazao = EDITNOMERAZAO.Text;
                fornecedor.nomefantasia = EDITNOMEFANTASIA.Text;
                fornecedor.cpf = EDITCPF.Text.Replace(',', '.');
                fornecedor.rg = EDITRG.Text;
                fornecedor.cnpj = EDITCNPJ.Text.Replace(',', '.');
                fornecedor.ie = EDITIE.Text;
                fornecedor.logradouro = EDITLOGRADOURO.Text;
                fornecedor.numero = EDITNUMERO.Text;
                fornecedor.complemento = EDITCOMPLEMENTO.Text;
                fornecedor.bairro = EDITBAIRRO.Text;
                fornecedor.cidadecontrole = Convert.ToInt32(EDITCIDADECONTROLE.Text);
                fornecedor.cep = EDITCEP.Text;
                fornecedor.ddd = EDITDDD.Text;
                fornecedor.telefone = EDITTELEFONE.Text;
                fornecedor.dddcelular = EDITDDDCELULAR.Text;
                fornecedor.celular = EDITCELULAR.Text;
                fornecedor.contato = EDITCONTATO.Text;
                fornecedor.email = EDITEMAIL.Text;

                FornecedorControle fornecedorcontrole = new FornecedorControle();
                if (EDITCODICO.Text != "" || (EDITCODICO.Text == null))
                {
                    fornecedorcontrole.alterar(fornecedor);
                }
                else
                {
                    fornecedorcontrole.salvar(fornecedor);
                }
                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro Fornecedor");
                limpaTela();
            }
        }
    }
}

