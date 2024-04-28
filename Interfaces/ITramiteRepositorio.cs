namespace GestorEx.aplicacion;

public interface ITramiteRepositorio
{
    public void Alta(Tramite tramite, int idUsuario);
    public void Baja(Tramite tramite);

    public void Modificar(Tramite tramite);

    public Tramite Buscar(int id);

    public List<Tramite> Listar();

    public List<Tramite> ListarPorEtiqueta(EtiquetaTramite etiqueta);

}