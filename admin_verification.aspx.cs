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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.SetActiveView(View1);
        }

    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Memb_Info info = new Memb_Info();
        //Memb_Sp sp = new Memb_Sp();
        //sp.ViewAllMembers();


        // Memb_Info info = new Memb_Info();
        Memb_Sp sp = new Memb_Sp();
        //sp.ViewAllData();
        Memb_Info info = sp.ViewMember(int.Parse(GridView2.SelectedValue.ToString()));

        txtage.Text = info.Age.ToString();
        txtname.Text = info.MemberName;
        txtaddress.Text = info.Address;
        txtnob.Text = info.Nob.ToString();
        txtmobile.Text = info.Mobile;
        String path = Server.MapPath("~/Photos/Owners/");
        Image1.ImageUrl = path + info.Phot;
        MultiView1.SetActiveView(View2);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Memb_Info inf = new Memb_Info();
        Memb_Sp sp1 = new Memb_Sp();

        int xx =int.Parse( GridView2.SelectedDataKey.Value.ToString());

        sp1.Update1(xx);

        inf = sp1.ViewMember(xx);
        
        
        Session["username"] = inf.Usrname;
        Session["own_name"] = inf.MemberName;
        Response.Redirect("admin_vehicle_info.aspx");


    }
}
