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
/// Summary description for Vehicle_Info
/// </summary>
public class Vehicle_Info
{
    string bus_name, bus_reg_no, model_no;
    int bus_id, no;
   
    public string BusName
    { 
        get{ return bus_name;}
        set { bus_name = value;}
    }

    public string Bus_Reg_No
    {
        get { return bus_reg_no; }
        set { bus_reg_no = value;}
    }

    public string Model_No
    {
        get { return model_no; }
        set { model_no = value; }
    }

    public int Bus_Id
    {
        get { return bus_id; }
        set { bus_id = value; }
    }

    public int Own_No
    {
        get { return no; }
        set { no = value; }
    }
    
   
}
