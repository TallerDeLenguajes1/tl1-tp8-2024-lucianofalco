public class Operacion {
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion tipoOp ;

    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
    public TipoOperacion TipoOp { get => tipoOp; set => tipoOp = value; }
}