using static System.Console;
namespace Clase18R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ejemplo = "Hola, que tal estás?";
            WriteLine("El texto es: {0}", ejemplo);
            WriteLine("La primera letra es: {0}", ejemplo[0]);
            WriteLine("Las tres primeras letras son: {0}", ejemplo.Substring(0, 3));
            WriteLine("La longitud del texto es: {0}", ejemplo.Length);
            WriteLine("La posición de \"que\" es: {0}", ejemplo.IndexOf("que"));
            WriteLine("La última A está en la posición: {0}", ejemplo.LastIndexOf("a"));
            WriteLine("En mayúsculas: {0}", ejemplo.ToUpper());
            WriteLine("En minúsculas: {0}", ejemplo.ToLower());
            WriteLine("Si insertamos \", tío\": {0}", ejemplo.Insert(4, ", tío"));
            WriteLine("Si borramos las 6 primeras letras: {0}", ejemplo.Remove(0, 6));
            WriteLine("Si cambiamos ESTÁS por ESTAMOS: {0}", ejemplo.Replace("estás", "estamos"));
            ReadKey();

            //string a = "algún texto";
            //Console.WriteLine(a.Length);  //Salida: 11

            //Console.WriteLine(a.IndexOf('t')); //Salida: 6
            //a = a.Insert(0, "Esto es");
            //Console.WriteLine(a); //Salida: “Esto es algún texto”

            //a = a.Replace("Esto es", "Yo tengo");

            //Console.WriteLine(a); //Salida: ”Yo tengo algún texto”

            //if (a.Contains("algún"))
            //Console.WriteLine("encontrado"); //Salida: “encontrado”

            //a = a.Remove(8);
            //Console.WriteLine(a); //Salida: “Yo tengo”

            //a = a.Substring(2);
            //Console.WriteLine(a); //tengo

            

        }
    }
}