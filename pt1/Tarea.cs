public class Tarea {
    private int tareaID;
    private String descripcion ;
    private int duracion ;
    private bool esTerminada;

    public Tarea()
    {
    }

    public Tarea(int tareaID, string descripcion, int duracion, bool esTerminada)
    {
        this.TareaID = tareaID;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
        this.EsTerminada = esTerminada;
    }

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public bool EsTerminada { get => esTerminada; set => esTerminada = value; }

    public void MostrarTarea(){
        Console.WriteLine($"ID: {TareaID}");
        Console.WriteLine($"Duracion: {Duracion} ");
        Console.WriteLine($"Descripcion:  {Descripcion}");
        Console.WriteLine();
    }
}