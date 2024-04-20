//Error en tiempo de compilación
//Error en tiempo de ejecución (Exception)
//Manejo Logs!!!!

using CodigoClase11;
try
{
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("1) Ingresar Empleado");
    Console.WriteLine("2) Mostrar Listado de Empleado");
    Console.WriteLine("3) Salir");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("Seleccione una opcion:");
    string opcionstring = Console.ReadLine();
    int opcion, idEmpleado;
    opcion = Convert.ToInt32(opcionstring);
   

    int numero = 10;
    int divisor = 0;
    int valor = numero / divisor;
    Console.WriteLine("Ejecución Exitosa");
    Console.Read();
}
catch (Exception ex)
{
    //Mensaje para el usuario
    Console.WriteLine("Error de Sistema, Contactar al Administrador");
    
    //Registro de Logs para el desarrollador
    Logs.Insert(ex.Message);    
    //throw ;
    Console.Read();
}


try
{
    Console.WriteLine("Error de Sistema, Contactar al Administrador");
}
catch (Exception ex)
{
    Logs.Insert(ex.Message);
}

try
{
    Console.WriteLine("error de sistema, contactar al administrador");
}
catch (Exception)
{
    throw;
}