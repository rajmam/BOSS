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
/// Summary description for Gen_Comment_Info
/// </summary>
public class Gen_Comment_Info
{
    int comment_id, rate,comment_type;
    string comment_text, comentator;
    DateTime comment_date,comment_time;


    public int Comment_Id
    {
       get {return comment_id; } 
       set {comment_id = value;}
    }
    
    public int Rate
    { 
        get { return rate; } 
        set { rate = value; } 
    }  
    
    public string Comment_Text
    { 
        get { return comment_text; } 
        set { comment_text = value; } 
    } 
    
    public int Comment_Type
    {
        get { return comment_type; }
        set { comment_type = value; } 
    }
    public DateTime Comment_Date
    { 
        get { return comment_date; }
        set { comment_date = value; } 
    }

    public DateTime Comment_Time
    {
        get { return comment_time; }
        set { comment_time = value; }
    }


    public string Comentator
    {
        get { return comentator; }
        set { comentator = value; }
    }
}
