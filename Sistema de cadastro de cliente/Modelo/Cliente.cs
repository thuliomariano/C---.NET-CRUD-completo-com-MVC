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
        private double rg;
        private double cpf;
        private String dataDeNascimento;

        public int Id { get => id; set => id = value; }   
        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
        public double Rg { get => rg; set => rg = value; }
        public double Cpf { get => cpf; set => cpf = value; }
        public String DataDeNascimento { get => dataDeNascimento; set => dataDeNascimento = value; }
    }
}
