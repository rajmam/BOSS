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
/// Summary description for Bus_Info_Info
/// </summary>
public class Bus_Info_Info
{
    int bus_id,tax_info_id,tax_date,month,year;
    float tax;
   




    public int Tax_Info_Id
    {
        get { return tax_info_id; }
        set { tax_info_id = value; }
    }
    
    
    
    
    
    public int Bus_Id
    {
        get { return bus_id; }
        set { bus_id = value; }
    }
    public float Tax
    {
        get { return tax; }
        set { tax = value; }
    }

    public  int Tax_Date
    {
        get { return tax_date; }
        set { tax_date = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }
}
