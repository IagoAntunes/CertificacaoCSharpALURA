using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Boxing boxing = new Boxing();
            Unboxing unboxing = new Unboxing();




            Console.WriteLine("Digite uma Opcao:");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    boxing.Executar();
                    break;
                case 2:
                    unboxing.Executar();
                    break;

            }
            Console.ReadLine();






        }
    }
}
/* 01
 * Boxing OBJECT -> INT
 * Unboxing INT -> OBJECT
 */
