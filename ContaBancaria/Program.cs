using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {

        static void Main(string[] args)
        {
            ContaBanco conta = new ContaBanco();
            sbyte i=0;
            do
            {
                try
                {
                    Console.WriteLine("------------------------------Bem vindo ao sistema------------------------------");
                    Console.WriteLine("1- Criar conta;\n2- Depositar;\n3- Levantar;\n4- Saldo;\n0- Sair do sistema;");
                    i = sbyte.Parse(Console.ReadLine());
                switch (i)
                {
                        case 1:
                            try
                            {
                                Console.WriteLine("Nome Completo: ");
                                string nome = Console.ReadLine();
                                Console.WriteLine("Numero da conta ");
                                int numC = int.Parse(Console.ReadLine());
                                Console.WriteLine("Deseja fazer um deposito inicial?\nS-sim\tN-Nao");
                                char op = char.Parse(Console.ReadLine());
                                if (op.ToString().ToUpper() == "S")
                                {
                                    Console.WriteLine("Quanto deseja depositar?");
                                    double depInicial = double.Parse(Console.ReadLine());
                                    conta.criarConta(nome, numC, depInicial);
                                }
                                else if (op.ToString().ToUpper() == "N")
                                {
                                    conta.criarConta(nome, numC);
                                }
                                else {
                                    ContaBanco.errorMessage("Escolha Sim(S) ou Nao(N)\n\nTente novamente!");
                                }
                            }
                            catch (FormatException)
                            {
                                ContaBanco.errorMessage("Insira um numero valido");
                            }
                            break;
                        case 2:
                            conta.deposito();
                            break;
                        case 3:
                            conta.levantamento();
                            break;
                        case 4:
                            conta.verificarSaldo();
                            break;

                        case 0:
                            Console.WriteLine("Obrigado por usar os nossos servicos");
                            Console.WriteLine("Clique enter para fechar");
                            Console.ReadKey();
                            break;
                        
                    }

                    }
                    catch (FormatException)
                    {
                        ContaBanco.errorMessage("Insira um numero valido");
                    }


                } while (i != 0);
                     
        }

        

        
    }
}
