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
/// Summary description for Meet_Sp
/// </summary>
public class Meet_Sp:dbconn
{
    public void Add_meeting(Meet_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_meeting", con);
        cmd.CommandType=CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        //p = cmd.Parameters.Add("@date", SqlDbType.DateTime);
        //p.Value = info.Date;
        p = cmd.Parameters.Add("@subject", SqlDbType.VarChar);
        p.Value = info.Subject; 
        p = cmd.Parameters.Add("@time", SqlDbType.VarChar);
        p.Value = info.Time; 
        p = cmd.Parameters.Add("@details", SqlDbType.VarChar);
        p.Value = info.Details; 
        p = cmd.Parameters.Add("@meeting_date", SqlDbType.DateTime);
        p.Value = info.Meeting_Date; 
        //p = cmd.Parameters.Add("@status", SqlDbType.Int);
        //p.Value = info.Status; 
        p = cmd.Parameters.Add("@location", SqlDbType.VarChar);
        p.Value = info.Location;

        cmd.ExecuteNonQuery();

        con.Close();
        
    }





    public object GetMaxMeetingDate()
    {
        int k;
        

        try
        {
            con.Open();
            string str = "SELECT  MAX(meeting_no)  AS id FROM meeting_table";
            SqlCommand cmd = new SqlCommand(str, con);
            object obj = cmd.ExecuteScalar();
            
            if (obj == DBNull.Value)
            {
                con.Close();
                return DateTime.Parse("0");
            }
            else
            {
                k = int.Parse(obj.ToString());
            }

        }
        catch (Exception e)
        {
            //DateTime dt = DateTime.;
            //return dt.;
            return null;
        }
        SqlCommand cmd2= new SqlCommand("ReturnLastMeetingDate", con);
        cmd2.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd2.Parameters.Add("@meeting_no",SqlDbType.Int);
        p.Value = k;
        object ob=cmd2.ExecuteScalar();
        con.Close();
        if (ob == DBNull.Value)
        {
            
            return DateTime.Parse("0");
        }
        else
        {
           
            return DateTime.Parse(ob.ToString());
        }
    
    
    }





    public void Delete_meeting(int meet_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("DeleteMeeting", con);
        cmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@meeting_no", SqlDbType.Int);
        p.Value = meet_id;

        cmd.ExecuteNonQuery();
        con.Close();
        
    
   
    
    }


    public DataTable ViewAllMeetings()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllMeetings", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];

    }


    public Meet_Info ViewMeet(int meet_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("ViewMeeting", con);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@meeting_no", SqlDbType.Int);
        p.Value = meet_id;

        SqlDataReader read = cmd.ExecuteReader();
        Meet_Info m_info = new Meet_Info();
        read.Read();
        if (read.HasRows)
        {
            m_info.Date = DateTime.Parse(read["date"].ToString());
            m_info.Subject = read["subject"].ToString();
            m_info.Time = read["time"].ToString();
            m_info.Details = read["details"].ToString();
            m_info.Meeting_Date = DateTime.Parse(read["meeting_date"].ToString());
            m_info.Status=int.Parse(read["status"].ToString());
            m_info.Location = read["location"].ToString();

        }
        else
        {
            m_info.Subject = "1000";//to show no such an entry.

        }
        read.Close();
        con.Close();
        return m_info;
    
    }



}
