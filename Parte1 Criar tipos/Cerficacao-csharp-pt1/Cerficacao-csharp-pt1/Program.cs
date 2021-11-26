using Cerficacao_csharp_pt1.Aula01._01_TiposDeValor;
using Cerficacao_csharp_pt1.Aula01.TiposInteiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opcao");
            int opc = 0;
            TiposDeValor tipo = new TiposDeValor();
            Inteiros inteiros = new Inteiros();
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 0:
                    break;
                case 1:
                    tipo.Executar();
                    break;
                case 2:
                    inteiros.Executar();
                    break;
            }
            Console.ReadLine();
        }
    }
}
/*01
 * Caracteristicas principais dos tipos de valor
 * Inicializando Tipos de Valor
 * Tipos Integrais
 */