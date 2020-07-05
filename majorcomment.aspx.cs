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
            txtcomment.Text = "";
            txtcomntatr.Text = "";
            RadioButton1.Checked=true;       
        
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Gen_Comment_Sp sp = new Gen_Comment_Sp();
        Gen_Comment_Info info = new Gen_Comment_Info();
        info.Comentator = txtcomntatr.Text;
        info.Comment_Date =DateTime.Parse(System.DateTime.Now.ToShortDateString());
        info.Comment_Text = txtcomment.Text;
        info.Comment_Time =DateTime.Parse(System.DateTime.Now.ToShortTimeString());
        if (RadioButton1.Checked == true)
        {
            info.Comment_Type = 1;
        }
        else if (RadioButton2.Checked == true)
        {
            info.Comment_Type = 2;
        }
        info.Rate = 1;


        sp.Add_Comment(info);
        txtcomment.Text = "";
        txtcomntatr.Text = "";
        RadioButton1.Checked = true;

    }
}
