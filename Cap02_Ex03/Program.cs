using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL;

            Console.Write("Horas trabalhadas ...............: "); /* HV */
            HT = float.Parse(Console.ReadLine());
            Console.Write("Valor da hora ...................: ");  /* VH */
            VH = float.Parse(Console.ReadLine());
            Console.Write("Valor do percentual de desconto .: ");  /* PD */
            PD = float.Parse(Console.ReadLine());

            SB = HT * VH; /* multiplica as variaveis citadas acima e acrescenta na variavel de salario bruto*/
            TD = (PD / 100) * SB; /* acha o percentual de desconto em porcentagem dividindo ele por 100 e logo em seguida 
                                   * multiplicando ele pelo salario bruto, para entao depoids acrescentar ele a variavel do salario total */
            SL = SB - TD; /* entao descobre o salario liquido atraves da subtração do salario  bruto com o salario total de desconto */

            Console.WriteLine();
            Console.Write("Salario liquido ................");
            Console.WriteLine(SL.ToString("##,##0.00")); /* retorna o valor armazenado no salario liquido para colocar ele junto ao comentario em string, usando uma mascara
                                                          * que retorna espaço para 2 casas decimais */

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
