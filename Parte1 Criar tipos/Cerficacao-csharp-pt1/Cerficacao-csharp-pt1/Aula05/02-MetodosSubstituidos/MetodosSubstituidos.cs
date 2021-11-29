using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class MetodosSubstituidos
    {
        public void Executar()
        {
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato() { Nome = "Pantera" };
            gata.Beber();
            gata.Comer();
            gata.Andar();


            //


        }
    }
    class Animal
    {
        public string Nome { get; set; }
        public virtual void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }
        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }
        public virtual void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }
    class Gato : Animal
    {
        public override void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }
        public override void Comer()
        {
            Console.WriteLine("Gato.Comer");
        }
        public override void Andar()
        {
            Console.WriteLine("Gato.Andar");
        }

    }
}
