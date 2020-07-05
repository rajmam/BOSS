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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

           LoadData();
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
      RepeaterItem it=  e.Item;

      Gen_Comment_Sp sp = new Gen_Comment_Sp();
      sp.Rate_Comment(int.Parse(e.CommandArgument.ToString()));
       
    }



    public void LoadData()
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\busop\db\dbboss.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

    

        SqlDataAdapter ad = new SqlDataAdapter("select * from general_comment_table where comment_type='2'", con);
        DataSet ds = new DataSet();
        ad.Fill(ds);
        Repeater1.DataSource = ds.Tables[0].Rows ;
        Repeater1.DataBind();
        
    }


    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            DataRow row = e.Item.DataItem as DataRow;
            Literal lbcommentdate = e.Item.FindControl("lbcommentdate") as Literal;
            lbcommentdate.Text = DateTime.Parse( row["comment_date"].ToString()).Date.ToShortDateString();
            Literal lbcommentator = e.Item.FindControl("lbcommentator") as Literal;
            if (row["comentator"].ToString() != "")
            {
                lbcommentator.Text = row["comentator"].ToString();
            }
            else
            {
                lbcommentator.Text = "Boss"; 
            }
           
            
            Literal lbtime = e.Item.FindControl("lbtime") as Literal;
            lbtime.Text = DateTime.Parse(row["comment_time"].ToString()).ToShortTimeString();

            Literal lbcomment_text = e.Item.FindControl("lbcomment_text") as Literal;
            lbcomment_text.Text = row["comment_text"].ToString();
            //TextBox txtUnitsInStock = e.Item.FindControl("txtUnitsInStock") as TextBox;
           // txtUnitsInStock.Text = row["unitsinstock"].ToString();

            Button btnrate = e.Item.FindControl("btnrate") as Button;
            btnrate.CommandName = "rate";
            btnrate.CommandArgument = row["comment_id"].ToString();

            //Button btnDiscontinued = e.Item.FindControl("btnDiscontinued") as Button;
            //btnDiscontinued.CommandName = "Discontinued";
            //btnDiscontinued.CommandArgument = row["productid"].ToString();


        } 

    }
}
