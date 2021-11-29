using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula01._07_Enums
{
    public class Enumerações : IAulaItem
    {
        public void Executar()
        {
            const int Seg = 0;
            const int Ter = 1;
            const int Qua = 2;


            DiasDaSemana primeiroDia = DiasDaSemana.Seg;

            DiasDeTrabalho diasDeTrabalho = 
                DiasDeTrabalho.Ter | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex;


            Console.WriteLine(diasDeTrabalho);


        }
    }
    enum DiasDaSemana : long
    {
        Seg,Ter,Qua,Qui,Sex,Sab,Dom
    }
    [Flags]
    enum DiasDeTrabalho
    {
        Seg = 0,Ter = 1,Qua = 2,Qui = 4,Sex = 8,Sab = 16,Dom = 32
    }
}
