using GestorEx;

public class TramiteValidador
{
    public bool Validar(Tramite tramite, int usuario)
    {
        string mensajeError = "";

        if (tramite == null)
            throw new ValidacionException("El trámite no puede ser nulo.");

        if (tramite.Contenido == "")
            mensajeError += "El contenido del trámite no puede estar vacío.";

        if (usuario <= 0)
            mensajeError += "El usuario no puede ser menor o igual que 0";

        if (mensajeError != "")
            throw new ValidacionException(mensajeError);

        return true;

    }

}