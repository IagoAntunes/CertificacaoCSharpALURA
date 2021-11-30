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
            Funcionario funcionario = new Funcionario(10000);
            /*
            funcionario.salario = 1000;

            Console.WriteLine(funcionario.salario);

            funcionario.salario = -1200;
            Console.WriteLine(funcionario.salario);
            */
            //funcionario.Salario = 1200;
            Console.WriteLine(funcionario.Salario);


            Console.ReadLine();
        }
    }
    class Funcionario
    {
        private decimal salario;
        public Funcionario(decimal salario)
        {
            if(salario < 0)
            {
                throw new ArgumentException();
            }
            this.salario = salario;
        }
        public decimal Salario//Encapsulamento do campo Salario 
        {
            get
            {
                return salario;
            }
            //set
            //{
            //    if (value < 0)
            //    {
            //        throw new ArgumentOutOfRangeException("Salario nao pode ser negativo!");
            //    }
            //    this.salario = value;
            //}
        }

        //public decimal Salario { get; set; }


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