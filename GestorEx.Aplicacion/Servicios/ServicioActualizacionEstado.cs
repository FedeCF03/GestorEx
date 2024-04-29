namespace GestorEx.aplicacion;

public class ServicioActualizacionEstado(EspecificacionCambioDeEstado especificacionCambioDeEstado)
{
    public void ActualizarEstado(int ExpedienteId)
    {

        EtiquetaTramite etiqueta = EspecificacionCambioDeEstado.BuscarCambioDeEstado(ExpedienteId);

    }
}
