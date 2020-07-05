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
/// Summary description for add_trip_info
/// </summary>
public class add_trip_info:dbconn
{
    string from, to, reg_no, time,day,category,towards;

        int trip_no,brt_id;

    public string Regn_no
    {
        get { return reg_no; }
        set { reg_no = value; }

    }
    public string From
    {
        get { return from; }
        set { from = value; }
    }
    public string To
    {
        get { return to; }
        set { to = value; }
    }
    public string Time
    {
        get { return time; }
        set { time = value; }
    }
    public int Trip_no
    {
        get { return trip_no; }
        set { trip_no = value; }
    }
    public int Brt_id
    {
        get { return brt_id; }
        set { brt_id = value; }
    }
    public string Category
    {
        get { return category; }
        set { category = value; }
    }
    public string Day
    {
        get { return day; }
        set {day = value; }
    }
    public string Towards
    {
        get { return towards; }
        set { towards = value; }

    }  

}
