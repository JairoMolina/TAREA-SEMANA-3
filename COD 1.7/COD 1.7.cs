using System;
class Program
{
    static void Main()
    {
        try
        {
            int Fig;

            Console.WriteLine("---- CALCULAR AREA DE FIGURA GEOMETRICA ----");
            Console.WriteLine("Ingrese la figura gemétrica que desee trabajar: ");
            Console.WriteLine("Cuadrado ---------------------> 1 ");
            Console.WriteLine("Triangulo --------------------> 2 ");
            Console.WriteLine("Circulo ----------------------> 3 ");
            Fig = Convert.ToInt32(Console.ReadLine());

            if (Fig == 1) {
                double Long, Resul;

                Console.WriteLine("Ingresa la base o altura del cuadrado");
                Long = Convert.ToSingle(Console.ReadLine());
                Resul = Long * Long;

                Console.WriteLine("El area del cuadrado es " + Resul);
            }
            else if (Fig == 2) {
                double Bas, Alt, Resul ;
                Console.WriteLine("Ingresa la base del traingulo: ");
                Bas = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingresa la altura del triangulo: ");
                Alt = Convert.ToSingle(Console.ReadLine());
                Resul = (Bas * Alt) * 0.5;

                Console.WriteLine("El area del triangulo es " + Resul);
            }
            else if (Fig == 3) {
                double Rad, Resul;
                Console.WriteLine("Ingresa el radio del circulo: ");
                Rad = Convert.ToSingle(Console.ReadLine());
                Resul = Math.Pow(Rad, 2) * Math.PI;

                Console.WriteLine("El area del circulo es " + Resul);
            }
            else {
                Console.WriteLine("Numero invalido");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}