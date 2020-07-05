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

public partial class admin_bustimeview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.SetActiveView(View1);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        MultiView1.SetActiveView(View2);




    }

    protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
    {
        //add_trip_info info = new add_trip_info();
        //add_trip_sp sp = new add_trip_sp();
        //sp.Update(info);
    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
    protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "GoBackToView1")
        { MultiView1.SetActiveView(View1); }
        else
        { MultiView1.SetActiveView(View2); }

    }
    protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        GridView1.DataBind();
    }
    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
    }
    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        GridView1.DataBind();
    }
}
