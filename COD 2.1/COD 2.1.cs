using System;

class Program
{
    static void Main()
    {
        try
        {
            string Num;

            Console.WriteLine("---- CONVERSION DE NUMERO EN LETRAS A NUMERO ----");
            Console.WriteLine("Ingrese un número del 1 al 5 (En letras): ");
            Num = Console.ReadLine().ToLower();

            switch (Num)
            {
                case "uno":
                    Console.WriteLine("1");
                    break;

                case "dos":
                    Console.WriteLine("2");
                    break;

                case "tres":
                    Console.WriteLine("3");
                    break;

                case "cuatro":
                    Console.WriteLine("4");
                    break;

                case "cinco":
                    Console.WriteLine("5");
                    break;

                default:
                    Console.WriteLine("Dato ingresado no válido");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}