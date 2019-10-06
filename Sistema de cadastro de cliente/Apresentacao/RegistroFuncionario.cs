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
            
            
            

            Cliente cliente = new Cliente();

            if (txtId.Text == "")
            {
                txtRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;


                cliente.Nome = txtNome.Text;
                cliente.SobreNome = txtSobreNome.Text;
                cliente.Rg = Convert.ToDouble(txtRg.Text);
                cliente.Cpf = Convert.ToDouble(txtCpf.Text);
                String[] data = txtDataDeNascimento.Text.Split('-');
                cliente.DataDeNascimento = data[2] + "-" + data[1] + "-" + data[0];

                Controle controle = new Controle();
                controle.Cadastrar(cliente);
                MessageBox.Show(controle.Mesagem);
            }
            else
            {
                cliente.Id = Convert.ToInt16(txtId.Text);


            }

        }

        private void Registros_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
