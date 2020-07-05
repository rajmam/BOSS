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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.SetActiveView(View1);
            //Label4.Visible = false;
        }
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View2);
    }
    protected void btnyes_Click(object sender, EventArgs e)
    {
        Punch_Fine_Info inf = new Punch_Fine_Info();
        Punch_Fine_Sp sp= new Punch_Fine_Sp();
        sp.Delete_Punch_Fine();
        //Label4.Visible = true;
        MultiView1.SetActiveView(View1);
    }
    protected void btnno_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
    }
    protected void btnview_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View3);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
    }
}
