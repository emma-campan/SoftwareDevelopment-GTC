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
    public class BookRepository : IBookRepository
    {
        public  async Task<IEnumerable<Book>> GetBookByAuthor(string FirstName, string LastName)
        {
            using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
            {
                dbConnection.Open();


                string query = @"SELECT a.FirstName AS Author_Name , i.ItemId, i.Title, i.PublishDate, i.Rare, i.IsNeeded,i.Available,i.Copies,i.Description,b.ISBN,b.Binding,b.Edition,b.SubjectArea
                            FROM Item i
	                        INNER JOIN Book b
	                        ON i.ItemId=b.ItemId
	                        INNER JOIN dbo.Author a
	                        ON i.ItemId=a.ItemId
	                    WHERE a.FirstName='" + FirstName + "' AND a.LastName='" + LastName + "'";



                return await dbConnection.QueryAsync<Book>(query);
            }
        }

        public  async Task<IEnumerable<Book>>  GetBookByName(string name)
        {
            using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
            {
                dbConnection.Open();


                var p = new DynamicParameters();

                p.Add("@Title", name, direction: ParameterDirection.Input);
              



                var result = dbConnection.QueryAsync<Book>("dbo.BringBooksByName",
                    param: p,
                    commandType: CommandType.StoredProcedure);

                return await result;
            }
        }

        public  async Task<IEnumerable<Book>>  GetBookByIsRare()
        {
            using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
            {
                dbConnection.Open();
                //var parameters = new DynamicParameters();
                //parameters.Add("@IsRare", isRare);

                var result = dbConnection.QueryAsync<Book>("dbo.BringAllRareItems", 
                    //param: parameters,
                    commandType: CommandType.StoredProcedure);


                //string query = @"SELECT * FROM Item i
	               //             LEFT JOIN Book b
	               //             ON i.ItemId=b.ItemId
                //                WHERE i.Rare=1";



                //return await dbConnection.QueryAsync<Book>(query);

                return await result;
            }
        }

    }
}
