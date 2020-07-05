using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dbopn
/// </summary>
public class dbconn
{ 
    public SqlConnection con = new SqlConnection();
    public dbconn()
    {
        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\busop\db\dbboss.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
          
    }

}
