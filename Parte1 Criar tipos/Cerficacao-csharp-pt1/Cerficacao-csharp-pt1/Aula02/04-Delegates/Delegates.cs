using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula02._04_Delegates
{
    public class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();







        }
    }

    delegate double MetodoMultiplicacao(double input);



    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }
        static double Triplicar(double input)
        {
            return input * 3;
        }
        public static void Executar()
        {
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            MetodoMultiplicacao metodoMultiplicacao = new MetodoMultiplicacao(Duplicar);
            Console.WriteLine(metodoMultiplicacao(7.5));

            metodoMultiplicacao = Triplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            MetodoMultiplicacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };
            double quadrado = metodoQuadrado(5);
            Console.WriteLine("Quadrado {0}", quadrado);


            MetodoMultiplicacao metodoCubo = input => input * input * input;

            double cubo = metodoCubo(4.375);

            Console.WriteLine("Cubo:{0}",cubo);



        }
    }
}
