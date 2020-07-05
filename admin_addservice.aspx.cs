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

public partial class admin_addservice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtfrom.Text = "";
            txtregno.Text = "";
            
            txtto.Text = "";
            txttripno.Text = "";
            ddlday.ClearSelection();
            ddlcategory.ClearSelection();
            ddlapm.ClearSelection();
            DD2.ClearSelection();
            DD1.ClearSelection();

            
        }



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            add_trip_info inf = new add_trip_info();
            add_trip_sp sp = new add_trip_sp();

            inf.Regn_no = txtregno.Text;
            inf.From = txtfrom.Text;
            inf.To = txtto.Text;
            inf.Time = (DD1.SelectedItem.ToString() + ":" + DD2.SelectedItem.ToString() + " " + ddlapm.SelectedItem.ToString());
            inf.Trip_no = int.Parse(txttripno.Text);
            inf.Category = ddlcategory.SelectedItem.ToString();
            inf.Day = ddlday.SelectedItem.ToString();
            inf.Towards = TextBox1.Text;
            sp.Add(inf);

            txtfrom.Text = "";
            txtregno.Text = "";

            txtto.Text = "";
            txttripno.Text = "";
            ddlday.ClearSelection();
            ddlcategory.ClearSelection();
            ddlapm.ClearSelection();
            DD2.ClearSelection();
            DD1.ClearSelection();

          

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txtfrom.Text = "";
        txtregno.Text = "";
        
        txtto.Text = "";
        txttripno.Text = "";
        Label7.Visible = false;
        Label9.Visible = false;
        //label10.visible = false;

    }
    protected void ddlday_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlapm_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
