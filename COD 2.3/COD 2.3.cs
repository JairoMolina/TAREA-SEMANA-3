using System;
class Program
{
    static void Main()
    {
        try
        {
            int Dec;

            Console.WriteLine("---- CALCULAR IMPORTE A PAGAR POR UN SERVICIO ----");
            Console.WriteLine("Ingrese un número entero: ");
            Console.WriteLine("Lavado de Auto -----------> 1 ");
            Console.WriteLine("Cambio de Aceite ---------> 2 ");
            Console.WriteLine("Revision Mecanica --------> 3 ");
            Dec = Convert.ToInt32(Console.ReadLine());

            switch(Dec)
            {
                case 1:
                    Console.WriteLine("El cobro del servicio que desea es de Q25");
                    break;

                case 2:
                    Console.WriteLine("El cobro del servicio que desea es de Q50");
                    break;

                case 3:
                    Console.WriteLine("El cobro del servicio que desea es de Q150");
                    break;

                default:
                    Console.WriteLine("El numero ingresado es incorrecto");
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