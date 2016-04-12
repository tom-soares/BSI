﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public abstract class Conta
    {
        protected int Numero { get; set; }
        protected double Saldo { get; set; }
        protected Cliente Titular { get; set; }

        public Conta(int numero, double saldo, Cliente titular)
        {
            this.Numero = numero;
            this.Saldo = saldo;
            this.Titular = titular;
        }
         
        public double GetSaldo()
        {
            return this.Saldo;
        }

        public abstract bool Sacar(double valor);
        public abstract bool Depositar(double valor);
        public abstract bool Transferir(double valor, Conta conta);

        public int GetNumero()
        {
            return this.Numero;
        }

    }
}
