using System;
using System.Collections;
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
            Aluno aluno1 = new Aluno()
            {
                Nome = "Jose da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };
            Aluno aluno2 = new Aluno()
            {
                Nome = "Jose da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };
            Aluno aluno3 = new Aluno()
            {
                Nome = "jose da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };


            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));

            Aluno aluno4 = new Aluno
            {
                Nome = "ANDRE DOS SANTOS",
                DataNascimento = new DateTime(1970, 1, 1)
            };
            Aluno aluno5 = new Aluno
            {
                Nome = "Ana de Souza",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            List<Aluno> alunos = new List<Aluno>
            {
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5
            };
            List<int> alunos2 = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            alunos.Sort();
            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }


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
        }
    
        static void aula04()
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

            Cliente cliente = new Cliente
            {
                CPF = "789.456.123-99",
                DataNascimento = new DateTime(1980, 1, 1),
                Nome = "Maria de Souza",
                dataUltimaCompra = new DateTime(2018, 1, 1),
                ValorUltimaCompra = 200
            };

            Console.WriteLine(cliente);

            Pessoa teste = new Cliente();
        }
    
        static void aula05()
        {
            Aluno aluno1 = new Aluno()
            {
                Nome = "Jose da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };
            Aluno aluno2 = new Aluno()
            {
                Nome = "Jose da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };
            Aluno aluno3 = new Aluno()
            {
                Nome = "jose da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };


            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));
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
/*04
 * CLasse Base
 * -O conceito de Heranca
 * -Extraindo a clase base a partir de membros em comum
 * Proibindo criação de instancias de classe com o modificador abstract
 * Poribindo criação de classes derivadas com o modificador sealed
 */
/*05
 * Comparando identidade de objetos com o metodo Equals()
 * Implementando os metodos Equals() e GetHashCode()
 * Definindo a ordenação de objetos com os metodos IComparable.CompareTo()
 * Conclusao
 */