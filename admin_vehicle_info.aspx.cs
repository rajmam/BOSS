using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class admin_vehicle_info : System.Web.UI.Page
{

   static int i = 0;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        // sir, this page don't  have its own wxistence.this get enabled with admin_regn.aspx//ok.
        
        
        if(!IsPostBack)
        {
            Memb_Sp m_sp = new Memb_Sp();

            string own_name_recieved = Session["own_name"].ToString();
            //sir, this page don't  have its own wxistence.
            lbown.Text = own_name_recieved;
            Txtbname.Text = "";
            Txtbrno.Text = "";
            Txtmno.Text = "";
             
            

        }
          
        
    }
   
    

    
    
    protected void Button1_Click(object sender, EventArgs e)
    {

        Vehicle_Info v_info = new Vehicle_Info();
        Vehicle_Sp v_sp = new Vehicle_Sp();
        Memb_Sp m_sp = new Memb_Sp();



        
        string uname_recieved = Session["username"].ToString();
        int no_of_bus = m_sp.return_nob(uname_recieved)-i;
        
        v_info.Bus_Reg_No = Txtbrno.Text;
        if (v_sp.CompareBusRegNo(v_info.Bus_Reg_No) == 0)
        {
            v_info.BusName = Txtbname.Text;
            v_info.Model_No = Txtmno.Text;

            int own_id;
            own_id = (m_sp.GetMaxCode() - 1);

            v_info.Own_No = own_id;
            v_sp.Add_Vehicles(v_info);

            i++;

            if (no_of_bus <= 1)
            {
                i = 0;

                Response.Redirect("admin_regn.aspx");

            }
            else
            {
                Response.Redirect("admin_vehicle_info.aspx");
            }
            Txtbname.Text = "";
            Txtbrno.Text = "";
            Txtmno.Text = "";


        }
        else 
        {
            lbexists.Text = "This Regno already exists, To see more about it!!//add link btn to vehicle view grid";
        }
    }
}
