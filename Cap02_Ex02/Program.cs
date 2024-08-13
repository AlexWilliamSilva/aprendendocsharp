using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;

            Console.Write("Entre o 1o. valor: ");
            A = int.Parse(Console.ReadLine()); /* parse pega o que foi escrito em uma linha e altera seu tipo para inteiro, jogando dentro de uma variavel para uso de calculos */

            Console.Write("Entre o 2o. valor: ");
            B = int.Parse(Console.ReadLine());

            R = A + B; /* soma os valores das variaveis A e B e armazena no R*/

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R);  /* nos mostra o resultado chamando a variavel R */

            Console.WriteLine();
            Console.WriteLine("Tecla <Enter> para continuar... ");
            Console.ReadLine();

        }
    }
}
