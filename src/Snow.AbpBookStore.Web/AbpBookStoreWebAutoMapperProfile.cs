using AutoMapper;
using Snow.AbpBookStore.Authors;
using Snow.AbpBookStore.Books;

namespace Snow.AbpBookStore.Web;

public class AbpBookStoreWebAutoMapperProfile : Profile
{
    public AbpBookStoreWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,
                      CreateAuthorDto>();
        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel,
                  UpdateAuthorDto>();
    }
}
