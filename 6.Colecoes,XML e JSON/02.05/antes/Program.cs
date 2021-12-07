using System;
using System.Collections.Generic;

namespace _02._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //COLEÇÃO: FILA = QUEUE
            //Regra: primeiro que entra é o primeiro que sai

            //TAREFA: Implementar uma fila de pedágio

            ///<image url="$(ProjectDir)\Slides\queue0.png" scale=""/>
            var pedagio = new Pedagio();
            pedagio.Enfileirar("Van");
            pedagio.Enfileirar("Kombi");
            pedagio.Enfileirar("Guincho");
            pedagio.Enfileirar("Pickup");

            pedagio.Desenfileirar();
            pedagio.Desenfileirar();


            Console.ReadKey();
        }
    }
    class Pedagio
    {
        Queue<string> fila = new Queue<string> ();

        public void Enfileirar(string veiculo)
        {
            fila.Enqueue(veiculo);
            Console.WriteLine("Entrou na fila..." + veiculo);
            Console.WriteLine();
            Console.WriteLine("VEICULOS NA FILA");
            Imprimir();
        }

        private void Imprimir()
        {
            foreach (var v in fila)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }

        public void Desenfileirar()
        {
            if(fila.Count == 0)
            {
                Console.WriteLine("Fila Vazia!!");
                return;
            }
            Console.WriteLine("Peek:"+fila.Peek());
            var veiculo = fila.Dequeue();
            Console.WriteLine("Saiu da fila..."+veiculo);
            Imprimir();
            string proximo;
            fila.TryPeek(out proximo);
            Console.WriteLine("O proximo da fila é:" + proximo);
        }
    }
}
