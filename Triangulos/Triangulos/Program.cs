using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Program
    {       
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;
            RecebeValoresTriângulo(out ladoA, out ladoB, out ladoC);

            // Verifica se os lados são válidos
            VerificaExistência(ladoA, ladoB, ladoC);

            //Verifica tipo do triângulo
            VerificaTipoTriângulo(ladoA, ladoB, ladoC);

            Console.ReadLine();

        }

        private static void RecebeValoresTriângulo(out int ladoA, out int ladoB, out int ladoC)
        {
            Console.WriteLine("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());
        }

        private static void VerificaExistência(int ladoA, int ladoB, int ladoC)
        {
            if (ladoA > ladoB + ladoC)
            {
                ApresentaMensagemErro("Triângulo inválido.");
                Environment.Exit(0);
            }
            if (ladoB > ladoA + ladoC)
            {
                ApresentaMensagemErro("Triângulo inválido.");
                Environment.Exit(0);
            }
            if (ladoC > ladoA + ladoB)
            {
                ApresentaMensagemErro("Triângulo inválido.");
                Environment.Exit(0);
            }
           
        }

        private static void VerificaTipoTriângulo(int ladoA, int ladoB, int ladoC)
        {
            if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
            {
                ApresentaTipoTriângulo("Triângulo escaleno: Lados e ângulos diferentes");
            }
            if ((ladoA == ladoB && ladoA != ladoC) || (ladoA == ladoC && ladoA != ladoB) || (ladoC == ladoB && ladoC != ladoA))
            {
                ApresentaTipoTriângulo("Triângulo isósceles: Dois lados iguais e os ângulos opostos a estes lados são iguais.");
            }
            if (ladoA == ladoB && ladoB == ladoC)
            {
                ApresentaTipoTriângulo("Triângulo equilátero: Seus lados são iguais, onde seus ângulos internos serão de 60º");
            }
        }

        private static void ApresentaMensagemErro(string mensagem)
        {
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mensagem);
            Console.ResetColor();
                        
        }

        private static void ApresentaTipoTriângulo(string tipo)
        {
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(tipo);
            Console.ResetColor();
            
        }
    }
}
