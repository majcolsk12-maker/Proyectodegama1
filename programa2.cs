Console.WriteLine("Tienda de respuestos");
Console.WriteLine();

static double CalcularTotal(double subtotal, bool esFrecuente)
{
    if (esFrecuente == true)
    {
        subtotal = subtotal - (subtotal * 0.10);
    }

    double itbis = subtotal * 0.18;

    double total = subtotal + itbis;

    return total;
}

static void MostrarFactura(string cliente, double total)
{

    Console.WriteLine("Cliente: " + cliente);
    Console.WriteLine("Total a pagar: " + total);

}

Console.Write("Ingrese el nombre del cliente: ");
string cliente = Console.ReadLine();

Console.Write("Ingrese el subtotal: ");
double subtotal = Convert.ToDouble(Console.ReadLine());


Console.Write("Es cliente frecuente? true o false: ");
bool esFrecuente = Convert.ToBoolean(Console.ReadLine());

double total = CalcularTotal(subtotal, esFrecuente);

MostrarFactura(cliente, total);