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
using Controle_Veiculos.Classes.Model;
using Controle_Veiculos.Classes.Controller;
using Controle_Veiculos.Classes.View;
using System.IO;
using Correios.Net;



namespace Controle_Veiculos
{
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {
            COMBOTIPOCADASTRO.Enabled = false;
            COMBOESTADO.Enabled = false;
            EDITNOMECADASTRO.Enabled = false;
            EDITENDERECO.Enabled = false;
            EDITNUMERO.Enabled = false;
            EDITBAIRRO.Enabled = false;
            EDITCIDADE.Enabled = false;
            MASKCEP.Enabled = false;
            EDITEMAIL.Enabled = false;
            EDITDDD.Enabled = false;
            EDITTELEFONE.Enabled = false;
            MASKDATANASCIMENTO.Enabled = false;
            MASKCPFCNPJ.Enabled = false;
            EDITINSCRICAOESTADUAL.Enabled = false;
            EDITCATEGORIACNH.Enabled = false;
            EDITCOMPLEMENTO.Enabled = false;
            BOTAOSALVARCADASTRO.Enabled = false;
            BOTAOATUALIZARCADASTRO.Enabled = false;
            BOTAOEXCLUIRCADASTRO.Enabled = false;
            MASKDATAEMISSAOCNH.Enabled = false;
            MASKDATAVALIDADECNH.Enabled = false;
            EDITNUMEROCNH.Enabled = false;
        }

        private void limpaTela()
        {
            COMBOTIPOCADASTRO.Text = "";
            COMBOESTADO.Text = "";
            EDITCODICOCADASTRO.Clear();
            EDITNOMECADASTRO.Clear();
            EDITENDERECO.Clear();
            EDITNUMERO.Clear();
            EDITBAIRRO.Clear();
            EDITCIDADE.Clear();
            MASKCEP.Clear();
            EDITEMAIL.Clear();
            EDITDDD.Clear();
            EDITDDD.Clear();
            MASKCPFCNPJ.Clear();
            EDITINSCRICAOESTADUAL.Clear();
            EDITTELEFONE.Clear();
            CHECKCELULAR.Checked = false;
            EDITCOMPLEMENTO.Clear();
            EDITNUMEROCNH.Clear();
            EDITCATEGORIACNH.Clear();
            BOTAOSALVARCADASTRO.Enabled = false;
        }

