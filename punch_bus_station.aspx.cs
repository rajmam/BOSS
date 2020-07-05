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

public partial class _Default : System.Web.UI.Page
{
    static ArrayList arr = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["username"] == null)
        {
            Response.Redirect("majphome.aspx");
        }
        if (!IsPostBack)
        {
            DataView busrootview = new DataView(new add_trip_sp().ViewAllData());

            busrootview.RowFilter = "day='"+ (System.DateTime.Today.DayOfWeek)  +"'";

            //starttime+select spped from speedtable where tripcategory=tripcategory/sess["distance"]==currentime;

            DataView dv = new DataView();

            
            for (int i = 0; i < busrootview.Count; i++)
            {
                //float speed = new speed_tabe_Sp().ViewSpeed_Category(busrootview[i]["trip_category"].ToString()).Speed;
                //float distance = float.Parse(Session["distance"].ToString());
                //float time = speed / distance;
                //double timed = double.Parse(time.ToString());
                DateTime dt = DateTime.Parse(busrootview[i]["trip_start_time"].ToString());
                //DateTime n = dt.AddHours(timed);
                DateTime st = DateTime.Now.AddMinutes(5);
                DateTime en = DateTime.Now.AddMinutes(-30);
                TimeSpan stt = st.TimeOfDay;
                TimeSpan ent = en.TimeOfDay;
                TimeSpan nt = dt.TimeOfDay;
                int k = stt.CompareTo(nt);
                int j = ent.CompareTo(nt);
                if (k >= 0 && j <= 0)
                {
                    add_trip_info add = new add_trip_info();
                    add.Brt_id = int.Parse(busrootview[i]["brt_id"].ToString());
                    add.Category = busrootview[i]["trip_category"].ToString();
                    add.From = busrootview[i]["from"].ToString();
                    add.Regn_no = busrootview[i]["bus_reg_no"].ToString();
                    add.To = busrootview[i]["to"].ToString();
                    add.Trip_no = int.Parse(busrootview[i]["trip_no"].ToString());
                    arr.Add(add);
                }
            }
            GridView1.DataSource = arr;
            GridView1.DataBind();
            MultiView1.SetActiveView(View1);
        }


        //string check = Session["username"].ToString();

        

    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        Punch_Fine_Info info = new Punch_Fine_Info();
        Punch_Fine_Sp sp = new Punch_Fine_Sp();
        info.Punch_Fine_Date = DateTime.Parse(lbdate.Text);
        info.Brt_Id = int.Parse(GridView1.SelectedValue.ToString());
        info.Punch_name = Session["username"].ToString();
        info.Punched_Time = DateTime.Parse(lbarrtime.Text);
        info.Late_By = Label1.Text;
        info.Fine_Amount = float.Parse(txtfine.Text);
        info.Bus_no = lbbus_no.Text;
        info.Late_By = Label1.Text;

        sp.Add_Punch_Fine(info);
        //for (int j = 0; j <= arr.Count; j++)
        //{ 
        //if(arr[j][2]==info.Brt_Id)
        //{
        //    int index = arr.IndexOf(arr[j][2]);
        //    arr.RemoveAt(index);
        //}
        //}
        int index = 0;
        foreach (add_trip_info inf in arr)
        {

            if (inf.Brt_id == info.Brt_Id)
            {
                break;
            }
            index++;
        }
        arr.RemoveAt(index);
        GridView1.DataSource = arr;
        GridView1.DataBind();

        MultiView1.SetActiveView(View1);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {lbpunchstname.Text = Session["username"].ToString();
        lbdate.Text = System.DateTime.Now.Date.ToShortDateString();
        lbtime.Text = System.DateTime.Now.ToShortTimeString();
        lbday.Text = System.DateTime.Now.DayOfWeek.ToString();
        lbarrtime.Text = System.DateTime.Now.ToShortTimeString();
        add_trip_info info = new add_trip_info();
        add_trip_sp sp = new add_trip_sp();
        info = sp.ViewTrip(int.Parse(GridView1.SelectedValue.ToString()));
        lbbus_no.Text = info.Regn_no.ToString();
        lbtrip_no.Text = info.Trip_no.ToString();
        lbfrom.Text = info.From.ToString();
        lbto.Text = info.To.ToString();
 
        //ArrayList arr = new ArrayList();
        //for (int i = 0; i < busrootview.Count; i++)
        //{
            //float speed = new speed_tabe_Sp().ViewSpeed_Category(info.Category.ToString()).Speed;
            //float distance = float.Parse(Session["distance"].ToString());
            //float time = speed / distance;
            //double timed = double.Parse(time.ToString());
            DateTime dt = DateTime.Parse(info.Time.ToString());
            //DateTime n = dt.AddHours(timed);
            //DateTime st = DateTime.Now.AddMinutes(10);
            //DateTime en = DateTime.Now.AddMinutes(-10);
            //TimeSpan stt = st.TimeOfDay;
            //TimeSpan ent = en.TimeOfDay;
            //TimeSpan nt = n.TimeOfDay;
            //int k = stt.CompareTo(nt);
            //int j = ent.CompareTo(nt);
            //if (k >= 0 && j <= 0)
            //{
            //    add_trip_info add = new add_trip_info();
            //    add.Brt_id = int.Parse(busrootview[i]["brt_id"].ToString());
            //    arr.Add(add);
            //}
        //}
        


        string check = Session["username"].ToString();
        Label7.Text = dt.ToShortTimeString();
       // arr.
        MultiView1.SetActiveView(View2);

        TimeSpan  lat =   (DateTime.Now.TimeOfDay).Subtract(dt.TimeOfDay)  ;
       // lat.
        Label1.Text  =int.Parse(lat.Hours.ToString())+":"+lat.Minutes .ToString()+":"+lat.Seconds .ToString();
    }
}
