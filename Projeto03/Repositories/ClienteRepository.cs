using System;
using System.Collections.Generic;
using System.Text;
using Projeto03.Entities; //importando
using Projeto03.Contracts; //importando
using System.Data.SqlClient; //importando
using Dapper; //importando

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

        }

        public void Inserir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Consultar()
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
