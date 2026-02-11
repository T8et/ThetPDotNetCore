// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//Console.WriteLine("");
Console.ReadKey();

// md = markdown

// C# database to connet

// ADO.ent
// Dapper (ORM - Object Relational Mapping)
// EF Core/ Entity Framework - ORM

// C# -> query

// nuget 

// Ctrl + .
// only ADO.net need to close connection
string connectionString = "Data Source=.;Initial Catalog=DotNetTrainingBatch5;User ID=sa;Password=p@ssw0rd";
Console.WriteLine(value: "Connection String:"+connectionString);
SqlConnection connection = new SqlConnection(connectionString);

Console.WriteLine("Connection Opening...");
connection.Open();
Console.WriteLine("Connection Opened");

//Command = Query
string query = @"SELECT * FROM TBL_BLOG";
SqlCommand cmd = new SqlCommand(query,connection);
#region "DataAdapter"
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);
#endregion

#region "DataReader"
SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["BlogId"] + "|" + reader["BlogTitle"] + "|" + reader["BlogAuthor"] + "|" + reader["BlogContent"]);
}
#endregion

//dt = adapter.execute();
//for vs foreach (foreach better)

//DataSet
//DataTable
//DataRow
//DataColumn

Console.WriteLine("Connection Closing");
connection.Close();
Console.WriteLine("Connection Closed");

//C# mhr data table htae pp so yin con close htr lae use loh ya tl
#region "DataAdapter"
//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"] + "|" + dr["BlogTitle"] + "|" + dr["BlogAuthor"] + "|" + dr["BlogContent"]);
//}
#endregion

//SqlDataAdapter >> for group dataset (not many amount number should use)
//SqlDataReader  >> for performance, can use line by line read (not for some group of dataset usage)

Console.Write("Enter Blog Tite");
string Title = Console.ReadLine();

Console.Write("Enter Blog Author");
string Author = Console.ReadLine();

Console.Write("Enter Blog Content");
string Content = Console.ReadLine();


string connectionString1 = "Data Source=.;Initial Catalog=DotNetTrainingBatch5;User Id=sa;Password=p@ssw0rd";
SqlConnection con2 = new SqlConnection(connectionString1);

con2.Open();
//string insquery = $@"INSERT INTO [dbo].[Tbl_Blog]
//           ([BlogTitle]
//           ,[BlogAuthor]
//           ,[BlogContent]
//           ,[DeleteFlag])
//     VALUES
//           ('{Title}' 
//           ,'{Author}'
//           ,'{Content}'
//           ,0)";

string insquery = $@"insert into [dbo].[tbl_blog]
           ([blogtitle]
           ,[blogauthor]
           ,[blogcontent]
           ,[deleteflag])
     values
           (@blogtitle 
           ,@blogauthor
           ,@blogcontent
           ,0)";

//string so yin '_' need (imp)

SqlCommand insCmd = new SqlCommand(insquery, con2);
//For sql injection protection
insCmd.Parameters.AddWithValue("@blogtitle", Title);
insCmd.Parameters.AddWithValue("@blogauthor", Author);
insCmd.Parameters.AddWithValue("@blogcontent", Content);
//SqlDataAdapter adapter = new SqlDataAdapter(insCmd);
//DataTable db = new DataTable();
//adapter.Fill(db);

//foreach (DataRow drow in db.Rows)
//{
//    Console.WriteLine(drow["BlogId"] + "|" + drow["BlogTitle"] + "|" + drow["BlogAuthor"] + "|" + drow["BlogContent"]);
//}

int result = insCmd.ExecuteNonQuery();
//if(result == 1)
//{
//    Console.WriteLine("Success Insert");
//}
//else
//{
//    Console.WriteLine("Success Fail");
//}

Console.WriteLine(result == 1 ? "Success Insert" : "Fail");
con2.Close();

//24min
