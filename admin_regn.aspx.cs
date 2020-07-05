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
using System.IO;

public partial class admin_regn : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtusrname.Text = "";
            txtuname.Text = "";
            txtage.Text = "";
            txtpw.Text = "";
            txtvpw.Text = "";
            txtadd.Text = "";
            txtemid.Text = "";
            txtmob.Text = "";
            txtnob.Text = "";
            RadioButton3.Checked = true;
            lbfile.Visible = false;
            lbusrname1.Visible=false;
            
        }
    }
    
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        int verify = 2;   // entry "2" in authorisation field represents an verified/authorised member.
        string dest = "";
        bool flag=true;
        
        Memb_Info info = new Memb_Info();
        Memb_Sp sp = new Memb_Sp();
                      
        string imagepath = "";
        Boolean fileOK = false;
        String path = Server.MapPath("~/Photos/Owners/");
        if (FileUpload1.HasFile)
        {
            String fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            String[] allowedExtensions = 
                { ".gif", ".png", ".jpeg", ".jpg" };
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (fileExtension == allowedExtensions[i])
                {
                    fileOK = true;
                }
            }
        }

        if (fileOK)
        {
            try
            {
                imagepath = path + FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(imagepath);
                FileInfo f = new FileInfo(imagepath);
                dest = new Memb_Sp().GetMaxCode() + "." + f.Name.Split('.')[1];
               
                
                
                info.MemberName = txtuname.Text;
                info.Age = int.Parse(txtage.Text);
                info.Password = txtpw.Text;
                info.Address = txtadd.Text;
                info.E_Mail = txtemid.Text;
                info.Mobile = txtmob.Text;
                info.Nob = int.Parse(txtnob.Text);
                
                info.Usrname = txtusrname.Text;
                if(sp.Compareusername(info.Usrname)!= 0)
                {
                  flag=false;
                }
                
                if (RadioButton1.Checked)
                {
                    info.Authorised = verify;
                }

                if(flag==true)
                {
                    f.CopyTo(path+dest);
                    info.Phot=dest;

                                        
                                        
                    
                    sp.Add(info);

                txtusrname.Text = "";
                txtuname.Text = "";
                txtage.Text = "";
                txtpw.Text = "";
                txtvpw.Text = "";
                txtadd.Text = "";
                txtemid.Text = "";
                txtmob.Text = "";
                txtnob.Text = "";
                RadioButton3.Checked = true;
                lbfile.Visible = false;
                lbusrname1.Visible=false;
                if (RadioButton1.Checked)
                {
                Session["username"] = info.Usrname;//for reference to vehicle details entry
                Session["own_name"] = info.MemberName;//-do-
                Response.Redirect("admin_vehicle_info.aspx");
                }
                }
                else
                {
                 lbusrname1.Text="user name exists.!!";
                 lbusrname1.Visible=true;
                }
                 f = new FileInfo(imagepath);
                f.Delete();
            }
               
            catch (Exception ex)
            {
                lbfile.Text = "File could not be uploaded.";
                lbfile.Visible = true;
            }
        }
        else
        {
            lbfile.Text = "Cannot accept files of this type.";
            lbfile.Visible = true;
        }
    }
    






    protected void Button2_Click1(object sender, EventArgs e)
    {
        txtusrname.Text = "";
                txtuname.Text = "";
                txtage.Text = "";
                txtpw.Text = "";
                txtvpw.Text = "";
                txtadd.Text = "";
                txtemid.Text = "";
                txtmob.Text = "";
                txtnob.Text = "";
                RadioButton3.Checked = true;
                lbfile.Visible = false;
                lbusrname1.Visible = false;
    }









    protected void Button3_Click(object sender, EventArgs e)
    {

    }
}
