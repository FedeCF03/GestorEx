namespace GestorEx.aplicacion;

public class TramiteValidador
{
    public bool Validar(Tramite tramite, int usuario)
    {
        string message = "";
        if (tramite == null)
            message += "Debe ingresar un trámite validado";
        else
        {
            if (tramite.Contenido == "")
                message += "El contenido del trámite no puede estar vacío";
            if (usuario <= 0)
                message += "El ID del usuario tiene que ser mayor a 0";
        }
        if (message != "")
            throw new ValidacionException(message);
        return true;
        // es correcto devolver un bool y una excepcion, o solo con la excepcion es suficiente?
    }

}