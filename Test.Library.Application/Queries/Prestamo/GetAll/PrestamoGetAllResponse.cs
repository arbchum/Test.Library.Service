namespace Test.Library.Application.Queries.Prestamo.GetAll
{
    public class PrestamoGetAllResponse
    {
        public int IdPrestamo { get; set; }
        public int IdCliente { get; set; }
        public string? NomCliente { get; set; }
        public DateTime FechaReg { get; set; }
    }
}
