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
/// Summary description for Trip_Satus_Info
/// </summary>
public class Trip_Satus_Info
{
    int trip_status_id, brt_id;
    DateTime date;
    string trip_status;


    public int Trip_Status_Id
    {
        get { return trip_status_id; }
        set { trip_status_id = value; }
    }

    public int Brt_Id
    {
        get { return brt_id; }
        set { brt_id = value; }
    }

    public string Trip_Status
    {
        get { return trip_status; }
        set { trip_status = value; }
    }


    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }


}
