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
/// Summary description for Meet_Info
/// </summary>
public class Meet_Info
{
    string  subject, time, details,location;
    int status,meeting_no;
    DateTime date, meeting_date;
    
    public int Status
    {
        get { return status; }
        set { status = value; }
    }
    
    
    public int Meeting_No
    {
        get { return meeting_no; }
        set { meeting_no= value; }
    }
    
    
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }
    
    public string Time
    {
        get { return time; }
        set { time = value; }
    }
    
    public string Details
    {
        get { return details; }
        set { details = value; }
    }
    
    
    public DateTime Meeting_Date
    {
        get { return meeting_date; }
        set { meeting_date= value; }
    }
    
    
    public string Location
    {
        get { return location; }
        set { location = value; }
    }


}
