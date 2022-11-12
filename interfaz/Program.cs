// See https://aka.ms/new-console-template for more information

//utilizando una interfaz

namespace interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {//correcto
            Dog perro = new Dog("casca");
            Console.Write("descripcion del perro: "+perro.Describe());
        }

        interface IAnimal
        {
            string Describe();//metodos interfaz
            string Name
            {
                get;
                set;

            }
        }

        class Dog : IAnimal
        {//implementa la interfaz
            private string name;
            public Dog(string name)
            {
                this.Name = name;
            }

            public string Describe()
            {//metodo de la intwefaz
                return " mi nombre es " + this.name;
            }

            public string Name
            {//mayus atrib
                get { return name; }//me das nombre
                set { name = value; }//asigna nombre
            }
        }
    }
}






