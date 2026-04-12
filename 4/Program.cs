/*
 * Desarrolle un programa que solicite el año de nacimiento de una persona, 
 * validando que sea un número válido y que esté en un rango lógico (por ejemplo entre 1900 y el año actual)
 */
int year;
bool correct;

do
{
    Console.WriteLine("Ingrese el año de nacimiento: ");
    correct = int.TryParse(Console.ReadLine(), out year);
    if (!correct || (year < 1900 || year > 2026))
    {
        Console.WriteLine("Dato inválido");
        correct = false;
        Console.ReadKey();
    }
} while (!correct);

Console.WriteLine($"El año de nacimiento es : {year}");