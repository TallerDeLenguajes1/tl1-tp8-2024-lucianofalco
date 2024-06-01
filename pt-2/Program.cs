
TipoOperacion operacion;
var calc = new Calculadora();
double numero;
bool exit = false;


while (!exit) // Cambia este número al número máximo de opciones en tu menú
{
    Console.WriteLine("Ingrese el numero a operar");
    while (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Por favor, introduce un número válido.");
        continue;
    }

    calc.Op.NuevoValor = numero;
    Console.WriteLine();
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.Write("Elige una opción: ");


    if (Enum.TryParse<TipoOperacion>(Console.ReadLine(), out operacion))
    {
        switch (operacion)
        {
            case TipoOperacion.Suma:
                Console.WriteLine("Has seleccionado la Opción 1");
                Console.WriteLine($"La suma de es: " + calc.Sumar() );
                break;

            case TipoOperacion.Resta:
                Console.WriteLine("Has seleccionado la Opción 2");
                Console.WriteLine("La resta es : " + calc.Restar());
                break;

            case TipoOperacion.Multiplicacion:
                Console.WriteLine("Has seleccionado la Opción 3");
                Console.WriteLine("El producto es: "+ calc.Multiplicar());
                break;

            case TipoOperacion.Division:
                Console.WriteLine("Has seleccionado la Opción 4 " );
                Console.WriteLine("La division es : "+ calc.Dividir());

                break;

            case TipoOperacion.Limpiar:
                calc.Limpiar();
                exit = true;
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Operación no válida.");
    }
}

