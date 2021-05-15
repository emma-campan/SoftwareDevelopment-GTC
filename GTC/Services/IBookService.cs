using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetBookByAuthor(string FirstName, string LastName);
        Task<IEnumerable<Book>> GetBookByName(string name);
    }
}
