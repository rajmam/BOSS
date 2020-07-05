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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_viewmembers.aspx?view1");
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("majphome.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_regn.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_verification.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_addservice.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_user.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("change_pw.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_bustimeview.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_bustimeview.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("workers.aspx");
    }
}
