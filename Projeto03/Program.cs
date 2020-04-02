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

                Console.WriteLine();

                Console.WriteLine("Cadastrar cliente (1)");
                Console.WriteLine("Consultar cliente (2)");
                Console.WriteLine();
                Console.WriteLine("Digite a opção desejada:");
                int num = int.Parse(Console.ReadLine());
                var cliente = new Cliente(); //objeto
                                                                         //instanciando o repositorio..
                var repository = new ClienteRepository();

                switch (num)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Informe o nome do cliente..........: ");
                        cliente.Nome = Console.ReadLine();

                        Console.Write("Informe o email do cliente.........: ");
                        cliente.Email = Console.ReadLine();

                        cliente.DataCriacao = DateTime.Now; //data do sistema!

                        repository.Inserir(cliente);

                        Console.WriteLine("\nCliente cadastrado com sucesso.");
                        break;
                    case 2:
                        //exibindo os clientes cadastrados na base de dados
                        var lista = repository.Consultar();

                        Console.WriteLine();
                        Console.WriteLine("Consulta de Clientes");

                        foreach (var item in lista)
                        {
                            //item -> representa cada cliente contido na lista
                            Console.WriteLine("Id do(a) cliente: " + item.IdCliente + ", Nome do(a) cliente: " + item.Nome + ", E - mail do cliente: " + item.Email + ", Data de Criação: " + item.DataCriacao.ToString("dd/MM/yyyy"));

                        }
                        break;
                    default:
                        break;
                }

                
                
            }
            catch (Exception e)
            {

                Console.WriteLine("Ocorreu um erro: " + e.Message); 
            }


            Console.ReadKey(); //pausar o prompt
        }
    }
}
