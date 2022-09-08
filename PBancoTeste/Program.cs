using PBancoTeste.Models;
using System;
using System.Collections.Generic;

namespace PBancoTeste
{
    internal class Program
    {
        public static ClientePJ RegistrarClientePJ(List<Agencia> agencias)
        {
            ClientePJ cpj = new ClientePJ();

            cpj.CadastrarClientePJ(agencias);
            return cpj;
        }
        public static ClientePF RegistrarClientePF(List<Agencia> agencias)
        {
            ClientePF cpf = new ClientePF();

            cpf.CadastrarClientePF(agencias);
            return cpf;
        }
        public static Agencia RegistrarAgencia(Funcionario f1)
        {
            return f1.CadastrarAgencia();
        }

        public static void AutorizarAbertura()
        {
            Funcionario gerente = new Funcionario();

            if (gerente.PermissaoConta() == true)
                Console.WriteLine("\nPermissão para Abertura de Conta Concedida");
            else
                Console.WriteLine("\nPermissão para Abertura de Conta Negada");
        }

        public static void AutorizarEmprestimo()
        {
            Funcionario gerente = new Funcionario();

            if (gerente.PermissaoEmp() == true)
                Console.WriteLine("\nSolicitação de Empréstimo Concedida");
            else
                Console.WriteLine("\nSolicitação de Empréstimo Negada");
        }

        public static Pessoa AprovarClientePendente(List<Pessoa> clientesPendentes)
        {
            Pessoa p = new Pessoa();
            Console.WriteLine("Lista de Clientes Pendentes:");
            foreach (var item in clientesPendentes)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Write("Informe o nome do Cliente a ser aprovado: ");
            string nome = Console.ReadLine();

            foreach (var item in clientesPendentes)
            {
                if (item.Nome == nome)
                {
                    p = item;
                    clientesPendentes.Remove(item);
                    return p;
                }
            }
            return null;
        }

        public static void ListarClientesAprovados(List<Pessoa> clientesAprovados)
        {
            foreach (var item in clientesAprovados)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void MostrarListaAgencias(List<Agencia> agencias)
        {
            foreach (var item in agencias)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ListarClientesPendentes(List<Pessoa> clientesPendentes)
        {
            foreach (var item in clientesPendentes)
            {
                Console.WriteLine(item.ToString());
            }
        }


        static void Main(string[] args)
        {
            int op = 0;
            int opfunc = 0;
            int opcli = 0;
            List<Pessoa> clientesAprovados = new List<Pessoa>();
            List<Pessoa> clientesPendentes = new List<Pessoa>();
            Funcionario funcionario1 = new Funcionario();
            List<Agencia> agencias = new List<Agencia>();

            do
            {
                Console.Clear();
                Console.Write("Escolha a opção referente ao menu que deseja utilizar.\n1-Menu do Cliente\n2-Menu do Funcionário\n0-Sair do Menu Principal\nOpção desejada: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("\nVocê saiu do MENU PRINCIPAL!");
                        break;
                    case 1:
                        ContaCorrente login = new ContaCorrente();
                        Console.Write("Informe seu ID de LOGIN: ");
                        int idlogin = int.Parse(Console.ReadLine());
                        Console.Write("Informe sua Senha de LOGIN: ");
                        string senha = Console.ReadLine();
                        bool loginAceito = login.EfetuarLogin(idlogin, senha, clientesAprovados);

                        if (loginAceito)
                        {
                            do
                            {
                                Console.Write("\nEscolha a opção referente ao que deseja realizar.\n1-Efetuar Saque\n2-Efetuar Depósito\n3-Consultar Saldo\n4-Efetuar Transferência\n5-Imprimir Extrato\n6-Consultar Limite\n7-Solicitar Limite\n8-Realizar Pagamento\n0-Sair do Menu de Cliente\nOpção desejada: ");
                                opcli = int.Parse(Console.ReadLine());
                                switch (opcli)
                                {
                                    case 1:
                                        login.EfetuarSaque(login);
                                        break;
                                    case 2:
                                        login.EfetuarDeposito(login);
                                        break;
                                    case 3:
                                        login.ConsultarSaldo(login);
                                        break;
                                    case 4:
                                        login.EfetuarTransferencia();
                                        break;
                                    case 5:
                                        login.ImprimirExtrato();
                                        break;
                                    case 6:
                                        login.ConsultarLimite();
                                        break;
                                    case 7:
                                        login.SolicitarLimite();
                                        break;
                                    case 8:
                                        login.RealizarPagamento();
                                        break;
                                    case 0:
                                        Console.WriteLine("\nVocê saiu do Menu de Cliente!");
                                        break;
                                    default:
                                        Console.WriteLine("Você selecionou uma opção inválida! Favor selecionar uma opção válida.\n");
                                        break;
                                }
                            } while (opcli != 0);
                        }
                        else
                            Console.WriteLine("Login ou senha incorretos!");
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.Write("Escolha a opção referente ao que deseja realizar.\n1-Cadastrar Cliente Pessoa Fisica\n2-Cadastrar Cliente Pessoa Juridica\n3-Cadastrar Agencia\n4-Autorizar Abertura de Conta\n5-Autorizar Empréstimo\n6-Aprovar Cliente Pendente\n7-Mostrar Clientes Aprovados\n8-Mostrar CLientes Pendentes\n9-Mostrar Lista de Agencias\n0-Sair do Menu de Funcionário\nOpção desejada: ");
                            opfunc = int.Parse(Console.ReadLine());
                            switch (opfunc)
                            {
                                case 1:
                                    clientesPendentes.Add(RegistrarClientePF(agencias));
                                    break;
                                case 2:
                                    clientesPendentes.Add(RegistrarClientePJ(agencias));
                                    break;
                                case 3:
                                    agencias.Add(RegistrarAgencia(funcionario1));
                                    break;
                                case 4:
                                    AutorizarAbertura();
                                    break;
                                case 5:
                                    AutorizarEmprestimo();
                                    break;
                                case 6:
                                    Pessoa p = AprovarClientePendente(clientesPendentes);
                                    if (p == null)
                                        Console.WriteLine("Não foi possivel aprovar cliente!");
                                    else
                                        clientesAprovados.Add(p);
                                    break;
                                case 7:
                                    ListarClientesAprovados(clientesAprovados);
                                    break;
                                case 8:
                                    ListarClientesPendentes(clientesPendentes);
                                    break;
                                case 9:
                                    MostrarListaAgencias(agencias);
                                    break;
                                case 0:
                                    Console.WriteLine("\nVocê saiu do Menu de Funcionário!");
                                    break;
                                default:
                                    Console.WriteLine("Você selecionou uma opção inválida! Favor selecionar uma opção válida.\n");
                                    break;
                            }
                            Console.WriteLine("Pressionar qualquer tecla para continuar!");
                            Console.ReadKey();

                        } while (opfunc != 0);

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Você selecionou uma opção inválida! Favor selecionar uma opção válida.\n");
                        break;
                }
                if (op != 0)
                {
                    Console.WriteLine("Pressionar qualquer tecla para continuar!");
                    Console.ReadKey();
                }
            } while (op != 0);
        }
    }
}
