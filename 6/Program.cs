/*
 * Desarrolle un programa que solicite una fecha, 
 * validando que el formato ingresado sea correcto, y luego mostrarla en formato corto
 */
DateOnly historicEvent;
bool correct;
do
{
    Console.WriteLine("Ingrese su la fecha del evento historico (DC) (MM/DD/YYYY): ");
    correct = DateOnly.TryParse(Console.ReadLine(), out historicEvent);
    if (!correct)
    {
        Console.WriteLine("Dato inválido.");
        Console.ReadKey();
    }

} while (!correct);

Console.WriteLine($"La fecha es: {historicEvent}");
