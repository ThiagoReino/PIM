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
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Interface;
using Controle_Veiculos.Classes.Persistencia;


namespace Controle_Veiculos
{
    public partial class frmVeiculo : Form
    {

        public frmVeiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void limpaTela()
        {
            EDITCODIGO.Clear();
            EDITMARCAMODELOCODIGO.Clear();
            EDITMODELO.Clear();
            EDITPLACA.Clear();
            EDITCHASSI.Clear();
            EDITCOMBUSTIVEL.SelectedIndex = -1;
            EDITANOFABRICA.Clear();
            EDITANOMODELO.Clear();
            EDITCODIGORENAVAN.Clear();
            EDITEXERCICIO.Clear();
            EDITSITUACAO.SelectedIndex = -1;
            EDITMOTIVOBAIXA.Clear();
            EDITSEGURADORACODIGO.Clear();
        }

        private void BOTAOLIMPATELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            BOTAONOVO.Enabled = true;
            BOTAOSALVAR.Enabled = false;
            BOTAOATUALIZAR.Enabled = false;
            BOTAOEXCLUIRCADASTRO.Enabled = false;
            EDITEXERCICIO.MaxLength = 4;
            EDITPLACA.MaxLength = 9;
            EDITCHASSI.MaxLength = 20;
            EDITCOMBUSTIVEL.MaxLength = 8;
            EDITCODIGORENAVAN.MaxLength = 11;
            EDITSITUACAO.MaxLength = 7;
            EDITMOTIVOBAIXA.MaxLength = 60;
            EDITMARCAMODELOCODIGO.Visible = false;
            EDITSEGURADORACODIGO.Visible = false;
            EDITCODIGORENAVAN.Enabled = false;
            EDITEXERCICIO.Enabled = false;
            EDITPLACA.Enabled = false;
            EDITCHASSI.Enabled = false;
            EDITCOMBUSTIVEL.Enabled = false;
            EDITANOFABRICA.Enabled = false;
            EDITANOMODELO.Enabled = false;
            BOTAOMARCA.Enabled = false;
        }

        private void BOTAOSAIRVEICULO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAOMARCA_Click(object sender, EventArgs e)
        {
            FMarcamodeloLoc marcaFrmLoc = new FMarcamodeloLoc();
            marcaFrmLoc.ShowDialog();
            if (marcaFrmLoc.codigoretornado != "" && marcaFrmLoc.codigoretornado != null)
            {
                MarcamodeloModelo marca = new MarcamodeloModelo();
                marca.codigo = int.Parse(marcaFrmLoc.codigoretornado);
                MarcamodeloControle Marcacontrole = new MarcamodeloControle();
                marca = Marcacontrole.pesquisaMarca(marca);
                EDITMARCAMODELOCODIGO.Text = Convert.ToString(marca.codigo);
                EDITMODELO.Text = marca.descricao;
            }
        }

