// See https://aka.ms/new-console-template for more information

//uso de colecciones y estructuras
namespace colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {   //correcto
            //estructura
            punto p;
            p.x = 3;
            p.y = 4;
            Console.Write("sacamos sus: "+p.getTodo()+"\n");

            //enumeracion
            Posibi pos = Posibi.mucha;//de la enumeracion cogemos 1
            Console.Write("el valor en la enumeracion: "+pos+"\n");
            Console.Write((int)pos+"\n");


            //diccionario
            Dictionary<String, String> openwith = new Dictionary<String, String>();

            openwith.Add("txt", "notepad");
            openwith.Add("rtf", "wordpad");
            Console.Write("para abrir rtf: "+openwith["rtf"]+"\n");


            //pila
            Stack<String> nombre = new Stack<String>();
            nombre.Push("chema");
            nombre.Push("javier");
            nombre.Push("juan");//metemos o eliminamos
            Console.WriteLine("haciendo pop: "+nombre.Pop()+"\n");
            Console.WriteLine("haciendo peek: "+nombre.Peek()+"\n");
        }
        struct punto
        {
            public int x;
            public int y;

            public string getTodo()
            {
                return "coordenadas: " + x + "  " + y;
            }
        }//struct como una clase

        enum Posibi{mucha=200,poca=100};//pueden llevar valores asociados
    }
}















