using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoTeste.Models
{
    internal class ClientePJ : Pessoa
    {
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }

        public ClientePJ()
        {
        }

        public ClientePJ(int IdCliente) : base(IdCliente)
        {
        }

        public void CadastrarClientePJ(List<Agencia> agencias)
        {
            CadastrarPessoa();

            Console.Write("Informe o CNPJ do Cliente: ");
            this.CNPJ = Console.ReadLine();

            Console.Write("Informe o Nome Fantasia do Cliente: ");
            this.NomeFantasia = Console.ReadLine();

            AbrirConta(agencias);
        }

        public override string ToString()
        {
            return base.ToString() + "CNPJ do Cliente: " + CNPJ + "\nNome Fantasia do Cliente: " + NomeFantasia + "\nDados da Conta: " + this.ContaCorrente.ToString() + "*************************************";
        }
    }
}
