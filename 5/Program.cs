/*
 * Desarrolle un programa que solicite un número entero y determine si es par o impar, 
 * validando previamente que el dato ingresado sea correcto
 */
int number;
bool correct;

do
{
    Console.WriteLine("Ingrese un número entero: ");
    correct = int.TryParse(Console.ReadLine(), out number);
    if (!correct)
    {
        Console.WriteLine("Dato inválido");
        Console.ReadKey();
    }
} while (!correct);

if (number % 2 == 0)
{
    Console.WriteLine($"El número {number} es par.");
} else
{
    Console.WriteLine($"El número {number} es impar.");
}