
namespace GestorEx.aplicacion;

public class CasoDeUsoTramiteAlta
{

    public void Ejecutar(int idUsuario, Tramite tramite, ITramiteRepositorio tramiteRepositorio, TramiteValidador tramiteValidador, ServicioAutorizacionProvisorio servicioAutorizacionProvisorio)
    {

        if (servicioAutorizacionProvisorio.PoseeElPermiso(idUsuario, Permiso.TramiteAlta) && tramiteValidador.Validar(tramite, idUsuario))
        {

            tramiteRepositorio.Alta(tramite, idUsuario);

            //Cambio de estado
            /*
            Además, resultaría beneficioso desacoplar el servicio de la especificación que define qué cambio de estado
            debe llevarse a cabo en función de la etiqueta del último trámite. Esta especificación podría ser
            suministrada al servicio mediante la técnica de inyección de dependencias. 

            Preguntar si estaría bien llamar a ServicioActualizacionDeEstado que llame a EspecificacionCambioEstado que devuelva el estado nuevo del expediente, 
            para eso llama a ITramiteRepositorio, que busca el ultimo trámite de dicho expediente 
            ???????
            */
        }


    }


}

