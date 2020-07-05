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

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.SetActiveView(View1);

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string day = DropDownList1.SelectedItem.ToString();
        string to = ddlto.SelectedItem.ToString();
        add_trip_sp sp = new add_trip_sp();
        DataTable tb = sp.ViewAllBusOfGivenRoot(to, day);
        GridView1.DataSource = tb;
        GridView1.DataBind();
        MultiView1.SetActiveView(View2);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("majorcomment.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("majorshowcomplaint.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("majorshowsuggesions.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Vehicle_Info v_inf = new Vehicle_Info();
        Vehicle_Sp v_sp = new Vehicle_Sp();
        Memb_Info info = new Memb_Info();
        Memb_Sp sp = new Memb_Sp();
        v_inf.Bus_Reg_No = txtvehicle.Text.ToLower();
        if (v_sp.CompareBusRegNo(v_inf.Bus_Reg_No) != 0)
        {

            Vehicle_Info nv_inf = new Vehicle_Info();
            nv_inf = v_sp.ViewVehicleThroughBusRegNo(v_inf.Bus_Reg_No);
            int sds = nv_inf.Own_No;
            Memb_Info ninfo = new Memb_Info();
            ninfo = sp.ViewMember(sds);
            lbname.Text = ninfo.MemberName;
            lbage.Text = ninfo.Age.ToString();
            lbadd.Text = ninfo.Address;
            lbemail.Text = ninfo.E_Mail;
            lbphno.Text = ninfo.Mobile;
            lbnob.Text = ninfo.Nob.ToString();
            String path = Server.MapPath("~/Photos/Owners/");
            Image1.ImageUrl = path + ninfo.Phot;
            MultiView1.SetActiveView(View3);
        }
        else
            Label14.Visible = true;


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("majphome.aspx?view1");
    }
}
