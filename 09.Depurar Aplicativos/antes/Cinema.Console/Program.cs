using Cinema.Dados;
using System;
using System.Collections.Generic;
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
            var cinemaDB = new CinemaDB(DatabaseServer, MasterDatabase, DatabaseName);

            await cinemaDB.CriarBancoDeDadosAsync();

            IList<Filme> filmes = await cinemaDB.GetFilmes();

            foreach (var filme in filmes)
            {
                Console.WriteLine("Diretor: {0} Titulo: {1}", filme.Diretor, filme.Titulo);
            }

            Console.ReadKey();
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