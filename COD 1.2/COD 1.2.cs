using System;
    class Program
{
    static void Main()
    {
        try
        {
            int Edad;

            Console.WriteLine("---- VALIDAR EDAD PARA INGRESAR A CLUB ----");
            Console.WriteLine("Ingresa tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            if (Edad >= 18) {
                Console.WriteLine("Puedes ingresar al club");
            }
            else {
                Console.WriteLine("Lo sentimos. No puedes ingresar al Club");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}