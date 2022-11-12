// See https://aka.ms/new-console-template for more information

//clase simple con properties

namespace poosimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coc = new Coche();
            coc.Nombre = "mdne";
            Console.WriteLine("el nombre es: "+coc.Nombre);
        }
        public class Coche
        {
            private string nombre;
            public string Nombre
            {//mayusc atrib
                get
                {
                    return nombre;//get nos lo da
                }
                set
                {
                    nombre = value;//set lo doy
                }
            }
        }
    }
}









