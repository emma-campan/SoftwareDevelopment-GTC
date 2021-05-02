using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Interface;
using Models;

namespace SQLRepository
{
    public class MemberRepository : IMemberRepository
    {
        public List<Member> GetAllMembers()
        {
            throw new System.NotImplementedException();
        }

        public Member GetMemberById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void ModifyMember(Member member)
        {
            throw new System.NotImplementedException();
        }
    }
}
