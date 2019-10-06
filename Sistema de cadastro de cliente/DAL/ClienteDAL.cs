using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sistema_de_cadastro_de_cliente.Modelo;

namespace Sistema_de_cadastro_de_cliente.DAL
{
    public class ClienteDAL
    {
        private String mesagem;

        public string Mesagem { get => mesagem; set => mesagem = value; }
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String Cadastrar(Cliente cliente)
        {
            cmd.CommandText = @"insert into pessoa(nome, sobreNome, rg, cpf, dataDeNascimento) 
            values(@nome, @sobrenome, @rg, @cpf, @data )";

            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", cliente.SobreNome);
            cmd.Parameters.AddWithValue("@rg", cliente.Rg);
            cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("@data", cliente.DataDeNascimento);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                this.mesagem = "Cadastro efetuado com sucesso!";

            }
            catch (Exception)
            {

                this.mesagem = "Erro de conexão com o banco de dados!";
            }
            finally
            {
                con.Desconectar();
            }
            return mesagem;
        }

    }
}
