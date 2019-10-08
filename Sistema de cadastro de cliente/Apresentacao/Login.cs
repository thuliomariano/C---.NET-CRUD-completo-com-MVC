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


namespace Sistema_de_cadastro_de_cliente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "admin") && (txtSenha.Text == "123"))
            {
                Registros registro = new Registros();
                registro.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Tente novamente", "Usuario ou senha está incorreto!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "admin") && (txtSenha.Text == "123"))
            {
                this.Visible = false;
                MenuPrincipal menuPrincipal = new MenuPrincipal(); 
                menuPrincipal.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show("Tente novamente", "Usuario ou senha está incorreto!");
            }

        }
    }
}
