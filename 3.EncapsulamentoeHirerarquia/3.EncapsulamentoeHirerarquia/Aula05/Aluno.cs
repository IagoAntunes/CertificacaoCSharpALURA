using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    public class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome:{Nome},Data Nascimento: {DataNascimento:dd/MM/yyyy}";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if(outro == null)
            {
                return false;
            }
            return this.Nome.Equals(outro.Nome,StringComparison.CurrentCultureIgnoreCase)&&
                this.DataNascimento.Equals(outro.DataNascimento);
        }

        public override int GetHashCode()
        {
            int hashCode = -1523756618;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
            return hashCode;
        }

        public int CompareTo(object obj)
        {
            // 0 -> iguais     >0    -> obj atual vem depois   <0   -> Objeto atual vem antes
            if(obj == null)
            {
                return 1;
            }

            Aluno outro = obj as Aluno;
            if(outro == null)
            {
                throw new ArgumentException("Objeto não é um aluno.");
            }

            int resultado = this.DataNascimento.CompareTo(outro.DataNascimento);
            if(resultado == 0)
            {
                resultado = this.Nome.CompareTo(outro.Nome);
            }
            return resultado;
        }
    }
}
