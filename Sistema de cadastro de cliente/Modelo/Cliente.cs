using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_cadastro_de_cliente.Modelo
{
    public class Cliente
    {
        private int id;
        private String nome;
        private String sobreNome;
        private long rg;
        private long cpf;
        private DateTime dataDeNascimento;

        public int Id { get => id;}   // não é possivel modificar o ID, somente ler
        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
        public long Rg { get => rg; set => rg = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public DateTime DataDeNascimento { get => dataDeNascimento; set => dataDeNascimento = value; }
    }
}
