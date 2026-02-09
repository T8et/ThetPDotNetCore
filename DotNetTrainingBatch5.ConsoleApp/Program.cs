// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
Console.WriteLine("");
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
Console.WriteLine("Connection Closing");
connection.Close();
Console.WriteLine("Connection Closed");