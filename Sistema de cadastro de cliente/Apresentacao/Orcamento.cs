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
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            txtOrcamento.Enabled = false;
            txtTotal.Enabled = false;
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
