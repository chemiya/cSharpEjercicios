//clase abstracta
namespace abstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {//correcto
            
            Cuadrado cua = new Cuadrado(3);
            Console.WriteLine("el area es: "+cua.Area());
        }

        public abstract class Pieza
        {//clases con metodos abstractos
            public abstract decimal Area();
            public abstract decimal Perimetro();
        }

        public class Cuadrado : Pieza
        {//implementan la abs
            readonly decimal Lado;
            public Cuadrado(decimal lado)
            {
                Lado = lado;
            }

            public override decimal Area()//sobreescriben abstractos
            {

                return Lado * Lado;

            }
            public override decimal Perimetro()
            {
                return Lado * 4;
            }
        }
    }
}






