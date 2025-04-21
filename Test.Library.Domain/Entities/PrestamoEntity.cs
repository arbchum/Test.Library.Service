namespace Test.Library.Domain.Entities
{
    public class PrestamoEntity
    {
        public int Id { get; set; }
        public short IdCliente { get; set; }
        public DateTime FechaReg { get; set; }
        public ClienteEntity Cliente { get; set; } = null!;
        public ICollection<DetPrestamoEntity> Detalle { get; set; } = [];
    }
}
