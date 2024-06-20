

using System.Data.Common;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.ComponentModel.Design;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Control Escolar - Alta y Consuta de Promedio Final";

        //Declaración de Variables
        int opcion;
        int altaopcion;
        string Nombre;
        float Promedio;
        float TotalPromedio;
        int i=0;

        //Creación de lista
        List<Alumno> Alumnos = [];

        do
        {
            //Ménú
        Console.WriteLine("___________________________________________________________________________________\n SISTEMA DE CONTROL ESCOLAR - ALTA DE ESTUDIANTES Y CONSUTLA DE PROMEDIO FINAL \n-----------------------------------------------------------------------------------");
        Console.WriteLine("\n Por favor, digite la opción deseada:\n");
        Console.WriteLine("\n1.- Alta de alumno");
        Console.WriteLine("2.- Mostrar lista de alumnos");
        Console.WriteLine("3.- Salir del sistema \n \n");

        opcion = int.Parse(Console.ReadLine());


        //Limpia pantalla

        Console.Clear();

        // Inicia evaluación de opcion seleccionada
            switch (opcion)
            {
                //Alta de alumnos en lista
                case 1:
                    

                    do
                    {
                    Console.WriteLine(" _________________________________________________\n SISTEMA DE CONTROL ESCOLAR - ALTA DE ESTUDIANTES\n--------------------------------------------------"); 

                        //Ingreso de datos del alumno
                        Console.WriteLine("\n\n Escriba el nombre del alumno iniciando por el apellido");
                        Nombre = Console.ReadLine();

                        Console.WriteLine("\n\nEscriba el promedio final\n");
                        Promedio = float.Parse(Console.ReadLine());
                        




                        //Almacenamiento de datos
                        Alumnos.Add(new Alumno(Nombre, Promedio));


                        //Alta nuevo alumno o salir del sistema
                        Console.WriteLine("\n\n¿Desea dar de alta un alumno nuevo?\n Escriba la telca 1 para si y 2 volver al menú anterior\n");
                        altaopcion = int.Parse(Console.ReadLine());

                        Console.Clear();
                    }

                    while (altaopcion == 1);

                    //Volver al menú anterior
                    if (altaopcion !=1)
                    {
                        
                    }
                    break;


                case 2:
                    Console.WriteLine("___________________________________________________________");
                    Console.WriteLine("SISTEMA DE CONTROL ESCOLAR - CONUSLTA DE ALUMNOS Y PROMEDIO");
                    Console.WriteLine("-----------------------------------------------------------");
                    
                    //Evalua si ya se ha dado alta al menos un alumno y si es el caso imprime los elementos guardados en la lista
                    if (Alumnos.Count > 0) 
                    {
                        foreach (var alumno in Alumnos)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(alumno.Nombre, alumno.Promedio);

                            TotalPromedio = Alumnos.Sum(x => x.Promedio) / Alumnos.Count;

                            Console.WriteLine($"El promedio general del grupo es: {TotalPromedio}");

                        }
                    }
                    //Solicita al usuario agregar al menos un alumno a la lista
                    else
                    {
                        
                        Console.WriteLine(" \n No hay elementos para mostrar, por favor elija la opción 1 y realice el alta de al menos 1 alumno");
                        
                        Console.WriteLine("\n\nPresione Enter para volver al menú anterior");

                        

                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;

                    }

                    break;
                // Sale del sistema
                case 3:

                    Console.WriteLine("______________________________________________________________________________\nSISTEMA DE CONTROL ESCOLAR - ALTA DE ESTUDIANTES Y CONSUTLA DE PROMEDIO FINAL\n------------------------------------------------------------------------------");

                    Console.WriteLine("\n \n Gracias por usar el Sistema de Control Escolar - Alta y Consuta de Promedio Final, hasta la proxima");

                    Console.WriteLine("\n \n \n");
                    break;

                default:

                    Console.WriteLine("La opción elegida no es válida, intente otra vez");
                    break;
            }



        }
        while (opcion != 3);

    }





    //Define los atributos para el objeto Alumno
    public class Alumno
    {
        public string Nombre { get; set; }
        public float Promedio { get; set; }

        public Alumno()
        { }

        public Alumno(string n, float p)
        {
            this.Nombre = n;
            this.Promedio = p;

        }
    }
}



