using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula01.Booleanos
{
    public  class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //bool possuiSaldo = 1;
            bool possuiSaldo = true;

            Console.WriteLine($"Possui Saldo:{possuiSaldo}");

            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias:{dias}");

            bool diasPar = (dias % 2 ==0);

            if(diasPar == true)
            {
                Console.WriteLine("dias é um numero par");
            }
            else
            {
                Console.WriteLine("dias é um numero impar");
            }











        }

    }
}
