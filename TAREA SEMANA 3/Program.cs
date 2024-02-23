using System;
class Program
{
    static void Main()
    {
        try
        {
            int NumEnt;

            Console.WriteLine("---- CONVERSION ENTERO A DECIMAL ----");
            Console.WriteLine("Ingrese un número entero: ");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}