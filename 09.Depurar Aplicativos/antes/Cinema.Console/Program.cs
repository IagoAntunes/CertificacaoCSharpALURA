using Cinema.Dados;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        private const string DatabaseServer = "(LocalDB)\\MSSQLLocalDB";
        private const string MasterDatabase = "master";
        private const string DatabaseName = "Cinema";

        static async Task Main(string[] args)
        {
            //TraceListener traceListener = new ConsoleTraceListener();
            //TraceListener traceListener = new TextWriterTraceListener("log.txt");
            //Trace.Listeners.Add(traceListener);
            
            TraceListener traceListener = new EventLogTraceListener("Cinema");
            Trace.Listeners.Add(traceListener);
            Trace.AutoFlush = true;
            TraceSource traceSource = new TraceSource("Cinema",SourceLevels.All);
            traceSource.Listeners.Add(traceListener);

            traceSource.TraceEvent(TraceEventType.Information,1001,"A aplicação iniciou.");

            string estaVariavelEhDebug = "So existe em debug";
            var cinemaDB = new CinemaDB(DatabaseServer, MasterDatabase, DatabaseName);

            await cinemaDB.CriarBancoDeDadosAsync();

            IList<Filme> filmes = await cinemaDB.GetFilmes();

            Console.WriteLine("Relatorio de Filmes.");
            Console.WriteLine(new string('=',50));
            foreach (var filme in filmes)
            {
                Console.WriteLine("Diretor: {0}\n Titulo: {1}", filme.Diretor, filme.Titulo);
                Console.WriteLine(new string('-', 50));
            }

            //traceListener.Flush();
            Console.ReadKey();

            traceSource.TraceEvent(TraceEventType.Information,1002,"A aplicação terminou");

        }
    }
}
/*01
 * Gerenciando Assemblies
 * O que sao Assemblies? Os arquivos .EXE e .DLL
 * Dependencia de Assemblies
 * Compilador c# e o compilador Just in time
 * Linguagem C# X A linguagem intermediaria X linguagem de maquina
 * Uma olhada dentro do assembly com o utilitario ILDASM
 * versionamento de assemblies
 */
/*02
 * Assinando assemblies com nomeFonte
 * -Os arquivos .pfx e .snk
 * Desenvolvendo com assinatura atrasada
 * Arquivos de chaves e atributos de assinatura em assemblyInfo cs
 * Compartilhando componentes com o cache de assembly global
 */
/*03
 * Depurando aplicações
 * -Como depurar aplicações
 * -Um programa ,muitas versoes: A compilação condicional
 * -Multiplos simbolos de compilação condicional
 * -Compilação condicional com msbuild
 */
/*04
 * Compilação Condicional
 * -Evitando a execução de metodo com o atributo de compilação condicional
 * -Alertando o desenvolvedor com o atributo obsolete
 * -Evitando compilação inadequada com as diretivas #warning e #error
 * Suprimindo alertas que poluem a interface
 * - Como prevenir entrada do depurador em metodos
 */
/*05
 * Compilação em Modo Debug e Realease
 * -Desenvolvimento ou Produção? Escolhendo entre Debug e Release
 * -Melhorando o Relatório de Filmes
 * -Muito alem do Console.WriteLine: Usando a Classe Debug e Janela Output
 * -Como usar Entendetação para Estruturar as informações de Debug
 */
/*06
 * Rastreamento de Aplicações
 * -Permitindo Monitorar aplicação em Produção: A Classe Trace
 * -Definindo Ouvintes do Trace: Console,Arquivo,EventLog
 * -Gravando Trace no Log de Eventos do Windows
 * -Tipos de Mensagens: TraceInformation,TraceWarning,TraceError
 */
/*07
 * Gravando Mensagens no Event Log
 * -Mais riqueza de informações com a classe TraceSource
 * -Medindo Tempo decorrido com stopwatch
 * por dentor da classe eventLog
 * -Lendo Log do windows com EventLog
 */
/*08
 * Contadores de Desempenho
 * -Preparando a aplicação para monitorar desempenho
 * Adicionando projeto cinemaperformance
 * incrementando contadores de desempenho
 * entendendo a criação de categoria e contadores de desempenho
 * conclusao do curso
 */