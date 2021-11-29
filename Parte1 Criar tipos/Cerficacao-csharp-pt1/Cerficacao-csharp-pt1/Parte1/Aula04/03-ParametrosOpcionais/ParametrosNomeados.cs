using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula04._03_ParametrosOpcionais
{
    internal class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            //Ordem Normal
            ImprimirDetalhesDoPedido("Maria de Fatima", 31, "Caneca Vermelha");

            //Argumentos nomeados
            ImprimirDetalhesDoPedido(numeroPedido: 31,nomeProduto: "Caneca Vermelha",vendedor: "Maria de Fatima");
            ImprimirDetalhesDoPedido(nomeProduto: "Caneca Vermelha", vendedor: "Maria de Fatima", numeroPedido: 31);

            //Misturados
            ImprimirDetalhesDoPedido("Maria de Fatima",31,nomeProduto:"Caneca Vermelha");

            //Outros tipos
            ImprimirDetalhesDoPedido(vendedor:"Maria de Fatima",31,nomeProduto:"Caneca Vermelha");
            ImprimirDetalhesDoPedido("Maria de Fatima",numeroPedido: 31,"Caneca Vermelha");

        }
        void ImprimirDetalhesDoPedido(string vendedor,int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrEmpty(vendedor))
            {
                throw new ArgumentException(message: "Nome do vendedor na oencontrado!");
            }
            Console.WriteLine($"Vendedor: {vendedor}, Pedido no {numeroPedido}");
        }
    }

}
