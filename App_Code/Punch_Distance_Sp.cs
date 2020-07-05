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
/// Summary description for Punch_Distance_Sp
/// </summary>
public class Punch_Distance_Sp:dbconn
{
    public void Add_PunchDistance(Punch_Distence_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_PunchDistance", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value = info.PunchId;
        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = info.BrtId;
        p = cmd.Parameters.Add("@distance", SqlDbType.Float);
        p.Value = info.Distance;
        


        cmd.ExecuteNonQuery();

        con.Close();
    }




    public void Update_PunchDistance(Punch_Distence_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Update_PunchDistance", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value = info.PunchId;
        
        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = info.BrtId;
        p = cmd.Parameters.Add("@distance", SqlDbType.Float);
        p.Value = info.Distance;



        cmd.ExecuteNonQuery();

        con.Close();
    }








    public void Delete_PunchDistance(int punch_id,int brt_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Delete_PunchDistance", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value = punch_id;
        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = brt_id;
        



        cmd.ExecuteNonQuery();

        con.Close();
    }


    public Punch_Distence_Info View_PunchDistance(int punch_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("View_PunchDistance", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value =punch_id;
       

        SqlDataReader read = cmd.ExecuteReader();
        Punch_Distence_Info p_info = new Punch_Distence_Info();
        if (read.Read())
        {
            p_info.Distance = float.Parse(read["distance"].ToString());

        }
        else
        {

            p_info = null ;//for null reference.

        }


        read.Close();
        con.Close();
        return p_info;
    }

}
