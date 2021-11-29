using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é \r\n o meu documento");
            impressora.ImprimirDocumento();
            //impressora.ImprimirDocumentoHTML(impressora.Documento);
            impressora.imprimirdocumentohtml();



        }

    }
    class Impressora
    {
        public string Documento { get; }
        public Impressora(string documento)
        {
            this.Documento = documento;
        }
        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
        //public void imprimirdocumentohtml(string documento)
        //{
        //    console.writeline($"<html><body>{documento}</body></html>");
        //}
    }
    static class ImpressoraExtensios
    {
        public static void imprimirdocumentohtml(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }


}
