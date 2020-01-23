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
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Interface;
using Controle_Veiculos.Classes.Persistencia;
using System.IO;
using Correios.Net;




namespace Controle_Veiculos
{
    public partial class frmMotorista : Form
    {
        public frmMotorista()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmMotorista_Load(object sender, EventArgs e)
        {
            EDITSEXO.Enabled = false;
            EDITNOMEMOTORISTA.Enabled = false;
            EDITENDERECO.Enabled = false;
            EDITNUMERO.Enabled = false;
            EDITBAIRRO.Enabled = false;
            EDITCIDADECONTROLE.Enabled = false;
            EDITCIDADE.Enabled = false;
            EDITCEP.Enabled = false;
            EDITEMAIL.Enabled = false;
            EDITDDD.Enabled = false;
            EDITTELEFONE.Enabled = false;
            EDITCPF.Enabled = false;
            EDITRG.Enabled = false;
            EDITCATEGORIACNH.Enabled = false;
            EDITCOMPLEMENTO.Enabled = false;
            BOTAOSALVARMOTORISTA.Enabled = false;
            BOTAOATUALIZARCADASTRO.Enabled = false;
            BOTAOEXCLUIRCADASTRO.Enabled = false;
            EDITDATAEMISSAO.Enabled = false;
            EDITNUMEROCNH.Enabled = false;
            EDITDDD1.Enabled = false;
            EDITTELEFONE1.Enabled = false;
            BOTAOCEP.Enabled = false;
            BOTAOCIDADE.Enabled = false;
            EDITCODIGOCADASTRO.Enabled = false;
            EDITCIDADECONTROLE.Visible = false;
        }

        private void limpaTela()
        {
            EDITSEXO.SelectedIndex = -1;
            EDITNOMEMOTORISTA.Clear();
            EDITENDERECO.Clear();
            EDITNUMERO.Clear();
            EDITBAIRRO.Clear();
            EDITCIDADECONTROLE.Clear();
            EDITCIDADE.Clear();
            EDITCEP.Clear();
            EDITEMAIL.Clear();
            EDITDDD.Clear();
            EDITTELEFONE.Clear();
            EDITCPF.Clear();
            EDITRG.Clear();
            EDITCATEGORIACNH.SelectedIndex = -1;
            EDITCOMPLEMENTO.Clear();
            EDITDATAEMISSAO.Clear();
            EDITNUMEROCNH.Clear();
            EDITDDD1.Clear();
            EDITTELEFONE1.Clear();
            EDITCODIGOCADASTRO.Clear();

        }

