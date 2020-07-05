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

public partial class workers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txttype.Visible = true;
            txtname.Text = "";
            txttype.ClearSelection();
            txtaddress.Text = "";
            txtid.Text = "";
            txttype.ClearSelection();
       
        
        }
        MultiView1.SetActiveView(View1);
        


    }
   
    
    protected void txtname_TextChanged(object sender, EventArgs e)
    {

    }
    
    
    protected void txttype_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    
    protected void Btnsubmit_Click(object sender, EventArgs e)
    {
        string dest = "";
        bool flag = true;
        txttype.Visible = true;

        Worker_Info w_info = new Worker_Info();
        Worker_Sp w_sp = new Worker_Sp();

        w_info.Worker_Name = txtname.Text;
        w_info.Work_Category = txttype.SelectedValue;
        w_info.Licence_No = txtid.Text;
        w_info.Adress = txtaddress.Text;
        




        
            string imagepath = "";
            Boolean fileOK = false;
            String path = Server.MapPath("~/Photos/workers/");
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
                    dest = new Worker_Sp().GetMaxCode() + "." + f.Name.Split('.')[1];
                    if (flag == true)
                    {
                        f.CopyTo(path + dest);


                        w_info.Worker_Photo = dest;

                        w_sp.Add_Worker(w_info);
                        GridView1.DataBind();
                        MultiView1.SetActiveView(View1);
                    
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
    
    
    
    
    
    
    protected void txtid_TextChanged(object sender, EventArgs e)
    {

    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }
    
    
    
    
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        //Worker_Sp sp = new Worker_Sp();
        //Worker_Info info = sp.View_Worker(int.Parse(GridView1.SelectedValue.ToString()));
        
        //String path = Server.MapPath("~/Photos/workers/");
        
        //txtname.Text = info.Worker_Name;
        //txtaddress.Text = info.Adress;
        //int k =info.Work_Category;
        //txttype.Visible = false;
        //if (k == 1)
        //{
        //    Label5.Text = "conductor";
        //}
        //else if (k == 2)
        //{
        //    Label5.Text = "driver";
        //}
        //else if (k == 3)

        //{

        //    Label5.Text = "coductor/driver";
        //}   
             
        // txtid.Text = info.Licence_No;

        //Image1.ImageUrl = path + info.Worker_Photo;

        MultiView1.SetActiveView(View3);
    }
    
    
    
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        txttype.Visible = true;
        txtid.Text = "";
        txttype.ClearSelection();
        txtname.Text = "";
        txttype.ClearSelection();
        txtaddress.Text = "";
        Image1.Visible = false;

        
        MultiView1.SetActiveView(View2);


    }
    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        GridView1.DataBind();
    }
    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
    }

   
    protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "GoBackToView1")
        {
            MultiView1.SetActiveView(View1);
        }
        else
        {
            MultiView1.SetActiveView(View3);
        }
    }

    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
}
