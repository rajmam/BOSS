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
/// Summary description for Loan_Info
/// </summary>
public class Loan_Info
{
    int loan_id, bus_id;
    float amount, period,paid;



    public int Loan_Id
    {   
        get { return loan_id; }
        set { loan_id = value; }
    }

    public int Bus_Id
    {
        get { return bus_id; }
        set { bus_id = value; }
    }


    public float Amount
    {
        get { return amount; }
        set { amount = value; }
    }


    public float Period
    {
        get { return period; }
        set { period = value; }
    }

    public float Paid
    {
        get { return paid; }
        set { paid = value; }
    }
}
