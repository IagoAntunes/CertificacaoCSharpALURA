using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarefa 1: Processar uma faixa de 100 itens em paralelo
            //Tarefa 2: Completou sem interrupção?
            //Tarefa 3: Interromper quando começar a processar o valor 75
            //Tarefa 4: Quantos itens foram processados (parcialmente)?

            Console.WriteLine("Tarefa 1");
            var resultadoLoop = Parallel.For(0,100,(int i,ParallelLoopState state) => 
            {
                if(i == 75)
                {
                    state.Break();
                }
                Processar(i); 
            }
            );

            Console.WriteLine();

            Console.WriteLine("Tarefa 2");
            Console.WriteLine("Completou sem interrupcao ? {0}", resultadoLoop.IsCompleted) ;

            Console.WriteLine("Tarefa 3");
            Console.WriteLine("itens processados: {0}",resultadoLoop.LowestBreakIteration);


            Console.WriteLine("Término do processamento. Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        static void Processar(object item)
        {
            Console.WriteLine("Começando a trabalhar com: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Terminando a trabalhar com: " + item);
        }
    }
}
/*01
 * Task Parallel com Parallel.For,PLINQ,Tasks
 * -Processamento em serie x processamento paralelo
 * Executando actions em paralelo com o metodo Parallel invoke
 * Executando faixa de action em paralelo com o metodo Parallel.For
 * Exeuctando colecao de actions em paralelo com o metodo Parallel.Foreach
 * Usando um cronometro StopWatch para calcular o tempo decorrido
 * Detectar se uma tarefa completou sem interrupção
 * Calculando quantos itens foram processados parcialmente
 */

