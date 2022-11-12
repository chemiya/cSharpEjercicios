















class Vehiculo{
    public static void arranca(string sonido){
        Console.WriteLine($"arrancado {sonido}");
    }
    public static void parar(string sonido){
        Console.WriteLine($"parando {sonido}");//dolar y entre {} el atributo
    }
}

class Avion:Vehiculo{//herencia con :
    public void aterrizar(){
        Console.WriteLine("aterrizo");
    }
}

class Coche:Vehiculo{
    public void acelero(){
        Console.WriteLine("acelero");
    }
}