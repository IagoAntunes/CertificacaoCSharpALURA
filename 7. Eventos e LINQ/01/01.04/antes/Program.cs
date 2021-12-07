using System;

namespace _01_04
{
    class Program
    {
        delegate int Operacao(int a,int b);
        static void Main(string[] args)
        {

            //Operacao operacao = (x, y) => { return x + y; };
            Operacao operacao = (x, y) =>  x + y;//<-- Lambda
            Console.WriteLine(operacao(3,2));

            Func<int, int, int> somar = (x, y) => x + y;
            Console.WriteLine(somar(3,2));


            Action<string> imprimirMensagem = (mensagem) => { Console.WriteLine(mensagem); };
            imprimirMensagem("Ola mundo");


            var numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Numeros divisiveis por 3:");
            Predicate<int> divisivelPor3 = (numero) => numero % 3 == 0;
            var divisiveis = Array.FindAll(numeros, divisivelPor3);
            foreach (var numero in divisiveis)
            {
                Console.WriteLine(numero);
            }


            Console.ReadLine();
        }
    }
}
/*03
 * Delegados e Lambda
 * -Criando delegados como ponteiros para metodos
 * expressao lambda e metodos anonimos
 * Utiliza lambdas e economize a criação de metodos
 * utilize metodos anonimos e economize a criação de classes
 */
/*04
 * Func,Action,Predicate
 * -Delegado Func e Delegado Action
 * -O delegado de funcao Func
 * -O delegado de funcao booleana predicate
 * -O delegado de metodo sem retorno Action
 * -Criando e consumindo predicados
 * -Usando predicados em parametros de metodos do framework
 */