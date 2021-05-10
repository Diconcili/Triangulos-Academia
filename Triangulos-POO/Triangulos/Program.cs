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
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Digite o valor do lado A: ");
            int ladoA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor do lado B: ");
            int ladoB = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor do lado C: ");
            int ladoC = Convert.ToInt32(Console.ReadLine());

            triangulo.VerificaExistência(ladoA, ladoB, ladoC);
            triangulo.VerificaTipoTriângulo(ladoA, ladoB, ladoC);

        }       
    }
}
