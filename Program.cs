using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        // TODO: Implementar la lógica de menú
        if (opcion == 1)
        {
        }
        if (opcion == 2)
        {
        Console.Write("Ingrese el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());
        int resultado = Resta(num1, num2);
        Console.WriteLine("El resultado de la resta es: " + resultado);   
        }
        
        if (opcion == 3)
        {
        Console.Write("Ingrese el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());
        int resultado = Multi(num1, num2);
        Console.WriteLine("El resultado de la multiplicacion es: " + resultado);    
        }
        
        if (opcion == 4)
        {
        Console.Write("Ingrese el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());
        int resultado = Division(num1, num2);
        Console.WriteLine("El resultado de la division es: " + resultado);   
        }
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
    //RESTA
    static double Resta(double a, double b)
    {
        return a - b;
    }
    
    //MULTIPLICACION
    static double Multi(double a, double b)
    {
        return a * b;
    }
    
    //DIVISION
    static double Division(double a, double b)
    {
        if (b==0)
        {
            Console.WriteLine("No se puede dividir entre 0");
        }
        else
        {
            return a / b;   
        }
    }
}
