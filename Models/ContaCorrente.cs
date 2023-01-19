using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisando_POO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;

        }
        // Encapsulamento - Permite que alteração de dados seja feita apenas dentro da prória classe
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }
        public void Sacar(decimal valor){
            Saldo -= valor;
        }
    }
}