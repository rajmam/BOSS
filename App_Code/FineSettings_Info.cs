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
/// Summary description for FineSettings_Info
/// </summary>
public class FineSettings_Info
{
    int latency_id;
    float latency_time, fine;

    public int Latency_Id
    {
        get { return latency_id; }
        set { latency_id = value; }
    }

    public float Latency_Time
    {
        get { return latency_time; }
        set { latency_time= value; }
    }


    public float Fine
    {
        get { return fine; }
        set { fine = value; }
    }


}