        public static bool validarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool validarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);

        }

        public static bool validarEmail(string email)
        {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }

        public bool validaDado()
        {

            bool validaDado;
            validaDado = true;
            if (COMBOTIPOCADASTRO.Text == "CLIENTE")
            {
                if (String.IsNullOrEmpty(EDITNOMECADASTRO.Text) || EDITNOMECADASTRO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Razao social invalida", "Razao Social");
                    validaDado = false;
                }

                else if (validarCNPJ(MASKCPFCNPJ.Text) == false)
                {
                    MessageBox.Show("CNPJ invalido", "CNPJ");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITENDERECO.Text) || EDITENDERECO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Endereco invalido", "Endereco");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITNUMERO.Text) || !EDITNUMERO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Numero invalido", "Endereco");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITBAIRRO.Text) || EDITBAIRRO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Bairro invalido", "Endereco");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITCIDADE.Text) || EDITCIDADE.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Cidade invalida", "Endereco");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(COMBOESTADO.Text))
                {
                    MessageBox.Show("Estado invalido", "Endereco");
                    validaDado = false;
                }
                else if (CHECKCELULAR.Checked == false)
                {
                    MessageBox.Show("Necessario informar um telefone", "Telefone");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITDDD.Text) || !EDITDDD.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Necessario infornar um DDD", "DDD");
                    validaDado = false;
                }

                else if (validarEmail(EDITEMAIL.Text) == false)
                {
                    MessageBox.Show("Email invalido", "E-mail");
                    validaDado = false;
                }

            }
            if (COMBOTIPOCADASTRO.Text == "CONDUTOR")
            {

                if (String.IsNullOrEmpty(EDITNOMECADASTRO.Text) || EDITNOMECADASTRO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("O nome deve ser preenchido", "Nome / Razao Social");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITINSCRICAOESTADUAL.Text) || !EDITINSCRICAOESTADUAL.Text.All(char.IsNumber))
                {
                    MessageBox.Show("RG / Inscricao Estadual invalido", "RG / Inscricao Estadual");
                    validaDado = false;
                }

                else if (validarCpf(MASKCPFCNPJ.Text) == false)
                {
                    MessageBox.Show("CPF invalido", "CPF");
                    validaDado = false;
                }
                else if (Convert.ToDateTime(MASKDATANASCIMENTO.Value).ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Data nascimento invalida", "Data nascimento");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITNUMEROCNH.Text) || !EDITNUMEROCNH.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Numero CNH invalido", "Numero CNH");
                    validaDado = false;
                }
                else if (String.IsNullOrEmpty(EDITCATEGORIACNH.Text) || EDITCATEGORIACNH.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Categoria CNH invalido", "Categoria CNH");
                    validaDado = false;
                }
                else if (Convert.ToDateTime(MASKDATAEMISSAOCNH.Value).ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Data emissao CNH invalida", "Data emissao CNH");
                    validaDado = false;
                }
                else if (Convert.ToDateTime(MASKDATAVALIDADECNH.Value).ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Data validade CNH invalida", "Data validade CNH");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITENDERECO.Text) || EDITENDERECO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Endereco invalido", "Endereco");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITNUMERO.Text) || !EDITNUMERO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Numero invalido", "Endereco");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITBAIRRO.Text) || EDITBAIRRO.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Bairro invalido", "Endereco");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITCIDADE.Text) || EDITCIDADE.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Cidade invalida", "Endereco");
                    validaDado = false;
                }

                else if (COMBOESTADO.Text == "")
                {
                    MessageBox.Show("Estado invalido", "Endereco");
                    validaDado = false;
                }

                else if (CHECKCELULAR.Checked == false)
                {
                    MessageBox.Show("Necessario informar um telefone", "Telefone");
                    validaDado = false;
                }

                else if (String.IsNullOrEmpty(EDITDDD.Text) || !EDITDDD.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Necessario infornar um DDD", "DDD");
                    validaDado = false;
                }
                else if (EDITTELEFONE.Text == "" && EDITTELEFONE.Text == null)
                {
                    MessageBox.Show("Necessario infornar um numero do telefone", "Telefone");
                    validaDado = false;
                }
                else if (validarEmail(EDITEMAIL.Text) == false)
                {
                    MessageBox.Show("Email invalido", "E-mail");
                    validaDado = false;
                }
            }
            return validaDado;
        }

        private void BOTAOATUALIZARCADASTRO_Click(object sender, EventArgs e)
        {

            Cadastro cadastro = new Cadastro();
            cadastro.codigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            cadastro.razaosocial = EDITNOMECADASTRO.Text;
            cadastro.rginsestadual = EDITINSCRICAOESTADUAL.Text;
            cadastro.cpfcnpj = MASKCPFCNPJ.Text;
            cadastro.datanascimento = MASKDATANASCIMENTO.Value;
            cadastro.tipo = COMBOTIPOCADASTRO.Text;
            CadastroController cadcontroller = new CadastroController();
            cadcontroller.alterar(cadastro);

            Endereco endereco = new Endereco();
            endereco.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            endereco.logradouro = EDITENDERECO.Text;
            endereco.numero = EDITNUMERO.Text;
            endereco.complemento = EDITCOMPLEMENTO.Text;
            endereco.bairro = EDITBAIRRO.Text;
            endereco.cep = MASKCEP.Text;
            endereco.estado = COMBOESTADO.Text;
            EnderecoController endcontroller = new EnderecoController();
            endcontroller.alterar(endereco);

            Telefone telefone = new Telefone();
            telefone.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            telefone.ddd = EDITDDD.Text;
            telefone.telefone = EDITTELEFONE.Text;
            telefone.tipo = "TELEFONE";
            telefone.email = EDITEMAIL.Text;
            TelefoneController telcontroller = new TelefoneController();
            telcontroller.alterar(telefone);

            Cidade cidade = new Cidade();
            cidade.nome = EDITCIDADE.Text;
            cidade.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            CidadeController cidcontroller = new CidadeController();
            cidcontroller.alterar(cidade);

            Documentacao documento = new Documentacao();
            documento.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            documento.categoria = EDITCATEGORIACNH.Text;
            documento.dataemissao = MASKDATAEMISSAOCNH.Value;
            documento.datavalidade = MASKDATAVALIDADECNH.Value;
            documento.numerocnh = EDITNUMEROCNH.Text;

            MessageBox.Show("Cadastro atualizado com sucesso");
            limpaTela();
        }

        private void BOTAOLOCALIZARCADASTRO_Click(object sender, EventArgs e)
        {

            FpessoaLoc pessoaLocFrm = new FpessoaLoc();
            pessoaLocFrm.ShowDialog();

            Cadastro cadastro = new Cadastro();
            CadastroController cadcontroller = new CadastroController();
            if (pessoaLocFrm.codigoretornado != "" && pessoaLocFrm.codigoretornado != null)
            {
                cadastro.codigo = int.Parse(pessoaLocFrm.codigoretornado);
                cadastro = cadcontroller.atualizatela(cadastro);

                EDITCODICOCADASTRO.Text = Convert.ToString(cadastro.codigo);
                EDITNOMECADASTRO.Text = cadastro.razaosocial;
                EDITINSCRICAOESTADUAL.Text = cadastro.rginsestadual;
                MASKCPFCNPJ.Text = cadastro.cpfcnpj;
                MASKDATANASCIMENTO.Value = cadastro.datanascimento;
                COMBOTIPOCADASTRO.Text = cadastro.tipo;

                //Dados da tabela telefone
                Telefone telefone = new Telefone();
                telefone.cadcodigo = cadastro.codigo;
                TelefoneController telcontroller = new TelefoneController();
                telefone = telcontroller.atualizatela(telefone);
                EDITEMAIL.Text = telefone.email;
                EDITDDD.Text = telefone.ddd;
                EDITTELEFONE.Text = telefone.telefone;


                //Dados da tabela Endereco
                Endereco endereco = new Endereco();
                endereco.cadcodigo = cadastro.codigo;
                EnderecoController endcontroller = new EnderecoController();
                endereco = endcontroller.atualizatela(endereco);

                EDITENDERECO.Text = endereco.logradouro;
                EDITBAIRRO.Text = endereco.bairro;
                EDITNUMERO.Text = endereco.numero;
                MASKCEP.Text = endereco.cep;
                EDITCOMPLEMENTO.Text = endereco.complemento;
                COMBOESTADO.Text = endereco.estado;

                //Dados da tabela cidade
                Cidade cidade = new Cidade();
                cidade.cadcodigo = cadastro.codigo;
                CidadeController cidcontroller = new CidadeController();
                cidade = cidcontroller.atualizatela(cidade);
                EDITCIDADE.Text = cidade.nome;

                //Dados da tabela documentacao
                Documentacao documento = new Documentacao();
                documento.cadcodigo = cadastro.codigo;
                DocumentacaoController doccontroller = new DocumentacaoController();
                documento = doccontroller.atualizatela(documento);
                EDITNUMEROCNH.Text = documento.numerocnh;
                EDITCATEGORIACNH.Text = documento.categoria;
                if (documento.dataemissao != Convert.ToDateTime("01/01/0001 00:00:00"))
                {
                    MASKDATAEMISSAOCNH.Value = documento.dataemissao;
                }
                if (documento.datavalidade != Convert.ToDateTime("01/01/0001 00:00:00"))
                {
                    MASKDATAVALIDADECNH.Value = documento.datavalidade;
                }
            }

            if (COMBOTIPOCADASTRO.Text == "CLIENTE")
            {
                MASKCPFCNPJ.Mask = "00.000.000/0000-00";
                MASKDATANASCIMENTO.Enabled = false;
                MASKCPFCNPJ.Enabled = true;
                EDITCATEGORIACNH.Enabled = false;
                MASKDATAVALIDADECNH.Enabled = false;
                MASKCEP.Enabled = true;
                COMBOESTADO.Enabled = true;
                CHECKCELULAR.Checked = true;
                EDITCATEGORIACNH.Enabled = false;
                EDITINSCRICAOESTADUAL.Enabled = true;
                EDITNOMECADASTRO.Enabled = true;
                EDITENDERECO.Enabled = true;
                EDITBAIRRO.Enabled = true;
                EDITCIDADE.Enabled = true;
                EDITNUMERO.Enabled = true;
                EDITCOMPLEMENTO.Enabled = true;
                EDITEMAIL.Enabled = true;
                EDITNUMEROCNH.Enabled = false;
                MASKDATAEMISSAOCNH.Enabled = false;
                BOTAOEXCLUIRCADASTRO.Enabled = true;
                BOTAOATUALIZARCADASTRO.Enabled = true;
                BOTAOLIMPARTELACADASTRO.Enabled = true;
                BOTAOEXCLUIRCADASTRO.Enabled = true;
                COMBOTIPOCADASTRO.Enabled = true;
                CHECKCELULAR.Enabled = true;
                BOTAOSALVARCADASTRO.Enabled = true;

            }
            else
            {
                MASKCPFCNPJ.Mask = "000.000.000-00";
                MASKDATANASCIMENTO.Enabled = true;
                MASKDATAEMISSAOCNH.Enabled = true;
                MASKDATAVALIDADECNH.Enabled = true;
                MASKCEP.Enabled = true;
                EDITCATEGORIACNH.Enabled = true;
                COMBOESTADO.Enabled = true;
                CHECKCELULAR.Checked = true;
                MASKCPFCNPJ.Enabled = true;
                EDITINSCRICAOESTADUAL.Enabled = false;
                EDITNOMECADASTRO.Enabled = true;
                EDITENDERECO.Enabled = true;
                EDITBAIRRO.Enabled = true;
                EDITCIDADE.Enabled = true;
                EDITNUMERO.Enabled = true;
                EDITCOMPLEMENTO.Enabled = true;
                EDITEMAIL.Enabled = true;
                EDITNUMEROCNH.Enabled = true;
                BOTAOEXCLUIRCADASTRO.Enabled = true;
                BOTAOATUALIZARCADASTRO.Enabled = true;
                EDITINSCRICAOESTADUAL.Enabled = true;
                BOTAOLIMPARTELACADASTRO.Enabled = true;
                BOTAOEXCLUIRCADASTRO.Enabled = true;
                COMBOTIPOCADASTRO.Enabled = true;
                BOTAOSALVARCADASTRO.Enabled = true;
            }
        }

        private void BOTAOEXCLUIRCADASTRO_Click(object sender, EventArgs e)
        {
            BOTAOATUALIZARCADASTRO.Enabled = false;

            Cidade cidade = new Cidade();
            cidade.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            CidadeController cidcontroller = new CidadeController();
            cidcontroller.excluir(cidade);

            Documentacao documento = new Documentacao();
            documento.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            DocumentacaoController doccontroller = new DocumentacaoController();
            doccontroller.excluir(documento);

            Endereco endereco = new Endereco();
            endereco.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            EnderecoController endcontroller = new EnderecoController();
            endcontroller.excluir(endereco);

            Telefone telefone = new Telefone();
            telefone.cadcodigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            TelefoneController telcontroller = new TelefoneController();
            telcontroller.excluir(telefone);

            Cadastro cadastro = new Cadastro();
            cadastro.codigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            CadastroController cadcontroller = new CadastroController();
            cadcontroller.excluir(cadastro);

            Veiculo veiculo = new Veiculo();
            veiculo.codigo = Int32.Parse(EDITCODICOCADASTRO.Text);
            VeiculoController veicontroller = new VeiculoController();

            if (veicontroller.excluir(veiculo) == true)
            {
                MessageBox.Show("Cadastro excluído com sucesso");
            }
            else
            {
                MessageBox.Show("O veículo não pode ser excluído pois existem registros de locação ou manutenção");
            }
            limpaTela();
        }

        private void BOTAOSALVARCADASTRO_Click(object sender, EventArgs e)
        {
            BOTAOEXCLUIRCADASTRO.Enabled = false;
            BOTAOATUALIZARCADASTRO.Enabled = false;

            //Chamado o metodo validadados caso todos as validacoes sejam verdadeiras executada a gravacao.
            if (validaDado())
            {
                //Gravando dados na tabela cadastro
                Cadastro cadastro = new Cadastro();
                cadastro.tipo = COMBOTIPOCADASTRO.Text;
                cadastro.razaosocial = EDITNOMECADASTRO.Text;
                if (EDITINSCRICAOESTADUAL.Text != "")
                {
                    cadastro.rginsestadual = EDITINSCRICAOESTADUAL.Text;
                }
                else
                {
                    cadastro.rginsestadual = "";
                }

                if (MASKDATANASCIMENTO.Text != "")
                {
                    cadastro.datanascimento = MASKDATANASCIMENTO.Value;
                }
                else
                {
                    cadastro.datanascimento = DateTime.Parse("");
                }

                cadastro.cpfcnpj = MASKCPFCNPJ.Text;

                CadastroController cadcontroller = new CadastroController();

                int cadcodigo;
                cadcodigo = cadcontroller.salvar(cadastro);

                //Gravando dados na tabela Endereco
                Endereco endereco = new Endereco();
                endereco.logradouro = EDITENDERECO.Text;
                endereco.numero = EDITNUMERO.Text;
                endereco.bairro = EDITBAIRRO.Text;
                endereco.complemento = EDITCOMPLEMENTO.Text;
                endereco.cep = MASKCEP.Text;
                endereco.estado = COMBOESTADO.Text;
                endereco.cadcodigo = cadcodigo;

                EnderecoController endcontroller = new EnderecoController();
                endcontroller.salvar(endereco);

                //Gravando dados na tabela cidade
                Cidade cidade = new Cidade();
                cidade.nome = EDITCIDADE.Text;
                cidade.cadcodigo = cadcodigo;

                CidadeController cidcontroller = new CidadeController();
                cidcontroller.salvar(cidade);

                //Gravando dados na tabela Telefon
                Telefone telefone = new Telefone();
                telefone.email = EDITEMAIL.Text;
                telefone.cadcodigo = cadcodigo;
                telefone.ddd = EDITDDD.Text;
                telefone.tipo = "CELULAR";
                telefone.telefone = EDITTELEFONE.Text;
                TelefoneController telcontroller = new TelefoneController();
                telcontroller.salvar(telefone);

                //Gravando dados na tabela documentacao
                Documentacao documento = new Documentacao();
                documento.cadcodigo = cadcodigo;
                if (EDITNUMEROCNH.Text != "")
                {
                    documento.numerocnh = EDITNUMEROCNH.Text;
                }
                else
                {
                    documento.numerocnh = "";
                }
                if (EDITCATEGORIACNH.Text != "")
                {
                    documento.categoria = EDITCATEGORIACNH.Text;
                }
                else
                {
                    documento.categoria = "";
                }
                if (MASKDATAEMISSAOCNH.Text != "")
                {
                    documento.dataemissao = MASKDATAEMISSAOCNH.Value;
                }
                else
                {
                    documento.dataemissao = DateTime.Parse("");
                }
                if (MASKDATAVALIDADECNH.Text != "")
                {
                    documento.datavalidade = MASKDATAVALIDADECNH.Value;
                }
                else
                {
                    documento.datavalidade = DateTime.Parse("");
                }
                DocumentacaoController doccontroller = new DocumentacaoController();
                doccontroller.salvar(documento);

                MessageBox.Show("Cadastro realizado com sucesso");

                limpaTela();
            }
        }

        private void BOTAOSAIRCADASTRO_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void COMBOTIPOCADASTRO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMBOTIPOCADASTRO.Text == "CLIENTE")
            {
                MASKCPFCNPJ.Mask = "00.000.000/0000-00";
                MASKDATANASCIMENTO.Enabled = false;
                MASKCPFCNPJ.Enabled = true;
                EDITCATEGORIACNH.Enabled = false;
                MASKDATAVALIDADECNH.Enabled = false;
                MASKCEP.Enabled = true;
                COMBOESTADO.Enabled = true;
                CHECKCELULAR.Enabled = true;
                CHECKCELULAR.Enabled = true;
                EDITCATEGORIACNH.Enabled = false;
                EDITINSCRICAOESTADUAL.Enabled = true;
                EDITNOMECADASTRO.Enabled = true;
                EDITENDERECO.Enabled = true;
                EDITBAIRRO.Enabled = true;
                EDITCIDADE.Enabled = true;
                EDITNUMERO.Enabled = true;
                EDITCOMPLEMENTO.Enabled = true;
                EDITEMAIL.Enabled = true;
                EDITNUMEROCNH.Enabled = false;
                MASKDATAEMISSAOCNH.Enabled = false;
                BOTAOEXCLUIRCADASTRO.Enabled = true;
                BOTAOATUALIZARCADASTRO.Enabled = true;

            }
            else
            {
                MASKCPFCNPJ.Mask = "000.000.000-00";
                MASKDATANASCIMENTO.Enabled = true;
                MASKDATAEMISSAOCNH.Enabled = true;
                MASKDATAVALIDADECNH.Enabled = true;
                MASKCEP.Enabled = true;
                EDITCATEGORIACNH.Enabled = true;
                COMBOESTADO.Enabled = true;
                CHECKCELULAR.Enabled = true;
                CHECKCELULAR.Enabled = true;
                MASKCPFCNPJ.Enabled = true;
                EDITINSCRICAOESTADUAL.Enabled = false;
                EDITNOMECADASTRO.Enabled = true;
                EDITENDERECO.Enabled = true;
                EDITBAIRRO.Enabled = true;
                EDITCIDADE.Enabled = true;
                EDITNUMERO.Enabled = true;
                EDITCOMPLEMENTO.Enabled = true;
                EDITEMAIL.Enabled = true;
                EDITNUMEROCNH.Enabled = true;
                BOTAOEXCLUIRCADASTRO.Enabled = true;
                BOTAOATUALIZARCADASTRO.Enabled = true;
                EDITINSCRICAOESTADUAL.Enabled = true;
            }
        }

        private void BOTAOLIMPARTELACADASTRO_Click(object sender, EventArgs e)
        {
            limpaTela();
            BOTAOATUALIZARCADASTRO.Enabled = false;
            BOTAOEXCLUIRCADASTRO.Enabled = false;
        }

        private void CHECKCELULAR_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKCELULAR.Checked == true)
            {
                EDITDDD.Enabled = true;
                EDITTELEFONE.Enabled = true;
            }
            else if (CHECKCELULAR.Checked == false)
            {
                EDITTELEFONE.Enabled = false;
                EDITDDD.Enabled = false;
            }
        }

        private void BOTAONOVOCADASTRO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe o tipo de cadastro que deseja realizar", "Tipo de Cadastro");
            COMBOTIPOCADASTRO.Enabled = true;
            BOTAOLIMPARTELACADASTRO.Enabled = true;
            BOTAOSALVARCADASTRO.Enabled = true;
        }

        private void EDITTELEFONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void MASKCEP_Leave(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                var resultado = ws.consultaCEP(MASKCEP.Text);
                EDITENDERECO.Text = resultado.end;
                EDITCOMPLEMENTO.Text = resultado.complemento2;
                EDITCIDADE.Text = resultado.cidade;
                EDITBAIRRO.Text = resultado.bairro;
                COMBOESTADO.Text = resultado.uf;
            }
        }

        private void EDITNOMECADASTRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDITINSCRICAOESTADUAL.Focus();
            }
        }

        private void EDITINSCRICAOESTADUAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MASKCPFCNPJ.Focus();
            }
        }

        private void MASKCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MASKCPFCNPJ.Focus();
            }
        }

        private void MASKDATANASCIMENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDITNUMEROCNH.Focus();
            }
        }
    }
}

