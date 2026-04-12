/*
 * Desarrolle un programa que solicite la cantidad de estudiantes en un curso,
 * validando que sea un número entero positivo, evitando valores negativos o letras
 */

int amountOfStudents;
bool correct;

do
{
    Console.WriteLine("Ingrese cantidad de estudiantes: ");
    correct = int.TryParse(Console.ReadLine(), out amountOfStudents);
    if (!correct || amountOfStudents < 0)
    {
        Console.WriteLine("Dato inválido");
        correct = false;
        Console.ReadKey();
    }
} while (!correct);

Console.WriteLine($"Hay {amountOfStudents} estudiantes.");