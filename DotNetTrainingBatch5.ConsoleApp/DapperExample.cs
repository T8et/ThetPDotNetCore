using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch5.ConsoleApp
{
    public class DapperExample
    {
        protected readonly string _connection = "Data Source=.;Initial Catalog=DotNetTrainingBatch5;User Id=sa;Password=p@ssw0rd";

        public void Read()
        {
            using(IDbConnection db = new SqlConnection(_connection))
            {
                string query = "SELECT * FROM TBL_BLOG WHERE DeleteFlag=0";
                var list = db.Query(query).ToList();
                foreach (var item in list) 
                {
                    Console.Write(item.BlogId + "-");
                    Console.Write(item.BlogTitle + "-");
                    Console.Write(item.BlogAuthor + "-");
                    Console.Write(item.BlogContent + "-");
                    Console.WriteLine("");
                }
            }
        }
    }
}

//DTO - Data Transfer Object
//22min
