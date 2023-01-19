using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisando_POO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        // Uso do *override* para sobrescrever o metodo herdado da classe Pessoa (polimorfismo)
        public override void apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho" + 
            $"{Idade} de idade e meu salário de professor é: {Salario}");
        }
    }
}