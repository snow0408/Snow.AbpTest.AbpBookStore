using AutoMapper;
using Snow.AbpBookStore.Authors;
using Snow.AbpBookStore.Books;

namespace Snow.AbpBookStore;

public class AbpBookStoreApplicationAutoMapperProfile : Profile
{
    public AbpBookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<Author, AuthorDto>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
