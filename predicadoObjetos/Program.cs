// See https://aka.ms/new-console-template for more information

//predicado que busca en array de objetos por atributo
namespace predicado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array
            List<Persona> gente = new List<Persona>();
            Persona p1 = new Persona();
            p1.Nombre = "chema";
            p1.Edad = 23;

            Persona p2 = new Persona();
            p2.Nombre = "juan";
            p2.Edad = 23;

            Persona p3 = new Persona();
            p3.Nombre = "fede";
            p3.Edad = 23;

            gente.Add(p1);
            gente.Add(p2);
            gente.Add(p3);


//predicado
            Predicate<Persona> predic = new Predicate<Persona>(pred);//creamos como arraylist con arg el metodo
            bool exite = gente.Exists(predic);//array con los datos. le preguntamos si existe del predicado

            if (exite)
            {
                Console.WriteLine("si hay persona");
            }
        }
        static bool pred(Persona p)
        {//metodo para el delegado
            if (p.Nombre == "juan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        class Persona
        {
            private string nombre;
            private int edad;

            public string Nombre
            {//mayusc de atrib
                get => nombre;//get nos lo da
                set => nombre = value;//set en nombre lo pongo
            }

            public int Edad
            {
                get => edad;
                set => edad = value;
            }
        }
    }
}












