using System;
class Program
{
    static void Main()
    {
        try
        {
            int Num;

            Console.WriteLine("---- DETERMINAR SI UN NUMERO ES PAR O IMPAR ----");
            Console.WriteLine("Ingrese un número: ");
            Num = Convert.ToInt32(Console.ReadLine());

            if (Num % 2 == 0) {
                Console.WriteLine("El numero " + Num + " es par");
            }
            else {
                Console.WriteLine("El numero " + Num + " es impar");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}