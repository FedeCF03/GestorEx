﻿namespace GestorEx.aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio tramiteRepositorio, TramiteValidador validador, ServicioAutorizacionProvisorio servicio)
{
    private readonly ITramiteRepositorio _tramiteRepositorio = tramiteRepositorio;
    private readonly TramiteValidador _validador = validador;
    private readonly ServicioAutorizacionProvisorio _servicio = servicio;

    public bool Ejecutar(int usuario, Tramite tramite)
    {
        try
        {
            if (_servicio.PoseeElPermiso(usuario, Permiso.TramiteModificacion) && _validador.Validar(tramite, usuario))
                _tramiteRepositorio.Modificar(tramite);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
        //Implementar try y catch acá o en consola principal
        // hacemos throw excepcion dentro del validador o lo hacemos acá?
    }
}
