using AutoMapper;
using Test.Library.Application.Commands.Libro.Create;
using Test.Library.Application.Commands.Prestamo.Create;
using Test.Library.Application.Queries.Libro.GetAll;
using Test.Library.Application.Queries.Prestamo.GetAll;
using Test.Library.Application.Queries.Usuario;
using Test.Library.Domain.Entities;

namespace Test.Library.Application.Mapping
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            #region Usuario
            CreateMap<UsuarioEntity, UsuarioGetAllResponse>()
                .ForMember(dest => dest.IdUsuario, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => $"{src.Nombres} {src.Apellidos}"))
                .ForMember(dest => dest.FechaRegistro, opt => opt.MapFrom(src => src.FechaReg));
            #endregion

            #region Libro
            CreateMap<LibroCreateCommand, LibroEntity>();
            CreateMap<LibroEntity, LibroGetAllResponse>();
            #endregion

            #region Prestamo
            CreateMap<PrestamoCreateCommand, PrestamoEntity>();
            CreateMap<PrestamoLibrosDto, DetPrestamoEntity>();
            CreateMap<PrestamoEntity, PrestamoGetAllResponse>()
                .ForMember(dest => dest.IdPrestamo, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NomCliente, opt => opt.MapFrom(src => $"{src.Cliente.Apellidos}, {src.Cliente.Nombres}"));
            #endregion

        }
    }
}
