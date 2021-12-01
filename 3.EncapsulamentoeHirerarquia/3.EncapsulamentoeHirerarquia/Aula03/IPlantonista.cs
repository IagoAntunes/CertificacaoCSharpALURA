using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    interface IPlantonista
    {
        int CargaHorariaMensal { get; set; }
        void GerarCracha();
    }
}
