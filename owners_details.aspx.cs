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

public partial class owners_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            MultiView1.SetActiveView(View1);
        
        //Memb_Sp sp = new Memb_Sp();
        //sp.Show_OwnerDetails();
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
           
        
            Memb_Sp sp = new Memb_Sp();
            Memb_Info info = sp.ViewMember(int.Parse(GridView1.SelectedValue.ToString()));

            lbname.Text = info.MemberName;
            lbage.Text = info.Age.ToString();
            lbadd.Text = info.Address;
            lbemail.Text = info.E_Mail;
            lbphno.Text = info.Mobile;
            lbnob.Text = info.Nob.ToString();
            String path = Server.MapPath("~/Photos/Owners/");
            Image1.ImageUrl = path+info.Phot;

            MultiView1.SetActiveView(View2);
            
    }
    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("owners_details.aspx?view1");
    }
    protected void BtnOk_Click(object sender, EventArgs e)
    {
        Response.Redirect("owners_home.aspx");
    }
}
