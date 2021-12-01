using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EncapsulamentoeHirerarquia
{
    class Cliente : Pessoa
    {
        public DateTime? dataUltimaCompra { get; set; }
        public decimal? ValorUltimaCompra { get; set; }


        public override string ToString()
        {
            return $"Nome: {Nome},Data Ultima Compra: {dataUltimaCompra}";
        }



    }
}
