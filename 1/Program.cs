/*
 * Desarrolle un programa que solicite la edad de una persona, validando que el valor ingresado 
 * sea un número entero válido, repitiendo hasta que el dato sea correcto y mostrando la edad ingresada
 * */
int age;
bool correct;

do
{
    Console.WriteLine("Ingrese edad: ");
    correct = int.TryParse(Console.ReadLine(), out age);
    if (!correct || (age <0 || age > 120))
    {
        Console.WriteLine("Dato inválido");
        correct = false;
        Console.ReadKey();
    }
} while (!correct);

Console.WriteLine($"Edad es: {age}");