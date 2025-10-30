using Calculadora.ConsoleApp1.Operações;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp1.Tela
{
    public class TelaCalculadora : Operacoes
    {
        private static Historico historico = new Historico();

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|     CALCULADORA      |");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("| 1 - Fazer cálculo    |");
            Console.WriteLine("| 2 - Ver histórico    |");
            Console.WriteLine("| 3 - Sair             |");
            Console.WriteLine("+----------------------+");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao.ToLower())
            {
                case "1":
                    Calcular();
                    break;

                case "2":
                    historico.MostrarHistorico();
                    break;

                case "3":
                case "s":
                case "sair":
                case "q":
                case "quit":
                    SairDoMenu();
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public static void SairDoMenu()
        {
            Console.Clear();
            Console.WriteLine("\nEncerrando a calculadora... Até logo!");
            Environment.Exit(0); // Encerra o programa
        }

        public void Calcular()
        {
            Console.Clear();
            Console.WriteLine("=== NOVO CÁLCULO ===\n");
            Console.WriteLine("Digite a expressão (ex: 8*2):");
            Console.WriteLine("Você pode usar: (+, -, *, /)");
            Console.Write("> ");

            string entrada = Console.ReadLine();
            entrada = entrada.Replace(" ", "");

            char operacao = entrada.FirstOrDefault(c => c == '+' || c == '-' || c == '*' || c == '/');

            if (operacao == '\0')
            {
                Console.WriteLine("Operação inválida. Use apenas +, -, * ou /.");
                return;
            }

            string[] partes = entrada.Split(operacao);

            if (partes.Length != 2 ||
                !double.TryParse(partes[0], out double num1) ||
                !double.TryParse(partes[1], out double num2))
            {
                Console.WriteLine("Expressão inválida. Use o formato: número operação número (ex: 8*2).");
                return;
            }

            double resultado = operacao switch
            {
                '+' => Adicionar(num1, num2),
                '-' => Subtrair(num1, num2),
                '*' => Multiplicar(num1, num2),
                '/' => Dividir(num1, num2),
                _ => throw new InvalidOperationException("Operação inválida.")
            };

            Console.WriteLine($"\nResultado: {resultado}");

            // Adiciona ao histórico
            historico.AdicionarOperacao($"{num1} {operacao} {num2} = {resultado}");
        }
    }
   
}

