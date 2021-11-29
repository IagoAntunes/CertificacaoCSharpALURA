using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula04._02_Metodos
{
    internal class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);

            Console.WriteLine(retangulo.GetArea());

            Retangulo outroRetangulo = new Retangulo(10, 10);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo.Altura,outroRetangulo.Largura));

            outroRetangulo = new Retangulo(5, 6);
            Console.WriteLine(Retangulo.Semelhante(retangulo,outroRetangulo));

        }
    }
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set;}

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura},largura: {largura}");

            var area = GetArea();
            Console.WriteLine($"area: {area}");
        }

        public double GetArea()
        {
            return Altura * Largura;
        }
        public bool Semelhante(double outroRetanguloAltura,double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) ==
                (outroRetanguloLargura / outroRetanguloAltura))
                ||
                ((Altura / Largura) ==
                (outroRetanguloLargura / outroRetanguloAltura));
        }
        internal static bool Semelhante(Retangulo retangulo,Retangulo outroRetangulo)
        {
            return
                ((retangulo.Largura / retangulo.Altura) ==
                (outroRetangulo.Largura / outroRetangulo.Altura))
                ||
                ((retangulo.Altura) / retangulo.Largura) ==
                (outroRetangulo.Largura / outroRetangulo.Altura));
        }
    }
}
