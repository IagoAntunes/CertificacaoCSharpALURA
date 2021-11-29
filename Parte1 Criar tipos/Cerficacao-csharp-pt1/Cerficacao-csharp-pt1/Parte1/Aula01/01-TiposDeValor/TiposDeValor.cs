using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula01._01_TiposDeValor
{
    public class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine(idade);

            int copiaIdade = idade;

            Console.WriteLine($"Idade: {idade} " +
                $"\nCopiaIdade{copiaIdade}");

            idade = 23;

            Console.WriteLine($"Idade: {idade} " +
            $"\nCopiaIdade{copiaIdade}");

            int? idade2 = null;
            idade2 = 4;
        }
    }
}
