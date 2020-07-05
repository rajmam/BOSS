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

public partial class change_pw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label5.Visible = false;
            
            txtpw.Text = "";
            txtvnewpw.Text = "";
            txtnewpw.Text = "";
        }

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Memb_Info info = new Memb_Info();
        Memb_Sp sp = new Memb_Sp();
        info.Usrname = Session["username"].ToString(); 
        info.Password = txtpw.Text;
        Memb_Info inf_return = new Memb_Info();
        inf_return = sp.logcheck_1(info.Usrname); //checks,is there any user  as per given datas
       // if (inf_return.Authorised == 1000)                                                         //if so retuns his authorisation status.
       // {
       //     Label5.Text = "ACCESS DENIED";
        //    Label5.Visible = true;
       // }
       // else
        //{

            if (inf_return.Password == info.Password)
            {

                

                    
                    
                    if (txtvnewpw.Text == txtnewpw.Text)
                    {

                        info.Password = txtnewpw.Text;
                        sp.change_pw(info);

                    }
                    else
                    {



                        Label5.Visible = true;


                    }
               
                
            }
            else
            {
                Label5.Text = "INVALID PASSWORD/USER NAME";
            }
        //}
    }
}
