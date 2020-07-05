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
/// Summary description for speed_tabe_info
/// </summary>
public class speed_tabe_info
{
    string trip_category;
    float speed;
	
    public string Trip_Category
    {
    get{return trip_category ;}
        set{trip_category=value;}
    }
    public float Speed
    {
    get{return speed;}
    set{speed=value;}

    }

}
