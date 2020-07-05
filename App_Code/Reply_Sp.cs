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
/// Summary description for Reply_Sp
/// </summary>
public class Reply_Sp:dbconn
{
    public void Add_Reply( Reply_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_Reply", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@reply_date", SqlDbType.DateTime);
        p.Value = info.Reply_Date;
        p = cmd.Parameters.Add("@reply_time", SqlDbType.DateTime);
        p.Value = info.Reply_Time;
        p = cmd.Parameters.Add("@reply_text", SqlDbType.VarChar);
        p.Value = info.Reply_Text;
        p = cmd.Parameters.Add("@reply_by", SqlDbType.VarChar);
        p.Value = info.Reply_By;
        p = cmd.Parameters.Add("@comment_id", SqlDbType.Int);
        p.Value = info.Comment_Id;


        cmd.ExecuteNonQuery();

        con.Close();

    }



    




    public void Delete_Reply(int reply_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Delete_Reply", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@reply_id", SqlDbType.Int);
        p.Value = reply_id;


        cmd.ExecuteNonQuery();

        con.Close();

    }



    public DataTable ViewAllReplys()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllReplys", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];

    }





    public Reply_Info ViewReplay(int reply_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("ViewReplay", con);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@reply_id", SqlDbType.Int);
        p.Value = reply_id;

        SqlDataReader read = cmd.ExecuteReader();
        Reply_Info r_info = new Reply_Info();
        read.Read();
        if (read.HasRows)
        {
           
            r_info.Reply_By = read["reply_by"].ToString();
            r_info.Reply_Date = DateTime.Parse(read["reply_date"].ToString());
            r_info.Reply_Time = DateTime.Parse(read["reply_time"].ToString());
            r_info.Reply_Text = read["reply_text"].ToString();
            r_info.Reply_Id = int.Parse(read["reply_id"].ToString());
            r_info.Comment_Id = int.Parse(read["comment_id"].ToString());

        }
        else
        {
           r_info.Reply_By = "!!.@@.$.@@.!!";//to show no such an entry.

        }
        read.Close();
        con.Close();
        return r_info;

    }
}
