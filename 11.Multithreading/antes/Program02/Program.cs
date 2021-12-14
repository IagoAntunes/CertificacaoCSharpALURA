using System;
using System.Threading;

namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "A thread principal";
            ExibirThread(Thread.CurrentThread);
            //1. Task X Thread
            Thread thread1 = new Thread(Executar);
            thread1.Name = "TaskVSThread";
            thread1.Start();
            thread1.Join();
            //2. Thread com expressão lambda
            Thread thread2 = new Thread(()=>Executar());
            thread2.Name = "Expressao lambda";
            thread2.Start();
            thread2.Join();
            //3. Passando parâmetro para thread
            ParameterizedThreadStart ps =
                new ParameterizedThreadStart((p)=>ExecutarComParametro(p));

            Thread thread3 = new Thread(ps);
            thread3.Name = "Parametro thread";
            thread3.Start();
            thread3.Join();
            //4. Interrompendo um relógio
            bool relogioFuncionando = true;
            Thread thread4 = new Thread(() =>
            {
                ExibirThread(Thread.CurrentThread);
                while (relogioFuncionando) 
                { 
                    Console.WriteLine("Tic");
                    Thread.Sleep(1000);
                    Console.WriteLine("Tac");
                    Thread.Sleep(1000);
                }
            });
            thread4.Name = "InterrompendoRelogio";
            thread4.Start();

            Console.WriteLine("Tecle algo para interromper:");
            Console.ReadKey();
            relogioFuncionando = false;
            thread4.Join();
            //5. Sincronizando uma thread

            //6. Dados da Thread: Nome, cultura, prioridade, contexto, background, pool

            //7. Usando Thread Pool

            for (int i = 0; i < 50; i++)
            {
                int estadoDoItem = i;
                ThreadPool.QueueUserWorkItem((estado)
                    =>ExecutarComParametro(i));
            }

            Console.ReadLine();
        }
        static void Executar()
        {
            Console.WriteLine("Inicio da execucao");
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execucao");
        }        
        static void ExecutarComParametro(object param)
        {
            Console.WriteLine("Inicio da execucao: {0}",param);
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execucao: {0}",param);
        }
        static void ExibirThread(Thread t)
        {
            Console.WriteLine();
            Console.WriteLine("\nNome: {0}" +
                " \nCultura: {1}" +
                " \nPrioridade: {2}"+
                "\nContexto{3}:"+
                "\nEsta em background ? {4}"+
                "\nEsta em Pool de threads? {5}"
                ,t.Name,t.CurrentCulture,t.Priority,t.ExecutionContext,t.IsBackground,t.IsThreadPoolThread);
            Console.WriteLine();
        }
    }
}
/*04
 * Gerar threads usando ThreadsPool
 * Task x Thread
 * Thread Start
 * Declarando thread com expressao lambda
 * Passando parametro para threads com a classe ParameterizedThreadStart
 * Iniciando uma thread com o metodo Start()
 * Interrompendo uma thread
 * Sincronizando uma thread com o metodo join()
 * Obtendo dados da Thread: Nome,cultura,prioridade,contexto,backhround,pool
 * Usando um pool de threads
 */