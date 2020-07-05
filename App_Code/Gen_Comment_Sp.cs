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
/// Summary description for Gen_Comment_Sp
/// </summary>
public class Gen_Comment_Sp:dbconn
{
    public void Add_Comment(Gen_Comment_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_Comment", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        
        p = cmd.Parameters.Add("@comment_date", SqlDbType.DateTime);
        p.Value = info.Comment_Date;
        p = cmd.Parameters.Add("@comment_time", SqlDbType.DateTime);
        p.Value = info.Comment_Time;
        p = cmd.Parameters.Add("@comment_text", SqlDbType.VarChar);
        p.Value = info.Comment_Text;
        
        p = cmd.Parameters.Add("@rate", SqlDbType.Int);
        p.Value = info.Rate;
        p = cmd.Parameters.Add("@comment_type", SqlDbType.Int);
        p.Value = info.Comment_Type;
        p = cmd.Parameters.Add("@comentator", SqlDbType.VarChar);
        p.Value = info.Comentator;

        cmd.ExecuteNonQuery();

        con.Close();

    }



    public void Rate_Comment(int comnt_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Rate_Comment", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();



        p = cmd.Parameters.Add("@comment_id", SqlDbType.Int);
        p.Value = comnt_id;


        cmd.ExecuteNonQuery();

        con.Close();
    }





    public void Delete_Comment(int comnt_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Delete_Comment", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@comment_id", SqlDbType.Int);
        p.Value = comnt_id;
        

        cmd.ExecuteNonQuery();

        con.Close();

    }



    public DataTable ViewAllComments()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllComments", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];

    }





    public Gen_Comment_Info ViewComment(int comnt_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("ViewComment", con);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@comment_id", SqlDbType.Int);
        p.Value = comnt_id;

        SqlDataReader read = cmd.ExecuteReader();
        Gen_Comment_Info g_info = new Gen_Comment_Info();
        read.Read();
        if (read.HasRows)
        {
            g_info.Comment_Type = int.Parse(read["comment_type"].ToString());
          g_info.Comentator = read["comentator"].ToString();
          g_info.Comment_Date = DateTime.Parse(read["comment_date"].ToString());
          g_info.Comment_Time = DateTime.Parse(read["comment_time"].ToString());
          g_info.Rate = int.Parse(read["rate"].ToString());
          g_info.Comment_Text = read["comment_text"].ToString();
          g_info.Comment_Id = int.Parse(read["comment_id"].ToString());


        }
        else
        {
            g_info.Comentator = "!!.@@.$.@@.!!";//to show no such an entry.

        }
        read.Close();
        con.Close();
        return g_info;

    }
}
