using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Evaluar el numero mayor y menor del arreglo existente";

        int[] numeros = { 14, 76, 6, 52, 12, 24, 32, 1, 7, 2 };
        int menor = numeros[0];
        int mayor = numeros[0];


        for (var i = 0; i < 10; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }

        }
        Console.WriteLine("_________________________________________________________________");
        Console.WriteLine("EVALUAR EL NÚMERO MAYOR Y EL NÚMERO MENOR DEL ARREGLO EXISTENTE");
        Console.WriteLine("-----------------------------------------------------------------\n");


        Console.WriteLine("Este programa evalúa cual es el numero mayor  y el número menor del arreglo");
        Console.WriteLine(" \nLos valores actuales del arreglo son:\n");
        foreach (int numero in numeros)
        {
            Console.Write(numero +"    ");
        }

            Console.WriteLine("\n\nEl numero mayor del arreglo es:" + mayor + "\n\nEl numero menor del arreglo es:" + menor);

    }
}
