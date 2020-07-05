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

public partial class members_regn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);

        if (!IsPostBack)
        {
            txtuname.Text = "";
            txtage.Text = "";
            txtpw.Text = "";
            txtvpw.Text = "";
            txtusrname.Text = "";
            txtadd.Text = "";
            txtemid.Text = "";
            txtmob.Text = "";
            txtnob.Text = "";
            lbfile.Visible = false;
            lbusrname1.Visible = false;

        }
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string dest = "";
        bool flag = true;
       
            Memb_Info info = new Memb_Info();
            Memb_Sp sp = new Memb_Sp();
            info.MemberName = txtuname.Text;
            info.Age = int.Parse(txtage.Text);
            info.Password = txtpw.Text;
            info.Address = txtadd.Text;
            info.E_Mail = txtemid.Text;
            info.Mobile = txtmob.Text;
            info.Nob = int.Parse(txtnob.Text);
            info.Usrname = txtusrname.Text;

            if (sp.Compareusername(info.Usrname) != 0)
            {
                flag = false;
            }
            

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
                    if (flag == true)
                    {
                        f.CopyTo(path + dest);
                        
                                                
                        info.Phot = dest;
                        sp.Add(info);

                        txtuname.Text = "";
                        txtage.Text = "";
                        txtpw.Text = "";
                        txtvpw.Text = "";
                        txtadd.Text = "";
                        txtemid.Text = "";
                        txtmob.Text = "";
                        txtnob.Text = "";
                        txtusrname.Text = "";


                        int id = (sp.GetMaxCode() - 1);

                        Memb_Info inf = new Memb_Info();
                        inf = sp.ViewMember(id);
                        lbid.Text = inf.No.ToString();
                        lbusrname2.Text = inf.Usrname;
                        lbhiname.Text = inf.MemberName;

                        MultiView1.SetActiveView(View2);
                    }
                    else 
                    {
                        lbusrname1.Text = "usrer name exists!!.";
                        lbusrname1.Visible = true;
                    }
                    f = new FileInfo(imagepath);
                    f.Delete();

                }
                catch (Exception ex)
                {
                   
                   
                    
                        lbfile.Text = "File could not be uploaded!!.";
                        lbfile.Visible = true;
                    
                }
            }
            else
            {
                lbfile.Text = "Cannot accept files of this type!!.";
                lbfile.Visible = true;
            }
            

    }
    protected void txtage_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
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
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
      
       
        
    }
}
