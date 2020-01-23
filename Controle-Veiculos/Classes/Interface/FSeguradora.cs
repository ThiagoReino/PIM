using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Veiculos.Classes.Persistencia;
using Controle_Veiculos.Classes.Controle;
using Controle_Veiculos.Classes.Model;

namespace Controle_Veiculos.Classes.Interface
{
    public partial class FSeguradora : Form
    {
        public FSeguradora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            BOTAOSALVAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
            EDITNOME.Enabled = true;
            EDITDDD.Enabled = true;
            EDITTELEFONE.Enabled = true;
        }

        private void limpaTela()
        {
            EDITCODIGO.Clear();
            EDITNOME.Clear();
            EDITDDD.Clear();
            EDITTELEFONE.Clear();
        }

        public Boolean validaDados()
        {
            Boolean resultado = true;

            Funcoes funcoes = new Funcoes();

            if (String.IsNullOrEmpty(EDITNOME.Text) || EDITNOME.Text.All(char.IsNumber))
            {
                MessageBox.Show("Nome da seguradora inválido ou não informado!", "NOME");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {

                SeguradoraModelo seguradora = new SeguradoraModelo();
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    seguradora.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }

                seguradora.nome = EDITNOME.Text;
                seguradora.ddd = EDITDDD.Text;
                seguradora.telefone = EDITTELEFONE.Text;

                SeguradoraControle seguradoracontrole = new SeguradoraControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    seguradoracontrole.alterar(seguradora);
                }
                else
                {
                    seguradoracontrole.salvar(seguradora);
                }
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro de Seguradoras");


                limpaTela();

            }

        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            SeguradoraModelo segur = new SeguradoraModelo();

            segur.codigo = Convert.ToInt32(EDITCODIGO.Text);

            SeguradoraControle seguradoracontrole = new SeguradoraControle();
            seguradoracontrole.excluir(segur);

            MessageBox.Show("Cadastro excluído com sucesso", "Cadastro de Seguradoras");
            limpaTela();

        }

        private void BOTAOLIMPARTELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            limpaTela();
            FseguradoraLoc seguradoralocFrm = new FseguradoraLoc();
            seguradoralocFrm.ShowDialog();

            if (seguradoralocFrm.codigoretornado != "" && seguradoralocFrm.codigoretornado != null)
            {
                SeguradoraModelo seguradora = new SeguradoraModelo();
                SeguradoraControle SeguradoraControle = new SeguradoraControle();
                seguradora.codigo = int.Parse(seguradoralocFrm.codigoretornado);
                if (seguradora.codigo > 0)
                {

                    seguradora = SeguradoraControle.atualizatela(seguradora);

                    EDITCODIGO.Text = Convert.ToString(seguradora.codigo);

                    EDITNOME.Text = seguradora.nome;
                    EDITDDD.Text = seguradora.ddd;
                    EDITTELEFONE.Text = seguradora.telefone;
                }
            }
            BOTAONOVO_Click(sender, e);
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FSeguradora_Load(object sender, EventArgs e)
        {
            EDITNOME.MaxLength = 60;
            EDITTELEFONE.MaxLength = 11;
            BOTAOSALVAR.Enabled = false;
            BOTAOEXCLUIR.Enabled = false;
            BOTAOATUALIZAR.Enabled = false;
            EDITCODIGO.Enabled = false;
            EDITNOME.Enabled = false;
            EDITDDD.Enabled = false;
            EDITTELEFONE.Enabled = false;
        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                SeguradoraModelo seguradora = new SeguradoraModelo();
                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    seguradora.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }

                seguradora.nome = EDITNOME.Text;
                seguradora.ddd = EDITDDD.Text;
                seguradora.telefone = EDITTELEFONE.Text;

                SeguradoraControle seguradoracontrole = new SeguradoraControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    seguradoracontrole.alterar(seguradora);
                }
                else
                {
                    seguradoracontrole.salvar(seguradora);
                }
                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro de Seguradoras");
                limpaTela();
            }
        }
    }
}
