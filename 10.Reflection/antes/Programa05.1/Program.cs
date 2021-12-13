using Programa05_1.Modelo;
using System;

namespace Programa05
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA 1: obter as propriedades de CarrinhoCliente

            //TAREFA 2: descobrir se podem ler ou escrever
            //TAREFA 3: descobrir seus acessadores getters e setters


            var tipo = typeof(CarrinhoCliente);
            var propriedades = tipo.GetProperties();
            foreach (var propriedade in propriedades)
            {
                Console.WriteLine("Propriedade: {0}",propriedade.Name);

                if (propriedade.CanRead)
                {
                    Console.WriteLine("\tPode ler");
                    Console.WriteLine("\t\tMetodo Get: {0}",propriedade.GetMethod.Name);
                }
                if (propriedade.CanWrite)
                {
                    Console.WriteLine("\tPode escrever");
                    Console.WriteLine("\t\tMetodo Set: {0}",propriedade.SetMethod.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
/*05
 * Usar tipos do namespace System.Reflection
 * -Obtendo informações de assembly com a classe Assembly
 * -Obtendo informações de propriedades com a classe PropertyInfo
 * -Obtendo informações de metodos com a methodInfo
 * -Obtendo informações de tipos com a classe type
 */