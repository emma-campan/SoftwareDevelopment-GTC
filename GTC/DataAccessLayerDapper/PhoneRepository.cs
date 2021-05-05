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
    public class PhoneRepository :  IPhoneRepository
    {
     
        
        public async Task<IEnumerable<Phone>> GetAllPhonesAsync()
        {
           try
            {
                using (IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    dbConnection.Open();

                    string query = @"SELECT * FROM Phone";


                    return await dbConnection.QueryAsync<Phone>(query);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void CreatePhone(Phone phone)
        {
            try
            {
                using(IDbConnection dbConnection = new SqlConnection(Global.ConnectionString))
                {
                    dbConnection.Open();


                    var p = new DynamicParameters();
                    
                    p.Add("@PhoneNo", phone.PhoneNo, dbType: DbType.Int64, direction: ParameterDirection.Input);
                    p.Add("@SSN", phone.SSN, dbType: DbType.Int64, direction: ParameterDirection.Input);
                   


                   dbConnection.Execute(sql: "dbo.CreatePhone",
                   param: p,
                   commandType: CommandType.StoredProcedure);

                }

            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
