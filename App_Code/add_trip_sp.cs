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
/// Summary description for add_trip_sp
/// </summary>
public class add_trip_sp:dbconn 
{
    public void Add(add_trip_info inf)//FOR REGISTRATION
    {
      
        con.Open();
        SqlCommand cmd = new SqlCommand("Addbrtinfo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        
        p = cmd.Parameters.Add("@day", SqlDbType.VarChar, 50);
        p.Value = inf.Day;
        p = cmd.Parameters.Add("@bus_reg_no", SqlDbType.VarChar, 50);
        p.Value = inf.Regn_no;
        p = cmd.Parameters.Add("@tripno", SqlDbType.Int);
        p.Value = inf.Trip_no;
        p = cmd.Parameters.Add("@from", SqlDbType.VarChar, 50);
        p.Value = inf.From;
        p = cmd.Parameters.Add("@to", SqlDbType.VarChar, 50);
        p.Value = inf.To;

        p = cmd.Parameters.Add("@towards", SqlDbType.VarChar, 50);
        p.Value = inf.Towards;
        p = cmd.Parameters.Add("@trip_start_time", SqlDbType.VarChar, 50);
        p.Value = inf.Time;
        p = cmd.Parameters.Add("@trip_category", SqlDbType.VarChar, 50);
        p.Value = inf.Category;

        cmd.ExecuteNonQuery();

        con.Close();
    }

    public void Update(add_trip_info inf)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("UpdateTrip", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = inf.Brt_id;
        
        
        p = cmd.Parameters.Add("@day", SqlDbType.VarChar, 50);
        p.Value = inf.Day;
        p = cmd.Parameters.Add("@bus_reg_no", SqlDbType.VarChar, 50);
        p.Value = inf.Regn_no;
        p = cmd.Parameters.Add("@tripno", SqlDbType.Int);
        p.Value = inf.Trip_no;
        p = cmd.Parameters.Add("@from", SqlDbType.VarChar, 50);
        p.Value = inf.From;
        p = cmd.Parameters.Add("@to", SqlDbType.VarChar, 50);
        p.Value = inf.To;
        p = cmd.Parameters.Add("@trip_start_time", SqlDbType.VarChar, 50);
        p.Value = inf.Time;
        p = cmd.Parameters.Add("@towards", SqlDbType.VarChar, 50);
        p.Value = inf.Towards;
        p = cmd.Parameters.Add("@trip_category", SqlDbType.VarChar, 50);
        p.Value = inf.Category;
        
        cmd.ExecuteNonQuery();

        con.Close();

    
    }

    public add_trip_info ViewTrip(int brt_id)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Viewbusdata", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = brt_id ;
        SqlDataReader read = cmd.ExecuteReader();
        add_trip_info info = new add_trip_info();
        
        if (read.Read())
        {
            info.Day = read["day"].ToString();
            info.Regn_no  = read["bus_reg_no"].ToString();
            info.Trip_no  = int.Parse(read["trip_no"].ToString());
            info.From  = read["from"].ToString();
            info.To  = read["to"].ToString();
            info.Time = read["trip_start_time"].ToString();
            info.Category = read["trip_category"].ToString();
            info.Towards = read["towards"].ToString();
        }
        read.Close();
        con.Close();
        return info;
        
    
    }


   
    public DataTable ViewAllData()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllData", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];

    }
    //public add_trip_info ViewMember(int no)
    //{
       // con.Close();
      //  con.Open();
       // SqlCommand cmd = new SqlCommand("Viewbusdata", con);
       // cmd.CommandType = CommandType.StoredProcedure;
       // SqlParameter p = new SqlParameter();
       // p = cmd.Parameters.Add("@no", SqlDbType.VarChar, 50);
       // p.Value = no;
       // SqlDataReader read = cmd.ExecuteReader();
       // add_trip_info info = new add_trip_info();
       // if (read.Read())
       // {
       //     info.Day = read["day"].ToString();
       //     info.Time = read["time"].ToString();
       //     info.From = read["from"].ToString();
       //     info.To = read["to"].ToString();
      //      info.Regn_no = read["reg_no"].ToString();
      //      info.Trip_no = int.Parse (read["e_mail"].ToString());
            
      //  }
        //read.Close();
      //  con.Close();
      //  return info;
    //}



    public void DeleteTrip(int brt_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("delete_trip", con);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = brt_id;

        cmd.ExecuteNonQuery();
        con.Close();

    }




    public DataTable ViewAllBusOfGivenRoot(string to,string day)
    {
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter ("ViewAllBusOfGivenTimeandRoot", con);
        da.SelectCommand.CommandType =CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter ();
        p = da.SelectCommand.Parameters.Add("@towards", SqlDbType.VarChar,50);
        p.Value = to;
        p = da.SelectCommand.Parameters.Add("@day", SqlDbType.VarChar,50);
        p.Value = day;
              
        
        da.Fill(ds);
        tb= ds.Tables[0];
        return tb;

    }
}
