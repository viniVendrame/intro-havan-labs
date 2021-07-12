using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Ex001
{
    class Menu
    {
            public static void MontaMenu()
        {
            // cabeçalho
            Cabecalho();

            // opções
            Opcoes();

            // rodapé
            Rodape();

            //escolha
            Escolha();
        }

        private static void Rodape()
        {
            Console.Write("\nEscolha uma opção do menu: ");
        }

        private static void Opcoes()
        {
            Console.WriteLine("\n\t1 - Cadastrar Usuário");
            Console.WriteLine("\t2 - Cadastrar Produto");
            Console.WriteLine("\t0 - Sair");
        }

        private static void Cabecalho()
        {
            Console.WriteLine("\n********** Bem-vindo **********");
            Console.WriteLine("********** HAVAN **********");
        }

        private static void Escolha()
        {
            int opcao = 0;
            do
            {

                opcao = Validacao.ValidarInteiros();
                switch (opcao)
                {
                    case 1:
                        string resposta = "";
                        List<Usuario> usuarios = new List<Usuario>();
                        do
                        {
                            Console.WriteLine("\n--- Cadastro de Cliente ---\n");
                            Console.Write("Nome: ");
                            string nome = Validacao.ValidarDados();
                            Console.Write("Sobrenome: ");
                            string sobrenome = Validacao.ValidarDados();
                            Console.Write("Idade: ");
                            int idade = Validacao.ValidarInteiros();
                            Console.Write("E-mail: ");
                            string email = Validacao.ValidarDados();
                            Console.Write("Endereço: ");
                            string endereco = Validacao.ValidarDados();
                            Usuario user = new Usuario(nome, sobrenome, idade, email, endereco);
                            usuarios.Add(user);

                            Console.WriteLine();

                            Console.WriteLine("Deseja cadastrar mais 1? (y/n)");
                            resposta = Console.ReadLine();
                        } while (resposta == "y");

                        //lambda
                        //Usuario userSelect1 = usuarios.FirstOrDefault(u => u.nome.Equals("cimbinha"));
                        //Usuario userSelect2 = (from u in usuarios where u.nome == "chimbinha" select u).FirstOrDefault();

                        foreach (var item in usuarios)
                        {
                            Console.WriteLine($"\nSeu nome: {item.Nome.ToLower()}\nSeu sobrenome: {item.Sobrenome.ToLower()}\nSua idade: {item.Idade}\nSeu email: {item.Email.ToLower()}\nSeu Endereço: {item.Endereco.ToLower()}");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Em implementação");
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        Console.Write("Escolha outra opção: ");
                        break;
                }
            }while(opcao != 0);
        }
    }
}
