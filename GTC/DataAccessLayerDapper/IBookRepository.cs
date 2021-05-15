using System;
using System.Collections.Generic;
using Domain;
using System.Threading.Tasks;

namespace DataAccessLayerDapper
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBookByAuthor(string FirstName, string LastName);

        Task<IEnumerable<Book>> GetBookByName(string name);


    }
}