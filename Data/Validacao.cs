using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Validacao
    {
        public static string ValidarDados()
        {
            string dado = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(dado))
            {
                Console.Write("Dado Inválido. Tente novamente: ");
                dado = Console.ReadLine().Trim();
                
            }

            return dado;
        }

        public static int ValidarInteiros()
        {
            do
            {
                try
                {
                    int dado = Convert.ToInt32(Console.ReadLine());
                    return dado;
                }
                catch (FormatException)
                {
                    Console.Write("Erro! dado inválido, tente novamente: ");
                }
            } while (true);

        }
    }
}
