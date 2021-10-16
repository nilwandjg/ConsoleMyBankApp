using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    //A linha abaixo diz que a classe 'ContaCorrente' é filha da classe 'Conta' ee erda seus métodos e atributos.
    public class ContaCorrente : Conta
    {
        //MÉTODO CONSTRUTOR:
        public ContaCorrente(Cliente titular, int agencia, int conta)
        {
            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);
        }
        
    }
}
