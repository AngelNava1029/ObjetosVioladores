using System;

namespace ObjetosVoladores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa");
            Console.WriteLine("Instanciando dron");
            Dron miDron1 = new Dron();
            
            miDron1.Encender();
            Console.WriteLine( miDron1.ToString());

            Console.WriteLine("Fabricando avion");
            Avion miAvion = new Avion();

            miAvion.Encender(); 
            Console.WriteLine(miAvion.ToString());
            miAvion.despegar();
            miDron1.despegar();


            Console.ReadKey();
        }
    }
}