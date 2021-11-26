using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula01.Decimal
{
    internal class DecimalValor : IAulaItem
    {
        public void Executar()
        {

            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subtotal = 30;

            Console.WriteLine("Descobrindo...");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

            valorProduto1 = 10.1;
            valorProduto2 = 20.2;
            subtotal = 30.3;

            Console.WriteLine("Descobrindo...");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

            Console.WriteLine(valorProduto1 + valorProduto2);

            Console.WriteLine("Descobrindo...");
            Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999997);

            decimal materiaPrima = 10.1m;
            decimal maoDeObra = 20.2M;
            decimal custo = 30.3M;

            Console.WriteLine("\n\nDescobrindo...");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);






        }
    }
}
