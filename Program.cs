using System;
using System.Collections.Generic;
using System.Linq;


namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à sua Lista de Tarefas");
            List<string> TarefasParaFazer = new List<string>();
            List<string> TarefasFeitas = new List<string>();
            string opcao = "";

            while (opcao != "e")
            {
                Console.WriteLine("O que você quer fazer?");
                Console.WriteLine("Aperte 1 para adicionar uma tarefa à sua lista de tarefas.");
                Console.WriteLine("Aperte 2 para remover uma tarefa da sua lista de tarefas à fazer.");
                Console.WriteLine("Aperte 3 para visualizar sua lista de tarefas à fazer.");
                Console.WriteLine("Aperte 4 para visualizar sua lista de tarefas feitas.");
                Console.WriteLine("Aperte 5 para marcar uma tarefas à fazer como feita.");
                Console.WriteLine("Aperte \"e\" para sair do programa.");

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Dê um nome para sua nova tarefa:");
                    string novaTarefa = Console.ReadLine();
                    TarefasParaFazer.Add(novaTarefa);
                    Console.WriteLine($"Tarefa {novaTarefa} adicionada à sua lista com sucesso.");
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Essas são suas tarefas à serem feitas: ");

                    for (int i = 0; i < TarefasParaFazer.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {TarefasParaFazer[i]}");
                    }

                    Console.WriteLine("Digite o número da tarefa que você deseja remover da sua lista.");
                    int numeroDaTarefa = Convert.ToInt32(Console.ReadLine()) - 1;
                    TarefasParaFazer.RemoveAt(numeroDaTarefa);
                    Console.WriteLine("Tarefa removida.");
                }
                else if (opcao == "3")
                {
                    for (int i = 0; i < TarefasParaFazer.Count; i++)
                    {
                        Console.WriteLine($"Suas tarefas são: {TarefasParaFazer[i]}");
                    }
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Suas tarefas já concluídas: ");

                    for (int i = 0; i < TarefasFeitas.Count; i++)
                    {
                        Console.WriteLine(TarefasFeitas[i]);
                    }
                }
                else if (opcao == "5")
                {
                    Console.WriteLine("Essas são suas tarefas à serem feitas: ");

                    for (int i = 0; i < TarefasParaFazer.Count; i++)
                    {
                        Console.WriteLine($"Tarefa {i + 1}: {TarefasParaFazer[i]}");
                    }

                    Console.WriteLine("Qual seria a tarefa a ser concluída? Digite o índice correspodente à tarefa.");

                    int tarefaConcluida = Convert.ToInt32(Console.ReadLine());

                    string tarefaRemovida = TarefasParaFazer[tarefaConcluida - 1];
                    TarefasParaFazer.RemoveAt(tarefaConcluida - 1);

                    TarefasFeitas.Add(tarefaRemovida);

                    Console.WriteLine($"Tarefa concluída com sucesso.");

                }
                else if (opcao == "e")
                {
                    Console.WriteLine("Saindo do programa...");
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