using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp1.Operações
{
    public class Historico
    {
        private List<string> operacoes = new List<string>();

        public void AdicionarOperacao(string descricao)
        {
            operacoes.Add(descricao);
        }

        public void MostrarHistorico()
        {
            Console.Clear();
            Console.WriteLine("=== HISTÓRICO DE OPERAÇÕES ===\n");

            if (operacoes.Count == 0)
            {
                Console.WriteLine("Nenhuma operação realizada ainda.");
            }
            else
            {
                foreach (var op in operacoes)
                {
                    Console.WriteLine(op);
                }
            }
        }
    }
}
