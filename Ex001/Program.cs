using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Crie um projeto do tipo console aplication em C# com .net framework V4.7.2
            // 2 - Crie uma aplicação para cadastro de usuário, que contenha os seguintes dados :
            // nome - sobrenome - Email - Endereço
            // 4 - Os dados do usuário devem ser impressor em uma unica linha

            Menu.MontaMenu();
            Console.WriteLine("Saindo... Pressione qualquer tecla para fechar!");
            Console.ReadLine();


        }

    }
}
