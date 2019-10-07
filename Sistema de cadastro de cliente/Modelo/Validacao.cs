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
           

        }
    }
}
