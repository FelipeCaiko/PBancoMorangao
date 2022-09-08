using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoTeste.Models
{
    internal class Agencia
    {
        public int IdAgencia { get; set; }
        public String NomeAgencia { get; set; }
        public Endereco Endereco { get; set; }

        public Agencia()
        {
        }

        public Agencia(int idAgencia, string nome, Endereco endereco)
        {
            this.IdAgencia = idAgencia;
            this.NomeAgencia = nome;
            this.Endereco = endereco;
        }

        public override string ToString()
        {
            return "\nID da Agencia: " + this.IdAgencia +
                   "\nNome: " + this.NomeAgencia + "\n" +
                   "Endereço: " + this.Endereco.ToString();

        }

    }
}
