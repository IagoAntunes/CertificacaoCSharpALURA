using System;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA: Criar e executar uma tarefa-mãe 
            //e 10 tarefas-filhas que levam 1s cada uma para terminar.

            Task tarefaMae = 
                Task.Factory.StartNew(() =>{
                    Console.WriteLine("Tarefa-Mae iniciou");

                    for(int i = 0; i < 10; i++)
                    {
                        int tarefaId = i;

                        Task tarefaFilha =
                        Task.Factory.StartNew((id) => 
                        ExecutarFilha(id),
                        tarefaId,
                        TaskCreationOptions.AttachedToParent);
                    }

                });
            tarefaMae.Wait();
            Console.WriteLine("Tarefa-Mae terminou");


            Console.ReadLine();
        }

        private static void ExecutarFilha(object i)
        {
            Console.WriteLine("\tTarefa-filha {0} Iniciou",i);
            Thread.Sleep(1000);
            Console.WriteLine("\tTarefa-filha {0} Terminou",i);
        }
    }
}
/*03
 * Espera, continuacao e hierarquia de tarefas
 * Enfileirando tarefa no ThreadPool com o metodo Task.Run()
 * Aguardando as tarefas serem completadas com o metodo Task.WaitAll()
 * Contando o numero de threads atual com Process.GetCurrentProcess()Threads.Count
 * Criando tarefas de continuação de tarefas com Task.ContinueWith()
 * Criando e iniciando com Task.Factory.StartNew()
 * Associando tarefa-mae e tarefas-filhas com a opção TaskCreationOptions.AttachedToParent
 */
