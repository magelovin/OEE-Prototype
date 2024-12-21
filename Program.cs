using System;
using System.Globalization;

namespace OEE_ProjectMageLovin
{
    class Program
    {

        static int GetInput(string prompt)
        {
            int value;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();


                if (int.TryParse(input, out value) && value >= 0)
                {
                    return value;
                }
                else
                {

                    if (!int.TryParse(input, out _))
                    {
                        Console.WriteLine("Por favor, insira apenas números.");
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número válido maior ou igual a 0.");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            double resultadoDoDiaPerformance, tempoForaDeProducao, oEE;

            Console.WriteLine("Protótipo de OEE  - Ver 0.2");
            Console.WriteLine("---------------------------------------------");


            int realizado = GetInput("Realizado: ");
            int meta = GetInput("Meta do dia: ");
            int tempoNaoProduzido = GetInput("Tempo não produzido: ");
            int qualidade = GetInput("Qualidade: ");


            resultadoDoDiaPerformance = (double)realizado / meta * 100;
            tempoForaDeProducao = (double)(480 - tempoNaoProduzido) / 480 * 100;
            oEE = (double)tempoForaDeProducao * qualidade * resultadoDoDiaPerformance / 10000;


            Console.WriteLine("Performance do dia: " + resultadoDoDiaPerformance.ToString("F2") + "%");
            Console.WriteLine("Disponibilidade: " + tempoForaDeProducao.ToString("F2") + "%");
            Console.WriteLine("OEE do dia: " + oEE.ToString("F2") + "%");

            Console.WriteLine("Programa encerrado, tecle Enter duas vezes para fechar a janela!");

            Console.WriteLine("Por Matheus Cavalheiro - Ver 0.2");
            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();

        }
    }
}
