//clase generica con restriccion para las clases
namespace clasegenericarestriccion
{
    internal class Program
    {
        static void Main(string[] args)
        {//correcto
            Almacen<Director> alm = new Almacen<Director>(3);//creo como arraylist 
            alm.agregar(new Director(222));
            alm.agregar(new Director(22222));
            Console.Write("tamano es: "+alm.getI());

            
        }

        class Almacen<T> where T : IParaEmpleados
        {//clase generica de almacen y sus elementos tienen que implementar interfaz

            public Almacen(int z)
            {
                datosEmpleado = new T[z];
            }

            public void agregar(T obj)
            {
                datosEmpleado[i] = obj;
                i++;
            }

            public int getI(){
                return i;
            }

            private int i = 0;
            private T[] datosEmpleado;
        }
        class Director : IParaEmpleados
        {//implementan la interfaz y tienen que definir ese metodo
            private double salario;
            public double getSalario()
            {
                return salario;
            }
            public Director(double salario)
            {
                this.salario = salario;
            }
        }
        class Electricista : IParaEmpleados
        {
            private double salario;
            public double getSalario()
            {
                return salario;
            }
            public Electricista(double salario)
            {
                this.salario = salario;
            }

        }

        class Secretario : IParaEmpleados
        {
            private double salario;
            public double getSalario()
            {
                return salario;
            }
            public Secretario(double salario)
            {
                this.salario = salario;
            }
        }

        interface IParaEmpleados
        {//la interfaz con el metodo
            public double getSalario();
        }
    }
}











