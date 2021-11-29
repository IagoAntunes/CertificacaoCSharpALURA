using Cerficacao_csharp_pt1.Aula01._06_Estruturas_Definidas_pelo_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1.Aula02._02_Classes
{
    public class Classes : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS() 
            {Latitude=12.78,Longitude=29.51 };

            posicao1 = new ClassePosicaoGPS(13.78, 29.51);

            Console.WriteLine(posicao1);

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78,29.51,DateTime.Now);

            Console.WriteLine(posicao2);

        }
    }
    class ClassePosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public ClassePosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public ClassePosicaoGPS()
        {

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

    internal class PosicaoGPSComLeitura : ClassePosicaoGPS
    {
        private readonly DateTime dataLeitura;

        public PosicaoGPSComLeitura(double latitude, double longitude,DateTime dataLeitura) : base(latitude, longitude)
        {
            this.dataLeitura = dataLeitura;

        }
        public override string ToString()
        {
            return $"\tTOSTRING\nLatitude: {Latitude} \nLongitude: {Longitude} \nDataLeitura:{dataLeitura}";
        }
    }
}
