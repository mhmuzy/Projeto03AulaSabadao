using System;
using System.Collections.Generic;
using System.Text;
using Projeto03.Entities; //importando
using Projeto03.Contracts; //importando
using System.Data.SqlClient; //importando
using Dapper; //importando
using System.Linq;

namespace Projeto03.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        //declarar a connectionstring como um atributo (campo)
        //private -> acesso permitido somente dentro da propria classe
        private string connectionString;

        //método construtor (responsavel por inicializar os atributos da classe)
        //ctor + 2x[tab]
        public ClienteRepository()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aula03Sabado;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public void Inserir(Cliente cliente)
        {
            var query = "insert into Cliente(Nome, Email, DataCriacao) Values (@Nome, @Email, @DataCriacao)";

            using (var connection = new SqlConnection(connectionString))
            {
                //executar o comando SQL (query)
                connection.Execute(query, cliente);
            }
        }

        public void Atualizar(Cliente cliente)
        {
            var query = "update Cliente set Nome = @Nome, Email = @Email where IdCliente = @IdCliente";

            using (var connection = new SqlConnection(connectionString))
            {
                //executar o commando SQL (query)
                connection.Execute(query, cliente);
            }
        }

        public void Excluir(Cliente cliente)
        {
            var query = "delete from Cliente where IdCliente = @IdCliente";

            using (var connection = new SqlConnection(connectionString))
            {
                //executar o comando SQL (query)
                connection.Execute(query, cliente);
            }
        } 

        public List<Cliente> Consultar()
        {
            var query = "select * from Cliente";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>(query).ToList();
            }
        }

        public Cliente ObterPorId(int id)
        {
            var query = "select * from Cliente where IdCliente = @IdCliente";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>(query, new { IdCliente = id }).FirstOrDefault();    
            }


        /*
         * FirstOrDefault() -> retorna o primeiro elemento obtido pela consulta
         * ou retorna null (vazio) se a consulta não obter registros
         */
        }

    }
}
