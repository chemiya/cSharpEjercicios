// See https://aka.ms/new-console-template for more information


//clases con herencia en diferente fichero

namespace pooherenciasimple
{
    internal class Program
    {
        static void Main(string[] args)
        {//correcto
            Coche nuevo = new Coche();
            nuevo.acelero();
            Avion avi = new Avion();
            avi.aterrizar();
            Console.Write("atterrizo correctamnte");
        }
    }
}