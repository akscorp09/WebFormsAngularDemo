using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

public static class DatabaseHelper
{
    private static string GetConnString()
    {
        return ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
    }

    public static List<User> GetUsers()
    {
        List<User> list = new List<User>();
        using (SqlConnection conn = new SqlConnection(GetConnString()))
        {
            conn.Open();
            string sql = "SELECT Id, Name, Email FROM Users";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        User u = new User
                        {
                            Id = rdr.GetInt32(rdr.GetOrdinal("Id")),
                            Name = rdr["Name"].ToString(),
                            Email = rdr["Email"].ToString()
                        };
                        list.Add(u);
                    }
                }
            }
        }
        return list;
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
