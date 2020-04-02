using System;
using Projeto03.Entities; //importando
using Projeto03.Repositories; //importando

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n - SISTEMA DE CONTROLE DE CLIENTES - \n");

                var cliente = new Cliente(); //objeto

                Console.Write("Informe o nome do cliente..........: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Informe o email do cliente.........: ");
                cliente.Email = Console.ReadLine();

                cliente.DataCriacao = DateTime.Now; //data do sistema!

                //instanciando o repositorio..
                var repository = new ClienteRepository();
                repository.Inserir(cliente);

                Console.WriteLine("\nCliente cadastrado com sucesso.");

            }
            catch (Exception e)
            {

                Console.WriteLine("Ocorreu um erro: " + e.Message); 
            }


            Console.ReadKey(); //pausar o prompt
        }
    }
}
