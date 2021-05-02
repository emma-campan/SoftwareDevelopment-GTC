using System;
using System.Collections.Generic;
using Models;

namespace Interface
{
    public interface IMemberRepository
    {

        Member GetMemberById(int id);
        List<Member> GetAllMembers();
        void ModifyMember(Member member);
    }
}
