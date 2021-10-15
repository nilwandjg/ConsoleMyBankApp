using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Nilwan de Jesus", "999.999.999-88", "Desempregado");

            /*
            cliente.setNome("Nilwan de Jesus");
            cliente.setCPF("999.999.999-88");
            cliente.setProfissao("Desempregado");
            */
                    
            ContaCorrente conta = new ContaCorrente();

            conta.titular = cliente;
            conta.agencia = 01;
            conta.conta = 0001;

            Console.WriteLine("CONTA CORRENTE CRIADA");
            Console.WriteLine("Titular: {0}.", conta.titular.nome);
            Console.WriteLine("Agência: {0}.", conta.agencia);
            Console.WriteLine("Conta: {0}", conta.conta);
        }
    }
}
