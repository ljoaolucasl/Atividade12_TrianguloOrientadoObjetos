namespace Atividade12_TrianguloOrientadoObjetos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            int ladoA = Validar.Numero("Lado A: ");
            int ladoB = Validar.Numero("Lado B: ");
            int ladoC = Validar.Numero("Lado C: ");

            triangulo.SetLados(ladoA, ladoB, ladoC);

            string tipoTriangulo = triangulo.AnalisarTriangulo();

            Console.WriteLine();

            Console.WriteLine(tipoTriangulo);

            Console.ReadLine();
        }
    }
}