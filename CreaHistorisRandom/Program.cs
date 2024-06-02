
Console.Title = "Generador de historias";

//Declaración de Variables

Random random = new Random();
string continuar;

//Creación de listas
List<string> personajes = ["Juana la Cubana ", "Jack Skeleton ", "La rana suertuda ", "Pipi Calzas Largas ", "Mi vecino de arriba "];
List<string> evento = ["posa alegremente con sus gafas favoritas ", "baila salsa con la luna ", "escucha el triste llorar de las marmotas ", "escucha tap "];
List<string> lugar = ["en el infino y más allá", "en las tumbas del cementerio", "en el circuito interior de la CDMX a la hora pico", " en las rocas mas grandes de la playa", "mientras camina hacia el dorado"];

Console.WriteLine("________________________________________________________________");
Console.WriteLine("                 C U E N T A   H I S T O R I A S");
Console.WriteLine("----------------------------------------------------------------\n");
Console.WriteLine("\n Bienvenido a cuenta historias, estoy segura que te encantarán");
Console.WriteLine("\n °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°\n");

do
{
    foreach (string p in personajes)
    {
        string PersRandom = personajes[random.Next(personajes.Count)];
        string EventoRandom = evento[random.Next(evento.Count)];
        string LugarRandom = lugar[random.Next(lugar.Count)];

        Console.WriteLine($"\n {PersRandom + EventoRandom + LugarRandom}\n");


    }
    Console.WriteLine("\n °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°\n");
    Console.WriteLine("\n ¿Desea crear más historias? Presione S para si, para no presione cuaquier tecla \n");
    continuar = Console.ReadLine();

}

while (continuar == "S " || continuar == "s");

return;



