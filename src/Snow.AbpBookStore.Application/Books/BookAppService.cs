﻿using Snow.AbpBookStore.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Snow.AbpBookStore.Books
{
    public class BookAppService :
        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {
            GetPolicyName = AbpBookStorePermissions.Books.Default;
            GetListPolicyName = AbpBookStorePermissions.Books.Default;
            CreatePolicyName = AbpBookStorePermissions.Books.Create;
            UpdatePolicyName = AbpBookStorePermissions.Books.Edit;
            DeletePolicyName = AbpBookStorePermissions.Books.Delete;
        }
    }
}
