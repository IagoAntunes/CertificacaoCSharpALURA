using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula02._06_Dynamic
{
    public class Dinamicos :IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;

            //objeto = objeto + 3;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;

            Console.WriteLine(dinamico);

            //dinamico.teste();
            //objeto.teste();

        }
    }
}
