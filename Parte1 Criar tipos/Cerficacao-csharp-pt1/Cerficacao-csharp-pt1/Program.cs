using Cerficacao_csharp_pt1.Aula01._01_TiposDeValor;
using Cerficacao_csharp_pt1.Aula01._03_Tipos_de_Ponto_Flutuante;
using Cerficacao_csharp_pt1.Aula01._06_Estruturas_Definidas_pelo_Usuario;
using Cerficacao_csharp_pt1.Aula01._07_Enums;
using Cerficacao_csharp_pt1.Aula01.Booleanos;
using Cerficacao_csharp_pt1.Aula01.Decimal;
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
            PontoFlutuante pontoFlutuante = new PontoFlutuante();
            DecimalValor decimalV = new DecimalValor();
            Booleanos booleanos = new Booleanos();
            Estrutura estruturas = new Estrutura();
            Enumerações enumeracoes = new Enumerações();
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
                case 3:
                    pontoFlutuante.Executar();
                    break;
                case 4:
                    decimalV.Executar();
                    break;
                case 5:
                    booleanos.Executar();
                    break;
                case 6:
                    estruturas.Executar();
                    break;
                case 7:
                    enumeracoes.Executar();
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
/* 02
 * Tipos de ponto Flutuante
 * Decimal
 * Booleanos
 * Estrutura definidas pelo Usuario
 * Enums*/