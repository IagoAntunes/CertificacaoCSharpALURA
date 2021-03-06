using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace _05.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(1, 100);
            ContaCorrente conta2 = new ContaCorrente(4, 50);
            Console.WriteLine(conta1);
            Console.WriteLine(conta2);

            ITransferenciaBancaria transferencia = new TransferenciaBancaria();
            transferencia.Efetuar(conta1, conta2, 30);

            Console.WriteLine(conta1);
            Console.WriteLine(conta2);

            try
            {
                transferencia.Efetuar(conta1, null, 50);
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("Aconteceu um problema na transferencia.");
                Logger.LogErro(ae.ToString());
            }
            catch(Exception ex)
            {

            }


            Console.ReadKey();
        }
    }

    class ContaCorrente
    {
        public int Id { get; }
        public decimal Saldo { get; private set; }

        public ContaCorrente(int id, decimal saldo)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }

            Id = id;
            Saldo = saldo;
        }

        public void Debitar(decimal valor)
        {
            if (Saldo < valor)
            {
                //throw new ArgumentException("saldo insuficiente");
                throw new SaldoInsuficienteException();
            }

            Saldo -= valor;
        }

        public void Creditar(decimal valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return $"Conta Nº: {Id:0000}, Saldo: {Saldo:C}";
        }
    }

    interface ITransferenciaBancaria
    {
        void Efetuar(ContaCorrente contaDebito, ContaCorrente contaCredito
            , decimal valor);
    }

    class TransferenciaBancaria : ITransferenciaBancaria
    {
        public void Efetuar(ContaCorrente contaDebito, ContaCorrente contaCredito
            , decimal valor)
        {
            if(contaDebito == null)
            {
                throw new ArgumentNullException("contaDebito");
            }
            if(contaCredito == null)
            {
                throw new ArgumentNullException("contaCredito");
            }
            if(valor < 0)
            {
                throw new ArgumentOutOfRangeException("Valor negativo . . . ");
            }
            if(valor > contaDebito.Saldo) { 
                throw new InsuficienteException03();
            }


            Logger.LogInfo("Entrando do método Efetuar.");

            contaDebito.Debitar(valor);
            contaCredito.Creditar(valor);
            Logger.LogInfo("Transferência realizada com sucesso.");
            Logger.LogInfo("Saindo do método Efetuar.");
        }
    }

    class TransferenciaBancaria_BD : ITransferenciaBancaria
    {
        private const string CONNECTION_STRING =
            @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB\ByteBank.mdf;Integrated Security=True";
        private const decimal TAXA_TRANSFERENCIA = 1.0m;
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void Efetuar(ContaCorrente contaCredito, ContaCorrente contaDebito
            , decimal valor)
        {
            Logger.LogInfo("Entrando do método Efetuar.");

            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            transaction = connection.BeginTransaction();

            SqlCommand comandoTransferencia = GetTransferenciaCommand
                (contaCredito.Id, contaDebito.Id, valor);
            SqlCommand comandoTaxa = GetTaxaTransferenciaCommand
                (contaCredito.Id, TAXA_TRANSFERENCIA);

            comandoTaxa.ExecuteNonQuery();
            comandoTransferencia.ExecuteNonQuery();
            transaction.Commit();
            Logger.LogInfo("Transferência realizada com sucesso.");

            Logger.LogInfo("Saindo do método Efetuar.");
        }

        private SqlCommand GetTransferenciaCommand(int contaDebitoId, int contaCreditoId, decimal valorTransferencia)
        {
            SqlCommand command = new SqlCommand("p_TRANSFERENCIA_BANCARIA_i", connection, transaction);
            command.Parameters.AddWithValue("@CONTA_ID_DEBITO", contaDebitoId);
            command.Parameters.AddWithValue("@CONTA_ID_CREDITO", contaCreditoId);
            command.Parameters.AddWithValue("@VALOR", valorTransferencia);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }

        private SqlCommand GetTaxaTransferenciaCommand(int contaId, decimal valorTransferencia)
        {
            SqlCommand command = new SqlCommand("p_TARIFA_TRANSFERENCIA_i", connection, transaction);
            command.Parameters.AddWithValue("@CONTA_ID", contaId);
            command.Parameters.AddWithValue("@VALOR", valorTransferencia);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }
    }

    [Serializable]
    public class SaldoInsuficienteException02 : Exception
    {
        public SaldoInsuficienteException02() { }
        public SaldoInsuficienteException02(string message) : base(message) { }
        public SaldoInsuficienteException02(string message, Exception inner) : base(message, inner) { }
        protected SaldoInsuficienteException02(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string Message => "Saldo Insuficiente.";
    }

    class Logger
    {
        public static void LogInfo(string mensagem)
        {
            Log(mensagem, "INFO");
        }

        public static void LogErro(string mensagem)
        {
            Log(mensagem, "ERRO");
        }

        private static void Log(string mensagem, string tipo)
        {
            using (var sw = new StreamWriter("logs.txt", append: true))
            {
                sw.WriteLine(DateTime.Now.ToLocalTime() + ": " + tipo + " - " + mensagem);
            }
        }
    }


    [Serializable]
    public class InsuficienteException03 : Exception
    {
        public InsuficienteException03() { }
        public InsuficienteException03(string message) : base(message) { }
        public InsuficienteException03(string message, Exception inner) : base(message, inner) { }
        protected InsuficienteException03(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string Message => "Saldo Insuficiente:!:!";
    }

}
/*05Manipulação de Excecoes
 * Realizando transferencia entre contas
 * Capturando excecoes com try e catch
 * excecao Base
 * Lançando exceções especializadas
 * criando exceç~~oes customizadas
 */
/*06
 * Execoes om SQL Server e Rede
 * Fazendo a transferencia bancaria com SQL Server
 * Liberando recursos apos a ocorrencia de uma excecao
 * Desfazendo Transação e Relançanddo Excecoes
 * Capturando mais de um tipo de Excecao no Bloco Try Catch Finally
 */