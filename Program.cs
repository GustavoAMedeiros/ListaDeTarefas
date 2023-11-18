using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à sua Lista de Tarefas");
            List<string> Tarefas = new List<string>();
            string opcao = "";

            while (opcao != "e")
            {
                Console.WriteLine("O que você quer fazer?");
                Console.WriteLine("Aperte 1 para adicionar uma tarefa à sua lista de tarefas");
                Console.WriteLine("Aperte 2 para remover uma tarefa da sua lista de tarefas");
                Console.WriteLine("Aperte 3 para visualizar sua lista de tarefas");
                Console.WriteLine("Aperte \"e\" para sair do programa");

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Dê um nome para sua nova tarefa:");
                    string novaTarefa = Console.ReadLine();
                    Tarefas.Add(novaTarefa);
                    Console.WriteLine($"Tarefa {novaTarefa} adicionada à sua lista com sucesso.");
                }
                else if(opcao == "2")
                {
                    Console.WriteLine("Essas são suas tarefas: ");

                    for (int i = 0; i < Tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {Tarefas[i]}");
                    }

                    Console.WriteLine("Digite o número da tarefa que você deseja remover da sua lista.");
                    int numeroDaTarefa = Convert.ToInt32(Console.ReadLine()) - 1;
                    Tarefas.RemoveAt(numeroDaTarefa);
                    Console.WriteLine("Tarefa removida.");
                }
                else if (opcao == "3")
                {
                    for (int i = 0; i < Tarefas.Count; i++)
                    {
                        Console.WriteLine($"Suas tarefas são: {Tarefas[i]}");
                    }
                }
                else if (opcao == "e")
                {
                    Console.WriteLine("Saindo do programa.");
                }
                else 
                {
                    Console.WriteLine("Valor inválido. Por favor tente novamente.");
                }
            }
            Console.WriteLine("Obrigado por usar o programa!");
        }
    }
}