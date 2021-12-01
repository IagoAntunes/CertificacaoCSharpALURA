using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario02 funcionario = new Funcionario02(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "Jose da Silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            ((IPlantonista)funcionario).CargaHorariaMensal = 32;
            funcionario.EfetuarPagamento();
            funcionario.CrachaGerado += (s, e) =>
             {
                 Console.WriteLine("Cracha gerado");
             };
            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();




            Console.ReadLine();
        }

        static void aula02()
        {
            IEletros eletro1 = new Televisao();
            IEletros eletro2 = new Abajur();
            IEletros eletro3 = new Lanterna();
            IEletros eletro4 = new Radio();

            eletro1 = new Abajur();
            eletro2 = new Televisao();
            eletro3 = new Radio();
            eletro4 = new Lanterna();
        }

        static void aula03()
        {

        }
    }

}




/*01
 * Propriedades e Acessadores
 * Introducao
 * Encapsulamento
 * -Acessadores get e set
 * Propriedade somente leitura
 * propriedade autoimplementada
 * -Como o compilador gera codigo da propriedade autoimplementada
 * Modificadores de Visibilidade
 * -private
 * -protected
 * -internal
 * -public
 */
/*02
 * Projetando e extraindo interfaces
 * Metodos
 * propriedades
 * eventos
 */
/*03
 * Interfaces Explicitas
 * -Implementando membros de mesmo nome de interfaces diferentes
 */