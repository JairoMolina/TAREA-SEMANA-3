using System;
class Program
{
    static void Main()
    {
        try
        {
            string Usuario, Contra;
            Console.WriteLine("---- VALIDAR USUARIO Y CONTRASEÑA ----");
            Console.WriteLine("BIENVENIDO ");
            Console.WriteLine("Ingresa el Usuario ");
            Usuario = Console.ReadLine();

            if (Usuario == "usuario") {
                Console.WriteLine("Usuario Correcto");
                Console.WriteLine("Ingresa la contraseña: ");
                Contra = Console.ReadLine();

                if (Contra == "contraseña") {
                    Console.WriteLine("Bienvenido");
                }
                else {
                    Console.WriteLine("Contraseña Incorrecta");
                }
            }
            else {
                Console.WriteLine("Usuario Incorrecto");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hubo un Error. Ingresa los Datos Correctamente.");
            Console.WriteLine("Error :" + ex.Message);
        }
    }
}