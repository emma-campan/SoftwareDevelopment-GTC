using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Domain;
using Dapper;
using Common;

namespace DataAccessLayerDapper
{
    public class MemberRepository : IMemberRepository
    {

        public async Task<IEnumerable<Member>> GetMemberByName(string FirstName, string LastName)
        {
            using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
            {
                dbConnection.Open();

                string query = @"SELECT FirstName,LastName, SSN,Type,Campus,RegistrationDate,ExpirationDate,IsStaff 
                                FROM dbo.Member
                                WHERE
                                FirstName='" + FirstName + "' AND LastName='" + LastName+ "'";



                return await dbConnection.QueryAsync<Member>(query);
            }
        }


        public async Task<IEnumerable<Member>> GetMembersWithActiveBorrowing()
        {
            using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
            {
                dbConnection.Open();

                string query = @"SELECT COUNT(m.SSN) Num_Students , m.Campus  
                                FROM dbo.Member m 
                                INNER JOIN dbo.Borrowing b
                                ON m.SSN=b.SSN
                                WHERE m.Type='student' AND b.Active=1
                                GROUP BY m.Campus";



                return await dbConnection.QueryAsync<Member>(query);

            }
        }


    }
}