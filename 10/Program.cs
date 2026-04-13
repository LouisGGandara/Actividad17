/*
 * Desarrolle un programa que solicite la cantidad de productos a comprar, 
 * validando que sea un número entero positivo y luego simule el ingreso de esos productos
 */
int number;
bool correct;

do
{
    Console.WriteLine("Ingrese cantidad de productos a comprar: ");
    correct = int.TryParse(Console.ReadLine(), out number);
    if (!correct || number <= 0)
    {
        Console.WriteLine("Dato inválido");
        correct = false;
        Console.ReadKey();
    }
} while (!correct);

List<string> products = new List<string>();

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Ingrese producto {i}");
    products.Add(Console.ReadLine());
}
Console.WriteLine("Procesando...");
Console.WriteLine("Productos a llevar: ");
foreach (string p in products)
{
    Console.WriteLine(p);
}