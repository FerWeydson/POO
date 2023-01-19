using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisando_POO.Models
{
    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }

        public override void apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho" + 
            $"{Idade} de idade e sou um aluno nota: {Nota}");
        }
    }
}