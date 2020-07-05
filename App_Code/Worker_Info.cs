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
/// Summary description for Worker_Info
/// </summary>
public class Worker_Info
{
    int worker_id, bus_id;
    string worker_name, worker_adress, worker_photo, license_no, work_category;

    public int Worker_Id
    {
        get { return worker_id; }
        set { worker_id = value; }

    }
    public int Bus_Id
    {
        get { return bus_id; }
        set { bus_id = value; }

    }

    public string Work_Category
    {
        get { return work_category; }
        set { work_category = value; }

    }
    public string Worker_Name
    {
        get { return worker_name; }
        set { worker_name = value; }

    }

    public string Adress
    {
        get { return worker_adress; }
        set { worker_adress = value; }

    }
    public string Worker_Photo
    {
        get { return worker_photo; }
        set { worker_photo = value; }

    }
    public string Licence_No
    {
        get { return license_no; }
        set { license_no = value; }

    }
}
