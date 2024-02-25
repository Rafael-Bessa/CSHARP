using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BessaBank
{
    public class Conta
    {

        private String titular;
        private Double saldo;

        public Conta(double saldo, string nome)
        {
            this.titular = nome;
            this.saldo = saldo;
        }

        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void Deposita(double valor) 
        {
            this.saldo += valor;
        }

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void Transfere(double valor, Conta conta)
        {
            this.saldo -= valor;
            conta.Saldo += valor;
        }
        public override string ToString()
        {
            return $"Nome: {Titular}, Saldo da Conta: {Saldo}";
        }
    }
}
