using System;
using System.Collections.Generic;

class Program
{
    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("==== Gerenciador de Contatos ====");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Exibir Contatos");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    AdicionarContato();
                    break;
                case "2":
                    ExibirContatos();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AdicionarContato()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Contact novoContato = new Contact(nome, telefone, email);
        contacts.Add(novoContato);

        Console.WriteLine("Contato adicionado com sucesso!");
    }

    static void ExibirContatos()
    {
        Console.WriteLine("==== Lista de Contatos ====");

        foreach (Contact contato in contacts)
        {
            Console.WriteLine("Nome: " + contato.Nome);
            Console.WriteLine("Telefone: " + contato.Telefone);
            Console.WriteLine("E-mail: " + contato.Email);
            Console.WriteLine();
        }
    }
}