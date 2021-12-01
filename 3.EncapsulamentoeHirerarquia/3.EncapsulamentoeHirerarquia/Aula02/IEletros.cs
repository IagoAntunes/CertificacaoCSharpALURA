using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    interface IEletros
    {
        event EventHandler Ligou;
        event EventHandler Desligou;

        void Desligar();
        void Ligar();
    }
}
