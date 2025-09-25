using System;
using System.Collections.Generic;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // nothing here for now
    }

    [WebMethod]
    public static List<User> GetUsers()
    {
        // calls the helper to fetch from DB
        return DatabaseHelper.GetUsers();
    }
}
