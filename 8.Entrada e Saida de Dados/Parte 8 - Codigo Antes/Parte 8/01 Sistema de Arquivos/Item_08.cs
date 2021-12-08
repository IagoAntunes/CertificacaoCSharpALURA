using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_08 //Informações de arquivo
    {
        private const string caminho = "Arquivo.txt";

        static void Main(string[] args)
        {
            //TAREFA: OBTER INFORMAÇÕES EM UM ARQUIVO
            //1. Gravar um texto em Arquivo.txt
            //2. Obter informações desse arquivo:
            //      Nome
            //      Caminho completo (diretório + nome do arquivo)
            //      Data e hora do último acesso
            //      Tamanho do arquivo (bytes)
            //      Atributos do arquivo
            //      Adicionar atributo somente-leitura
            //      Verificar os atributos novamente
            //      Remover atributo somente-leitura
            //      Verificar os atributos novamente

            File.WriteAllText(caminho, "Texto Inicial do arquivo");

            FileInfo info = new FileInfo(caminho);

            Console.WriteLine("Nome: {0}",info.Name);
            Console.WriteLine("Caminho completo: {0}",info.FullName);
            Console.WriteLine("Ultimo acesso: {0}",info.LastAccessTime);
            Console.WriteLine("Tamanho arquivo: {0} bytes",info.Length);
            Console.WriteLine("Atributos: {0}",info.Attributes);
            //info.Attributes = FileAttributes.ReadOnly;//zera todos outros
            info.Attributes = info.Attributes | FileAttributes.ReadOnly;
            Console.WriteLine("Atributos: {0}", info.Attributes);
            info.Attributes = info.Attributes & ~FileAttributes.ReadOnly;
            Console.WriteLine("Atributos: {0}", info.Attributes);


        }
    }
}
/*03
 * Obter informações de drive
 * A classe DriveInfo
 * Obter e manipular atributos de arquivo
 * FileInfo e FileAttributes
 */
