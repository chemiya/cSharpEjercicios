// See https://aka.ms/new-console-template for more information


//ejemplo de herencia
namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trabajador trabajador = new Trabajador("chema", 23, 12000);
            Console.WriteLine("nombre del trabajador: "+trabajador.getNombre());
        }

        class Persona
        {
            private string nombre;
            private int edad;

            void cumpleanos()
            {
                edad++;
            }

            public Persona(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            public string getNombre()
            {
                return nombre;
            }


        }

        class Trabajador : Persona
        {//herencia con dos puntos
            public int sueldo;
            //constructor normal y utilizamos base para poner esos atributos
            public Trabajador(string nombre, int edad, int sueldo) : base(nombre, edad)
            {
                this.sueldo = sueldo;
                //el otro atributo lo ponemos normal
            }
        }

    }
}








