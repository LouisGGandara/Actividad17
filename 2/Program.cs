/*
 * Desarrolle un programa que solicite el precio de un producto, 
 * validando que sea un número decimal mayor que 0, repitiendo hasta que el usuario ingrese correctamente el valor
 */
double price;
bool correct;

do
{
    Console.WriteLine("Ingrese precio: ");
    correct = double.TryParse(Console.ReadLine(), out price);
    if (!correct || price <= 0)
    {
        Console.WriteLine("Precio inválido");
        correct = false;
        Console.ReadKey();
    }
} while (!correct);

Console.WriteLine($"El precio es: Q{price}");