/*
 * Desarrolle un programa que solicite un número y calcule su raíz cuadrada,
 * validando que el valor ingresado sea numérico y no negativo
 */
double number;
bool correct;

do
{
    Console.WriteLine("Ingrese un número: ");
    correct = double.TryParse(Console.ReadLine(), out number);
    if (!correct || number <= 0)
    {
        Console.WriteLine("Dáto inválido.");
        correct = false;
        Console.ReadKey();
    }

} while (!correct);

Console.WriteLine($"La raíz cuadrada es {Math.Sqrt(number)}");

