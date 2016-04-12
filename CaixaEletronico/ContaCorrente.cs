﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class ContaCorrente : Conta
    {
        private double TaxaSaque { get; set; }

        public ContaCorrente(int numero, double saldo, Cliente titular) : base (numero, saldo, titular)
        {
            this.TaxaSaque = 0.20;
        }

        public override bool Sacar(double valor)
        {
            if(valor > 0.0)
            {
                if((valor + TaxaSaque) > Saldo)
                {
                    throw new Exception("Saldo insuficiente!");
                }

                Saldo -= (valor + TaxaSaque);
                return true;
            }

            return false;
        }

        public override bool Depositar(double valor)
        {
            if (valor > 0.0)
            {
                Saldo += valor;
                return true;
            }

            return false;
        }

        public override bool Transferir(double valor, Conta conta)
        {
            if (valor > 0.0)
            {
                if (valor > Saldo)
                {
                    throw new Exception("Saldo insuficiente!");
                }

                Saldo -= valor;
                conta.Depositar(valor);
                return true;
            }

            return false;
        }

    }
}
