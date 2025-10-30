using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp1.Operações
{
    public class Operacoes
    {
        public static double Adicionar(double a, double b) => a + b;
        public static double Subtrair(double a, double b) => a - b;
        public static double Multiplicar(double a, double b) => a * b;
        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: divisão por zero!");
                return double.NaN;
            }
            return a / b;
        }
    }
}
