using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    internal class Funcionario
    {
        private decimal salario;
        public Funcionario(decimal salario)
        {
            if (salario < 0)
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
