using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
///libraries need to talk database
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
///This class will connect to the database
/// It will have mehtods to retrieve the services 
/// It will also retrieve all the grands for that service
/// Mario Gomez 4/12/2016
/// 
/// 
/// </summary>
public class DataClass
{
    SqlConnection connect;
    public DataClass()
    {
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ToString());
    }//end constructor

    public DataTable GetServices()
    {
        DataTable tbl = null;

        string sql = "SELECT authorkey, authorname FROM Author";
        SqlCommand cmd = new SqlCommand(sql, connect);

        tbl = ReadData(cmd);


        return tbl;


    }

    public DataTable GetGrants(int AuthorKey)
    {
        DataTable tbl = null;

        string sql = "SELECT * FROM book INNER JOIN authorbook ON book.bookkey= authorbook.bookkey WHERE authorkey = @authorkey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@AuthorKey", AuthorKey);

        SqlDataReader reader = null;
        tbl = new DataTable();

        connect.Open();
        reader = cmd.ExecuteReader();
        tbl.Load(reader);
        reader.Close();
        connect.Close();


        tbl = ReadData(cmd);
        return tbl;

    }

    private DataTable ReadData(SqlCommand cmd)
    {
        SqlDataReader reader = null;
       DataTable tbl = new DataTable();

        connect.Open();
        reader = cmd.ExecuteReader();
        tbl.Load(reader);
        reader.Close();
        connect.Close();

        return tbl;
    }

}//end of class 