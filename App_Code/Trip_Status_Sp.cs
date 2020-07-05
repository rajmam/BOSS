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
/// Summary description for Trip_Status_Sp
/// </summary>
public class Trip_Status_Sp:dbconn
{
    public void Add_Status(Trip_Satus_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_Status", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = info.Brt_Id;
        p = cmd.Parameters.Add("@date", SqlDbType.DateTime);
        p.Value = info.Date;
        p = cmd.Parameters.Add("@trip_status", SqlDbType.VarChar);
        p.Value = info.Trip_Status;
       


        cmd.ExecuteNonQuery();

        con.Close();

    }



    public void Update_Status(Trip_Satus_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Update_Status", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = info.Brt_Id;
        p = cmd.Parameters.Add("@date", SqlDbType.DateTime);
        p.Value = info.Date;
        p = cmd.Parameters.Add("@trip_status", SqlDbType.VarChar);
        p.Value = info.Trip_Status;
        p = cmd.Parameters.Add("@trip_status_id", SqlDbType.Int);
        p.Value = info.Trip_Status_Id;


        cmd.ExecuteNonQuery();

        con.Close();
    }



    public void Delete_Status(int id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Delete_Status", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

       
        p = cmd.Parameters.Add("@trip_status_id", SqlDbType.Int);
        p.Value = id;


        cmd.ExecuteNonQuery();

        con.Close();
    }




    public Trip_Satus_Info View_Status(int id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("View_Status", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@trip_status_id", SqlDbType.Int);
        p.Value = id;


        SqlDataReader read = cmd.ExecuteReader();
         Trip_Satus_Info t_info = new  Trip_Satus_Info();


        read.Read();
        if (read.HasRows)
        {
            t_info.Brt_Id = int.Parse(read["brt_id"].ToString());
            t_info.Date = DateTime.Parse(read["date"].ToString());
            t_info.Trip_Status = read["trip_status"].ToString();

        
        }
        read.Close();
        con.Close();
        return t_info;
    }






    public DataTable ViewAll()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAll", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];

    }
}
