namespace GestorEx;

public class CasoDeUsoExpedienteConsultaPorId
{
    public Expediente Ejecutar(int id, IExpedienteRepositorio expedienteRepositorio)
    {

        return expedienteRepositorio.BuscarPorId(id);
    }





}
