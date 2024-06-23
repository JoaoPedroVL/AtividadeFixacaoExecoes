using AtividadeFixacaoExecoes.Entidades;
using System;
using AtividadeFixacaoExecoes.Entidades.Execoes;

namespace AtividadeFixacaoExecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da conta: ");
            try
            {
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.Write("Limite da conta de saque: ");
                double limite = double.Parse(Console.ReadLine());

                Conta conta = new Conta(numero, nome, saldo, limite);


                Console.WriteLine();
                Console.Write("Entre com o valor do saque: ");
                double saque = double.Parse(Console.ReadLine());

                conta.saque(saque);
                Console.WriteLine(conta.ToString());
            }
            catch (ExecaoPersonalizada e)
            {
                Console.WriteLine($"{e}");
            }
        }
    }
}