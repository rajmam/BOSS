using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Punch_Station_Info
/// </summary>
public class Punch_Station_Info
{
    int punch_id, stage;
    string punch_name, punch_category, towards;
    float distance;

    public int Punch_Id
    {
        get { return punch_id; }
        set { punch_id = value; }
    }
    public int Stage
    {
        get { return stage; }
        set { stage = value; }
    }
    public string Punch_Name
    {
        get { return punch_name; }
        set { punch_name = value; }
    }


    public string Punch_Category
    {
        get { return punch_category; }
        set { punch_category = value; }
    }


    public float Distance
    {
        get { return distance; }
        set { distance = value; }
    }


    public string Towards
    {
        get { return towards; }
        set { towards = value; }
    }
    

}
