﻿using System;
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