using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class Sobrecargas
    {
        public void Executar()
        {
            int lado = 3;
            Console.WriteLine($"Volume do cubo: "+ Volume(lado));

            //cilindro
            double raio = 2;
            int altura = 10;
            Console.WriteLine("Volume do colindro: "+ Volume(raio,altura));

            //Prisma
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine("Volume do Prisma:"+Volume(largura,altura,profundidade));


        }
        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }
        double Volume(double raio,int altura)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }
        double Volume(long largura,int altura,int profundidade)
        {
            return largura * profundidade * altura;
        }
    }
}
