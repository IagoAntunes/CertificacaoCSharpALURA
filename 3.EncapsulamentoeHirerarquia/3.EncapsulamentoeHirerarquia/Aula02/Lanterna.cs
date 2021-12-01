using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    class Lanterna : IEletros , IIluminacao
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double PotenciaDaLampada { get; set; }
        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }
}
