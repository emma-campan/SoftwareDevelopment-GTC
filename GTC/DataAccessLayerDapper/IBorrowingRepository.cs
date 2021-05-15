using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerDapper
{
    public interface IBorrowingRepository
    {
        Task<IEnumerable<Borrowing>> GetBorrowingBySSN(int SSN);

        Borrowing CreateBorrowing(Borrowing borrowing);

        void ReturnBorrowing(int borrowingId);

        void RenewBorrowing(int borrowingId);
    }
}
