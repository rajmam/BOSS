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
/// Summary description for FineSettings_Sp
/// </summary>
public class FineSettings_Sp:dbconn
{
    public void Set_Fine(FineSettings_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Set_Fine", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@latency_time", SqlDbType.Float);
        p.Value = info.Latency_Time;
        p = cmd.Parameters.Add("@fine", SqlDbType.Float);
        p.Value = info.Fine;
       


        cmd.ExecuteNonQuery();

        con.Close();

    }




    public void Update_Fine_Settings(FineSettings_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Update_Fine_Settings", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@latency_id", SqlDbType.Int);
        p.Value = info.Latency_Id;
        
        
        
        p = cmd.Parameters.Add("@latency_time", SqlDbType.Float);
        p.Value = info.Latency_Time;
        p = cmd.Parameters.Add("@fine", SqlDbType.Float);
        p.Value = info.Fine;



        cmd.ExecuteNonQuery();

        con.Close();

    }

     public void Delete_Fine_Settings(int latncy_id)
    {
        con.Open();
         
         SqlCommand cmd = new SqlCommand("Delete_Fine_Settings", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@latency_id", SqlDbType.Int);
        p.Value = latncy_id;

        cmd.ExecuteNonQuery();

        con.Close();

    }

     public FineSettings_Info View_Fine_Settings(int latncy_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("View_Fine_Settings", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@latency_id", SqlDbType.Int);
        p.Value = latncy_id;
         SqlDataReader read=cmd.ExecuteReader();
         FineSettings_Info f_info = new FineSettings_Info();

         if(read.Read())
         {
         
         
             f_info.Latency_Time=float.Parse(read["latency_time"].ToString());
             f_info.Fine=float.Parse(read["fine"].ToString());

         }
         else
         {
           f_info.Latency_Time=1000.1000F;
         }

         read.Close();
         con.Close();
         return f_info;
     }



    public DataTable View_All_Fine_Settings()
    {
        con.Open();

        SqlDataAdapter da = new SqlDataAdapter("View_All_Fine_Settings", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];
    }





}
