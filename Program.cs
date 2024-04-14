// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Data.SqlClient;
using YNLLDotNetCore.ConsoleApp;
using SqlConnectionStringBuilder = YNLLDotNetCore.ConsoleApp.SqlConnectionStringBuilder;

Console.WriteLine("Hello, World!");
//nap
//pub.dev
//nudet
// SqlConnection

// Ctrl+ => suggesstion
// f10 => line by line
// f11 => all detail
// f9 => BreakPoint


SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "DESKTOP-6QTP69L\\MSSQL2O22";
stringBuilder.InitialCatalog = " DotNetTraningBatch4";
stringBuilder.UserID = "sa";
stringBuilder.Password = "sa@123";

SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
connection.Open();
Console.WriteLine("Connection Open.");

string query = "select * from Tbl_Blog";
SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);


connection.Close();
Console.WriteLine("Connection Close.");

foreach(DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id =>" + dr["BlogId"]);
     Console.WriteLine("Blog Title =>" + dr["BlogTitle"]);
    Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
    Console.WriteLine("=====================================");
}


Console.ReadKey();