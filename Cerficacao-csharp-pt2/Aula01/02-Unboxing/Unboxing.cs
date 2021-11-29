using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt2
{
    internal class Unboxing
    {
        public void Executar()
        {
            int numero = 57;
            object caixa = numero;


            try
            {
                int unboxed = (int)caixa;

                System.Console.WriteLine("Unboxing OK");
            }
            catch (System.InvalidCastException)
            {
                System.Console.WriteLine("{0} Erro: unboxing incorreto");
            }
        }
    }
}
