namespace Test.Library.Domain.Entities
{
    public class UsuarioEntity
    {
        public short Id { get; set; }

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Usuario { get; set; } = null!;

        public string Clave { get; set; } = null!;

        public DateTime FechaReg { get; set; }
    }
}

