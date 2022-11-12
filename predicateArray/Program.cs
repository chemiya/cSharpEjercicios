// See https://aka.ms/new-console-template for more information

//predicado que busca en un array los pares

namespace predicatesimple
{
    internal class Program
    {
        static void Main(string[] args)
        {//correcto
            List<int> numeros = new List<int>();
            numeros.Add(2);
            numeros.Add(9);
            numeros.Add(7);
            numeros.Add(6);

            Predicate<int> pred = new Predicate<int>(pares);//predicado como arraylist pasando arg el metodo
            List<int> paressolo = numeros.FindAll(pred);//donde los datos le decimos que encuentre del pred
            Console.Write("pares segun predicado: ");
            foreach (int num in paressolo)
            {//para cada numero en el array
                Console.WriteLine(num);
            }
        }

        static bool pares(int num)
        {//metodo
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}




