using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class OperadoresISeAS
    {
        public void Exexutar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("Jose da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);

        }
        public void Alimentar(object obj){
            //Animal animal = obj as Animal;

            /*if (obj is Animal)
            {
                animal = (Animal)obj;
            }*/
            if(obj is Animal animal) {
                animal.Beber();
                animal.Comer();
                Console.WriteLine("obj nao é um animal");
                return;
            }
        }
    }
    class Cliente
    {
        public string nome;
        public int idade;
        public Cliente(string nome,int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }
}
/*
 * 02
 * Conversoes Implicitas
 * Conversoes Explicitas(cast)
 */
