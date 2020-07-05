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
/// Summary description for WorkTypeInfo
/// </summary>
public class WorkType_Info
{

    int work_category;
    string work_name;

    public int WorkCategory
    {
        get { return work_category; }
        set { work_category = value; }
    }

    public string WorkName
    {
        get { return work_name; }
        set { work_name=value;}
    }
}
