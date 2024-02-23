using System;
class Program
{
    static void Main()
    {
        try
        {
            decimal PrecioIn, PrecioFin, Desc, Porcen = 0.10M;

            Console.WriteLine("---- CALCULAR EL PRECIO FINALE DE UN PRODUCTO ----");
            Console.WriteLine("Ingrese el precio del producto: ");
            PrecioIn = Convert.ToDecimal(Console.ReadLine());

            if ( PrecioIn > 100 ) {
                Desc = Porcen * PrecioIn;
                PrecioFin = PrecioIn - Desc;
                Console.WriteLine("Su precio final con descuento aplicado es de: Q" + PrecioFin);
            }
            else {
                Console.WriteLine("No es posible aplicar el descuento a su compra");
                Console.WriteLine("Su precio final es de: Q" + PrecioIn);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}