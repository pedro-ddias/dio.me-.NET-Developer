using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">Primeiro número inteiro para somar</param>
        /// <param name="y">Segundo número inteiro para somar</param>
        public static void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public static void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public static void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public static void Potencia(int x, int y)
        {
            var p = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {p}");
        }
        public static void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public static void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }
        public static void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public static void RaizQuadrada(double x)
        {
            var raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} = {raiz}");
        }
    }
}