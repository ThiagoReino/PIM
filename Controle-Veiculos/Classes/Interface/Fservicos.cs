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
    public partial class Fservicos : Form
    {
        public Fservicos()
        {
            InitializeComponent();
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            EDITDESCRICAO.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
        }

        public Boolean validaServico()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITDESCRICAO.Text) || EDITDESCRICAO.Text.All(char.IsNumber))
            {
                MessageBox.Show("A descrição do serviço deverá ser informada.!", "DESCRIÇÃO");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaServico())
            {
                ServicoModelo serivco = new ServicoModelo();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    serivco.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                serivco.descricao = EDITDESCRICAO.Text;

                ServicoControle servicocontrole = new ServicoControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    servicocontrole.alterar(serivco);
                }
                else
                {
                    servicocontrole.salvar(serivco);
                }
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Serviços");
                limpaTela();
            }
        }

        private void limpaTela()
        {
            EDITCODIGO.Text = "";
            EDITDESCRICAO.Clear();
        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            ServicoModelo srv = new ServicoModelo();

            srv.codigo = Convert.ToInt32(EDITCODIGO.Text);

            ServicoControle servicocontrole = new ServicoControle();
            servicocontrole.excluir(srv);

            MessageBox.Show("Cadastro excluído com sucesso", "Cadastro de Serviços");
            limpaTela();
        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaServico())
            {
                ServicoModelo servico = new ServicoModelo();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    servico.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                servico.descricao = EDITDESCRICAO.Text;

                ServicoControle servicocontrole = new ServicoControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    servicocontrole.alterar(servico);
                }
                else
                {
                    servicocontrole.salvar(servico);
                }
                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro de Serviços");
                limpaTela();
            }
        }

        private void BOTAOLIMPARTELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            FservicosLoc servicoLocFrm = new FservicosLoc();
            servicoLocFrm.ShowDialog();

            if (servicoLocFrm.codigoretornado != "" && servicoLocFrm.codigoretornado != null)
            {
                ServicoModelo serivco = new ServicoModelo();
                ServicoControle srvControle = new ServicoControle();
                serivco.codigo = int.Parse(servicoLocFrm.codigoretornado);
                if (serivco.codigo > 0)
                {

                    serivco = srvControle.atualizatela(serivco);

                    EDITCODIGO.Text = Convert.ToString(serivco.codigo);
                    EDITDESCRICAO.Text = serivco.descricao;
                }
            }
            BOTAONOVO_Click(sender, e);
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
