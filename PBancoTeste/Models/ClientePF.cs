using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoTeste.Models
{
    internal class ClientePF : Pessoa
    {
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public char Sexo { get; set; }

        public ClientePF ()
        {
        }

        public ClientePF(int IdCliente) : base(IdCliente)
        {
        }

        public void CadastrarClientePF(List<Agencia> agencias)
        {
            CadastrarPessoa();

            Console.Write("Informe o CPF do Cliente: ");
            this.CPF = Console.ReadLine();

            Console.Write("Informe a Data de Nascimento do Cliente: ");
            this.DataNasc = DateTime.Parse(Console.ReadLine());

            bool verifSexo = true;
            do
            {
                Console.Write("Informe o Sexo do Cliente. M / F : ");
                this.Sexo = char.Parse(Console.ReadLine().ToUpper());

                if (this.Sexo != 'M' && this.Sexo != 'F')
                {
                    Console.WriteLine("Voce inseriu um sexo inválido!");
                    verifSexo = false;
                }

                else
                    verifSexo = true;

            } while (verifSexo == false);

            AbrirConta(agencias);
        }

        public override string ToString()
        {
            return base.ToString() + "CPF do Cliente: " + this.CPF + "\nData de Nascimento do Cliente: " + this.DataNasc.ToShortDateString() + "\nSexo do Cliente: " + this.Sexo +  "Dados da Conta: " + this.ContaCorrente.ToString() + "******************************************";
        }
    }
}
