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
using Controle_Veiculos.Classes.Modelo;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Interface;
using Controle_Veiculos.Classes.Persistencia;
using System.IO;
using mshtml;


namespace Controle_Veiculos.Classes.Interface
{
    public partial class FRota : Form
    {

        public FRota()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void limpaTela()
        {
            EDITCODIGOMOTORISTA.Clear();
            EDITNOMEMOTORISTA.Clear();
            EDITVEICULOCODIGO.Clear();
            EDITPLACA.Clear();
            EDITNOMEMOTORISTA.Clear();
            EDITMARCAMODELO.Clear();
            EDITDESTINO.Clear();
            EDITORIGEM.Clear();
            EDITDATAFIM.Clear();
            EDITHORAFIM.Clear();
            EDITDATAINICIO.Clear();
            EDITHORAINICIO.Clear();
            EDITDESCRICAO.Clear();
            EDITNUMEROPASSAGEIROS.Clear();
            EDITKMPERCORRIDO.Clear();
            MAPAWEBBROWSER.Navigate("about:blank");
        }

        public bool validaDado()
        {
            bool validaDado;
            validaDado = true;
            if (String.IsNullOrEmpty(EDITCODIGOMOTORISTA.Text) || EDITCODIGOMOTORISTA.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe um codigo", "Codigo Motorista");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITNOMEMOTORISTA.Text) || EDITNOMEMOTORISTA.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o nome do motorista", "Nome Motorista");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITVEICULOCODIGO.Text) || EDITVEICULOCODIGO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o codigo do veiculo", "Codigo Veiculo");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITPLACA.Text) || EDITPLACA.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a placa do veiculo", "Placa Veiculo");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITMARCAMODELO.Text) || EDITMARCAMODELO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a marca/modelo do veiculo", "Marca Modelo Veiculo");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITDATAINICIO.Text) || !EDITDATAINICIO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a data inicio", "Data inicio");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITHORAINICIO.Text) || !EDITHORAINICIO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a hora de inicio", "Hora inicio");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITNUMEROPASSAGEIROS.Text) || !EDITNUMEROPASSAGEIROS.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o numero de passageiros", "Numero de passageiros");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITKMPERCORRIDO.Text) || !EDITKMPERCORRIDO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe o n", "Numero de passageiros");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITORIGEM.Text) || EDITORIGEM.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a origem", "ORIGEM");
                validaDado = false;
            }
            else if (String.IsNullOrEmpty(EDITDESTINO.Text) || EDITDESTINO.Text.All(char.IsNumber))
            {
                MessageBox.Show("Informe a destino", "DESTINO");
                validaDado = false;
            }
            return validaDado;
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculoLoc manutencaoFrm = new frmVeiculoLoc();
            manutencaoFrm.ShowDialog();

            VeiculoModelo veiculo = new VeiculoModelo();
            if (manutencaoFrm.codigoretornado != "" && manutencaoFrm.codigoretornado != null)
            {
                veiculo.codigo = int.Parse(manutencaoFrm.codigoretornado);
            }
            EDITVEICULOCODIGO.Text = Convert.ToString(veiculo.codigo);
        }

        private void FRota_Load(object sender, EventArgs e)
        {
            BOTAOATUALIZAR.Enabled = false;
            BOTAOEXCLUIR.Enabled = false;
            BOTAOSALVAR.Enabled = false;
            EDITCODIGOMOTORISTA.Enabled = false;
            EDITNOMEMOTORISTA.Enabled = false;
            EDITVEICULOCODIGO.Enabled = false;
            EDITPLACA.Enabled = false;
            BOTAOCONDUTOR.Enabled = false;
            BOTAOVEICULO.Enabled = false;
            EDITDATAFIM.Enabled = false;
            EDITDATAINICIO.Enabled = false;
            EDITDESCRICAO.Enabled = false;
            EDITDESTINO.Enabled = false;
            EDITHORAFIM.Enabled = false;
            EDITHORAFIM.Enabled = false;
            EDITHORAINICIO.Enabled = false;
            EDITHORAFIM.Enabled = false;
            EDITORIGEM.Enabled = false;
            BOTAOPESQUISARROTA.Enabled = false;
            EDITNUMEROPASSAGEIROS.Enabled = false;
            EDITKMPERCORRIDO.Enabled = false;
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            BOTAOATUALIZAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            EDITCODIGOMOTORISTA.Enabled = true;
            EDITNOMEMOTORISTA.Enabled = true;
            EDITVEICULOCODIGO.Enabled = true;
            EDITPLACA.Enabled = true;
            BOTAOCONDUTOR.Enabled = true;
            BOTAOVEICULO.Enabled = true;
            EDITDATAFIM.Enabled = true;
            EDITDATAINICIO.Enabled = true;
            EDITDESCRICAO.Enabled = true;
            EDITDESTINO.Enabled = true;
            EDITHORAFIM.Enabled = true;
            EDITHORAFIM.Enabled = true;
            EDITHORAINICIO.Enabled = true;
            EDITHORAFIM.Enabled = true;
            EDITORIGEM.Enabled = true;
            BOTAOPESQUISARROTA.Enabled = true;
            EDITNUMEROPASSAGEIROS.Enabled = true;
            EDITKMPERCORRIDO.Enabled = true;
        }

        private void BOTAOEXCLUIRRota_Click(object sender, EventArgs e)
        {
            /*
            Rota Rota = new Rota();
            Rota.cadcodigo = Int32.Parse(EDITCADCODIGO.Text);
            Rota.veicodigo = Int32.Parse(EDITCODIGO.Text);
            Rota.datainicioRota = EDITDATAINICIORota.Value;
            Rota.datafimRota = EDITDATAFIMRota.Value;
            Rota.valorRota = float.Parse(EDITVALORRota.Text);
            RotaController loccontroller = new RotaController();
            loccontroller.excluir(Rota);

            MessageBox.Show("Locaca excluída com sucesso");*/
        }

        private void BOTAOSALVAR_Click_1(object sender, EventArgs e)
        {
            if (validaDado())
            {
                RotaModelo rotaModelo = new RotaModelo();

                Funcoes funcoes = new Funcoes();

                if (funcoes.ApenasNumeros(EDITDATAINICIO.Text) != "" && funcoes.ApenasNumeros(EDITDATAINICIO.Text) != null)
                {
                    rotaModelo.datainicio = DateTime.Parse(EDITDATAINICIO.Text, new System.Globalization.CultureInfo("pt-BR"));
                }
                rotaModelo.horainicio = TimeSpan.Parse(EDITHORAINICIO.Text);
                if (funcoes.ApenasNumeros(EDITDATAFIM.Text) != "" && funcoes.ApenasNumeros(EDITDATAFIM.Text) != null)
                {
                    rotaModelo.datafim = DateTime.Parse(EDITDATAFIM.Text, new System.Globalization.CultureInfo("pt-BR"));
                }
                rotaModelo.horafim = TimeSpan.Parse(EDITHORAFIM.Text);
                rotaModelo.motoristacodigo = Int32.Parse(EDITCODIGOMOTORISTA.Text);
                rotaModelo.nrpassageiros = Int32.Parse(EDITNUMEROPASSAGEIROS.Text);
                rotaModelo.veiculocodigo = Int32.Parse(EDITVEICULOCODIGO.Text);
                rotaModelo.localorigem = EDITORIGEM.Text;
                rotaModelo.localdestino = EDITDESTINO.Text;
                rotaModelo.kmpercorrido = Convert.ToDecimal(EDITKMPERCORRIDO.Text);
                rotaModelo.descricaoatendimento = EDITDESCRICAO.Text;
                RotaControle rota = new RotaControle();
                rota.salvar(rotaModelo);

                MessageBox.Show("Rota salva com sucesso", "Rota");
                limpaTela();
            }

        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            BOTAOATUALIZAR.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;

            FRotaLoc rotaLocFrm = new FRotaLoc();
            rotaLocFrm.ShowDialog();

            if (rotaLocFrm.codigoretornado != "" && rotaLocFrm.codigoretornado != null)
            {
                RotaModelo rotaModelo = new RotaModelo();
                rotaModelo.controle = int.Parse(rotaLocFrm.codigoretornado);
                RotaControle rotaControle = new RotaControle();
                rotaModelo = rotaControle.pesquisaRota(rotaModelo);
                EDITCODIGO.Text = Convert.ToString(rotaModelo.controle);
                if (rotaModelo.datainicio != DateTime.MinValue)  //data nao foi iniciada
                {
                    DateTime wdata = new DateTime();
                    wdata = rotaModelo.datainicio;
                    EDITDATAINICIO.Text = wdata.ToShortDateString();
                }

                EDITHORAINICIO.Text = Convert.ToString(rotaModelo.horainicio);
                if (rotaModelo.datafim != DateTime.MinValue)  //data nao foi iniciada
                {
                    DateTime wdata = new DateTime();
                    wdata = rotaModelo.datafim;
                    EDITDATAFIM.Text = wdata.ToShortDateString();
                }

                EDITHORAFIM.Text = Convert.ToString(rotaModelo.horafim);
                EDITCODIGOMOTORISTA.Text = Convert.ToString(rotaModelo.motoristacodigo);
                EDITNUMEROPASSAGEIROS.Text = Convert.ToString(rotaModelo.nrpassageiros);
                EDITVEICULOCODIGO.Text = Convert.ToString(rotaModelo.veiculocodigo);
                EDITORIGEM.Text = rotaModelo.localorigem;
                EDITDESTINO.Text = rotaModelo.localdestino;
                EDITKMPERCORRIDO.Text = Convert.ToString(rotaModelo.kmpercorrido);
                EDITDESCRICAO.Text = rotaModelo.descricaoatendimento;

                if (rotaModelo.veiculocodigo > 0)
                {
                    VeiculoModelo veiculoModelo = new VeiculoModelo();
                    veiculoModelo.codigo = rotaModelo.veiculocodigo;
                    VeiculoControle veiculoControle = new VeiculoControle();
                    veiculoModelo = veiculoControle.atualizatela(veiculoModelo);
                    EDITPLACA.Text = veiculoModelo.placa;
                    if (veiculoModelo.marcamodelocodigo > 0)
                    {
                        MarcamodeloModelo marcaModelo = new MarcamodeloModelo();
                        marcaModelo.codigo = veiculoModelo.marcamodelocodigo;
                        MarcamodeloControle marcaControle = new MarcamodeloControle();
                        marcaModelo = marcaControle.pesquisaMarca(marcaModelo);
                        EDITMARCAMODELO.Text = marcaModelo.descricao;
                    }
                }

                if (rotaModelo.motoristacodigo > 0)
                {
                    MotoristaModelo motoristaModelo = new MotoristaModelo();
                    motoristaModelo.codigo = rotaModelo.motoristacodigo;
                    MotoristaControle motoristaControle = new MotoristaControle();
                    motoristaModelo = motoristaControle.atualizatela(motoristaModelo);
                    EDITNOMEMOTORISTA.Text = motoristaModelo.nome;
                }

            }
            BOTAOPESQUISARROTA_Click(sender, e);
        }

        private void BOTAOEXCLUIR_Click_1(object sender, EventArgs e)
        {
            RotaModelo Rota = new RotaModelo();
            //Rota.codigo = Int32.Parse(EDITCODIGO.Text);
            RotaControle loccontroller = new RotaControle();
            loccontroller.excluir(Rota);

            MessageBox.Show("Rota excluida com sucesso");
            limpaTela();
        }

        private void BOTAOLIMPARTELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaDado())
            {
                RotaModelo rotaModelo = new RotaModelo();

                Funcoes funcoes = new Funcoes();

                if (funcoes.ApenasNumeros(EDITDATAINICIO.Text) != "" && funcoes.ApenasNumeros(EDITDATAINICIO.Text) != null)
                {
                    rotaModelo.datainicio = DateTime.Parse(EDITDATAINICIO.Text, new System.Globalization.CultureInfo("pt-BR"));
                }
                rotaModelo.horainicio = TimeSpan.Parse(EDITHORAINICIO.Text);
                if (funcoes.ApenasNumeros(EDITDATAFIM.Text) != "" && funcoes.ApenasNumeros(EDITDATAFIM.Text) != null)
                {
                    rotaModelo.datafim = DateTime.Parse(EDITDATAFIM.Text, new System.Globalization.CultureInfo("pt-BR"));
                }
                rotaModelo.horafim = TimeSpan.Parse(EDITHORAFIM.Text);
                rotaModelo.motoristacodigo = Int32.Parse(EDITCODIGOMOTORISTA.Text);
                rotaModelo.nrpassageiros = Int32.Parse(EDITNUMEROPASSAGEIROS.Text);
                rotaModelo.veiculocodigo = Int32.Parse(EDITVEICULOCODIGO.Text);
                rotaModelo.localorigem = EDITORIGEM.Text;
                rotaModelo.localdestino = EDITDESTINO.Text;
                rotaModelo.kmpercorrido = Convert.ToDecimal(EDITKMPERCORRIDO.Text);
                rotaModelo.descricaoatendimento = EDITDESCRICAO.Text;
                RotaControle rota = new RotaControle();
                rota.salvar(rotaModelo);

                MessageBox.Show("Rota atualizada com sucesso", "Rota");
                limpaTela();
            }
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAOCONDUTOR_Click(object sender, EventArgs e)
        {
            FmotoristaLoc motoristaLocFrm = new FmotoristaLoc();
            motoristaLocFrm.ShowDialog();

            if (motoristaLocFrm.codigoretornado != "" && motoristaLocFrm.codigoretornado != null)
            {
                MotoristaModelo motoristaModelo = new MotoristaModelo();
                motoristaModelo.codigo = int.Parse(motoristaLocFrm.codigoretornado);
                MotoristaControle motoristacontrole = new MotoristaControle();
                motoristaModelo = motoristacontrole.atualizatela(motoristaModelo);
                EDITCODIGOMOTORISTA.Text = Convert.ToString(motoristaModelo.codigo);
                EDITNOMEMOTORISTA.Text = motoristaModelo.nome;
            }
        }

        private void BOTAOVEICULO_Click(object sender, EventArgs e)
        {
            frmVeiculoLoc manutencaoFrm = new frmVeiculoLoc();
            manutencaoFrm.ShowDialog();

            if (manutencaoFrm.codigoretornado != "" && manutencaoFrm.codigoretornado != null)
            {
                VeiculoModelo veiculo = new VeiculoModelo();
                veiculo.codigo = int.Parse(manutencaoFrm.codigoretornado);
                VeiculoControle veiculoControle = new VeiculoControle();
                veiculo = veiculoControle.atualizatela(veiculo);
                EDITVEICULOCODIGO.Text = Convert.ToString(veiculo.codigo);
                EDITPLACA.Text = veiculo.placa;
                if (veiculo.marcamodelocodigo > 0)
                {
                    MarcamodeloModelo marcaModelo = new MarcamodeloModelo();
                    marcaModelo.codigo = veiculo.marcamodelocodigo;
                    MarcamodeloControle marcaControle = new MarcamodeloControle();
                    marcaModelo = marcaControle.pesquisaMarca(marcaModelo);
                    EDITMARCAMODELO.Text = marcaModelo.descricao;
                }

            }
        }

        private void BOTAOPESQUISARROTA_Click(object sender, EventArgs e)
        {
            if (validaDado())
            {
                string origem = EDITORIGEM.Text;
                string destino = EDITDESTINO.Text;
                try
                {
                    StringBuilder buscarendeco = new StringBuilder();
                    buscarendeco.Append(string.Format("http://maps.google.com/maps/dir/{0}/{1}", EDITORIGEM.Text, EDITDESTINO.Text));
                    MAPAWEBBROWSER.Navigate(buscarendeco.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Erro");
                }
            }
        }

    }
}
