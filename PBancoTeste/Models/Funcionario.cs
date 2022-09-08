using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoTeste.Models
{
    internal class Funcionario : Pessoa
    {
        public Agencia agencia { get; set; }

        public Funcionario()
        {
        }

        public bool PermissaoConta()
        {
            return true;
        }

        public bool PermissaoEmp()
        {
            return true;
        }

        public Agencia CadastrarAgencia()
        {
            agencia = new Agencia();
            Console.Write("Informe o ID da Agência: ");
            this.agencia.IdAgencia = int.Parse(Console.ReadLine());

            Console.Write("Informe o Nome da Agência: ");
            this.agencia.NomeAgencia = Console.ReadLine();

            this.agencia.Endereco = new Endereco();

            Console.Write("Informe o CEP: ");
            this.agencia.Endereco.CEP = Console.ReadLine();

            Console.Write("Informe o Estado: ");
            this.agencia.Endereco.Estado = Console.ReadLine();

            Console.Write("Informe a Cidade: ");
            this.agencia.Endereco.Cidade = Console.ReadLine();

            Console.Write("Informe o Bairro: ");
            this.agencia.Endereco.Bairro = Console.ReadLine();

            Console.Write("Informe o Logradouro: ");
            this.agencia.Endereco.Logradouro = Console.ReadLine();

            Console.Write("Informe o Numero: ");
            this.agencia.Endereco.Numero = Console.ReadLine();

            return agencia;
        }

    }
}
