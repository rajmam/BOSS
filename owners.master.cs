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

public partial class owners : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
        //do nothing
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("owners_details.aspx");

    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("change_pw.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("own_bustimeview.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("majphome.aspx");
    }
}
