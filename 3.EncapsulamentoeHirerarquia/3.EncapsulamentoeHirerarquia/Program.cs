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
            IEletros eletro1 = new Televisao();
            IEletros eletro2 = new Abajur();
            IEletros eletro3 = new Lanterna();
            IEletros eletro4 = new Radio();

            eletro1 = new Abajur();
            eletro2 = new Televisao();
            eletro3 = new Radio();
            eletro4 = new Lanterna();


            Console.ReadLine();
        }

        static void aula02()
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