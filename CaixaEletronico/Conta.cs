using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CaixaEletronico
{
    class Conta
    {
        public int IdConta { get; private set; }
        public string Nome { get;   set; }
        public double Deposito { get;set; }
        public double Saldo { get; private set; }

        public Conta(int idConta, string nome, double deposito)
        {
            this.IdConta = idConta;
            this.Nome = nome;
            this.Saldo = deposito;
        }

        public Conta(int idConta, string nome)
        {
            this.IdConta = idConta;
            this.Nome = nome;
            Saldo = 0.0;
        }

        public void depositar(double quantia)
        {
            Saldo += quantia;    
        }

        public void sacar(double quantia)
        {

            Saldo = Saldo - quantia - 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + IdConta + "Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
