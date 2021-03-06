using System;
using System.Reflection;

namespace Programa05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarefa 1: obter o nome completo do assembly atual
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Nome do Assembly: {0}",assembly.FullName);

            //Tarefa 2: obter a versão do assembly atual
            //Obter a identidade do assembly primeiro
            var identidadeAssembly = assembly.GetName();
            Console.WriteLine("Versao: {0}",identidadeAssembly.Version);
            Console.WriteLine("Versao Major: {0}",identidadeAssembly.Version.Major);
            Console.WriteLine("Versao Minor: {0}",identidadeAssembly.Version.Minor);

            //Tarefa 3: descobrir se o assembly atual 
            //          está no Global Assembly Cache
            Console.WriteLine("Esta no GlobalAssemblyCache? {0}",
                assembly.GlobalAssemblyCache);

            //Tarefa 4: descobrir todos os módulos, 
            //          tipos e membros do assembly

            foreach (var modulo in assembly.GetModules())
            {
                Console.WriteLine("Modulo: {0}",modulo);
            }
            foreach (var tipo in assembly.GetTypes())
            {
                Console.WriteLine("\tTipo: {0}",tipo);
                foreach (var membro in tipo.GetMembers())
                {
                    Console.WriteLine("\t\tMembro: {0} ({1})",membro,membro.MemberType);
                }
            }            
            Console.ReadKey();
        }
    }
}


