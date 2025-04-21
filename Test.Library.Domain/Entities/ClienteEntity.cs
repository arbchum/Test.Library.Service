namespace Test.Library.Domain.Entities
{
    public class ClienteEntity
    {
        public short Id { get; set; }

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public DateTime FechaReg { get; set; }
    }
}

