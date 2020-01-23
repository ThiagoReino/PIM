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
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FMarcamodelo : Form
    {
        public FMarcamodelo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            BOTAOEXCLUIR.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
            EDITDESCRICAO.Enabled = true;
        }

        private void limpaTela()
        {
            EDITCODIGO.Text = "";
            EDITDESCRICAO.Clear();
        }

        private void FMarcamodelo_Load(object sender, EventArgs e)
        {
            EDITDESCRICAO.MaxLength = 60;
            BOTAOEXCLUIR.Enabled = false;
            BOTAOSALVAR.Enabled = false;
            BOTAOATUALIZAR.Enabled = false;
            EDITCODIGO.Enabled = false;
            EDITDESCRICAO.Enabled = false;
        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                MarcamodeloModelo marcamodelo = new MarcamodeloModelo();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    marcamodelo.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                marcamodelo.descricao = EDITDESCRICAO.Text;

                MarcamodeloControle marcamodelocontrole = new MarcamodeloControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    marcamodelocontrole.alterar(marcamodelo);
                }
                else
                {
                    marcamodelocontrole.salvar(marcamodelo);
                }
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Marca / Modelo Veiculo");
                limpaTela();
            }
        }

        public Boolean validaDados()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITDESCRICAO.Text) || EDITDESCRICAO.Text.All(char.IsNumber))
            {
                MessageBox.Show("A descrição da marca/modelo deverá ser informada.!", "DESCRIÇÃO");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOLIMPARTELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            FMarcamodeloLoc marcamodeloLocFrm = new FMarcamodeloLoc();
            marcamodeloLocFrm.ShowDialog();

            if (marcamodeloLocFrm.codigoretornado != "" && marcamodeloLocFrm.codigoretornado != null)
            {
                MarcamodeloModelo marcamodelo = new MarcamodeloModelo();
                MarcamodeloControle MarcamodeloControle = new MarcamodeloControle();
                marcamodelo.codigo = int.Parse(marcamodeloLocFrm.codigoretornado);
                if (marcamodelo.codigo > 0)
                {

                    marcamodelo = MarcamodeloControle.pesquisaMarca(marcamodelo);

                    EDITCODIGO.Text = Convert.ToString(marcamodelo.codigo);
                    EDITDESCRICAO.Text = marcamodelo.descricao;
                }
            }
            BOTAONOVO_Click(sender, e);
        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            MarcamodeloModelo marmo = new MarcamodeloModelo();

            marmo.codigo = Convert.ToInt32(EDITCODIGO.Text);

            MarcamodeloControle marcamodelocontrole = new MarcamodeloControle();
            marcamodelocontrole.excluir(marmo);

            MessageBox.Show("Cadastro excluído com sucesso", "Cadastro Marca / Modelo Veiculo");
            limpaTela();
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                MarcamodeloModelo marcamodelo = new MarcamodeloModelo();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    marcamodelo.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                marcamodelo.descricao = EDITDESCRICAO.Text;

                MarcamodeloControle marcamodelocontrole = new MarcamodeloControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    marcamodelocontrole.alterar(marcamodelo);
                }
                else
                {
                    marcamodelocontrole.salvar(marcamodelo);
                }
                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro Marca / Modelo Veiculo");
                limpaTela();
            }
        }
    }
}
