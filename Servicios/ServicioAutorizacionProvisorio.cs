namespace GestorEx.aplicacion;

public static class ServicioAutorizacionProvisorio
{
    public static bool PoseeElPermiso(int IdUsuario, Permiso permiso)
    {
        if (IdUsuario == 1)
            return true;
        return false;
    }
}
