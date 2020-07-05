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
/// Summary description for WorkType_Sp
/// </summary>
public class WorkType_Sp:dbconn
{

    public string ReturnWorkName(int wrk_id)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("ReturnWorkName", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@work_category", SqlDbType.Int);
        p.Value = wrk_id;

        SqlDataReader read = cmd.ExecuteReader();
        string wname="";
        read.Read();
        if (read.HasRows)
        {
             wname = read["@work_name"].ToString();
        }

        read.Close();
        con.Close();
        return wname;
    }
	
}
