namespace GestorEx;

public interface IExpedienteRepositorio
{
    public void Alta(IExpedienteRepositorio expediente);
    public void Baja(IExpedienteRepositorio expediente);
    public void Modificacion(IExpedienteRepositorio expediente);


}