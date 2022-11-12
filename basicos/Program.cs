//ejemplos basicos
namespace basicos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //correcto
            //dotnet new console y dotnet run en visual studio code
            // en visual studio aplicacion de console(.net framework)

            int option;
            double num1;
            double num2;
            string mes = "";
            double result;
            //leo de consola y lo convierto
            Console.WriteLine("escoge opcion");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("segundo numero");
            num2 = double.Parse(Console.ReadLine());


            //switch
            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    mes = "el resultado es " + result.ToString();
                    break;
                case 2:

                    result = num1 * num2;
                    mes = "el resultado es " + result.ToString();
                    break;
            }

            Console.WriteLine("en el switch: " + mes);



            //try
            try
            {
                result = num1 / num2;
                mes = "el resultado es " + result.ToString();
            }
            catch (FormatException e)
            {

            }

            Console.WriteLine("en el try: " + mes);


            //array
            var valores = new int[] { 3, 4, 5, 6 };
            Console.WriteLine(valores[0]);
            foreach (int x in valores)
            {
                Console.WriteLine(x);
            }



        }
    }
}

