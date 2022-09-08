using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoTeste.Models
{
    public class Endereco
    {
        public String Logradouro { get; set; }
        public String Cidade { get; set; }
        public String Bairro { get; set; }
        public String Estado { get; set; }
        public String CEP { get; set; }
        public String Numero { get; set; }

        public Endereco()
        {
        }

        public override string ToString()
        {
            return "\nCEP: " + this.CEP + "\n" +
                   "Estado: " + this.Estado + "\n" +
                   "Cidade: " + this.Cidade + "\n" +
                   "Bairro: " + this.Bairro + "\n" +
                   "Logradouro: " + this.Logradouro + "\n" +
                   "Numero: " + this.Numero + "\n";

        }
    }
}