        public Boolean validaVeiculo()
        {
            int anofabrica = Convert.ToInt32(EDITANOFABRICA.Text);
            int anomomdelo = Convert.ToInt32(EDITANOMODELO.Text);

            Boolean resultado = true;

            Funcoes funcoes = new Funcoes();

            if (String.IsNullOrEmpty(EDITCODIGORENAVAN.Text) || !EDITCODIGORENAVAN.Text.All(char.IsNumber))
            {
                MessageBox.Show("Código do renavan não informado ou inválido!", "Código renavan");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITEXERCICIO.Text) || !EDITEXERCICIO.Text.All(char.IsNumber))
            {
                MessageBox.Show("O ano exercício do renavan não foi informado ou está inválido.", "Exercício");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITMARCAMODELOCODIGO.Text) || !EDITMARCAMODELOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a marca e modelo do veiculo.", "Marca / Modelo");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITPLACA.Text))
            {
                MessageBox.Show("Informe a placa do veiculo.", "Placa");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITCHASSI.Text))
            {
                MessageBox.Show("Informe o Chassi do veiculo.", "Chassi");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITCOMBUSTIVEL.Text))
            {
                MessageBox.Show("Informe o combustivel.", "Combustivel");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITANOFABRICA.Text) || !EDITANOFABRICA.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o ano de fabricacao.", "Ano Fabricacao");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITANOMODELO.Text) || !EDITANOMODELO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o ano do modelo.", "Ano Modelo");
                resultado = false;
            }
            else if (anofabrica > anomomdelo)
            //else if ((!String.IsNullOrEmpty(EDITANOMODELO.Text)) || (Convert.ToInt32(EDITANOFABRICA.Text) > Convert.ToInt32(EDITANOMODELO.Text)))
            {
                MessageBox.Show("O ano modelo e menor que ano de fabricacao!", "Ano Modelo");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOSALVAR_Click_1(object sender, EventArgs e)
        {
            if (validaVeiculo())
            {

                VeiculoModelo veiculo = new VeiculoModelo();
                Funcoes funcoes = new Funcoes();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    veiculo.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                if (EDITMARCAMODELOCODIGO.Text != "" && EDITMARCAMODELOCODIGO.Text != null)
                {
                    veiculo.marcamodelocodigo = int.Parse(EDITMARCAMODELOCODIGO.Text);
                }
                veiculo.placa = EDITPLACA.Text;
                veiculo.chassi = EDITCHASSI.Text;
                veiculo.combustivel = EDITCOMBUSTIVEL.Text;
                if (EDITANOFABRICA.Text != "" && EDITANOFABRICA.Text != null)
                {
                    veiculo.anofabrica = Convert.ToInt32(EDITANOFABRICA.Text);
                }
                if (EDITANOMODELO.Text != "" && EDITANOMODELO.Text != null)
                {
                    veiculo.anomodelo = Convert.ToInt32(EDITANOMODELO.Text);
                }
                veiculo.codigorenavan = EDITCODIGORENAVAN.Text;
                if (EDITEXERCICIO.Text != "" && EDITEXERCICIO.Text != null)
                {
                    veiculo.exercicio = Convert.ToInt32(EDITEXERCICIO.Text);
                }
                veiculo.situacao = EDITSITUACAO.Text;

                if (funcoes.ApenasNumeros(EDITDATAVENDA.Text) != "" && funcoes.ApenasNumeros(EDITDATAVENDA.Text) != null)
                {
                    veiculo.datavenda = Convert.ToDateTime(EDITDATAVENDA.Text);
                }
                if (EDITVALORVENDA.Text != "" && EDITVALORVENDA.Text != null)
                {
                    veiculo.valorvenda = Convert.ToDecimal(EDITVALORVENDA.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATABAIXA.Text) != "" && funcoes.ApenasNumeros(EDITDATABAIXA.Text) != null)
                {
                    veiculo.databaixa = Convert.ToDateTime(EDITDATABAIXA.Text);
                }
                veiculo.motivobaixa = EDITMOTIVOBAIXA.Text;
                if (EDITSEGURADORA.Text != "" && EDITSEGURADORA.Text != null)
                {
                    veiculo.seguradoracodigo = int.Parse(EDITSEGURADORA.Text);
                }
                if (funcoes.ApenasNumeros(EDITINICIOVIGENCIA.Text) != "" && funcoes.ApenasNumeros(EDITINICIOVIGENCIA.Text) != null)
                {
                    veiculo.datainiciovigencia = Convert.ToDateTime(EDITINICIOVIGENCIA.Text);
                }
                if (funcoes.ApenasNumeros(EDITFIMVIGENCIA.Text) != "" && funcoes.ApenasNumeros(EDITFIMVIGENCIA.Text) != null)
                {
                    veiculo.datafimvigencia = Convert.ToDateTime(EDITFIMVIGENCIA.Text);
                }
                VeiculoControle veiculocontrole = new VeiculoControle();
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    veiculocontrole.alterar(veiculo);
                }
                else
                {
                    veiculocontrole.salvar(veiculo);
                }

                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Veiculo");
                limpaTela();

            }
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            BOTAOSALVAR.Enabled = true;
            BOTAOLOCALIZARCADASTRO.Enabled = true;
            BOTAONOVO.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
            BOTAOEXCLUIRCADASTRO.Enabled = true;
            EDITCODIGORENAVAN.Enabled = true;
            EDITEXERCICIO.Enabled = true;
            EDITPLACA.Enabled = true;
            EDITCHASSI.Enabled = true;
            EDITCOMBUSTIVEL.Enabled = true;
            EDITANOFABRICA.Enabled = true;
            EDITANOMODELO.Enabled = true;
            BOTAOMARCA.Enabled = true;
        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            VeiculoModelo veiculo = new VeiculoModelo();
            veiculo.codigo = Int32.Parse(EDITCODIGO.Text);
            VeiculoControle veiculoControle = new VeiculoControle();
            veiculoControle.excluir(veiculo);
            MessageBox.Show("Cadastro excluído com sucesso");
            limpaTela();
        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaVeiculo())
            {

                VeiculoModelo veiculo = new VeiculoModelo();
                Funcoes funcoes = new Funcoes();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    veiculo.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                if (EDITMARCAMODELOCODIGO.Text != "" && EDITMARCAMODELOCODIGO.Text != null)
                {
                    veiculo.marcamodelocodigo = int.Parse(EDITMARCAMODELOCODIGO.Text);
                }
                veiculo.placa = EDITPLACA.Text;
                veiculo.chassi = EDITCHASSI.Text;
                veiculo.combustivel = EDITCOMBUSTIVEL.Text;
                if (EDITANOFABRICA.Text != "" && EDITANOFABRICA.Text != null)
                {
                    veiculo.anofabrica = Convert.ToInt32(EDITANOFABRICA.Text);
                }
                if (EDITANOMODELO.Text != "" && EDITANOMODELO.Text != null)
                {
                    veiculo.anomodelo = Convert.ToInt32(EDITANOMODELO.Text);
                }
                veiculo.codigorenavan = EDITCODIGORENAVAN.Text;
                if (EDITEXERCICIO.Text != "" && EDITEXERCICIO.Text != null)
                {
                    veiculo.exercicio = Convert.ToInt32(EDITEXERCICIO.Text);
                }
                veiculo.situacao = EDITSITUACAO.Text;

                if (funcoes.ApenasNumeros(EDITDATAVENDA.Text) != "" && funcoes.ApenasNumeros(EDITDATAVENDA.Text) != null)
                {
                    veiculo.datavenda = Convert.ToDateTime(EDITDATAVENDA.Text);
                }
                if (EDITVALORVENDA.Text != "" && EDITVALORVENDA.Text != null)
                {
                    veiculo.valorvenda = Convert.ToDecimal(EDITVALORVENDA.Text);
                }
                if (funcoes.ApenasNumeros(EDITDATABAIXA.Text) != "" && funcoes.ApenasNumeros(EDITDATABAIXA.Text) != null)
                {
                    veiculo.databaixa = Convert.ToDateTime(EDITDATABAIXA.Text);
                }
                veiculo.motivobaixa = EDITMOTIVOBAIXA.Text;
                if (EDITSEGURADORA.Text != "" && EDITSEGURADORA.Text != null)
                {
                    veiculo.seguradoracodigo = int.Parse(EDITSEGURADORA.Text);
                }
                if (funcoes.ApenasNumeros(EDITINICIOVIGENCIA.Text) != "" && funcoes.ApenasNumeros(EDITINICIOVIGENCIA.Text) != null)
                {
                    veiculo.datainiciovigencia = Convert.ToDateTime(EDITINICIOVIGENCIA.Text);
                }
                if (funcoes.ApenasNumeros(EDITFIMVIGENCIA.Text) != "" && funcoes.ApenasNumeros(EDITFIMVIGENCIA.Text) != null)
                {
                    veiculo.datafimvigencia = Convert.ToDateTime(EDITFIMVIGENCIA.Text);
                }
                VeiculoControle veiculocontrole = new VeiculoControle();
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    veiculocontrole.alterar(veiculo);
                }
                else
                {
                    veiculocontrole.salvar(veiculo);
                }
            }

                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro Veiculo");
                limpaTela();
        }

        private void BOTAOLIMPAR_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            frmVeiculoLoc veiculoFrmLoc = new frmVeiculoLoc();
            veiculoFrmLoc.ShowDialog();

            VeiculoModelo veiculo = new VeiculoModelo();
            VeiculoControle veiculoControle = new VeiculoControle();
            veiculo.codigo = int.Parse(veiculoFrmLoc.codigoretornado);
            if (veiculoFrmLoc.codigoretornado != "" && veiculoFrmLoc.codigoretornado != null)
            {
                veiculo = veiculoControle.atualizatela(veiculo);
                EDITCODIGO.Text = Convert.ToString(veiculo.codigo);
                EDITCODIGORENAVAN.Text = veiculo.codigorenavan;
                EDITEXERCICIO.Text = Convert.ToString(veiculo.exercicio);
                EDITMARCAMODELOCODIGO.Text = Convert.ToString(veiculo.marcamodelocodigo);
                EDITPLACA.Text = veiculo.placa;
                EDITCHASSI.Text = veiculo.chassi;
                EDITCOMBUSTIVEL.Text = veiculo.combustivel;
                EDITANOFABRICA.Text = Convert.ToString(veiculo.anofabrica);
                EDITANOMODELO.Text = Convert.ToString(veiculo.anomodelo);

                if (veiculo.marcamodelocodigo > 0)
                {
                    MarcamodeloModelo marca = new MarcamodeloModelo();
                    marca.codigo = veiculo.marcamodelocodigo;
                    MarcamodeloControle marcaControle = new MarcamodeloControle();
                    marca = marcaControle.pesquisaMarca(marca);
                    EDITMARCAMODELOCODIGO.Text = Convert.ToString(marca.codigo);
                    EDITMODELO.Text = marca.descricao;
                }
            }
            BOTAONOVO_Click(sender, e);
        }

        private void BOTAOSAIRCADASTRO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EDITANOFABRICA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void EDITANOMODELO_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void EDITDATABAIXA_DragLeave(object sender, EventArgs e)
        {
            if (EDITDATABAIXA.Text != "" && EDITDATABAIXA.Text != null)
            {
                DateTime wdt;
                try
                {
                    wdt = Convert.ToDateTime(EDITDATABAIXA.Text);
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString(), "Erro com a data informada.");
                    EDITDATABAIXA.Clear();
                    EDITDATABAIXA.Focus();
                }
            }
        }

        private void EDITDATAVENDA_Leave(object sender, EventArgs e)
        {
            DateTime wdt;
            try
            {
                wdt = Convert.ToDateTime(EDITDATAVENDA.Text);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString(), "Erro com a data informada.");
                EDITDATAVENDA.Clear();
                EDITDATAVENDA.Focus();
            }
        }

        private void EDITINICIOVIGENCIA_DragLeave(object sender, EventArgs e)
        {
            if (EDITINICIOVIGENCIA.Text != "" && EDITINICIOVIGENCIA.Text != null)
            {
                DateTime wdt;
                try
                {
                    wdt = Convert.ToDateTime(EDITINICIOVIGENCIA.Text);
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString(), "Erro com a data informada.");
                    EDITINICIOVIGENCIA.Clear();
                    EDITINICIOVIGENCIA.Focus();
                }
            }
        }

        private void EDITFIMVIGENCIA_DragLeave(object sender, EventArgs e)
        {
            if (EDITFIMVIGENCIA.Text != "" && EDITFIMVIGENCIA.Text != null)
            {
                DateTime wdt;
                try
                {
                    wdt = Convert.ToDateTime(EDITFIMVIGENCIA.Text);
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.ToString(), "Erro com a data informada.");
                    EDITFIMVIGENCIA.Clear();
                    EDITFIMVIGENCIA.Focus();
                }
            }
        }
    }
}
