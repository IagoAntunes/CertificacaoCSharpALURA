using System;
using System.Threading;
using System.Threading.Tasks;

namespace Program07_01
{
    //Cancelar uma tarefa de execução longa
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tecle algo para parar o relógio");
            Task relogio = Task.Run(() => Relogio());
            Console.ReadKey();
            Console.WriteLine("O relógio parou.");
            Console.ReadLine();
        }

        static void Relogio()
        {
            while (true)
            {
                Console.WriteLine("Tic");
                Thread.Sleep(500);
                Console.WriteLine("Tac");
                Thread.Sleep(500);
            }
        }

    }
}
/*07
 * Cancelando uma tarefa de execucao longa
 * Definindo um cancelamento de tarefas com CancellationTokenSource
 * Notificando cancelamento de tarefas com CancellationToken
 * Detectando cancelamento de tarefas com IscancellantionRequestesd
 * Prevenindo contra condições de concorrencia em programas multi-thread
 * Implementando metodos thread-safe, com thread join e lock
 */
