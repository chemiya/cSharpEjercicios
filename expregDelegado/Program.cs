// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

//expresiones regulares y ejemplo delegado de diferentes tipos
namespace expregDelegado
{
    internal class Program
    {
        static void Main(string[] args)
        {//correcto

            //array de personas
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

            Console.Write("nombre del tercero: " + p3.Nombre);




            //delegado
            operacion del = new operacion((num1, num2) => num1 + num2);//construyo delegado y en argumentos lo que tiene que hace
            Console.WriteLine("suma: " + del(4, 7));//le llamo con argumentos

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> pares = numeros.FindAll(i => i % 2 == 0);//sobre el de datos encuentra la siguiente exoresion
            Console.Write("busca pares: ");
            pares.ForEach(numero =>
            {//para cada uno imprimes esto
                Console.WriteLine("un numero par");
                Console.WriteLine(numero);
            });


            compara comp = (person1, person2) => person1 == person2;//delegado con la operacion
            Console.WriteLine("hace comparacion: " + comp(p1.Edad, p2.Edad));//le paso argumentos


            //expresiones regulares
            String frase = "buenos dias, chemiya11@gmail.com es dia esta soleado ss+34-223-23-23in amenzaJa de lluvia, hoy hay tenis femenino";
            string patron=@"\d{3}-\d{2}-\d{2}";
            //string patron=@"\+34|\+44";
            //Regex regex = new Regex("[a-zA-Z]+@[a-zA-Z]+\\.[a-zA-Z]+");//regex con lo que se debe dcumplir 

            Regex regex=new Regex(patron);
            MatchCollection elmat = regex.Matches(frase);//guardo las veces que encaje en el patron
            if (elmat.Count > 0)
            {//imprimio numero de veces
                Console.WriteLine("se ha encontrado numeros");
            }


        }

        public delegate int operacion(int numero, int numero1);//delegado con atributos
        public delegate bool compara(int num, int num1);


        class Persona
        {//clase con properties
            private string nombre;
            private int edad;

            public string Nombre
            {//mayus atric
                get => nombre;//dame
                set => nombre = value;//asigno
            }

            public int Edad
            {
                get => edad;
                set => edad = value;
            }
        }
    }
}









