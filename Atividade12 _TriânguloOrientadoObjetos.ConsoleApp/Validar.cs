using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12_TrianguloOrientadoObjetos.ConsoleApp
{
    public class Validar
    {
        public static int InputNumero(string mensagem)
        {
            int numero;
            bool valido;

            do
            {
                Console.Write(mensagem);

                string entrada = Console.ReadLine();

                valido = int.TryParse(entrada, out numero);

            } while (!valido);

            return numero;
        }
    }
}
