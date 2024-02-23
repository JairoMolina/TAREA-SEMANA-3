using System;
class Program
{
    static void Main()
    {
        try
        {
            int Edad, Presta;

            Console.WriteLine("---- APROBACION O RECHAZO DE PRESTAMO ----");
            Console.WriteLine("Ingrese el prestamo solicitado: ");
            Presta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            if (Presta < 5000 || Edad > 60) {
                Console.WriteLine("Felicidades, su prestamo fue APROBADO");
            }
            else {
                Console.WriteLine("Lo sentimos, su prestamo fue RECHAZADO");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}