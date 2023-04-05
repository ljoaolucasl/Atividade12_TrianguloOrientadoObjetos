using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12_TrianguloOrientadoObjetos.ConsoleApp
{
    public class Triangulo
    {
        private int ladoATringulo;
        private int ladoBTringulo;
        private int ladoCTringulo;

        public void SetLados(int ladoA, int ladoB, int ladoC)
        {
            ladoATringulo = ladoA;
            ladoBTringulo = ladoB;
            ladoCTringulo = ladoC;
        }

        public string AnalisarTriangulo()
        {
            string tipo = "";

            if (TrianguloValido())
            {
                if (Equilatero())
                    tipo = "Triângulo equilátero";

                else if (Escaleno())
                    tipo = "Triângulo escaleno";

                else if (Isosceles())
                    tipo = "Triângulo isósceles";
            }
            else
                tipo = "Triângulo Inválido";

            return tipo;
        }

        private bool TrianguloValido()
        {
            bool ladosABC = ladoATringulo + ladoBTringulo >= ladoCTringulo;
            bool ladosBCA = ladoBTringulo + ladoCTringulo >= ladoATringulo;
            bool ladosACB = ladoATringulo + ladoCTringulo >= ladoBTringulo;

            return ladosABC && ladosBCA && ladosACB;
        }

        private bool Equilatero()
        {
            return ladoATringulo * 2 == ladoBTringulo + ladoCTringulo;
        }

        private bool Escaleno()
        {
            return ladoATringulo != ladoBTringulo && ladoATringulo != ladoCTringulo && ladoBTringulo != ladoCTringulo;
        }

        private bool Isosceles()
        {
            return ladoATringulo != ladoBTringulo || ladoBTringulo != ladoCTringulo;
        }
    }
}
