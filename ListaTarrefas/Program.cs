using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("==== Lista de Tarefas ====");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Concluir Tarefa");
            Console.WriteLine("3. Exibir Tarefas");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    ConcluirTarefa();
                    break;
                case "3":
                    ExibirTarefas();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AdicionarTarefa()
    {
        Console.Write("Digite a tarefa: ");
        string tarefa = Console.ReadLine();

        tasks.Add(tarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    static void ConcluirTarefa()
    {
        Console.Write("Digite o número da tarefa a ser concluída: ");
        int numeroTarefa = Convert.ToInt32(Console.ReadLine());

        if (numeroTarefa >= 1 && numeroTarefa <= tasks.Count)
        {
            tasks.RemoveAt(numeroTarefa - 1);
            Console.WriteLine("Tarefa concluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido! Tente novamente.");
        }
    }

    static void ExibirTarefas()
    {
        Console.WriteLine("==== Lista de Tarefas ====");

        if (tasks.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa encontrada.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + tasks[i]);
            }
        }
    }
}
