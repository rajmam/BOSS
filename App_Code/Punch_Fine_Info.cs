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
/// Summary description for Punch_Fine_Info
/// </summary>
public class Punch_Fine_Info
{
    int punch_fine_tab_id,brt_id;
    DateTime punch_fine_date,punched_time;
    string punch_name, bus_no,late_by;
    float  fine_amount;

    public int Punch_Fine_Tab_Id
    {
        get { return punch_fine_tab_id; }
        set { punch_fine_tab_id = value; }
    }

    public string Punch_name
    {
        get { return punch_name; }
        set { punch_name = value; }
    }

    public int Brt_Id
    {
        get { return brt_id; }
        set { brt_id = value; }
    }


    public DateTime Punch_Fine_Date
    {
        get { return punch_fine_date; }
        set { punch_fine_date = value; }
    }

 


    public DateTime Punched_Time
    {
        get { return punched_time; }
        set { punched_time = value; }
    }


    

    public string Late_By
    {
        get { return late_by; }
        set { late_by = value; }
    }


    public float Fine_Amount
    {
        get { return fine_amount; }
        set { fine_amount = value; }
    }
    public string Bus_no
    {
        get { return bus_no; }
        set { bus_no = value; }
    }

}
