using System;
using System.Collections.Generic;
using Domain;
using System.Threading.Tasks;

namespace DataAccessLayerDapper
{
    public interface IMemberRepository
    {
        public Task<IEnumerable<Member>> GetMemberByName(string FirstName, string LastName);

        public Task<IEnumerable<Member>> GetMembersWithActiveBorrowing();
    }
}