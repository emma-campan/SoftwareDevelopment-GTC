using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IMemberService
    {
        Task<IEnumerable<Member>> GetMembersByName(string FirstName, string LastName);
        Task<IEnumerable<Member>> GetMembersWithActiveBorrowing();
    }
}
