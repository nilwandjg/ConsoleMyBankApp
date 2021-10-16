using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente cliente, int agencia, int conta)
        {
            this.setTitular(cliente);
            this.setAgencia(agencia);
            this.setConta(conta);
        }
    }
}
