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
            Txtusrname.Text = "";
            Txtpw.Text = "";
            lbusrex.Visible = false;
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        lbusrex.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        lbusrex.Visible = false;

        int t1 = 0;

        Memb_Info info = new Memb_Info();
        Memb_Sp sp = new Memb_Sp();

        t1 = int.Parse(DropDownList1.SelectedValue.ToString());

        info.Usrname = Txtusrname.Text;
        info.Password = Txtpw.Text;
        info.MemberName = "";
        info.Age = 0;
        info.Type = t1;
        info.Address = "";
        info.E_Mail = "";
        info.Mobile = "";
        info.Nob = 0;
        info.Phot = "";

        //info.Type = t1;
        if (sp.Compareusername(info.Usrname) == 0)
        {
            sp.Add(info);
            Txtusrname.Text = "";
        }
        else
        {
            lbusrex.Text = "UserName Exists!!";
            lbusrex.Visible = true;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        lbusrex.Visible = false;

        int t1 = 0;

        Memb_Info info = new Memb_Info();
        Memb_Sp sp = new Memb_Sp();

        t1 = int.Parse(DropDownList1.SelectedValue.ToString());

        info.Usrname = Txtusrname.Text;
        info.Password = Txtpw.Text;
        info.MemberName = "";
        info.Age = 0;
        info.Type = t1;
        info.Address = "";
        info.E_Mail = "";
        info.Mobile = "";
        info.Nob = 0;
        info.Phot = "";

        //info.Type = t1;
        if (sp.Compareusername(info.Usrname) == 0)
        {
            sp.Add(info);
            Txtusrname.Text = "";
            Response.Redirect("admin_home.aspx");
        }
        else
        {
            lbusrex.Text = "UserName Exists!!";
            lbusrex.Visible = true;
        }
    }
}
