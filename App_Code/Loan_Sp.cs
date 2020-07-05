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
/// Summary description for Loan_Sp
/// </summary>
public class Loan_Sp:dbconn
{
    public void Add_Loan(Loan_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Add_Loan", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        
        
        
        p = cmd.Parameters.Add("@bus_id", SqlDbType.Int);
        p.Value = info.Bus_Id;
        p = cmd.Parameters.Add("@amount", SqlDbType.Float);
        p.Value = info.Amount;
        p = cmd.Parameters.Add("@paid", SqlDbType.Float);
        p.Value = info.Paid;
        p = cmd.Parameters.Add("@period", SqlDbType.Float);
        p.Value = info.Period;
       


        cmd.ExecuteNonQuery();

        con.Close();

    }




    public void Delete_Loan(int lon_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Delete_Loan", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();


        p = cmd.Parameters.Add("@loan_id", SqlDbType.Int);
        p.Value = lon_id;
        


        cmd.ExecuteNonQuery();

        con.Close();

    }




    public void Update_Loan(Loan_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("Update_Loan", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@loan_id", SqlDbType.Int);
        p.Value = info.Loan_Id;
        
       
        p = cmd.Parameters.Add("@amount", SqlDbType.Float);
        p.Value = info.Amount;
        p = cmd.Parameters.Add("@paid", SqlDbType.Float);
        p.Value = info.Paid;
        p = cmd.Parameters.Add("@period", SqlDbType.Float);
        p.Value = info.Period;



        cmd.ExecuteNonQuery();

        con.Close();

    }



    public Loan_Info View_Loan_Details(int lon_id)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("View_Loan_Details", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@loan_id", SqlDbType.Int);
        p.Value = lon_id;
        SqlDataReader read = cmd.ExecuteReader();
        Loan_Info l_info = new Loan_Info();
        if (read.Read())
        {
            l_info.Amount = float.Parse(read["amount"].ToString());
            l_info.Bus_Id = int.Parse(read["bus_id"].ToString());
            l_info.Paid = float.Parse(read["paid"].ToString());
            l_info.Period = float.Parse(read["priod"].ToString());
        }
        else
        {
            l_info.Period = 1000.1000F;

        }
        read.Close();
         con.Close();
         return l_info;

    }



    public DataTable View_All_Loan_Details()
    {
        
        SqlDataAdapter da = new SqlDataAdapter("View_All_Loan_Details", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];

        
    }


}
