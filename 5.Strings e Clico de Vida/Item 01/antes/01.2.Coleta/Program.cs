using System;
using System.Threading.Tasks;

namespace _01._02.TiposDeReferencia
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(3000); //aguarda 3 segundos

            //GerarTiposValor();
            GerarTiposReferencia();

            Console.ReadKey();
        }

        private static void GerarTiposValor()
        {
            for (long i = 0; i < 100000; i++)
            {
                EstruturaLivro livro = new EstruturaLivro
                {
                    NumeroPaginas = 1200
                };
            }
        }

        private static void GerarTiposReferencia()
        {
            for (long i = 0; i < 100000; i++)
            {
                ClasseLivro livro = new ClasseLivro
                {
                    Introducao = new string(' ', 100000),
                    Texto = new string(' ', 100000),
                    Conclusao = new string(' ', 100000)
                };
            }
        }
    }

    struct EstruturaLivro
    {
        public double NumeroPaginas { get; set; }
    }

    class ClasseLivro
    {
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
    }
}
/*Gerenciamento de Memoria com Pilha
 * Sao armazenados na pilha: tipos primitivos(int,bool,char)
 * Empilhamento/desempilhamento de blocos de metodos na pilha
 * Gerenciamento de memoria da pilha
 * 
 * Pilha X Heap
 * -Variaveis como endereços(referencias)de memoria
 * -Armazenamento no heap: tipos de referencia(strings,objetos,interfaces)
 * -Objetos queficaram no Heap sem nenhuma referencisa sao candidatos ao descarte pelo coletor de Lixo
 * 
 * Visualizando consumo de memoria no visua lstudio com ferramentas de diagnostico
 * -Comparação de consumo de memoria com tipso de valor x tipos de referencia
 * Identificando inicio do trabalho do garbage collector na visualização da memoria do processo/
 */
