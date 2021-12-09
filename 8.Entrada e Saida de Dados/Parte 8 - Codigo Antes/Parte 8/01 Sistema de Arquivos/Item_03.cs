using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_03 //StreamWriter and StreamReader
    {
        static void XIIIMain(string[] args)
        {
            //TAREFA: Usar FileStream dá muito trabalho...
            //        Não podemos usar algo mais simples??

            
            using(StreamWriter gravadorFluxo = new StreamWriter("ArquivoSaida.txt"))
            {
                gravadorFluxo.Write("Olá, Alura! (gravado com StreamWriter)");
            }
            using(StreamReader leitorFluxo = new StreamReader("ArquivoSaida.txt"))
            {
                string texto = leitorFluxo.ReadToEnd();
                Console.WriteLine(texto);
            }
        }
    }
}
