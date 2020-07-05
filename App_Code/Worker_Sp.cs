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
/// Summary description for Worker_Sp
/// </summary>
public class Worker_Sp:dbconn
{
	public void Add_Worker(Worker_Info info)
	{
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_worker", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        
        
        p = cmd.Parameters.Add("@worker_name", SqlDbType.VarChar);
        p.Value = info.Worker_Name;
        p = cmd.Parameters.Add("@work_category", SqlDbType.VarChar);
        p.Value = info.Work_Category;
        p = cmd.Parameters.Add("@worker_adress", SqlDbType.VarChar);
        p.Value = info.Adress;
        p = cmd.Parameters.Add("@worker_photo", SqlDbType.VarChar);
        p.Value = info.Worker_Photo;
        p = cmd.Parameters.Add("@license_no", SqlDbType.VarChar);
        p.Value = info.Licence_No;
        
        cmd.ExecuteNonQuery();
        con.Close();
	}


    public void Update_Worker(Worker_Info wrkr_id)
    {

        con.Open();


        SqlCommand cmd = new SqlCommand("update_workers", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        
        p = cmd.Parameters.Add("@worker_id", SqlDbType.Int);
        p.Value = wrkr_id.Worker_Id;
       
        p = cmd.Parameters.Add("@worker_name", SqlDbType.VarChar);
        p.Value = wrkr_id.Worker_Name;
        p = cmd.Parameters.Add("@work_category", SqlDbType.VarChar);
        p.Value = wrkr_id.Work_Category;
        p = cmd.Parameters.Add("@worker_adress", SqlDbType.VarChar);
        p.Value = wrkr_id.Adress;
        p = cmd.Parameters.Add("@worker_photo", SqlDbType.VarChar);
        p.Value = wrkr_id.Worker_Photo;
        p = cmd.Parameters.Add("@license_no", SqlDbType.VarChar);
        p.Value = wrkr_id.Licence_No;

        cmd.ExecuteNonQuery();
        con.Close();
        

        
    }






    public Worker_Info View_Worker(int wrkr_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("view_worker", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@worker_id", SqlDbType.Int);
        p.Value = wrkr_id;

        SqlDataReader read = cmd.ExecuteReader();
        Worker_Info w_inf = new Worker_Info();
        read.Read();
        if (read.HasRows)
        {
            w_inf.Worker_Name = read["worker_name"].ToString();
            w_inf.Worker_Photo = read["worker_photo"].ToString();
            w_inf.Work_Category = read["work_category"].ToString();
            w_inf.Adress = read["worker_adress"].ToString();
            w_inf.Licence_No = read["license_no"].ToString();

        }
        else
        {

            w_inf.Worker_Name = "1000";// to represent empty DataBase.
        }
        read.Close();      
        con.Close();
        return w_inf;
    }


    public DataTable ViewAllWorkers()
    {
        
        SqlDataAdapter da = new SqlDataAdapter("ViewAllWorkers",con);
        DataSet ds = new DataSet();
        da.SelectCommand.CommandType = CommandType.StoredProcedure;


        da.Fill(ds);
        return ds.Tables[0];

       
    }
   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public void Delete_Worker(int worker_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("delete_worker", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@worker_id", SqlDbType.Int);
        p.Value = worker_id;

         cmd.ExecuteNonQuery();
       
        con.Close();
        
    
    
    }




    public int GetMaxCode()//FOR PHOTO LOADING
    {
        con.Open();
        string str = "SELECT     MAX(worker_id) + 1 AS id FROM        workers_table";
        SqlCommand cmd = new SqlCommand(str, con);
        object obj = cmd.ExecuteScalar();
        con.Close();
        if (obj == DBNull.Value)
        {
            return 1;
        }
        else
        {
            return int.Parse(obj.ToString());

        }


    }





    
}
