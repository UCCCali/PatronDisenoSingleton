using System;

namespace PatronSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instancia1 = Singleton.ObtenerInstancia();

            Console.WriteLine(String.Format("Instancia Singleton 1 = {0}", instancia1.GetHashCode()));

            Singleton instancia2 = Singleton.ObtenerInstancia();

            Console.WriteLine(String.Format("Instancia Singleton 2 = {0}", instancia2.GetHashCode()));

            Console.ReadLine();
        }
    }
}
