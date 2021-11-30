using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {

            string s = "Certificacao C#";
            var v = "Certificacao C#";
            object o = "Certificacao C#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //s = 123;
            //v = 123;
            o = 123;
            o = (int)o + 4;
            Console.WriteLine(o);

            //-------------------------
            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);

            d = 123;
            Console.WriteLine(d);

            d = d + 4;
            Console.WriteLine(d);


        }
    }
}
