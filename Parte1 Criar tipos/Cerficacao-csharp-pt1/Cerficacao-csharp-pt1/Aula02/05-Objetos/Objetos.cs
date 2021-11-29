using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula02._05_Objetos
{
    public class Objetos
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");


            Console.WriteLine("object");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuobjeto = {meuObjeto}");
            Console.WriteLine($"meuobjeto.TYPE = {meuObjeto.GetType()}");
            //Console.WriteLine($"meuobjeto.TOSTRING = {meuObjeto.ToString()}");



            meuObjeto = new Jogador();
            Jogador classRef;

            classRef = (Jogador)meuObjeto;

            Console.WriteLine($"classRef.Pontuacao:{classRef.Pontuacao}");




        }
    }
    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}

