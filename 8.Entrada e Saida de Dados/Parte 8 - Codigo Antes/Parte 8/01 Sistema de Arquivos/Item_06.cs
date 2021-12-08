﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_06 //Stream exceptions
    {
        static void XVIMain(string[] args)
        {
            try
            {
                string conteudo = File.ReadAllText("Arquivo.txt");
                Console.WriteLine("O conteudo é: {0}", conteudo);
            }catch(FileNotFoundException e)
            {
                Console.WriteLine("O arquivo nao foi encontrado!");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
        }
    }
}
