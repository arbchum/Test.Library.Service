namespace Test.Library.Domain.Entities
{
    public class LibroEntity
    {
        public short Id { get; set; }
        public int IdGenero { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime FechaReg { get; set; }
    }
}
