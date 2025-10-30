using Calculadora.ConsoleApp1.Tela;
using System.Runtime.InteropServices;

namespace Calculadora.ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaCalculadora tela = new TelaCalculadora();
            while (true)
            {
                tela.MostrarMenu();
            }
        }
    }
}
