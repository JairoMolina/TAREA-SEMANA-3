using System;

class Program
{
    static void Main()
    {
        try
        {
            Decimal Nota;

            Console.WriteLine("---- EVALUAR CALIFICACION DE UN EXAMEN ----");
            Console.WriteLine("Ingrese la nota obtenida en el examen: ");
            Nota = Convert.ToDecimal(Console.ReadLine());

            if (Nota % 1 == 0) {

            switch (Nota)
            {
                case 100:
                    Console.WriteLine("Felicidades has alcanzado la nota máxima!!!");
                    break;

                case decimal N when (N >= 90 && N <= 99):
                    Console.WriteLine("Felicidades tu nota es Sobresaliente!!!");
                    break;

                case decimal N when (N >= 80 && N <= 89):
                    Console.WriteLine("Felicidades tu nota es Excelente ");
                    break;

                case decimal N when (N >= 70 && N <= 79):
                    Console.WriteLine("Tu nota es Aceptable");
                    break;

                case decimal N when (N >= 61 && N <= 69):
                    Console.WriteLine("Has ganado por muy poco...");
                    Console.WriteLine("Pero lo importante es ganar");
                    break;

                case decimal N when (N >= 0 && N <= 60):
                    Console.WriteLine("Lo sentimos, pero no has aprobado");
                    break;

                default:
                    Console.WriteLine("Ingresa los datos correctamente");
                    break;
            }
            }
            else
            {
                Console.WriteLine("Ingresa una nota sin decimales");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}