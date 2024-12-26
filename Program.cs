using System;
using System.Globalization;

namespace OEE_Project
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
            double perfomance, tempo, oEE;

            Console.WriteLine("Protótipo de OEE  - Ver 0.2");
            Console.WriteLine("---------------------------------------------");


            int realizado = GetInput("Realizado: ");
            int meta = GetInput("Meta do dia: ");
            int tempoProduzido = GetInput("Tempo total disponível: ");
            int tempoNaoProduzido = GetInput("Tempo não produzido: ");
            int qualidade = GetInput("Qualidade: ");


            perfomance = (double)realizado / meta * 100;
            tempo = (double)(tempoProduzido - tempoNaoProduzido) / tempoProduzido * 100;
            oEE = (double)tempo * qualidade * perfomance / 10000;


            Console.WriteLine("Performance: " + perfomance.ToString("F2") + "%");

                        Console.WriteLine("Disponibilidade: " + tempo.ToString("F2") + "%");
            Console.WriteLine("OEE: " + oEE.ToString("F2") + "%");
            if (oEE > 85)
            {
                Console.WriteLine("Parabéns! Meta do dia atingida!");
            }
            else
            {
                Console.WriteLine("Meta do dia não atingida!");
            }

            Console.WriteLine("Programa encerrado, tecle Enter duas vezes para fechar a janela!");

            Console.WriteLine("Por Matheus Cavalheiro - Ver 0.2");
            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();

        }
    }
}
