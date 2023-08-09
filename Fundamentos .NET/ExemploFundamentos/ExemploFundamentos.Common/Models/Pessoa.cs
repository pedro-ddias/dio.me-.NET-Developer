using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Apresentação da pessoa, falando seu nome e idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}