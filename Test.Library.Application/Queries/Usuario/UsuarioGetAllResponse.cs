namespace Test.Library.Application.Queries.Usuario
{
    public class UsuarioGetAllResponse
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }
    }
}
