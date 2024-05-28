// See https://aka.ms/new-console-template for more information

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasTerminadas = new List<Tarea>();
Random rnd = new Random();
int cantidadTareas, opcion;

Console.WriteLine("Ingrese La cantidad de Tareas");
while (!int.TryParse(Console.ReadLine(), out cantidadTareas))
{
    Console.WriteLine("Por favor, introduce un número válido.");
    continue;
}

for (int i = 0; i < cantidadTareas; i++)
{
    Tarea tarea = new Tarea();
    tarea.TareaID = i + 1;
    tarea.Duracion = rnd.Next(0, 101);
    Console.WriteLine($"Ingrese Tarea: {tarea.TareaID}");
    tarea.Descripcion = Console.ReadLine();
    tarea.EsTerminada = false;
    tareasPendientes.Add(tarea);
}

for (int i = tareasPendientes.Count - 1; i >= 0; i--)
{
    var t = tareasPendientes[i];
    Console.WriteLine($"¿La tarea '{t.Descripcion}' esta terminada ?");
    Console.WriteLine("Marque");
    Console.WriteLine("1_ Si");

    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opcion invalida..");
    }
    if (opcion == 1)
    {
        tareasTerminadas.Add(t);
        tareasPendientes.RemoveAt(i);
    }
}

Console.WriteLine("Tareas Pendientes:");
MostrarTareas(tareasPendientes);
Console.WriteLine("Tareas Terminadas:");
MostrarTareas(tareasTerminadas);

//------Funciones-----------------------------------------------------------------------------------------------------
void MostrarTareas(List<Tarea> ListaDeTareas)
{
    Console.WriteLine("---------------------------------------------\n");
    foreach (var ta in ListaDeTareas)
    {
        ta.MostrarTarea();
    }
    Console.WriteLine("---------------------------------------------\n");
}