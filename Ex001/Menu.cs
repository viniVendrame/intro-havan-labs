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
                        ModuloUsuario moduloUsuario = new ModuloUsuario();
                        moduloUsuario.Create();
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
