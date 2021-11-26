using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula01._03_Tipos_de_Ponto_Flutuante
{
    public class PontoFlutuante: IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            //int massa = 6_000000_000000_000000_000000;
            //long massa = 6_000000_000000_000000_000000;
            double massa = 6e24;
            Console.WriteLine($"{long.MaxValue}");
            Console.WriteLine($"{long.MinValue}");

            float massaDaTerra = 5.8736e24f;
            Console.WriteLine(massaDaTerra);

            float numeroPI = 3.14159f;
            Console.WriteLine(numeroPI);

            //float numeroMuitoMaior = 6e100f;
            double numeroMuitoMaior = 6e100;

            Console.WriteLine("Operacação com int, float e short");
            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine("x * y = {0}", resultado1);
            Console.WriteLine($"O resultado é do tipo {resultado1.GetType()}");

            float z = 4.5f;

            var resultado2 = (x * y) / z;
            Console.WriteLine("x * y / z = {0}", resultado2);
            Console.WriteLine("O resultado2 é do tipo"+ resultado2.GetType());


             











        }



    }
}
