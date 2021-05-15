using DataAccessLayerDapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class MemberService : IMemberService
    {
        protected readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public Task<IEnumerable<Member>> GetMembersByName(string FirstName, string LastName)
        {
            return _memberRepository.GetMemberByName(FirstName, LastName);
        }

        public Task<IEnumerable<Member>> GetMembersWithActiveBorrowing()
        {
            return _memberRepository.GetMembersWithActiveBorrowing();
        }
    }
}