using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Ex001
{
    class ModuloUsuario
    {
        public void Create()
        {
            UsuarioRepository repository = new UsuarioRepository();
            string resposta = "";
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
                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);
                Console.WriteLine();

                Console.WriteLine("Deseja cadastrar mais 1? (y/n)");
                resposta = Console.ReadLine();
            } while (resposta == "y");

        }

    }
}
