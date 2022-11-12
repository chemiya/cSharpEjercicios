// See https://aka.ms/new-console-template for more information

//delegado mandando mensajes
namespace delegadobase
{
    internal class Program
    {//correcto
        static void Main(string[] args)
        {
           objetoDel obj = new objetoDel(MensajeBienvenida.SaludoBienvenida);//construimos el delegado y le pasamos como arg la clase y metodo
           obj("hola que tal");// argumento para el delegado

           objetoDel1 obj1 = new objetoDel1(MensajeDespedida.SaludoDespedida);//construimos el delegado y le pasamos como arg la clase y metodo
           obj1();// argumento para el delegado

           
        }
        delegate void objetoDel(string msj);//creamos delegado con mismo parametr
        delegate void objetoDel1();

        class MensajeBienvenida
        {//clase con su metodo
            public static void SaludoBienvenida(string msg)
            {
                Console.WriteLine("hola {0}", msg);
            }
        }

        class MensajeDespedida
        {
            public static void SaludoDespedida()
            {
                Console.WriteLine("adios");
            }
        }
    }
}








