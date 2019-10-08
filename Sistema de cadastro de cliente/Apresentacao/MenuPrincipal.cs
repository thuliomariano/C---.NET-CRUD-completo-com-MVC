using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_cadastro_de_cliente.Apresentacao
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gerenciamentoLocalizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.ShowDialog();
        }

        private void requisiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Requisicao requisicao = new Requisicao();
            requisicao.ShowDialog();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroLogin registroLogin = new RegistroLogin();
            registroLogin.ShowDialog();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdemDeServico ordemDeServico = new OrdemDeServico();
            ordemDeServico.ShowDialog();
        }

        private void vendasDeTerceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void comprasDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
                    }

        private void empregadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            registros.ShowDialog();
        }
    }
}
