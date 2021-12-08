using System;
using System.IO;

namespace Listings
{
    class Item_07 //Informações do drive
    {
        private const int KILOBYTES = 1024;
        static void XVIIMain(string[] args)
        {
            //TAREFA:
            //=======
            //Nome do drive
            //Verificar se o drive está pronto
            //Tipo do drive
            //Formato do drive
            //Espaço livre, em bytes, MB, GB e TB
            
            var drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine();
                Console.WriteLine("Nome:  {0}",drive.Name);

                if (!drive.IsReady) { 
                    Console.WriteLine("O drive nao esta pronto.");
                    continue;
                }
                Console.WriteLine("Tipo {0}",drive.DriveType);
                Console.WriteLine("Formato {0}",drive.DriveFormat);

                Console.WriteLine("Espaco Livre:");

                long bytes = drive.TotalFreeSpace;
                Console.WriteLine("{0:N2} bytes",bytes);

                double kb = bytes / KILOBYTES;// 1024 -> 1kb
                Console.WriteLine("{0:N2} Kbytes", kb);

                double mb = kb / KILOBYTES;
                Console.WriteLine("{0:N2} Megabytes", mb);

                double gb = mb / KILOBYTES;
                Console.WriteLine("{0:N2} Gigabytes", gb);

                double tb = gb / KILOBYTES;
                Console.WriteLine("{0:N2} Terabytes", tb);
            }
            Console.ReadLine();
        }
    }
}
