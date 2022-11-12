//array con clase generica
namespace clasegenerica
{
    internal class Program
    {
        static void Main(string[] args)
        {//correcto
            
            //lo creamos como arraylist
            almacenobj<Empleado> alm = new almacenobj<Empleado>(4);

            alm.agregar(new Empleado(300));
            Empleado emp = alm.getElemento(0);
            Console.Write("salario: "+emp.getSal());
        }

        //almacen con cualquier tipo de elemtnosss
        //donde object ponet T
        class almacenobj<T>
        {
            public almacenobj(int z)
            {
                datosElemento = new T[z];
            }

            private T[] datosElemento;//array para almacenar
            private int i = 0;

            public void agregar(T obj)
            {
                datosElemento[i] = obj;
                i++;
            }

            public T getElemento(int i)
            {
                return datosElemento[i];
            }
        }

        class Empleado
        {
            private int salario;
            public int getSal()
            {
                return salario;
            }

            public Empleado(int salario)
            {
                this.salario = salario;
            }
        }
    }
}






/*
class Program{
    static void Main(String[] args){
        //lo creamos como arraylist
        almacenobj<Empleado> alm=new almacenobj<Empleado>(4);
        
        alm.agregar(new Empleado(300));
        Empleado emp=alm.getElemento(2);
        
    }

}

//almacen con cualquier tipo de elemtnosss
//donde object ponet T
class almacenobj<T>{
    public almacenobj(int z){
        datosElemento=new T[z];
    }

    private T[] datosElemento;
    private int i=0;

    public void agregar(T obj){
        datosElemento[i]=obj;
        i++;
    }

    public T getElemento(int i){
        return datosElemento[i];
    }
}

class Empleado{
    private int salario;
    public int getSal(){
        return salario;
    }

    public Empleado(int salario){
        this.salario=salario;
    }
}
*/