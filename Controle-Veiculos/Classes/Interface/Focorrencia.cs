using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Persistencia;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class Focorrencia : Form
    {
        public Focorrencia()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            EDITTIPOOCORRENCIA.Enabled = true;
            EDITDATAOCORRENCIA.Enabled = true;
            EDITHORAOCORRENCIA.Enabled = true;
            EDITLOCALOCORRENCIA.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
            BOTAOLOCALIZAR.Enabled = true;
            BOTAOVEICULO.Enabled = true;
            BOTAOMOTORISTA.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
        }

        public void limpaTela()
        {
            EDITTIPOOCORRENCIA.SelectedIndex = -1;
            EDITDATAOCORRENCIA.Clear();
            EDITHORAOCORRENCIA.Clear();
            EDITLOCALOCORRENCIA.Clear();
            EDITVEICULOCODIGO.Clear();
            EDITVEICULOPLACA.Clear();
            EDITVEICULOANOFABRICA.Clear();
            EDITVEICULOANOMODELO.Clear();
            EDITMARCAMODELOCODIGO.Clear();
            EDITMARCAMODELODESCRICAO.Clear();
            EDITMOTORISTACODIGO.Clear();
            EDITMOTORISTANOME.Clear();
        }

        public Boolean validaOcorrencia()
        {
            Boolean resultado = true;

            Funcoes funcoes = new Funcoes();

            if (String.IsNullOrEmpty(EDITVEICULOCODIGO.Text) || !EDITVEICULOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o código do veiculo!", "Código Veiculo");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITMOTORISTACODIGO.Text) || !EDITMOTORISTACODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o código do motorista.", "Código Motorista");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITMARCAMODELOCODIGO.Text) || !EDITMARCAMODELOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a marca e modelo do veiculo.", "Marca / Modelo");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITTIPOOCORRENCIA.Text))
            {
                MessageBox.Show("Informe o tipo de ocorrencia.", "Tipo Ocorrencia");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(funcoes.ApenasNumeros(EDITDATAOCORRENCIA.Text)) && funcoes.ApenasNumeros(EDITDATAOCORRENCIA.Text) != null) 
            {
                MessageBox.Show("A data da ocorrência deve ser informada.", "Data ocorrência");
                resultado = false;
            }
            else if (!funcoes.validaData(EDITDATAOCORRENCIA.Text))
            {
                MessageBox.Show("A data da ocorrência foi informada incorretamente.", "Data ocorrência");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(funcoes.ApenasNumeros(EDITHORAOCORRENCIA.Text)) && funcoes.ApenasNumeros(EDITHORAOCORRENCIA.Text) != null)
            {
                MessageBox.Show("Horario da ocorrência deve ser informado.", "Hora ocorrência");
                resultado = false;
            }
            else if (String.IsNullOrEmpty(EDITLOCALOCORRENCIA.Text))
            {
                MessageBox.Show("Preencher o local da ocorrência.", "Local da ocorrência");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOVEICULO_Click(object sender, EventArgs e)
        {
            frmVeiculoLoc veiculoFrmLoc = new frmVeiculoLoc();
            veiculoFrmLoc.ShowDialog();

            VeiculoModelo veiculo = new VeiculoModelo();
            VeiculoControle veiculoControle = new VeiculoControle();
            //veiculo.codigo = int.Parse(veiculoFrmLoc.codigoretornado);
            if (veiculoFrmLoc.codigoretornado != "" && veiculoFrmLoc.codigoretornado != null)
            {
                veiculo.codigo = int.Parse(veiculoFrmLoc.codigoretornado);
                veiculo = veiculoControle.atualizatela(veiculo);
                EDITVEICULOCODIGO.Text = Convert.ToString(veiculo.codigo);
                EDITMARCAMODELOCODIGO.Text = Convert.ToString(veiculo.marcamodelocodigo);
                EDITVEICULOPLACA.Text = veiculo.placa;
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

        private void Focorrencia_Load(object sender, EventArgs e)
        {
            EDITCODIGOOCORRENCIA.Enabled = false;
            EDITTIPOOCORRENCIA.Enabled = false;
            EDITDATAOCORRENCIA.Enabled = false;
            EDITHORAOCORRENCIA.Enabled = false;
            EDITLOCALOCORRENCIA.Enabled = false;
            BOTAOSALVAR.Enabled = false;
            BOTAOEXCLUIR.Enabled = false;
            BOTAOATUALIZAR.Enabled = false;
            BOTAOVEICULO.Enabled = false;
            BOTAOMOTORISTA.Enabled = false;
        }

        private void BOTAOMOTORISTA_Click(object sender, EventArgs e)
        {
            FmotoristaLoc motoristaFrm = new FmotoristaLoc();
            motoristaFrm.ShowDialog();

            MotoristaModelo motorista = new MotoristaModelo();
            MotoristaControle motoristaControle = new MotoristaControle();

            if (motoristaFrm.codigoretornado != "" && motoristaFrm.codigoretornado != null)
            {
                motorista.codigo = int.Parse(motoristaFrm.codigoretornado);
                motorista = motoristaControle.atualizatela(motorista);
                EDITMOTORISTACODIGO.Text = Convert.ToString(motorista.codigo);
                EDITMOTORISTANOME.Text = motorista.nome;
            }


        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaOcorrencia())
            {
                OcorrenciaModelo ocorrencia = new OcorrenciaModelo();
                Funcoes funcoes = new Funcoes();
                if (EDITCODIGOOCORRENCIA.Text != "" && EDITCODIGOOCORRENCIA.Text != null)
                {
                    ocorrencia.controle = Convert.ToInt32(EDITCODIGOOCORRENCIA.Text);
                }

                if (funcoes.ApenasNumeros(EDITDATAOCORRENCIA.Text) != "" && funcoes.ApenasNumeros(EDITDATAOCORRENCIA.Text) != null)
                {
                    ocorrencia.dataocorrencia = DateTime.Parse(EDITDATAOCORRENCIA.Text, new System.Globalization.CultureInfo("pt-BR"));
                }
                ocorrencia.horaocorrencia = EDITHORAOCORRENCIA.Text;
                ocorrencia.veiculocodigo = Convert.ToInt32(EDITVEICULOCODIGO.Text);
                ocorrencia.motoristacodigo = Convert.ToInt32(EDITMOTORISTACODIGO.Text);
                ocorrencia.localocorrencia = EDITLOCALOCORRENCIA.Text;
                ocorrencia.tipoocorrencia = EDITTIPOOCORRENCIA.Text;
                OcorrenciaControle controleOcorrencia = new OcorrenciaControle();
                controleOcorrencia.salvar(ocorrencia);

                MessageBox.Show("Ocorencia gravada com sucesso", "Cadastro Ocorrencia");
                limpaTela();
            }
            
        }

        private void EDITDATAOCORRENCIA_Leave(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes();

            if (funcoes.validaData(EDITDATAOCORRENCIA.Text) == false)
            {
                EDITDATAOCORRENCIA.Clear();
                EDITDATAOCORRENCIA.Focus();
            }

        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            OcorrenciaModelo ocorrencia = new OcorrenciaModelo();
            Funcoes funcoes = new Funcoes();
            if (EDITCODIGOOCORRENCIA.Text != "" && EDITCODIGOOCORRENCIA.Text != null)
            {
                ocorrencia.controle = Convert.ToInt32(EDITCODIGOOCORRENCIA.Text);
            }

            if (funcoes.ApenasNumeros(EDITDATAOCORRENCIA.Text) != "" && funcoes.ApenasNumeros(EDITDATAOCORRENCIA.Text) != null)
            {
                ocorrencia.dataocorrencia = DateTime.Parse(EDITDATAOCORRENCIA.Text, new System.Globalization.CultureInfo("pt-BR"));
            }
            ocorrencia.horaocorrencia = EDITHORAOCORRENCIA.Text;
            ocorrencia.veiculocodigo = Convert.ToInt32(EDITVEICULOCODIGO.Text);
            ocorrencia.motoristacodigo = Convert.ToInt32(EDITMOTORISTACODIGO.Text);
            ocorrencia.localocorrencia = EDITLOCALOCORRENCIA.Text;
            ocorrencia.tipoocorrencia = EDITTIPOOCORRENCIA.Text;
            OcorrenciaControle controleOcorrencia = new OcorrenciaControle();
            controleOcorrencia.alterar(ocorrencia);


            MessageBox.Show("Ocorencia atualizada com sucesso", "Cadastro Ocorrencia");
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            FocorrenciaLoc ocorrenciaLoc = new FocorrenciaLoc();
            ocorrenciaLoc.ShowDialog();

            OcorrenciaModelo ocorrencia = new OcorrenciaModelo();
            OcorrenciaControle ocorrenciaControle = new OcorrenciaControle();
            ocorrencia.controle = int.Parse(ocorrenciaLoc.codigoretornado);

            if (ocorrenciaLoc.codigoretornado != "" && ocorrenciaLoc.codigoretornado != null)
            {
                ocorrencia = ocorrenciaControle.pesquisaOcorrencia(ocorrencia);
                EDITCODIGOOCORRENCIA.Text = Convert.ToString(ocorrencia.controle);
                if (ocorrencia.dataocorrencia != DateTime.MinValue)  //data nao foi iniciada
                {
                    DateTime wdata = new DateTime();
                    wdata = ocorrencia.dataocorrencia;
                    EDITDATAOCORRENCIA.Text = wdata.ToShortDateString();
                }
                EDITHORAOCORRENCIA.Text = ocorrencia.horaocorrencia;
                EDITVEICULOCODIGO.Text = Convert.ToString(ocorrencia.veiculocodigo);
                EDITMARCAMODELOCODIGO.Text = Convert.ToString(ocorrencia.motoristacodigo);
                EDITLOCALOCORRENCIA.Text = ocorrencia.localocorrencia;
                EDITTIPOOCORRENCIA.Text = ocorrencia.tipoocorrencia;
            }

            if (ocorrencia.veiculocodigo > 0)
            {
                VeiculoModelo vei = new VeiculoModelo();
                vei.codigo = ocorrencia.veiculocodigo;
                VeiculoControle veiculoControle = new VeiculoControle();
                vei = veiculoControle.atualizatela(vei);
                EDITVEICULOPLACA.Text = vei.placa;
                EDITVEICULOANOFABRICA.Text = Convert.ToString(vei.anofabrica);
                EDITVEICULOANOMODELO.Text = Convert.ToString(vei.anomodelo);
                if (vei.marcamodelocodigo > 0)
                {
                    MarcamodeloModelo marca = new MarcamodeloModelo();
                    marca.codigo = vei.marcamodelocodigo;
                    MarcamodeloControle marcaControle = new MarcamodeloControle();
                    marca = marcaControle.pesquisaMarca(marca);
                    EDITMARCAMODELOCODIGO.Text = Convert.ToString(marca.codigo);
                    EDITMARCAMODELODESCRICAO.Text = marca.descricao;
                }
            }

            if (ocorrencia.motoristacodigo > 0)
            {
                MotoristaModelo motorista = new MotoristaModelo();
                motorista.codigo = ocorrencia.motoristacodigo;
                MotoristaControle motoristaControle = new MotoristaControle();
                motorista = motoristaControle.atualizatela(motorista);
                EDITMOTORISTACODIGO.Text = Convert.ToString(motorista.codigo);
                EDITMOTORISTANOME.Text = motorista.nome;
            }
            BOTAONOVO_Click(sender, e);
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAOLIMPARTELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void EDITDATAOCORRENCIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void EDITHORAOCORRENCIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            OcorrenciaModelo ocorrencia = new OcorrenciaModelo();

            ocorrencia.controle = Convert.ToInt32(EDITCODIGOOCORRENCIA.Text);
            OcorrenciaControle ocorrenciaControle = new OcorrenciaControle();
            ocorrenciaControle.excluir(ocorrencia);

            MessageBox.Show("Ocorrencia excluida com sucesso", "Cadastro Ocorrência");
            limpaTela();
        }
    }
}
