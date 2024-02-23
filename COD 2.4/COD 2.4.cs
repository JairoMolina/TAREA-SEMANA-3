using System;
class Program
{
    static void Main()
    {
        try
        {
            string Dec;

            Console.WriteLine("---- MENSAJE DE BIENVENIDA EN DIFERENTES IDIOMAS ----");
            Console.WriteLine("Ingrese el idioma que prefieras: ");
            Dec = Console.ReadLine().ToLower(); ;

            switch (Dec)
            {
                case "español":
                    Console.WriteLine("Te damos la bienvenida a este programa.");
                    Console.WriteLine("Gracias por utilizar el programa.");
                    break;
                    
                case "ingles":
                    Console.WriteLine("We welcome you to this program.");
                    Console.WriteLine("Thank you for using the program.");
                    break;

                case "frandes":
                    Console.WriteLine("Nous vous souhaitons la bienvenue dans ce programme.");
                    Console.WriteLine("Merci d'avoir utilisé le programme.");
                    break;

                default:
                    Console.WriteLine("Idioma aun no agregado");
                    Console.WriteLine("Prueba con Español, Ingles o Frances");
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