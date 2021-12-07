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