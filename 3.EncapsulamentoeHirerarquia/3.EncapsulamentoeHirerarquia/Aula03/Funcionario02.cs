using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    class Funcionario02 : IFuncionario,IPlantonista
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public event EventHandler CrachaGerado;
        void IFuncionario.GerarCracha()
        {
            if(CrachaGerado != null)
            {
                CrachaGerado(this,new EventArgs());
            }
        }
        void IPlantonista.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }
        public decimal Salario { get; }
        int IFuncionario.CargaHorariaMensal { get; set; }
        int IPlantonista.CargaHorariaMensal { get; set; }
        public Funcionario02(decimal salario) 
        { 
        }
        public void EfetuarPagamento()
        {

        }

    }
}
