using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaBanco
    {
        private string nome;
        private int numConta;
        private double saldo;
        private bool isOpen = false;

        public ContaBanco()
        {
        }


        public void criarConta(string nome, int numC, double depInicial)
        {
            try
            {
                if (string.IsNullOrEmpty(nome))
                {
                    throw new ArgumentException("Nome inválido!");
                }

                if (numC <= 0)
                {
                    throw new ArgumentException("Número de conta inválido!");
                }

                if (depInicial <= 0)
                {
                    throw new ArgumentException("Depósito inicial inválido!");
                }

                this.nome = nome;
                this.numConta = numC;
                this.saldo += depInicial;
                this.isOpen = true;
                sucessMessage(this.nome + ", conta criada com sucesso");
            }
            catch (ArgumentException ex)
            {
                errorMessage(ex.Message);
            }
            catch (Exception )
            {
                errorMessage("Falha a criar conta! Tente novamente");
            }
        }

        public void criarConta(string nome, int numC)
        {
            try
            {
                if (string.IsNullOrEmpty(nome))
                {
                    throw new ArgumentException("Nome inválido!");
                }

                if (numC <= 0)
                {
                    throw new ArgumentException("Número de conta inválido!");
                }

                this.nome = nome;
                this.numConta = numC;
                this.saldo = 0;
                this.isOpen = true;
                sucessMessage(this.nome + ", a sua conta foi criada com sucesso");
            }
            
            catch (Exception )
            {
                errorMessage("Falha a criar conta! Tente novamente");
            }
        }


        public void deposito()
        {
            try
            {
                if (this.isOpen == true)
                {
                    Console.WriteLine("Quanto deseja depositar?");
                    double deposito = double.Parse(Console.ReadLine());

                    if (deposito <= 0)
                    {
                        throw new ArgumentException("Valor de depósito inválido.");
                    }

                    this.saldo += deposito;
                    Console.WriteLine("Depositou " + deposito + "MZN;\nSaldo actual " + this.saldo + "MZN;");
                }
                else
                {
                    errorMessage("Por favor abra uma conta primeiro");
                }
            }
            catch (FormatException)
            {
                errorMessage("Valor de depósito inválido. Por favor, digite um valor numérico.");
            }
            catch (ArgumentException )
            {
                errorMessage("Valor de depósito inválido. Por favor, digite um valor numérico.");
            }
            catch (Exception)
            {
                errorMessage("Ocorreu um erro inesperado. Por favor, tente novamente.");
            }
        }

        public void levantamento()
        {
            if (!this.isOpen)
            {
                errorMessage("Por favor abra uma conta primeiro");
                return;
            }

            Console.WriteLine("Quanto deseja levantar");
            double saque;
            try
            {
                saque = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                errorMessage("Valor de levantamento inválido. Por favor, insira um valor numérico.");
                return;
            }

            if (saque <= 0)
            {
                errorMessage("Valor de levantamento inválido. Por favor, insira um valor maior que zero.");
                return;
            }

            if (this.saldo < saque + 5)
            {
                errorMessage("Saldo insuficientes");
                return;
            }

            this.saldo -= saque + 5;
            Console.WriteLine("Levantou " + saque + " MZN;\nSaldo atual: " + this.saldo + " MZN.");
        }


        public void verificarSaldo()
        {
            try
            {
                if (this.isOpen)
                {
                    Console.WriteLine("Seu saldo é: " + this.saldo + "MZN");
                }
                else
                {
                    throw new InvalidOperationException("Por favor, abra uma conta primeiro.");
                }
            }
            catch (InvalidOperationException)
            {
                errorMessage("Ocorreu um erro inesperado. Por favor, tente novamente.");
            }
        }


        public static void sucessMessage(string sucess)
        {
            Console.WriteLine(sucess +";\n\n\n\n\n\n");
        }
        public static void errorMessage(string error)
        {
            Console.WriteLine(error + ";\n\n\n\n\n\n");
        }
    }
}