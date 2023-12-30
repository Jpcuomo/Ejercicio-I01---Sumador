using ClassLibrary1;

namespace Ejercicio_I01___Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Console.WriteLine($"Contador sumas: {sumador1.CantidadSumas}");

            long resultado1 = sumador1.Sumar(5, 5);
            Console.WriteLine(resultado1);
            Console.WriteLine($"Contador sumas: {sumador1.CantidadSumas}");


            string resultado2 = sumador1.Sumar("Hola", " que tal");
            Console.WriteLine(resultado2);
            Console.WriteLine($"Contador sumas: {sumador1.CantidadSumas}");

            Sumador sumador2 = new Sumador();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine((int)sumador1 + "*");

            sumador2.Sumar("Hola", " que tal");
            sumador2.Sumar("Hola", " como va");
            Console.WriteLine(sumador1.CantidadSumas);
            Console.WriteLine(sumador2.CantidadSumas);

            Console.WriteLine(sumador1 + sumador2);
            Console.WriteLine(sumador1 | sumador2);
        }
    }
}
