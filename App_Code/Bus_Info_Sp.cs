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
/// Summary description for Bus_Info_Sp
/// </summary>
public class Bus_Info_Sp:dbconn
{
    public void Add_Bus_Tax(Bus_Info_Info inf)
    {

        con.Open();
        SqlCommand cmd = new SqlCommand("Add_Bus_Tax", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();


        p = cmd.Parameters.Add("@bus_id", SqlDbType.Int);
        p.Value = inf.Bus_Id;//select bus_id of given reg no.ie:   vsp.viewvehiclthroughbusregno(regno);
        p = cmd.Parameters.Add("@tax", SqlDbType.Float);
        p.Value = inf.Tax;
        p = cmd.Parameters.Add("@tax_date", SqlDbType.Int);
        p.Value = inf.Tax_Date;
        p = cmd.Parameters.Add("@month", SqlDbType.Int);
        p.Value = inf.Month;
        p = cmd.Parameters.Add("@year", SqlDbType.Int);
        p.Value = inf.Year;
       

        cmd.ExecuteNonQuery();

        con.Close();
    }

    public void Update_Bus_Tax(Bus_Info_Info inf)
    {

        con.Open();
        SqlCommand cmd = new SqlCommand("Update_Bus_Tax", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@bus_id", SqlDbType.Int);
        p.Value = inf.Bus_Id;//select bus_id of given reg no.ie:   vsp.viewvehiclthroughbusregno(regno);
        p = cmd.Parameters.Add("@tax_info_id", SqlDbType.Int);
        p.Value = inf.Tax_Info_Id;
        
        p = cmd.Parameters.Add("@tax", SqlDbType.Float);
        p.Value = inf.Tax;
        p = cmd.Parameters.Add("@tax_date", SqlDbType.Int);
        p.Value = inf.Tax_Date;
        p = cmd.Parameters.Add("@month", SqlDbType.Int);
        p.Value = inf.Month;
        p = cmd.Parameters.Add("@year", SqlDbType.Int);
        p.Value = inf.Year;

        cmd.ExecuteNonQuery();

        con.Close();
    }


    public Bus_Info_Info View_Bus_TaxOfGivenMonth(int bus_id,int month,int year)
    {

        con.Open();
        SqlCommand cmd = new SqlCommand("View_Bus_TaxOfGivenMonth", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@bus_id", SqlDbType.Int);
        p.Value = bus_id;//select bus_id of given reg no.ie:   vsp.viewvehiclthroughbusregno(regno);
        p = cmd.Parameters.Add("@month", SqlDbType.Int);
        p.Value = month;
        p = cmd.Parameters.Add("@year", SqlDbType.Int);
        p.Value = year;

        SqlDataReader read = cmd.ExecuteReader();
        Bus_Info_Info inf = new Bus_Info_Info();
        if (read.Read())
        {
            
           inf.Tax= float.Parse(read["tax"].ToString());
           inf.Tax_Date=int.Parse(read["tax_date"].ToString());

        }
        else 
        {
            inf.Tax_Date = int.Parse("1000");  //To show no tax in that month.
        }


        read.Close();
        con.Close();
        return inf;
    }




    public DataTable ViewAllBusTaxInDB()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllBusTaxInDB", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        
        
        da.Fill(ds);
        return ds.Tables[0];
   
    }


    public void Delete_Bus_Tax(int tax_info_id)
    {

        con.Open();
        SqlCommand cmd = new SqlCommand("Delete_Bus_Tax", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();


        p = cmd.Parameters.Add("@tax_info_id", SqlDbType.Int);
        p.Value = tax_info_id;//select id of selected gridview entry.


        cmd.ExecuteNonQuery();

        con.Close();
    }




    public Bus_Info_Info View_Bus_TaxForGridView(int tax_info_id)
    {

        con.Open();
        SqlCommand cmd = new SqlCommand("View_Bus_TaxForGridView", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@tax_info_id", SqlDbType.Int);
        p.Value = tax_info_id;//select bus_id of given reg no.ie:   vsp.viewvehiclthroughbusregno(regno);
        

        SqlDataReader read = cmd.ExecuteReader();
        Bus_Info_Info inf = new Bus_Info_Info();
        if (read.Read())
        {

            inf.Tax = float.Parse(read["tax"].ToString());
            inf.Tax_Date = int.Parse(read["tax_date"].ToString());
            inf.Bus_Id = int.Parse(read["bus_id"].ToString());
            inf.Year = int.Parse(read["year"].ToString());
            inf.Month = int.Parse(read["month"].ToString());

        }
        else
        {
            inf.Tax_Date = int.Parse("1000");  //To show no tax in that month.
        }


        read.Close();
        con.Close();
        return inf;
    }
}
