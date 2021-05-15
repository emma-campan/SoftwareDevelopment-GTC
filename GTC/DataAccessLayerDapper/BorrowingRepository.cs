using Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayerDapper
{
    public class BorrowingRepository : IBorrowingRepository
    {
        
        public async Task<IEnumerable<Borrowing>> GetBorrowingBySSN(int SSN)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    dbConnection.Open();
                    var p = new DynamicParameters();
                    p.Add("@SSN", SSN, dbType: DbType.Int64, direction: ParameterDirection.Input);

                   var lines = dbConnection.Query<Borrowing>(
                   sql: "dbo.BringBorrowingBySSN",
                   param: p,
                   commandType: CommandType.StoredProcedure).ToList();

                    //Change for the ST from Emma
                    foreach (var b in lines)
                    {
                        string queryb = @"SELECT * FROM item where ItemId = @ItemId" ;
                        b.book = await dbConnection.QueryFirstOrDefaultAsync<Book>(queryb, new {ItemId = b.ItemId });

                        string querym = @"SELECT * FROM Member where SSN = @SSN";
                        b.member = await dbConnection.QueryFirstOrDefaultAsync<Member>(querym, new { SSN = SSN });

                    }

                    return lines;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Borrowing CreateBorrowing(Borrowing borrowing)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    dbConnection.Open();
                    var p = new DynamicParameters();

                    p.Add("@BorrowDate", borrowing.BorrowDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    p.Add("@Remarks", borrowing.Remarks, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add("@SSN", borrowing.SSN, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add("@ItemId", borrowing.ItemId, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add("@BorrowingId", borrowing.BorrowingId, dbType: DbType.Int32, direction: ParameterDirection.Output);


                    dbConnection.Execute(sql: "dbo.CreateBorrowing",
                    param: p,
                    commandType: CommandType.StoredProcedure);

                    borrowing.BorrowingId = p.Get<Int32>("BorrowingId");


                    return borrowing;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ReturnBorrowing(int borrowingId)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    dbConnection.Open();
                    var p = new DynamicParameters();

                    p.Add("@BorrowingId", borrowingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
                   
                    dbConnection.Execute(sql: "dbo.ReturnBorrowing",
                    param: p,
                    commandType: CommandType.StoredProcedure);

                  
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void RenewBorrowing(int borrowingId)
        {
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    dbConnection.Open();
                    var p = new DynamicParameters();

                    p.Add("@BorrowingId", borrowingId, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    dbConnection.Execute(sql: "dbo.RenewBorrowing",
                    param: p,
                    commandType: CommandType.StoredProcedure);


                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}

