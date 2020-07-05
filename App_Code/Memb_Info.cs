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
/// Summary description for regn_con
/// </summary>
public class Memb_Info
{
	
    
        string name, adress, password, mobile, e_mail,phot,usrname;
        int no, age, nob, type, authorised;

        public string MemberName
        {
            get{return name;}
            set{name=value;}

        }
    public string Usrname
        {
            get { return usrname; }
            set { usrname = value; }

        }
    public string Password
    {
        get { return password; }
        set { password = value; }

    }
    public string Address 
    {
        get { return adress; }
        set { adress = value; }

    }
    public string Mobile
    {
        get { return mobile; }
        set { mobile = value; }

    }
    public string E_Mail
    {
        get { return e_mail; }
        set { e_mail = value; }

    }
    public string Phot
    {
        get { return phot; }
        set { phot = value; }

    }
    public int No
    {
        get { return no; }
        set { no = value; }

    }
    public int Age
    {
        get { return age; }
        set { age = value; }

    }
    public int Nob
    {
        get { return nob; }
        set { nob = value; }

    }
    public int Type
    {
        get { return type; }
        set { type = value; }

    }
    public int Authorised
    {
        get { return authorised; }
        set { authorised = value; }

    }
}
