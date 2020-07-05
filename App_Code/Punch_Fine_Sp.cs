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
/// Summary description for Punch_Fine_Sp
/// </summary>
public class Punch_Fine_Sp : dbconn
{
    public void Add_Punch_Fine(Punch_Fine_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_Punch_Fine", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@punch_fine_date", SqlDbType.DateTime);
        p.Value = info.Punch_Fine_Date;
        p = cmd.Parameters.Add("@punched_time", SqlDbType.DateTime);
        p.Value = info.Punched_Time;
    
        p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
        p.Value = info.Brt_Id;
        p = cmd.Parameters.Add("@punch_name", SqlDbType.VarChar);
        p.Value = info.Punch_name;
        p = cmd.Parameters.Add("@bus_no", SqlDbType.VarChar);
        p.Value = info.Bus_no ;
        p = cmd.Parameters.Add("@fine_amount", SqlDbType.Float);
        p.Value = info.Fine_Amount;
        p = cmd.Parameters.Add("@late_by", SqlDbType.VarChar );
        p.Value = info.Late_By;

        cmd.ExecuteNonQuery();

        con.Close();

    }



    //public void Update_Punch_Fine(Punch_Fine_Info info)
    //{
    //    con.Open();

    //    SqlCommand cmd = new SqlCommand("Update_Punch_Fine", con);
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    SqlParameter p = new SqlParameter();
    //    p = cmd.Parameters.Add("@punch_fine_tab_id", SqlDbType.Int);
    //    p.Value = info.Punch_Fine_Tab_Id;



    //    p = cmd.Parameters.Add("@punch_fine_date", SqlDbType.DateTime);
    //    p.Value = info.Punch_Fine_Date;
    //    p = cmd.Parameters.Add("@punched_time", SqlDbType.DateTime);
    //    p.Value = info.Punched_Time;
    //    p = cmd.Parameters.Add("@pay_status", SqlDbType.VarChar);
    //    p.Value = info.Pay_Status;
    //    p = cmd.Parameters.Add("@brt_id", SqlDbType.Int);
    //    p.Value = info.Brt_Id;
    //    p = cmd.Parameters.Add("@punch_id", SqlDbType.Int);
    //    p.Value = info.Punch_Id;
    //    p = cmd.Parameters.Add("@payed_date", SqlDbType.DateTime);
    //    p.Value = info.Payed_Date;
    //    p = cmd.Parameters.Add("@fine_amount", SqlDbType.Float);
    //    p.Value = info.Fine_Amount;
    //    p = cmd.Parameters.Add("@late_by", SqlDbType.Float);
    //    p.Value = info.Late_By;

    //    cmd.ExecuteNonQuery();

    //    con.Close();

    //}


    public void Delete_Punch_Fine()
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("DeleteAllPunch", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
       // p = cmd.Parameters.Add("@punch_fine_tab_id", SqlDbType.Int);
        //p.Value = punch_fine_id;



        cmd.ExecuteNonQuery();

        con.Close();

    }





    public object View_Punch_Fine(int punch_fine_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("View_Punch_Fine", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@punch_fine_tab_id", SqlDbType.Int);
        p.Value = punch_fine_id;

        SqlDataReader read = cmd.ExecuteReader();
        Punch_Fine_Info p_info = new Punch_Fine_Info();
        if (read.Read())
        {

            p_info.Late_By = read["late_by"].ToString();
     
    
            p_info.Punch_Fine_Date = DateTime.Parse(read["punch_fine_date"].ToString());
            p_info.Punch_Fine_Tab_Id = int.Parse(read["punch_fine_tab_id"].ToString());
            p_info.Punch_name = read["punch_name"].ToString();
            p_info.Punched_Time =  DateTime.Parse(read["punched_time"].ToString());
            p_info.Fine_Amount = int.Parse(read["fine_amount"].ToString());
            p_info.Brt_Id = int.Parse(read["brt_id"].ToString());
            p_info.Bus_no  = read["bus_no"].ToString();


        }



        read.Close();
        con.Close();
        return p_info;


    }

    public DataTable View_All_Punch_Fine()
    {
        SqlDataAdapter da = new SqlDataAdapter("View_All_Punch_Fine", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];
    }
}
