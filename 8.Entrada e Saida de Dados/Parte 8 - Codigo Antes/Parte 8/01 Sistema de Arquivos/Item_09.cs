using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_09 //A Classe Directory
    {
        static void Main(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Apagar o diretório que foi criado

            Directory.CreateDirectory("NovoDiretorio");
            if (Directory.Exists("NovoDiretorio"))
            {
                Console.WriteLine("Diretorio criado com sucesso!");
            };
            Directory.Delete("NovoDiretorio");
            Console.WriteLine("O diretorio foi removido com sucesso");


        }
    }
}
