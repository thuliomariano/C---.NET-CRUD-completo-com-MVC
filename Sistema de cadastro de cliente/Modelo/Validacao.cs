using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_cadastro_de_cliente.Modelo
{
    
    public class Validacao
    {
        private String mensagem;

        public string Mensagem { get => mensagem; set => mensagem = value; }

        public Validacao(Cliente cliente)
        {
            mensagem = " ";
            if (cliente.Nome.Length > 50)
            {
                mensagem = "Quantidades de caracteres Excede o valor maximo(50)";
            }
            if (cliente.SobreNome.Length > 70)
            {
                mensagem = "Quantidades de caracteres Excede o valor maximo(70)";
            }
            if (Convert.ToString(cliente.Rg).Length > 9)
            {
                mensagem = "Quantidades de valores númericos Excede o valor maximo(9)";
            }
            if (Convert.ToString(cliente.Cpf).Length > 11)
            {
                mensagem = "Quantidades de valores númericos Excede o valor maximo(11)";
            }
                      

        }
    }
}
