using System;
using System.Collections.Generic;
using Interface;
using Models;
using SQLRepository;

namespace Controllers
{
    public class MemberController : IDisposable
    {
        public Member GetMemberById(int id)
        {
            IMemberRepository instance = new MemberRepository();
            return instance.GetMemberById(id);
        }

        public List<Member> GetAllMembers()
        {
            IMemberRepository instance = new MemberRepository();
            return instance.GetAllMembers();
        }

        public void ModifyCategory(Member member)
        {
            IMemberRepository instance = new IMemberRepository();
            instance.ModifyCategory(member);
        }

        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
