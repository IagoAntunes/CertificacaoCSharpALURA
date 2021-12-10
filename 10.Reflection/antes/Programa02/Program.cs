using System;

namespace Programa02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarefa: Ler os atributos de formato 
            //de impressão da classe Venda

            Relatorio relatorio = new Relatorio("Relatório de Vendas");
            relatorio.Imprimir();

            if (Attribute.IsDefined(typeof(Venda), typeof(SerializableAttribute)))
            {
                Console.WriteLine("A classe Venda DEFINE o atributo Serializable");
            }
            else
            {
                Console.WriteLine("A classe Venda NÃO DEFINE o atributo Serializable");
            }

            Console.ReadLine();
        }
    }
}
/*02
 * Ler atributos
 * -Inspecionando atributos de uma classe
 * -Fazendo cast e acessando conteudo de um atributo
 */
