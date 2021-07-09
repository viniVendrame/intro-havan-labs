using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Ex001
{
    class Usuario
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public string email;
        public string endereco;
       

        public void Cadastro()
        {
            Console.WriteLine("\n--- Cadastro de Cliente ---\n");
            Console.Write("Nome: ");
            this.nome = Validacao.ValidarDados();
            Console.Write("Sobrenome: ");
            this.sobrenome = Validacao.ValidarDados();
            Console.Write("Idade: ");
            this.idade = Validacao.ValidarInteiros();
            Console.Write("E-mail: ");
            this.email = Validacao.ValidarDados();
            Console.Write("Endereço: ");
            this.endereco = Validacao.ValidarDados();
            Console.WriteLine();

        }
    }
}
