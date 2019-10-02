using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_cadastro_de_cliente.Apresentacao;
using Sistema_de_cadastro_de_cliente.DAL;
using Sistema_de_cadastro_de_cliente.Modelo;

namespace Sistema_de_cadastro_de_cliente.Modelo
{
    public class Controle
    {
        private String mesagem;
        Cliente cliente = new Cliente();

        public string Mesagem { get => mesagem; set => mesagem = value; }

        public void Cadastrar(Cliente cliente)
        {
            Validacao validacao = new Validacao(cliente);
            if (validacao.Equals(""))
            {
                ClienteDAL clienteDAL = new ClienteDAL();
                this.mesagem = clienteDAL.Cadastrar(cliente);

            }
            else
            {
                mesagem = validacao.Mensagem;
            }
        }


    }
}
