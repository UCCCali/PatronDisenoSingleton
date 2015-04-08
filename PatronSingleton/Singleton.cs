
namespace PatronSingleton
{
    public class Singleton
    {

        private static Singleton instancia = null;

        private Singleton(){}

        public static Singleton ObtenerInstancia(){

            if (instancia == null)
            {
                instancia = new Singleton();
            }

            return instancia;

        }

    }
}
