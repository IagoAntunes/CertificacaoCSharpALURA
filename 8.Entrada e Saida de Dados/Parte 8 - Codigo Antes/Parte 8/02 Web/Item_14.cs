﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Listings
{
    class Item_14 //WebClient
    {
        static void xMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //mas de forma mais simples e rápida
            //byte[] array = new byte[100];
            WebClient webClient = new WebClient();
            string textoDoSite = webClient.DownloadString("http://www.caelum.com.br");
            //array = webClient.DownloadData("http://www.caelum.com.br");
            Console.WriteLine(textoDoSite);

            //foreach (var item in array)
            //{
            //    Console.Write((char)item);
            //}

            Console.ReadKey();
        }
    }
}