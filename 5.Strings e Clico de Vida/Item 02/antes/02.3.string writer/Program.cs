using System;
using System.IO;
using System.Text;

namespace _02._3.string_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA:
            //======
            //1) Ler sequencialmente a lista de ingredientes
            //linha a linha.
            //2) Cada Linha deve começar com um caracter "•" e um espaço

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string ingredientes = GetIngredientes();
            using (StringWriter stringWriter = new StringWriter())
            {
                using (StringReader stringReader = new StringReader(ingredientes))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        stringWriter.WriteLine("• " + line);
                    }
                }
                Console.WriteLine(stringWriter  );
            }
            Console.ReadKey();
        }

        private static string GetIngredientes()
        {
            return
            @"3 cenouras médias raspadas e picadas
3 ovos
1 xícara de óleo
2 xícaras de açúcar
2 xícaras de farinha de trigo
1 colher(sopa) de fermento em pó
1 pitada de sal";
        }
    }
}
/* 
 * O conteudo de um objeto sring nao pode srr alterado.Porem sempre que modificamos
 * o conteudo de uma variavel string , na verdade o .net esta criando um novo objeto
 * como uma copia da string original e com a alteração desejada e depois disso a variavel string 
 * passa a fazer referencia a esse novo objeto
 * 
 * Uma instancia de string armazena 2 bilhoes de caracteres e pode armazenar o livro de harry potter
 * 
 * O tipo stringBudler nao é baseado em string.O StringBuilder usara uma ou mais matrizes
 * de caracteres para construir uma string
 * 
 * 
 */
/* 04
 * Concatenação, Escrita e Leitura de Strings
 * Manipulação de Strings
 * String Builder
 * -Concatenação com operador "+"
 * -Strigns como objetos imutaveis
 * -Concatenação repetitiva com operador "+" é ineficiente, pois cria trabalho para o coletor de lixo
 * -Usando StringBuilder para concatenação eficiente
 * -StringBuilder trablha internamente com um array de caracteres e nao com uma string
 * -quando um array interno de um stringBuilder fica sem espaço para novas concatenações,o StringBuilder
 * -aloca um tamanho maior para esse array
 * StringReader
 * -Lendo strings com StringReader
 * StringWriter
 * -Escrevendo sequencialmente em strings com a classe StringWriter
 */