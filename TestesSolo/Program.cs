using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            char op;

            do
            {
            Console.WriteLine("**********************************  Bem-vindo **********************************");
            Console.WriteLine("********************************** HAVAN LABS **********************************");

            Console.WriteLine("\n1 - Cadastrar Cliente");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Estoque");
            Console.WriteLine("0 - Sair");
            menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\n********** Preencha o formulário **********\n");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        break;
                }
            }while(menu != 0);
            
        }
    }
}
