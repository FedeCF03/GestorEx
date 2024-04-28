using GestorEx.aplicacion;

namespace GestorEx.aplicacion;

public class CasoDeUsoExpedienteAlta
{
    public CasoDeUsoExpedienteAlta()
    {

    }
    public void Ejecutar(int idUsuario, Expediente expediente, IExpedienteRepositorio repositorio)
    {
        if (ServicioAutorizacionProvisorio.PoseeElPermiso(idUsuario, Permiso.ExpedienteAlta))
            repositorio.Alta(expediente);

    }


}
