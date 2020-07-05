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
/// Summary description for speed_tabe_Sp
/// </summary>
public class speed_tabe_Sp:dbconn
{
    public void AddSpeed(speed_tabe_info info)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("addspeed",con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@trip_category",SqlDbType.VarChar);
        p.Value = info.Trip_Category;
        p = cmd.Parameters.Add("@speed",SqlDbType.Float);
        p.Value = info.Speed;
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public void UpdateSpeed(speed_tabe_info info)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Update_speed", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@trip_category",SqlDbType.VarChar);
        p.Value = info.Trip_Category;
        p = cmd.Parameters.Add("@speed",SqlDbType.Float);
        p.Value = info.Speed;
        cmd.ExecuteNonQuery();
        con.Close();

    }

    public void DeleteSpeed(string trip_category)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Delete_speed", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@trip_category",SqlDbType.VarChar);
        p.Value = trip_category;
        
        cmd.ExecuteNonQuery();
        con.Close();

    }


    public DataTable ViewAllSpeed_Categories()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllSpeed_Categories",con);
        DataSet ds= new DataSet();
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds);
        return ds.Tables[0];

    }


    public speed_tabe_info ViewSpeed_Category(string trip_category)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("ViewSpeed_Category", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@trip_category",SqlDbType.VarChar);
        p.Value = trip_category;
        SqlDataReader read = cmd.ExecuteReader();
        speed_tabe_info info=new speed_tabe_info();
        if (read.Read())
        {
        info.Speed=float.Parse(read["speed"].ToString());
        info.Trip_Category=read["trip_category"].ToString();
           
        }
        else
        {
            info.Speed = 1000.1000F;

        }

        read.Close();
        con.Close();
        return info;
    }
}
