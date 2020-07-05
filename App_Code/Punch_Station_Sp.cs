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
using System.Collections;

/// <summary>
/// Summary description for Punch_Station_Sp
/// </summary>
public class Punch_Station_Sp:dbconn
{
    public void Add_PunchStation(Punch_Station_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_PunchStation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value = info.Punch_Id;
        p = cmd.Parameters.Add("@punch_name", SqlDbType.VarChar, 50);
        p.Value = info.Punch_Name;
        p = cmd.Parameters.Add("@towards", SqlDbType.VarChar, 50);
        p.Value = info.Towards;
        p = cmd.Parameters.Add("@stage", SqlDbType.Int);
        p.Value = info.Stage;
        p = cmd.Parameters.Add("@punch_category", SqlDbType.VarChar, 50);
        p.Value = info.Punch_Category;
        p = cmd.Parameters.Add("@distance", SqlDbType.Float );
        p.Value = info.Distance;
        cmd.ExecuteNonQuery();

        con.Close();
    }





    public void Update_PunchStation(Punch_Station_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Update_PunchStation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value = info.Punch_Id;
        
        
        p = cmd.Parameters.Add("@punch_name", SqlDbType.VarChar, 50);
        p.Value = info.Punch_Name;
        p = cmd.Parameters.Add("@towards", SqlDbType.VarChar, 50);
        p.Value = info.Towards;
        p = cmd.Parameters.Add("@stage", SqlDbType.Int);
        p.Value = info.Stage;
        p = cmd.Parameters.Add("@punch_category", SqlDbType.VarChar, 50);
        p.Value = info.Punch_Category;
        p = cmd.Parameters.Add("@distance", SqlDbType.Float);
        p.Value = info.Distance;


        cmd.ExecuteNonQuery();

        con.Close();
    }



    public void Delete_PunchStation(int punch_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Delete_PunchStation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value = punch_id;



        cmd.ExecuteNonQuery();

        con.Close();
    }
    public Punch_Station_Info View_PunchStation(string  punch_name)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("ViewPunchStation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_name", SqlDbType.VarChar);
        p.Value = punch_name;

        SqlDataReader read = cmd.ExecuteReader();
        Punch_Station_Info p_info = new Punch_Station_Info();
        read.Read();
        if (read.HasRows)
        {
            p_info.Punch_Name = read["punch_name"].ToString();
            p_info.Towards = read["towards"].ToString();
            p_info.Stage = int.Parse(read["stage"].ToString());
            p_info.Punch_Category = read["punch_category"].ToString();
            p_info.Distance = float.Parse(read["distence"].ToString());


        }

        read.Close();



        con.Close();
        return p_info;

    }


    public Punch_Station_Info View_PunchStation(int punch_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("View_PunchStation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
        p.Value = punch_id;

        SqlDataReader read = cmd.ExecuteReader();
        Punch_Station_Info p_info = new Punch_Station_Info();
        read.Read();
        if (read.HasRows)
        {
            p_info.Punch_Name = read["punch_name"].ToString();
            p_info.Towards = read["towards"].ToString();
            p_info.Stage= int.Parse(read["stage"].ToString());
            p_info.Punch_Category = read["punch_category"].ToString();

            
        }

        read.Close();



        con.Close();
        return p_info;

    }


    public DataTable ViewAll_PunchStations()
    {

        SqlDataAdapter da = new SqlDataAdapter("ViewAll_PunchStations", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        
        da.Fill(ds);

        return ds.Tables[0];
    
    }


    public string ReturnTowrds(string pnchname)
    {
        con.Open();
        string towards=""; 
        SqlCommand cmd = new SqlCommand("ReturnTowrds", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_name", SqlDbType.Int);
        p.Value = pnchname;

        
        SqlDataReader read = cmd.ExecuteReader();
        Punch_Station_Info p_info = new Punch_Station_Info();
        read.Read();
        if (read.HasRows)
        {
           // p_info.Punch_Name = read["punch_name"].ToString();
             towards = read["towards"].ToString();
           // p_info.Stage = int.Parse(read["stage"].ToString());
            //p_info.Punch_Category = read["punch_category"].ToString();


        }

        read.Close();



        con.Close();
        return towards;

        
    }



    public DataTable  View_BusStation()
    {
        //con.Open();
        //ArrayList arr = new ArrayList();
        //SqlCommand cmd = new SqlCommand("View_BusStation", con);
        //cmd.CommandType = CommandType.StoredProcedure;
           

        //SqlDataReader read = cmd.ExecuteReader();
        
        //read.Read();
        //while (read.HasRows)
        //{
        //    Punch_Station_Info p_info = new Punch_Station_Info();
        //    p_info.Punch_Name = read["punch_name"].ToString();
        //    arr.Add(p_info);

        //}

        //read.Close();



        //con.Close();
        //return arr;
        SqlDataAdapter ad = new SqlDataAdapter("View_BusStation", con);
        ad.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;

    }

}