        public Boolean validaMotorista()
        {
            Boolean resultado = true;

            Funcoes funcoes = new Funcoes();

            String numerocep = funcoes.ApenasNumeros(EDITCEP.Text);

            if (String.IsNullOrEmpty(EDITNOMEMOTORISTA.Text) || EDITNOMEMOTORISTA.Text.All(char.IsNumber))
            {
                MessageBox.Show("Infomre um nome!", "NOME");
                resultado = false;
            }
            else if (EDITSEXO.SelectedItem == null)
            {
                MessageBox.Show("Informe um sexo!", "SEXO");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITRG.Text))
            {
                MessageBox.Show("Informe o RG", "RG");
                resultado = false;
            }
            else if ((!String.IsNullOrEmpty(EDITCPF.Text)) && (funcoes.validarCpf(funcoes.ApenasNumeros(EDITCPF.Text)) == false))
            {
                MessageBox.Show("Informe um CPF válido!", "CPF");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITNUMEROCNH.Text) || !EDITNUMEROCNH.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o numero da categoria CNH!", "NUMERO CNH");
                resultado = false;
            }
            else if (EDITCATEGORIACNH.SelectedItem == null)
            {
                MessageBox.Show("Informe uma categoria CNH!", "Categoria CNH");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITCIDADE.Text) || EDITCIDADE.Text.All(char.IsNumber))
            {
                MessageBox.Show("A cidade deverá ser informada.", "CIDADE");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITENDERECO.Text) || EDITENDERECO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe um enderço", "ENDERECO");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITNUMERO.Text))
            {
                MessageBox.Show("Informe um número do endereço", "NUMERO");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITBAIRRO.Text))
            {
                MessageBox.Show("Informe um bairro", "BAIRRO");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(numerocep))
            {
                MessageBox.Show("Informe um CEP", "CEP");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITDDD1.Text))
            {
                MessageBox.Show("Informe o DDD", "DDD CELULAR");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(funcoes.ApenasNumeros(EDITTELEFONE1.Text)))
            {
                MessageBox.Show("Informe o número do Celular", "NUMERO CELULAR");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOEXCLUIRCADASTRO_Click(object sender, EventArgs e)
        {
            MotoristaModelo motorista = new MotoristaModelo();

            MotoristaControle motoristacontrole = new MotoristaControle();
            motoristacontrole.excluir(motorista);

            MessageBox.Show("Cadastro excluido com sucesso", "Cadastro Motorista");
            limpaTela();
        }

        private void EDITRGCADASTRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void EDITCATEGORIACNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BOTAOLIMPARTELACADASTRO_Click(object sender, EventArgs e)
        {
            limpaTela();
            BOTAOATUALIZARCADASTRO.Enabled = false;
            BOTAOEXCLUIRCADASTRO.Enabled = false;
        }

        private void EDITTELEFONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void EDITNOMECADASTRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDITRG.Focus();
            }
        }

        private void EDITINSCRICAOESTADUAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDITCPF.Focus();
            }
        }

        private void MASKCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDITCPF.Focus();
            }
        }

        private void MASKDATANASCIMENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDITNUMEROCNH.Focus();
            }
        }

        private void BOTAOSAIR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            BOTAOLIMPARTELACADASTRO.Enabled = true;
            BOTAOSALVARMOTORISTA.Enabled = true;
            EDITSEXO.Enabled = true;
            EDITNOMEMOTORISTA.Enabled = true;
            EDITENDERECO.Enabled = true;
            EDITNUMERO.Enabled = true;
            EDITBAIRRO.Enabled = true;
            EDITCIDADECONTROLE.Enabled = true;
            EDITCIDADE.Enabled = false;
            EDITCEP.Enabled = true;
            EDITEMAIL.Enabled = true;
            EDITDDD.Enabled = true;
            EDITTELEFONE.Enabled = true;
            EDITCPF.Enabled = true;
            EDITRG.Enabled = true;
            EDITCATEGORIACNH.Enabled = true;
            EDITCOMPLEMENTO.Enabled = true;
            BOTAOSALVARMOTORISTA.Enabled = true;
            BOTAOATUALIZARCADASTRO.Enabled = true;
            BOTAOEXCLUIRCADASTRO.Enabled = true;
            EDITDATAEMISSAO.Enabled = true;
            EDITNUMEROCNH.Enabled = true;
            EDITDDD1.Enabled = true;
            EDITTELEFONE1.Enabled = true;
            BOTAOCEP.Enabled = true;
            BOTAOCIDADE.Enabled = true;
            EDITCODIGOCADASTRO.Enabled = false;
        }

        private void BOTAOSALVARMOTORISTA_Click(object sender, EventArgs e)
        {
            if (validaMotorista())
            {
                MotoristaModelo motorista = new MotoristaModelo();
                Funcoes funcoes = new Funcoes();

                if (EDITCODIGOCADASTRO.Text != "" && EDITCODIGOCADASTRO.Text != null)
                {
                    motorista.codigo = Convert.ToInt32(EDITCODIGOCADASTRO.Text);
                }
                motorista.nome = EDITNOMEMOTORISTA.Text;
                motorista.sexo = EDITSEXO.Text;
                motorista.rg = EDITRG.Text;
                motorista.cpf = EDITCPF.Text.Replace(',', '.');
                if (funcoes.ApenasNumeros(EDITDATAEMISSAO.Text) != "" && funcoes.ApenasNumeros(EDITDATAEMISSAO.Text) != null)
                {
                    motorista.datavalidade = DateTime.Parse(EDITDATAEMISSAO.Text, new System.Globalization.CultureInfo("pt-BR"));
                }
                motorista.habilitacao = EDITNUMEROCNH.Text;
                motorista.categoria = EDITCATEGORIACNH.Text;
                motorista.logradouro = EDITENDERECO.Text;
                motorista.numero = EDITNUMERO.Text;
                motorista.complemento = EDITCOMPLEMENTO.Text;
                motorista.bairro = EDITBAIRRO.Text;
                motorista.cep = EDITCEP.Text;
                motorista.ddd = EDITDDD.Text;
                motorista.telefone = EDITTELEFONE.Text;
                motorista.dddcelular = EDITDDD1.Text;
                motorista.celular = EDITTELEFONE1.Text;
                motorista.email = EDITEMAIL.Text;
                motorista.cidadecontrole = Convert.ToInt32(EDITCIDADECONTROLE.Text);

                MotoristaControle motoristacontrole = new MotoristaControle();
                if (EDITCODIGOCADASTRO.Text != "" && EDITCODIGOCADASTRO.Text != null)
                {
                    motoristacontrole.alterar(motorista);
                }
                else
                {
                    motoristacontrole.salvar(motorista);
                }
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Motorista");
                limpaTela();
            }
        }

        private void BOTAOCEP_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    if (EDITCEP.Text != "" && EDITCEP.Text != null)
                    {
                        var resultado = ws.consultaCEP(EDITCEP.Text);
                        EDITENDERECO.Text = resultado.end;
                        EDITCIDADE.Text = resultado.cidade;
                        EDITESTADO.Text = resultado.uf;
                        EDITBAIRRO.Text = resultado.bairro;

                        if (EDITCIDADE.Text != "" && EDITCIDADE.Text != null)
                        {
                            CidadeModelo cidade = new CidadeModelo();
                            cidade.nome = EDITCIDADE.Text;
                            CidadePersistencia cidcontrole = new CidadePersistencia();
                            cidade = cidcontrole.atualizatela(cidade);
                            EDITCIDADECONTROLE.Text = Convert.ToString(cidade.controle);
                            EDITCIDADE.Text = cidade.nome;
                            LABELUFSIGLA.Text = cidade.uf;
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
                EDITCIDADECONTROLE.Text = Convert.ToString(cidade.controle);
            }
        }

        private void BOTAOEXCLUIRCADASTRO_Click_1(object sender, EventArgs e)
        {
            MotoristaModelo motorista = new MotoristaModelo();

            motorista.codigo = Convert.ToInt32(EDITCODIGOCADASTRO.Text);

            MotoristaControle motoristacontrole = new MotoristaControle();
            motoristacontrole.excluir(motorista);

            MessageBox.Show("Cadastro excluido com sucesso", "Cadastro Motorista");
            limpaTela();
        }

        private void EDITDDD1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void EDITTELEFONE1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BOTAOLOCALIZARCADASTRO_Click_1(object sender, EventArgs e)
        {
            FmotoristaLoc motoristaLocFrm = new FmotoristaLoc();
            motoristaLocFrm.ShowDialog();

            if (motoristaLocFrm.codigoretornado != "" && motoristaLocFrm.codigoretornado != null)
            {
                MotoristaModelo motorista = new MotoristaModelo();
                MotoristaControle MotoristaControle = new MotoristaControle();
                motorista.codigo = int.Parse(motoristaLocFrm.codigoretornado);
                if (motorista.codigo > 0)
                {
                    motorista = MotoristaControle.atualizatela(motorista);

                    EDITCODIGOCADASTRO.Text = Convert.ToString(motorista.codigo);
                    EDITNOMEMOTORISTA.Text = motorista.nome;
                    EDITCPF.Text = motorista.cpf;
                    EDITRG.Text = motorista.rg;
                    EDITENDERECO.Text = motorista.logradouro;
                    EDITNUMERO.Text = motorista.numero;
                    EDITCOMPLEMENTO.Text = motorista.complemento;
                    EDITBAIRRO.Text = motorista.bairro;
                    EDITCIDADECONTROLE.Text = Convert.ToString(motorista.cidadecontrole);
                    EDITCEP.Text = motorista.cep;
                    EDITDDD.Text = motorista.ddd;
                    EDITTELEFONE.Text = motorista.telefone;
                    EDITDDD1.Text = motorista.dddcelular;
                    EDITTELEFONE1.Text = motorista.celular;
                    EDITNUMEROCNH.Text = motorista.habilitacao;
                    EDITCATEGORIACNH.Text = motorista.categoria;

                    if (motorista.datavalidade != DateTime.MinValue)  //data nao foi iniciada
                    {
                        DateTime wdata = new DateTime();
                        wdata = motorista.datavalidade;
                        EDITDATAEMISSAO.Text = wdata.ToShortDateString();
                    }
                    EDITSEXO.Text = motorista.sexo;
                    EDITEMAIL.Text = motorista.email;

                    if (motorista.cidadecontrole > 0)
                    {
                        CidadeModelo cidade = new CidadeModelo();

                        cidade.controle = motorista.cidadecontrole;
                        CidadePersistencia CidadeControle = new CidadePersistencia();
                        cidade = CidadeControle.atualizatela(cidade);

                        EDITCIDADECONTROLE.Text = Convert.ToString(cidade.controle);
                        EDITCIDADE.Text = cidade.nome;
                        LABELUFSIGLA.Text = cidade.uf;

                    }
                }
                BOTAONOVO_Click(sender, e);
            }
        }

        private void BOTAOLIMPARTELACADASTRO_Click_1(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void EDITDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EDITDATAEMISSAO_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATAEMISSAO.Text) == false)
            {
                EDITDATAEMISSAO.Clear();
                EDITDATAEMISSAO.Focus();
            }
        }

        private void BOTAOATUALIZARCADASTRO_Click_1(object sender, EventArgs e)
        {
            if (validaMotorista())
            {
                MotoristaModelo motorista = new MotoristaModelo();
                Funcoes funcoes = new Funcoes();

                if (EDITCODIGOCADASTRO.Text != "" && EDITCODIGOCADASTRO.Text != null)
                {
                    motorista.codigo = Convert.ToInt32(EDITCODIGOCADASTRO.Text);
                }
                motorista.nome = EDITNOMEMOTORISTA.Text;
                motorista.sexo = EDITSEXO.Text;
                motorista.rg = EDITRG.Text;
                motorista.cpf = EDITCPF.Text.Replace(',', '.');
                if (funcoes.ApenasNumeros(EDITDATAEMISSAO.Text) != "" && funcoes.ApenasNumeros(EDITDATAEMISSAO.Text) != null)
                {
                    motorista.datavalidade = DateTime.Parse(EDITDATAEMISSAO.Text, new System.Globalization.CultureInfo("pt-BR"));
                }
                motorista.habilitacao = EDITNUMEROCNH.Text;
                motorista.categoria = EDITCATEGORIACNH.Text;
                motorista.logradouro = EDITENDERECO.Text;
                motorista.numero = EDITNUMERO.Text;
                motorista.complemento = EDITCOMPLEMENTO.Text;
                motorista.bairro = EDITBAIRRO.Text;
                motorista.cep = EDITCEP.Text;
                motorista.ddd = EDITDDD.Text;
                motorista.telefone = EDITTELEFONE.Text;
                motorista.dddcelular = EDITDDD1.Text;
                motorista.celular = EDITTELEFONE1.Text;
                motorista.email = EDITEMAIL.Text;
                motorista.cidadecontrole = Convert.ToInt32(EDITCIDADECONTROLE.Text);

                MotoristaControle motoristacontrole = new MotoristaControle();
                if (EDITCODIGOCADASTRO.Text != "" && EDITCODIGOCADASTRO.Text != null)
                {
                    motoristacontrole.alterar(motorista);
                }
                else
                {
                    motoristacontrole.salvar(motorista);
                }
                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro Motorista");
                limpaTela();
            }
        }

    }
}

