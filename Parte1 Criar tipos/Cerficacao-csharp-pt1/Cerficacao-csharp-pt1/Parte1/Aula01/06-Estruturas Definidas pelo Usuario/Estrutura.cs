using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula01._06_Estruturas_Definidas_pelo_Usuario
{
    internal class Estrutura : IAulaItem
    {
        public void Executar()
        {

            double Latitude = 13.78;
            double Longitude = 29.51;
            double latitude2 = 40.23;
            double Longitude2 = 17.4;

            Console.WriteLine($"Latitude1 = {Latitude}");
            Console.WriteLine($"Longitude1 = {Longitude}");
            Console.WriteLine($"Latitude2 = {latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            PosicaoGPS posicao1;//STRUCT É TIPO DE VALOR

            //STRUCT É UMA CLASSE MUITO LEVE
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            posicao1 = new PosicaoGPS(13.78, 29.51);

            Console.WriteLine(posicao1);


        }
    }
    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }
    


    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

 

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"\tTOSTRING\nLatitude: {Latitude} \nLongitude: {Longitude}";
        }

    }
}


