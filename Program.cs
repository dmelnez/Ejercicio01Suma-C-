namespace Ejercicio01Suma ; 

class Program
{


    static void Main(string[] args)
    {

        int numero01;
        int numero02;



        Console.WriteLine("Introduzca un Numero");
        numero01 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca un Segundo Numero");
        numero02   = int.Parse(Console.ReadLine());
        int sumar = numero01 + numero02;
        Console.WriteLine("El Resultado es: " + sumar);
        
    
    }


}



