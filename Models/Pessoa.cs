using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisando_POO.Models
{
    public class Pessoa
    {
        // A classe pessoa faz uma abstração do mundo real para contexto específico
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        // Usar o *virtual* para sobrscrever o método (polimorfismo)
        public virtual void apresentar (){
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} de idade.");
        }
    }
}