using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /* FORMA ANTIGA:
             * 
            cliente.setNome("Nilwan de Jesus");
            cliente.setCPF("999.999.999-88");
            cliente.setProfissao("Desempregado");
            */

            // FORMA CORRETA:
            Cliente cliente = new Cliente("Nilwan de Jesus", "999.999.999-88", "Desempregado");


            /* FORMA ANTIGA:
             * 
            conta.titular = cliente;
            conta.agencia = 01;
            conta.conta = 0001;
            */

            //FORMA CORRETA:
            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            Console.WriteLine("CONTA CORRENTE CRIADA");
            Console.WriteLine("Titular: {0}.", conta.getTitular().getNome()); 
            Console.WriteLine("Agência: {0}.", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns, seu saldo é de R${0}. Obrigado por criar sua conta!", conta.getSaldo());

            //TESTANDO MÉTODO PARA DEPÓSITO:
            double valorDeposito = 200;
            conta.Depositar(valorDeposito);
            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            //TESTANDO MÉTODO PARA SAQUE:
            double valorSaque = 100;
            conta.Sacar(valorSaque);
            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            //CRIANDO NOVO CLIENTE:
            Cliente clienteSilvia = new Cliente("Silvia Mendes Oliveira", "000.000.000-00", "Administradora");
            ContaCorrente contaSilvia = new ContaCorrente(clienteSilvia, 01, 0002);

            //TESTE DO MÉTODO PARA PIX:
            double valorPix = 100;
            conta.Pix(valorPix, contaSilvia);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}", contaSilvia.getSaldo());

            //CRIANDO UMA CONTA POUPANÇA (filha da classe CONTA):
            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);

            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agência: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());
        }
    }
}
