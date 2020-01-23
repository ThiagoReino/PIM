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
    public partial class FGrupo : Form
    {
        public FGrupo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FGrupo_Load(object sender, EventArgs e)
        {
            EDITDESCRICAO.MaxLength = 30;
            EDITCODIGO.Enabled = false;
            EDITDESCRICAO.Enabled = false;
            BOTAOATUALIZAR.Enabled = false;
            BOTAOSALVAR.Enabled = false;
            BOTAOEXCLUIR.Enabled = false;
        }

        private void BOTAONOVO_Click(object sender, EventArgs e)
        {
            EDITDESCRICAO.Enabled = true;
            BOTAOATUALIZAR.Enabled = true;
            BOTAOSALVAR.Enabled = true;
            BOTAOEXCLUIR.Enabled = true;
        }

        private void BOTAOSALVAR_Click(object sender, EventArgs e)
        {
            if (validaGrupo())
            {
                GrupoModelo grupo = new GrupoModelo();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    grupo.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                grupo.descricao = EDITDESCRICAO.Text;

                GrupoControle grupocontrole = new GrupoControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    grupocontrole.alterar(grupo);
                }
                else
                {
                    grupocontrole.salvar(grupo);
                }
                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Grupo Produtos");
                limpaTela();
            }
        }

        private void limpaTela()
        {
            EDITCODIGO.Text = "";
            EDITDESCRICAO.Clear();
        }

        public Boolean validaGrupo()
        {
            Boolean resultado = true;

            if (String.IsNullOrEmpty(EDITDESCRICAO.Text) || EDITDESCRICAO.Text.All(char.IsNumber))
            {
                MessageBox.Show("A descrição do grupo deverá ser informada.!", "DESCRIÇÃO");
                resultado = false;
            }
            return resultado;
        }

        private void BOTAOEXCLUIR_Click(object sender, EventArgs e)
        {
            GrupoModelo gru = new GrupoModelo();

            gru.codigo = Convert.ToInt32(EDITCODIGO.Text);

            GrupoControle grupocontrole = new GrupoControle();
            grupocontrole.excluir(gru);

            MessageBox.Show("Cadastro excluído com sucesso", "Cadastro Grupo Produtos");
            limpaTela();
        }

        private void BOTAOLIMPARTELA_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void BOTAOLOCALIZAR_Click(object sender, EventArgs e)
        {
            FGrupoLoc grupoLocFrm = new FGrupoLoc();
            grupoLocFrm.ShowDialog();

            if (grupoLocFrm.codigoretornado != "" && grupoLocFrm.codigoretornado != null)
            {
                GrupoModelo grupo = new GrupoModelo();
                GrupoControle GrupoControle = new GrupoControle();
                grupo.codigo = int.Parse(grupoLocFrm.codigoretornado);
                if (grupo.codigo > 0)
                {

                    grupo = GrupoControle.atualizatela(grupo);

                    EDITCODIGO.Text = Convert.ToString(grupo.codigo);
                    EDITDESCRICAO.Text = grupo.descricao;
                }
            }
            BOTAONOVO_Click(sender, e);
        }

        private void BOTAOSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTAOATUALIZAR_Click(object sender, EventArgs e)
        {
            if (validaGrupo())
            {
                GrupoModelo grupo = new GrupoModelo();

                if (EDITCODIGO.Text != "" && EDITCODIGO.Text != null)
                {
                    grupo.codigo = Convert.ToInt32(EDITCODIGO.Text);
                }
                grupo.descricao = EDITDESCRICAO.Text;

                GrupoControle grupocontrole = new GrupoControle();
                if (EDITCODIGO.Text != "" || (EDITCODIGO.Text == null))
                {
                    grupocontrole.alterar(grupo);
                }
                else
                {
                    grupocontrole.salvar(grupo);
                }
                MessageBox.Show("Cadastro atualizado com sucesso", "Cadastro Grupo Produtos");
                limpaTela();
            }
        }
    }
}
