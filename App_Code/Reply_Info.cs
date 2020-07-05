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
/// Summary description for Reply_Info
/// </summary>
public class Reply_Info
{
    int reply_id,comment_id;
    string reply_text,reply_by;
    DateTime reply_date,reply_time;


    public int Reply_Id
    {
        get { return reply_id; }
        set { reply_id = value; }
    }

    public int Comment_Id
    {
        get { return comment_id; }
        set { comment_id = value; }
    }

    public string Reply_Text
    {
        get { return reply_text; }
        set { reply_text = value; }
    }

    
    public DateTime Reply_Date
    {
        get { return reply_date; }
        set { reply_date = value; }
    }

    public DateTime Reply_Time
    {
        get { return reply_time; }
        set { reply_time = value; }
    }


    public string Reply_By
    {
        get { return reply_by; }
        set { reply_by = value; }
    }
}
