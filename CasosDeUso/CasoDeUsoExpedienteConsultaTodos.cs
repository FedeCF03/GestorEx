namespace GestorEx;

public class CasoDeUsoExpedienteConsultaTodos
{
    public List<Expediente> Ejecutar(IExpedienteRepositorio expedienteRepositorio)
    {
        return expedienteRepositorio.Listar();
    }




}
