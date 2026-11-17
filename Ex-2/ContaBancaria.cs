using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex_2
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia;
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo em conta R$:{Saldo:F2}");
        }
        public override string ToString()
        {
            return $"O Nome do Titular é {Titular} e o saldo em conta é: R$:{Saldo:F2}";
        }
    }

}
