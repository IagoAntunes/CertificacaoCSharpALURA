using System;

namespace _02._5.enumerar
{
    class Program
    {
        static void Main(string[] args)
        {
            string documento = GetDocumento();

            Console.WriteLine(documento);

            //Char c = documento[0];
            //Char[] Array = documento.ToCharArray();

            for (int i = 0; i < documento.Length; i++)
            {
                char c = documento[i];
                if (char.IsUpper(c))
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.Write(c);
            }

            //TAREFA:
            //======
            //Imprimir o documento no console, destacando
            //as letras maiúsculas no texto

            Console.ReadKey();
        }

        private static string GetDocumento()
        {
            return "Uma cadeia de caracteres é uma coleção sequencial de caracteres que é usada para representar texto. Um objeto String é uma coleção sequencial de objetos System.Char que representam uma cadeia de caracteres; um System.Char objeto corresponde a uma unidade de código UTF-16. O valor de objeto String é o conteúdo da coleção sequencial de objetos System.Char cujo valor é imutável. Ou seja, ele é somente leitura.";
        }
    }
}
/*05
 * Pesquisando Strings
 * Pesquisa de strings parte1
 * -Descobrindo se uma strign conttem uma substring com o metodo Contains()
 * -Desobrindo se uma strign comereça com uma substring com o metodo StartsWith()
 * -Descobrindo se umma string termina com uma substring cm o metodo EndsWith()
 *Pesquisa de stringa parte2
 *-Obtendo o indice da peoxima substring dentor de uma string com o metodo IndexOf()
 *-Obtendo uam substring a partir de uma string com o metodo SUbstring()
 *Substituindo ocorrencias de uma substring em um texto com o metodo Replace()
 *Enumerar strings
 *-Varrengo strings com a instrução foreach
 *-Varrendo strings com a instrução for
 *Uma string pode ser iterada pela instrução foreach porque implementa a interface IEnumerable
 *Descobrindo se um caractere é letra maiuscula com o metodo IsUpper()
 */
