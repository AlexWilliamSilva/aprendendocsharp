using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME;

            Console.Write("Entre seu nome: "); /* o método write escreve atraves da classe console */
            NOME = Console.ReadLine(); /* le a linha na qual escrevemos e armazena ela em uma variavel  */
            Console.WriteLine("Ola, " + NOME); /* como se fosse um escreval ele nos fornece a informaçao do nosso nome junto com um ola */

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
