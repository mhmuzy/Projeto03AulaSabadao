using System;
using System.Collections.Generic;
using System.Text;
using Projeto03.Entities; //importando

//localização (namespace)/
namespace Projeto03.Contracts
{
    //declaração da interface
    public interface IClienteRepository
    {
        //método abstrato
        void Inserir(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(Cliente cliente);
        List<Cliente> Consultar();
        Cliente ObterPorId(int id);
    }
}
