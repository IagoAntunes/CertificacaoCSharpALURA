using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class ConversoesComClasses : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";

            //int numeroConvertido = textoDigitado;
            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            //numeroConvertido = int.Parse(textoDigitado);
            

            if(int.TryParse(textoDigitado, out numeroConvertido)) {
                Console.WriteLine(numeroConvertido);

            }
            else
            {
                Console.WriteLine("Texto nao é um numero. . . ´´");
            }
            textoDigitado = "R$ 123,45";


            decimal.TryParse(textoDigitado,
                System.Globalization.NumberStyles.Currency,//moeda
                System.Globalization.CultureInfo.CurrentCulture,//ptbr
                out decimal valorConvertido);
            Console.WriteLine(valorConvertido);







        }
    }
}
/*03
 * Conversoes definidas pelo usuario
 * Conversoes com classes auxiliares
 */