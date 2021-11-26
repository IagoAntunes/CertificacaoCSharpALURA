using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula01.TiposInteiros
{
    public class Inteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5

            char resposta = 'S'; // 2 Bytes , System.Char
            byte nivelDeAzul = 0xFF;// 255 em decimal
            short passageirosVoo = 230;// 2Bytes , System.Int16
            passageirosVoo = -7;
            int populacao = 1500;//System.int32
            populacao = -1213;
            long populacaoDoBrasil = 207_660_920;//+= 207Milhoes

            sbyte nivelDeBrilho = -127;//System.Sbyte
            ushort passageirosNavio = 230;// U = nao tem sinal
            uint estoque = 1520;
            ulong populacaoDoMundo = 7_000_000_000;//7Bilhoes

            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");


            //nivelDeAzul = 0xFFFF;
            //passageirosVoo = 230000 limite armazenamento
            //populacao 150000000 limite
            //ushort passageiroNavio = -15 NEGATIVO
            //uint estoqu = -2300 NEGATIVO
            //long populacaoDoBrasil = 207_660_929.345

            
        }
    }
}
