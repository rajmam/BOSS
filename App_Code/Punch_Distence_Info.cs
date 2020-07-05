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
/// Summary description for Punch_Distence_Info
/// </summary>
public class Punch_Distence_Info
{
    int punch_id, brt_id;
    float distance;


    public int PunchId
    {
        get { return punch_id;}
        set { punch_id = value; }
       
    
    }

    public int BrtId
    {
        get { return brt_id; }
        set { brt_id = value; }


    }



    public float Distance
    {
        get { return distance; }
        set { distance = value; }


    }
}
