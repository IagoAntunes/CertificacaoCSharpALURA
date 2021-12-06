using System;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Codigo";

            Console.WriteLine(alura);
            Console.WriteLine(caelum);
            Console.WriteLine(casaDoCodigo);

            //Matriz
            //string[] empresas = new string[3];
            ////empresas[0] = alura;
            ////empresas[1] = caelum;
            ////empresas[2] = casaDoCodigo;

            //string[] empresas = new string[]
            //{
            //    alura
            //    caelum,
            //    casaDoCodigo
            //};

            string[] empresas = { alura, caelum, casaDoCodigo };

            Imprimir(empresas);

            empresas[1] = "caelum ensino e inovação!";

            Imprimir(empresas);


            Console.WriteLine("Primeiro elemento:" + empresas[0]);
            Console.WriteLine("Ultimo elemento:" + empresas[empresas.Length-1]);

            Console.ReadLine();
        }

        private static void Imprimir(string[] empresas)
        {
            for (int i = 0; i < empresas.Length; i++)
            {
                Console.WriteLine(empresas[i]);
            }
        }
    }
}
/*
 * Arrays
 * Arrays(Matrizes) a coleção fundamental
 * Acessando elemeentos do array atraves do indice
 * Funções de busca e redimensionamento de arrays
 * Ordenando , copiando , clonnando e limpando array
 * Iteração com Array e a interface IEnumerable
 */