using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._4.IDisposable_Finalizador
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMensagem());
        }
    }
}
/*02
 * Coletando Lixo
 * Finalizadores
 * -Criando Finalizadores
 * FInalizadores soa usados para liberar recursos nao gerenciados
 * Finalizadores sao incovcados externamento pelo Garbage Collector
 * Forçando o trabalho de descar do coletro de lixo com o metodo GC.Collect()
 * O padrao Dispose
 * -Implementando a interface IDisposable]
 */
