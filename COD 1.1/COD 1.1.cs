using System;

class Program
{
    static void Main()
    {
        try
        {
            decimal Num1, Num2, Num3;

            Console.WriteLine("---- CALCULAR EL MAYOR DDE TRES NUMEROS ----");
            Console.WriteLine("Ingresa el primer numero: ");
            Num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            Num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer numero: ");
            Num3 = Convert.ToDecimal(Console.ReadLine());

            if (Num1 > Num2 && Num1 > Num3){
                Console.WriteLine("El numero mayor entre los tres es: " + Num1);
            }
            else if (Num2 > Num1 && Num2 > Num3){
                Console.WriteLine("El numero mayor entre los tres es: " + Num2);
            }
            else{
                Console.WriteLine("El numero mayor entre los tres es: " + Num3);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}