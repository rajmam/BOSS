using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;

public partial class Members_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            lbunexpcted.Visible = false;
        }
        else
        {
            lbunexpcted.Visible = false;
           
        } 
        MultiView1.SetActiveView(View1);
        //public HttpSessionState Session {}

    }

   
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Memb_Info info = new Memb_Info();
        Memb_Sp sp = new Memb_Sp();
      
        info.Usrname = Login1.UserName;
        info.Password = Login1.Password;

        Memb_Info inf_return = new Memb_Info();
        inf_return = sp.logcheck_1(info.Usrname); //checks,is there any user  as per given datas
        if (inf_return.Authorised == 1000)                                                         //if so retuns his authorisation status.
        {
            lbunexpcted.Text = "ACCESS DENIED";
            lbunexpcted.Visible = true;
        }
        else
        {

            if (inf_return.Password == info.Password)
            {
               
                if (inf_return.Authorised == 2)
                {
                    
                Session["username"] = Login1.UserName;
                     
                    bool flag = true;
                    string type_of_user = "";


                    switch (inf_return.Type)
                    {
                        case 0:
                            {
                                Response.Redirect("owners_home.aspx");
                                //string UserName = (string)(Session["usrname"]);
                                //string Password = (string)(Session["First"]);

                                break;
                            }
                        case 1:
                            {
                                //type_of_user = "ADMINISTRATOR";//redirect
                                Response.Redirect("admin_home.aspx");
                                break;
                            }
                        case 2:
                            {
                                //type_of_user = "PUNCH OPERATOR @ bus station"; 
                                Session["username"] = Login1.UserName;
                                //Punch_Station_Sp psp = new Punch_Station_Sp();
                              //Punch_Station_Info pinfo=  psp.View_PunchStation(Login1.UserName);
                              //Session["towards"] = pinfo.Towards;

                              
                                //Punch_Distance_Sp pdp = new Punch_Distance_Sp();
                              //Punch_Distence_Info pdinfo = pdp.View_PunchDistance(pinfo.Punch_Id);

                              //Session["distance"] = pdinfo.Distance;
                              Response.Redirect("punch_bus_station.aspx"); //redirect
                                break;
                            }

                        case 3:
                            {
                                Session["username"] = Login1.UserName;
                                Punch_Station_Sp psp = new Punch_Station_Sp();
                                Punch_Station_Info pinfo = psp.View_PunchStation(Login1.UserName);
                                Session["towards"] = pinfo.Towards;


                                //Punch_Distance_Sp pdp = new Punch_Distance_Sp();
                                //Punch_Distence_Info pdinfo = pdp.View_PunchDistance(pinfo.Punch_Id);

                                Session["distance"] = pinfo.Distance;
                                Response.Redirect("Punching.aspx"); //redirect
                                break;
                            }
                        case 4:
                            {
                                //type_of_user = "RTO";
                                Response.Redirect("rto_home.aspx");//redirect
                                break;
                            }
                        default:
                            {
                                lbunexpcted.Text = "ACCESS DENIED";
                                lbunexpcted.Visible = true;
                                flag = false;
                                break;
                            }

                    }
                    
                }
                else
                {
                    lbunexpcted.Text = "Hi  "+inf_return.MemberName+",u r still unauthorised ,waite untill we conform ur membership. ";
                    lbunexpcted.Visible = true;
                }

            }
            else
            {
                lbunexpcted.Text = "ACCESS DENIED";
                lbunexpcted.Visible = true;
            }
        }
    }
}
