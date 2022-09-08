using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoTeste.Models
{
    internal class Pessoa
    {
        #region Propriedades
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public float Salario { get; set; }
        public Endereco Endereco { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        protected int IdCliente { get; set; }
        #endregion

        public Pessoa()
        {
        }

        public Pessoa(int idCliente)
        {
            this.IdCliente = idCliente;
        }

        protected void CadastrarPessoa()
        {
            Console.Write("\nInforme o Nome: ");
            this.Nome = Console.ReadLine();

            Console.Write("Informe o Telefone: ");
            this.Telefone = Console.ReadLine();

            Console.Write("Informe a Renda Mensal: ");
            this.Salario = float.Parse(Console.ReadLine());

            this.Endereco = new Endereco();

            Console.Write("Informe o CEP: ");
            this.Endereco.CEP = Console.ReadLine();

            Console.Write("Informe o Estado: ");
            this.Endereco.Estado = Console.ReadLine();

            Console.Write("Informe a Cidade: ");
            this.Endereco.Cidade = Console.ReadLine();

            Console.Write("Informe o Bairro: ");
            this.Endereco.Bairro = Console.ReadLine();

            Console.Write("Informe o Logradouro: ");
            this.Endereco.Logradouro = Console.ReadLine();

            Console.Write("Informe o Numero: ");
            this.Endereco.Numero = Console.ReadLine();

        }
        protected void AbrirConta(List<Agencia> agencias)
        {
            this.ContaCorrente = new ContaCorrente();

            Console.Write("Informe o ID da Conta: ");
            this.ContaCorrente.IdConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o Titular da Conta: ");
            this.ContaCorrente.Titular = Console.ReadLine();

            Console.Write("Informe a Senha que o Cliente utilizará para fazer Login: ");
            this.ContaCorrente.Senha = Console.ReadLine();

            this.ContaCorrente.Saldo = 0;

            Console.WriteLine("Lista de agências:");
            foreach (var item in agencias)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Write("Informe qual Agência o Cliente será Cadastrado: ");
            int ag = int.Parse(Console.ReadLine());
            //this.ContaCorrente.agencia.IdAgencia = int.Parse(Console.ReadLine());
            //Agencia agencia;

            foreach (var item in agencias)
            {
                if (item.IdAgencia == ag)
                this.ContaCorrente.agencia = item;
            }
        }
        protected void SolicitarTipoConta()
        {
            Console.WriteLine("No momento só possuímos um tipo de conta!");
        }

        protected void SolicitarEmprestimo()
        {
            Console.Write("Função ainda não implementada!");
        }

        protected void SolicitarFecharConta()
        {
            Console.WriteLine("Função ainda não implementada!");
        }

        public override string ToString()
        {
            return "*************************************" +
                   "\nNome: " + this.Nome + "\n" +
                   "Telefone: " + this.Telefone + "\n" +
                   "Endereço: " + this.Endereco.ToString();
                   
        }
    }
}
