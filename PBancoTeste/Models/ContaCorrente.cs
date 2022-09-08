using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoTeste.Models
{
    internal class ContaCorrente
    {
        public int IdConta { get; set; }
        public string Titular { get; set; }
        public float Limite { get; set; }
        public Agencia agencia { get; set; }
        public float Saldo { get; set; }
        public string Senha { get; set; }

        public ContaCorrente()
        {
        }

        public void EfetuarSaque(ContaCorrente c)
        {
            Console.Write("Informe a quantidade em dinheiro que você deseja sacar de sua conta!\nValor: ");
            float valor = float.Parse(Console.ReadLine());

            if (valor <= c.Saldo)
            {
                c.Saldo = c.Saldo - valor;
                Console.WriteLine("Você realizou o saque no valor de " + valor + " reais.");
            }
            else
                Console.WriteLine("Impossível realizar saque! O valor solicitado é maior que o saldo da conta!");
        }

        public void EfetuarDeposito(ContaCorrente c)
        {
            Console.Write("Informe a quantidade em dinheiro que você deseja depositar em sua conta!\nValor: ");
            float valor = float.Parse(Console.ReadLine());

            c.Saldo = c.Saldo + valor;
        }

        public void ConsultarSaldo(ContaCorrente c)
        {
            Console.WriteLine("O saldo disponível em sua conta é de " + c.Saldo + " reais.");
        }

        public bool EfetuarLogin(int id, string senha, List<Pessoa> clientes)
        {
            foreach (var item in clientes)
            {
                if ((id == item.ContaCorrente.IdConta) && (senha == item.ContaCorrente.Senha))
                    return true;
            }
            return false;
        }

        public void ImprimirExtrato()
        {
            Console.Write("Função ainda não implementada!");
        }

        public void EfetuarTransferencia()
        {
            Console.Write("Função ainda não implementada!");
        }

        public void ConsultarLimite()
        {
            Console.Write("Função ainda não implementada!");
        }

        public void SolicitarLimite()
        {
            Console.Write("Função ainda não implementada!");
        }

        public void RealizarPagamento()
        {
            Console.Write("Função ainda não implementada!");
        }

        public override string ToString()
        {
            return "\nID da Conta: " + this.IdConta + "\nSenha da Conta: " + this.Senha + "\nTitular: " + this.Titular + "\nSaldo : " + this.Saldo + "\nLimite: " + this.Limite + "\nDados da Agencia: " + agencia.ToString();
        }
    }
}
