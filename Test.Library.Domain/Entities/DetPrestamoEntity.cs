namespace Test.Library.Domain.Entities
{
    public class DetPrestamoEntity
    {
        public int IdPrestamo { get; set; }
        public short IdLibro { get; set; }
        public PrestamoEntity Prestamo { get; set; } = null!;
        public LibroEntity Libro { get; set; } = null!;
    }
}
