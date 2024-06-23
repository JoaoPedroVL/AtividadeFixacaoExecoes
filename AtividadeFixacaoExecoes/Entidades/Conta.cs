using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeFixacaoExecoes.Entidades.Execoes;

namespace AtividadeFixacaoExecoes.Entidades
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double limiteSaque { get; set; }

        public Conta (int numero, string nome, double saldo, double limitesaque)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            limiteSaque = limitesaque;
        }

        public void deposito(double valor)
        {
             Saldo += valor;
        }

        public void saque(double valor)
        {
            if(valor >= limiteSaque)
            {
                throw new ExecaoPersonalizada($"Erro SAQUE 01! Valor de saque maior que o limite {limiteSaque}");
            }
            else if (Saldo == 0)
            {
                throw new ExecaoPersonalizada("Erro SAQUE 02! Saldo da conta zerado");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public override string ToString()
        {
            return $"New balance {Saldo}";
        }


    }
}
