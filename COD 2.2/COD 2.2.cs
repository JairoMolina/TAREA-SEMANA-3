using System;
class Program
{
    static void Main()
    {
        try
        {
            int Num;

            Console.WriteLine("---- DIA DE LA SEMANA A PARTIR DE UN NUMERO ----");
            Console.WriteLine("Ingrese un número del 1 al 7: ");
            Num = Convert.ToInt32(Console.ReadLine());

            switch (Num)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;

                case 5:
                    Console.WriteLine("Viernes");
                    break;

                case 6:
                    Console.WriteLine("Sabado");
                    break;

                case 7:
                    Console.WriteLine("Domingo");
                    break;

                default: 
                    Console.WriteLine("Numero no valido");
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