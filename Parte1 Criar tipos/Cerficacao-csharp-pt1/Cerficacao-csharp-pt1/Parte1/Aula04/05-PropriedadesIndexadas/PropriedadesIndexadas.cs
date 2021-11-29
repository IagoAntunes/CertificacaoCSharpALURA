using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerficacao_csharp_pt1
{
    internal class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();
            sala["D01"] = new ClienteCinema("Luiz henrique");
            sala.SetReserva("D01", new ClienteCinema("Maria de Souza"));
            sala.SetReserva("D02", new ClienteCinema("Jose da Silva"));

            sala.ImprimirReservas();
        }
    }
    class ClienteCinema
    {
        public ClienteCinema(string nome)
        {
            nome = nome;
        }
        public string Nome { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
    class Sala
    {
        private readonly IDictionary<string,ClienteCinema>reservas = new Dictionary<string,ClienteCinema>();

        public ClienteCinema GetReserva(string codigoAssento)
        {
            return reservas[codigoAssento];
        }
        public void SetReserva(string codigoAssento,ClienteCinema cliente)
        {
            reservas[codigoAssento] = cliente;
        }

        public ClienteCinema this[string codigoAssento]
        {
            get
            {
                return reservas[codigoAssento];
            }
            set
            {
                reservas[codigoAssento]=value;
            }
        }


        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos Reservados");
            Console.WriteLine("===========");

            foreach (var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} - {reserva.Key}");
            }
        }
    }
}
