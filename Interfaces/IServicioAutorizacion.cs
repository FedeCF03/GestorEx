namespace GestorEx.aplicacion;

public interface IServicioAutorizacion
{
    bool PoseeElPermiso(int IdUsuario, Permiso permiso);
}