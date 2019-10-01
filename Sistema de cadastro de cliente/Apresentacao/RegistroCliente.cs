using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_cadastro_de_cliente.Apresentacao;
using Sistema_de_cadastro_de_cliente.DAL;
using Sistema_de_cadastro_de_cliente.Modelo;

namespace Sistema_de_cadastro_de_cliente.Apresentacao
{
    public partial class Registros : Form
    {


        public Registros()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            txtRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtDataDeNascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt16(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.SobreNome = txtSobreNome.Text;
            cliente.Rg = Convert.ToInt32(txtRg);
            cliente.Cpf = Convert.ToInt32(txtCpf);
            cliente.DataDeNascimento = Convert.ToDateTime(txtDataDeNascimento);

            Controle controle = new Controle();
            controle.Cadastrar(cliente);
            


        }

        private void Registros_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
