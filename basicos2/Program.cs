//ejemplos basicos
namespace basicos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //correcto
            //array
            string[] array = new string[6];
            array[0] = "volvo";
            array[2] = "mercedes";

            Console.Write("array con longitud: " + array.Length);

            //funciones
            int res;
            res = sumanumeros(3, 4);
            Console.WriteLine("\n el resultado aplicando la funcion es: " + res);



            //bucle
            Random numero = new Random();//numero aleatorio
            int aleatorio = numero.Next(0, 100);// un aleatorio entre....
            Console.WriteLine("introduce numero");
            int minumero = 200;
            while (aleatorio != minumero)
            {
                minumero = int.Parse(Console.ReadLine());
                if (minumero > aleatorio)
                {
                    Console.WriteLine("es mayor");
                    Console.WriteLine(aleatorio - minumero);
                }
            }

            Console.WriteLine("el numero era " + aleatorio);


            //otra funcion
            int x = multiplicar(10000, 40000);
            int a = (int)Math.Pow(2, 3);
            Console.WriteLine("usando la multiplicacion:"+a);


            //varibale como clase
            var mivar = new { Nombre = "chema", edad = 21 };//new con los atributos directos
            Console.WriteLine("edad en la variable: "+mivar.edad);



        }

        static int sumanumeros(int x, int y, int z = 3)
        {
            int res;
            res = x + y + z;
            return res;
        }

        static int multiplicar(int x, int y)
        {
            int res;
            res = x * y;
            if (res > int.MaxValue)
            {
                throw new InvalidOperationException("salen");
            }
            return res;
        }
    }
}
