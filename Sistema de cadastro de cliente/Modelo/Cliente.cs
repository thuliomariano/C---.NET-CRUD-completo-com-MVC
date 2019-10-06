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
<<<<<<< HEAD
        private long rg;
        private long cpf;
=======
        private double rg;
        private double cpf;
>>>>>>> 38589999860e9afa6d19c38e54e1a22579ba0cf9
        private String dataDeNascimento;

        public int Id { get => id; set => id = value; }   
        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
<<<<<<< HEAD
        public long Rg { get => rg; set => rg = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public string DataDeNascimento { get => dataDeNascimento; set => dataDeNascimento = value; }
=======
        public double Rg { get => rg; set => rg = value; }
        public double Cpf { get => cpf; set => cpf = value; }
        public String DataDeNascimento { get => dataDeNascimento; set => dataDeNascimento = value; }
>>>>>>> 38589999860e9afa6d19c38e54e1a22579ba0cf9
    }
}
