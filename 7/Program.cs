/*
 * Desarrolle un programa que solicite el salario de un empleado, 
 * validando que sea un número decimal válido mayor o igual a 0
 */
double salary;
bool correct;

do
{
    Console.WriteLine("Ingrese salario del empleado: ");
    correct = double.TryParse(Console.ReadLine(), out salary);
    if (!correct || salary <= 0)
    {
        Console.WriteLine("Salario inválido");
        correct = false;
        Console.ReadKey();
    }
} while (!correct);

Console.WriteLine($"El salario es de: Q{salary}");