using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula02.Tipos_de_Referencia
{
    public class TiposDeReferencia
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade;

            Console.WriteLine("int idade = 42");
            Console.WriteLine("int copiaIdade = 42");
            Console.WriteLine($"idade = {idade}");
            Console.WriteLine($"Copiaidade = {copiaIdade}");
            idade = 32;

            Console.WriteLine($"idade = {idade}");
            Console.WriteLine($"Copiaidade = {copiaIdade}");

            var cliente1 = new Cliente("Jose", 42);
            var cliente2 = cliente1;

            Console.WriteLine($"Before- {cliente1}");
            Console.WriteLine($"Before- {cliente2}");

            cliente1.Nome = "Maria de Souza";

            Console.WriteLine($"After- {cliente1}");
            Console.WriteLine($"After- {cliente2}");


        }
        class Cliente
        {
            public Cliente(string nome,int idade)
            {
                Nome = nome;
                Idade = idade;
            }
            public string Nome { get; set; }
            public int Idade { get; set; }

            public override string ToString()
            {
                return $"Nome: {Nome}, Idade; {Idade}";
            }
        }
    }
}
