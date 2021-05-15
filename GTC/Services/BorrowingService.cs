using DataAccessLayerDapper;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class BorrowingService : IBorrowingService
    {
        protected readonly IBorrowingRepository _borrowingRepository;

        public BorrowingService(IBorrowingRepository borrowingRepository)
        {
            _borrowingRepository = borrowingRepository;
        }
        public Task<IEnumerable<Borrowing>> GetBorrowingBySSN(int SSN)
        {
            return _borrowingRepository.GetBorrowingBySSN(SSN);
        }

       public  Borrowing CreateBorrowing(Borrowing borrowing)
        {
            return _borrowingRepository.CreateBorrowing(borrowing);
        }

       public  void ReturnBorrowing(int borrowingId)
        {
            _borrowingRepository.ReturnBorrowing(borrowingId);
        }

        public void RenewBorrowing(int borrowingId)
        {
            _borrowingRepository.RenewBorrowing(borrowingId);
        }
    }
}
