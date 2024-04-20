// See https://aka.ms/new-console-template for more information

//DivideByZeroException
//ArgumentException

try
{

    int dividendo = 10;
    int divisor = 1;
    int resultado = dividendo / divisor; // Esta línea generará una excepción

    int[] valores; //valores sin inicializar
    valores = new int[3];
    valores[1] = 5;

    FileStream file = null;       
    file = File.Open("archivo.txt", FileMode.Open);
   

}
catch (DivideByZeroException)
{
    Console.WriteLine("Error de Sistema, No se puede divir entre cero");
    //Logs.Insert(ex.Message);
   
}
catch (IOException )
{
    Console.WriteLine("Error de Sistema, No se puede abrir el archivo");
    //Logs.Insert(ex.Message);
    
}
catch (Exception)
{
    Console.WriteLine("Error de Sistema, Contactar al Administrador");
    //Logs.Insert(ex.Message);
    
}
finally
{
    Console.Read();
}