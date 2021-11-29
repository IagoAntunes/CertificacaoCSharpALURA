using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt2
{
    internal class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;

            object caixa = numero;



            Console.WriteLine(caixa);
            Console.WriteLine(String.Concat("Resposta", numero,true));



        }
    }
}
