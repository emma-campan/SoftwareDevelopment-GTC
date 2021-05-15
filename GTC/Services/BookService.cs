using DataAccessLayerDapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class BookService : IBookService
    {
        protected readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<IEnumerable<Book>> GetBookByAuthor(string FirstName, string LastName)
        {
            return _bookRepository.GetBookByAuthor(FirstName, LastName);
        }

        public Task<IEnumerable<Book>> GetBookByName(string name)
        {
            return _bookRepository.GetBookByName(name);
        }

    }
}
