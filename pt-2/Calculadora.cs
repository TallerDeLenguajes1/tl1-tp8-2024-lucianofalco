using System.Security.Cryptography;

public class Calculadora{
    private List<Operacion> operaciones = new List<Operacion>();
    private Operacion op = new Operacion();
    public List<Operacion> Operaciones { get => operaciones; set => operaciones = value; }

    public Operacion Op { get => op; set => op = value; }

    public double Sumar(){
        op.ResultadoAnterior += op.NuevoValor ; 
        operaciones.Add(op);
        return op.ResultadoAnterior;
    }
    public double Restar(){
        op.ResultadoAnterior -= op.NuevoValor ; 
        operaciones.Add(op);
        return op.ResultadoAnterior;
    }
    public double Multiplicar(){
        op.ResultadoAnterior *= op.NuevoValor ; 
        operaciones.Add(op);
        return op.ResultadoAnterior;

    }
    public double Dividir(){
        if (op.NuevoValor == 0)
        {
            Console.WriteLine("No se puede dividir en 0");
        }
        else{
            op.ResultadoAnterior /= op.NuevoValor;
            operaciones.Add(op);
        }
        return op.ResultadoAnterior;
    }

    public void Limpiar(){
        op.ResultadoAnterior = 0 ;
        for (int i = 0; i < operaciones.Count; i++)
        {
            operaciones.Remove(operaciones[i]);
        }
    }
}