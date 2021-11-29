using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula04._03_ParametrosOpcionais
{
    internal class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas SkyWalker");
            clienteEspecial.FazerPedido(1,"Residencial",1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial.FazerPedido(2, "Comercial");
            clienteEspecial.FazerPedido(2);

            //Erro
            //clienteEspecial.FazerPedido();
            //clienteEspecial.FazerPedido(3, , 4);
            //clienteEspecial.FazerPedido(3,4);
        }
    }
    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Anonimo")
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId,string endereco="Residencial",int quantidade=10)
        {
            Console.WriteLine("Cliente {0}: produtoId: {1}, Endereco: {2},Quantidade:{3}",nome,produtoId,endereco,quantidade);
        }
    }
}
