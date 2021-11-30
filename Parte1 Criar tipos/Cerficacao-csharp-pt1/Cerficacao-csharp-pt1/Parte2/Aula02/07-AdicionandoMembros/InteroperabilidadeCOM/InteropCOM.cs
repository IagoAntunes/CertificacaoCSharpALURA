using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class InteropCOM : IAulaItem
    {
        public void Executar()
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application", true);
            dynamic excel = Activator.CreateInstance(excelType);

            excel.visible = true;
            excel.Workbooks.Add();

            dynamic planilha = excel.ActiveSheet;

            planilha.Cells[1, "A"] = "Alura";
            planilha.Cells[1, "B"] = "Cursos";
            planilha.Cells[2, "A"] = "Certificacao";
            planilha.Cells[2, "B"] = "C#";

            planilha.Columns[1].AutoFit();
            planilha.Columns[2].AutoFit();





        }
    }
}
/*05
 * Resolução de sobrecargas
 * Dynamic Language Runtime
 * Interoperabilidade COM
 */