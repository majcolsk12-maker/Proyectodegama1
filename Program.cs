Console.WriteLine("Centro educativo");
Console.WriteLine();

static string GenerarUsuario(string nombre, string apellido)
{
    string usuario = nombre.ToLower().Substring(0, 1) + apellido.ToLower();
    usuario = usuario.Replace(" ", "");
    return usuario;
}

static bool ClaveValida(string clave, string usuario)
{
    if (clave.Length >= 8 && clave != usuario)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void MostrarCuenta(string usuario, bool valida)
{
    Console.WriteLine($"Usuario: {usuario}");
    Console.WriteLine($"Clave: {valida}");
}

Console.Write("Ingrese su nombre:");
string nombre = Console.ReadLine();

Console.Write("Ingrese su apellido:");
string apellido = Console.ReadLine();

Console.Write("Ingrese una clave:");
string clave = Console.ReadLine();

string usuario = GenerarUsuario(nombre, apellido);

bool valida = ClaveValida(clave, usuario);

MostrarCuenta(usuario, valida);