using System;

namespace _01_04
{
    class Program
    {
        delegate int Operacao(int a,int b);
        static void Main(string[] args)
        {

            //Operacao operacao = (x, y) => { return x + y; };
            Operacao operacao = (x, y) =>  x + y;
            Console.WriteLine(operacao(3,2));






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