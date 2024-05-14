namespace ServicioInyeccionDependenciasV2.Aplicacion.Dependencies
{
    public interface ISender
    {
        public void SendMessage(string email, string message);
    }
}