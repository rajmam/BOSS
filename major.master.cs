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

public partial class major : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)

    {

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {


        Response.Redirect("Members_Login.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("majorcomment.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("majorshowcomplaint.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("majorshowsuggesions.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("majphome.aspx");
    }
    protected void LinkButton2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Members_Login.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("members_regn.aspx");
    }
}
