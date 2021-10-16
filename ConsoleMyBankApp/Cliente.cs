﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        //MÉTODO CONSTRUTOR:
        public Cliente(string nome, string cpf, string profissao)
        {
            this.setNome(nome);
            this.setCPF(cpf);
            this.setProfissao(profissao);
        }

        //GETTER E SETTERS DA CLASSE "Cliente":
        public virtual string getNome(){return this.nome;}
        public void setNome(string nome) { this.nome = nome; }

        public string getCPF() { return this.cpf; }
        public void setCPF(string cpf) { this.cpf = cpf; }

        public string getProfissao() { return this.profissao; }
        public void setProfissao(string profissao) { this.profissao = profissao; }


    }
    
}
