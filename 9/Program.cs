/*
 * Desarrolle un programa que solicite la nota de un estudiante,
 * validando que sea un número entre 0 y 100 antes de mostrar si aprueba o reprueba
 */
double grade;
bool correct;

do
{
    Console.WriteLine("Ingrese la nota del estudiante: ");
    correct = double.TryParse(Console.ReadLine(), out grade);
    if (!correct || (grade < 0 || grade > 100))
    {
        Console.WriteLine("Nota inválida");
        correct = false;
        Console.ReadKey();
    }
} while (!correct);

Console.WriteLine($"La nota es: {grade}");