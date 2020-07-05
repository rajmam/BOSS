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
/// Summary description for Vehicle_Sp
/// </summary>
public class Vehicle_Sp:dbconn
{
	public void Add_Vehicles(Vehicle_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_vehicles", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        
        //p = cmd.Parameters.Add("@bus_id",SqlDbType.Int);
        //p.Value = info.Bus_Id;
        p = cmd.Parameters.Add("@bus_name", SqlDbType.VarChar);
        p.Value = info.BusName;
        p = cmd.Parameters.Add("@bus_reg_no", SqlDbType.VarChar);
        p.Value = info.Bus_Reg_No;
        p = cmd.Parameters.Add("@model_no", SqlDbType.VarChar);
        p.Value = info.Model_No;
        p = cmd.Parameters.Add("@no", SqlDbType.Int);
        p.Value = info.Own_No;

        cmd.ExecuteNonQuery();
        con.Close();
        
       
	}



    public void Delete_Vehicles(int  bus_id)
    {   
        con.Open();

        SqlCommand cmd = new SqlCommand("Delete_Vehicles", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@bus_id", SqlDbType.VarChar);
        p.Value = bus_id;
        
        
        cmd.ExecuteNonQuery();
        con.Close();
        
        
    
    }






    public void update_vehicles(Vehicle_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Update_Vehicles", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@bus_id", SqlDbType.Int);
        p.Value = info.Bus_Id;


        p = cmd.Parameters.Add("@bus_name", SqlDbType.Int);
        p.Value = info.BusName;

        p = cmd.Parameters.Add("@bus_reg_no", SqlDbType.Int);
        p.Value = info.Bus_Reg_No;


        p = cmd.Parameters.Add("@no", SqlDbType.Int);
        p.Value = info.Own_No;

        p = cmd.Parameters.Add("@model_no", SqlDbType.Int);
        p.Value = info.Model_No;
        
        
        cmd.ExecuteNonQuery();
       
        con.Close();

       
    
    
    
    }





    public Vehicle_Info ViewVehicle(int bus_id_ref)
    {
        con.Open();


        SqlCommand cmd = new SqlCommand("View_Vehicle", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@bus_id", SqlDbType.Int);
        p.Value = bus_id_ref;

        SqlDataReader read =cmd.ExecuteReader();
        

        Vehicle_Info v_info = new Vehicle_Info();
        read.Read();
        if (read.HasRows)
        {
            v_info.Bus_Reg_No = read["bus_reg_no"].ToString();
            v_info.BusName = read["bus_name"].ToString();
            v_info.Model_No = read["model_no"].ToString();
            v_info.Own_No = int.Parse(read["no"].ToString());

            
        }
        else 
        {

            v_info.Bus_Reg_No = "1000";// to represent database is null or no such entry.

        }

        read.Close();
        con.Close();
        return v_info;


    
    
    }




    public DataTable ViewAllVehicles()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllVehicles",con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];
    }


    public int CompareBusRegNo(string newregno)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("CompareBusRegNo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@bus_reg_no", SqlDbType.VarChar);
        p.Value = newregno;

        object ob = new object();
        ob = cmd.ExecuteScalar();
        con.Close();
        if (ob == DBNull.Value)
        {
            return 0;
        }
        else
        {
            return int.Parse(ob.ToString());
        }

    }

    
    
    public Vehicle_Info ViewVehicleThroughBusRegNo(string busregno)
    {
        con.Open();


        SqlCommand cmd = new SqlCommand("ViewVehicleThroughBusRegNo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@bus_reg_no", SqlDbType.VarChar);
        p.Value = busregno;

        SqlDataReader read = cmd.ExecuteReader();


        Vehicle_Info v_info = new Vehicle_Info();
        read.Read();
        if (read.HasRows)
        {
            v_info.Bus_Id = int.Parse(read["bus_id"].ToString());
            v_info.BusName = read["bus_name"].ToString();
            v_info.Model_No = read["model_no"].ToString();
            v_info.Own_No = int.Parse(read["no"].ToString());


        }
        else
        {

            v_info.BusName ="Not exists such a regno";// to represent database is null or no such entry.

        }

        read.Close();
        con.Close();
        return v_info;




    }



}
