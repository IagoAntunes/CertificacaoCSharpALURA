using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_10 //A classe Directorylnfo
    {
        static void Main(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Exibir os atributos do diretório
            //Exibir último acesso
            //Apagar o diretório que foi criado


            DirectoryInfo localDir = new DirectoryInfo("NovoDiretorio");
            localDir.Create();
            if (localDir.Exists)
            {
                Console.WriteLine("Diretorio criado com sucesso :´l");
            }
            Console.WriteLine("Atributos: {0}",localDir.Attributes);
            Console.WriteLine("Ultimo Acesso: {0}",localDir.LastAccessTime);
            localDir.Delete();
            Console.WriteLine("Diretorio removido com sucesso!!");

        }
    }
}
