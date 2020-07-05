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
using System.Data.SqlClient;

public partial class owners_home : System.Web.UI.Page
{
    


        
protected void Page_Load(object sender, EventArgs e)
    {
         if (Session["username"] == null)
        {
            Response.Redirect("majphome.aspx");
        }
        if (!IsPostBack)
        {
            
            Label3.Visible = true;
            Label14.Visible = false;
            MultiView1.SetActiveView(View1);
        }
        //public HttpSessionState Session { get; }
        Label3.Text = Session["username"].ToString();

        Label3.Visible = true;
        
        
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
            MultiView1.SetActiveView(View2);
        }
        else
            Label14.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("owners_home.aspx?view1");
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        RepeaterItem it = e.Item;

        //Meet_Sp sp = new Meet_Sp();
        //sp.Rate_Comment(int.Parse(e.CommandArgument.ToString()));
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            DataRow row = e.Item.DataItem as DataRow;
            Literal lbdate = e.Item.FindControl("lbdate") as Literal;
            lbdate.Text = DateTime.Parse(row["meeting_date"].ToString()).Date.ToShortDateString();
            Literal lbsubject = e.Item.FindControl("lbsubject") as Literal;
            if (row["subject"].ToString() != "")
            {
                lbsubject.Text = row["subject"].ToString();
            }
            else
            {
                lbsubject.Text = "Regular Meeting";
            }


            Literal lbtime = e.Item.FindControl("lbtime") as Literal;
            lbtime.Text = row["time"].ToString();

            Literal lblocation = e.Item.FindControl("lblocation") as Literal;
            lblocation.Text = row["location"].ToString();

            Literal lbdetails = e.Item.FindControl("lbdetails") as Literal;
            lbdetails.Text = row["details"].ToString();


            //TextBox txtUnitsInStock = e.Item.FindControl("txtUnitsInStock") as TextBox;
            // txtUnitsInStock.Text = row["unitsinstock"].ToString();

            //Button btnrate = e.Item.FindControl("btnrate") as Button;
            //btnrate.CommandName = "rate";
            //btnrate.CommandArgument = row["comment_id"].ToString();

            //Button btnDiscontinued = e.Item.FindControl("btnDiscontinued") as Button;
            //btnDiscontinued.CommandName = "Discontinued";
            //btnDiscontinued.CommandArgument = row["productid"].ToString();


        } 
    }

    public void LoadData()
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\busop\db\dbboss.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");



        SqlDataAdapter ad = new SqlDataAdapter("select * from meeting_table" , con);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        Repeater1.DataSource = ds.Tables[0].Rows;
        Repeater1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        LoadData();
        Repeater1.DataBind();
        MultiView1.SetActiveView(View3);
    }
            
     
        
}
