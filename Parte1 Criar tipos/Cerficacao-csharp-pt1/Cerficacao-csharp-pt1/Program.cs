using Cerficacao_csharp_pt1.Aula01._01_TiposDeValor;
using Cerficacao_csharp_pt1.Aula01._03_Tipos_de_Ponto_Flutuante;
using Cerficacao_csharp_pt1.Aula01._06_Estruturas_Definidas_pelo_Usuario;
using Cerficacao_csharp_pt1.Aula01._07_Enums;
using Cerficacao_csharp_pt1.Aula01.Booleanos;
using Cerficacao_csharp_pt1.Aula01.Decimal;
using Cerficacao_csharp_pt1.Aula01.TiposInteiros;
using Cerficacao_csharp_pt1.Aula02._02_Classes;
using Cerficacao_csharp_pt1.Aula02._03_Interfaces;
using Cerficacao_csharp_pt1.Aula02._04_Delegates;
using Cerficacao_csharp_pt1.Aula02._05_Objetos;
using Cerficacao_csharp_pt1.Aula02._06_Dynamic;
using Cerficacao_csharp_pt1.Aula02.Strings;
using Cerficacao_csharp_pt1.Aula02.Tipos_de_Referencia;
using Cerficacao_csharp_pt1.Aula04._02_Metodos;
using Cerficacao_csharp_pt1.Aula04._03_ParametrosOpcionais;
using Cerficacao_csharp_pt1;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opcao");
            int opc = 0;
            TiposDeValor tipo = new TiposDeValor();
            Inteiros inteiros = new Inteiros();
            PontoFlutuante pontoFlutuante = new PontoFlutuante();
            DecimalValor decimalV = new DecimalValor();
            Booleanos booleanos = new Booleanos();
            Estrutura estruturas = new Estrutura();
            Enumerações enumeracoes = new Enumerações();
            TiposDeReferencia referencias = new TiposDeReferencia();
            Classes classes = new Classes();
            Interfaces interf = new Interfaces();
            Delegates delegates = new Delegates();
            Objetos objetos = new Objetos();
            Dinamicos dinamicos = new Dinamicos();
            Strings strings = new Strings();
            Metodos metodos = new Metodos();
            ParametrosNomeados PNomeados = new ParametrosNomeados();
            ParametrosOpcionais POpcionais = new ParametrosOpcionais();
            MetodosDeExtensao metodosDeExtensao = new MetodosDeExtensao();
            PropriedadesIndexadas propIndexadas = new PropriedadesIndexadas();
            Sobrecargas sobrecargas = new Sobrecargas();
            MetodosSubstituidos metodosSubstituidos = new MetodosSubstituidos();

            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 0:
                    break;
                case 1:
                    tipo.Executar();
                    break;
                case 2:
                    inteiros.Executar();
                    break;
                case 3:
                    pontoFlutuante.Executar();
                    break;
                case 4:
                    decimalV.Executar();
                    break;
                case 5:
                    booleanos.Executar();
                    break;
                case 6:
                    estruturas.Executar();
                    break;
                case 7:
                    enumeracoes.Executar();
                    break;
                case 8:
                    referencias.Executar();
                    break;
                case 9:
                    classes.Executar();
                    break;
                case 10:
                    interf.Executar();
                    break;
                case 11:
                    delegates.Executar();
                    break;
                case 12:
                    objetos.Executar();
                    break;
                case 13:
                    dinamicos.Executar();
                    break;
                case 14:
                    strings.Executar();
                    break;
                case 15:
                    metodos.Executar();
                    break;
                case 16:
                    PNomeados.Executar();
                    break;
                case 17:
                    POpcionais.Executar();
                    break;
                case 18:
                    metodosDeExtensao.Executar();
                    break;
                case 19:
                    propIndexadas.Executar();
                    break;
                case 20:
                    sobrecargas.Executar();
                    break;
                case 21:
                    metodosSubstituidos.Executar();
                    break;


               
                    

            }
            Console.ReadLine();
        }
    }
}
/*01
 * Caracteristicas principais dos tipos de valor
 * Inicializando Tipos de Valor
 * Tipos Integraisdasw
 */
/* 02
 * Tipos de ponto Flutuante
 * Decimal
 * Booleanos
 * Estrutura definidas pelo Usuario
 * Enums*/
/*03
 * tipos de referencia
 * classes
 * interface
 * delegate
 * object
 * dynamic
 * string
 */
/*04
 * Metodos
 * parametros opcionais e nomeados
 * Metodos de Extensao
 * propriedades indexadas
 */
/*05
 * Criar metodos sobrecarregados
 * Criar metodos substituidos
 */