namespace GestorEx.aplicacion;

public class ServicioActualizacionEstado
{
    public void ActualizarEstado(int ExpedienteId)
    {

        EtiquetaTramite etiqueta = EspecificacionCambioDeEstado.BuscarCambioDeEstado(ExpedienteId);

    }
}
