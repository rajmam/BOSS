using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;


/// <summary>
/// Summary description for regn_prov
/// </summary>
public class Memb_Sp:dbconn
{
    public void Add(Memb_Info inf)//FOR REGISTRATION
    {
        con.Open();
      
        SqlCommand cmd = new SqlCommand("AddMemb", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();

        p = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
        p.Value = inf.MemberName;
        p = cmd.Parameters.Add("@age", SqlDbType.Int);
        p.Value = inf.Age;
        p = cmd.Parameters.Add("@password", SqlDbType.VarChar, 50);
        p.Value = inf.Password;
        p = cmd.Parameters.Add("@address", SqlDbType.VarChar);
        p.Value = inf.Address;
        p = cmd.Parameters.Add("@e_mail", SqlDbType.VarChar, 50);
        p.Value = inf.E_Mail;
        p = cmd.Parameters.Add("@mobile", SqlDbType.VarChar, 50);
        p.Value = inf.Mobile;
        p = cmd.Parameters.Add("@nob", SqlDbType.Int);
        p.Value = inf.Nob;
        p = cmd.Parameters.Add("@type", SqlDbType.Int);
        p.Value = inf.Type; 
        p = cmd.Parameters.Add("@authorised", SqlDbType.Int);
        p.Value = inf.Authorised;
        p = cmd.Parameters.Add("@phot", SqlDbType.VarChar, 50);
        p.Value = inf.Phot;
        p = cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 50);
        p.Value = inf.Usrname;
        
        cmd.ExecuteNonQuery();
        
        con.Close();   
    }


    public void change_pw(Memb_Info info)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("UpdatePassword", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 50);
        p.Value = info.Usrname;



        p = cmd.Parameters.Add("@password", SqlDbType.VarChar, 50);
        p.Value = info.Password;

        cmd.ExecuteNonQuery();
        
        con.Close();
       
    }
    
    
    
    public void Update(Memb_Info inf)//FOR REGISTRATION
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("UpdateMember", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@no", SqlDbType.Int);
        p.Value = inf.No;



        p = cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
        p.Value = inf.MemberName;
        p = cmd.Parameters.Add("@age", SqlDbType.Int);
        p.Value = inf.Age;
        p = cmd.Parameters.Add("@password", SqlDbType.VarChar, 50);
        p.Value = inf.Password;
        p = cmd.Parameters.Add("@address", SqlDbType.VarChar);
        p.Value = inf.Address;
        p = cmd.Parameters.Add("@e_mail", SqlDbType.VarChar, 50);
        p.Value = inf.E_Mail;
        p = cmd.Parameters.Add("@mobile", SqlDbType.VarChar, 50);
        p.Value = inf.Mobile;
        p = cmd.Parameters.Add("@nob", SqlDbType.Int);
        p.Value = inf.Nob;
        p = cmd.Parameters.Add("@type", SqlDbType.Int);
        p.Value = inf.Type; 
        p = cmd.Parameters.Add("@authorised", SqlDbType.Int);
        p.Value = inf.Authorised;
        p = cmd.Parameters.Add("@phot", SqlDbType.VarChar, 50);
        p.Value = inf.Phot;
        p = cmd.Parameters.Add("@usrname", SqlDbType.VarChar, 50);
        p.Value = inf.Usrname;
        
        
         cmd.ExecuteNonQuery();
        con.Close();
        
        
           
    }


    public void Update1(int no)//FOR REGISTRATION
    {
         
        con.Open();

        SqlCommand cmd = new SqlCommand("UpdateMember1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@no", SqlDbType.Int);
       p.Value = no;
        


       // p = cmd.Parameters.Add("@authorised", SqlDbType.Int);
        //p.Value = inf.Authorised;
        

        cmd.ExecuteNonQuery();
        con.Close();



    }
   
    
    
    public Memb_Info ViewMember(int no)
    {
        con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand("ViewMember", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@no", SqlDbType.VarChar, 50);
        p.Value = no ;
        SqlDataReader read = cmd.ExecuteReader();
        Memb_Info info = new Memb_Info();
        if (read.Read())
        {
            info.No=int.Parse(read["no"].ToString());
            info.MemberName =read["nam"].ToString();
            info.Age = int.Parse(read["age"].ToString());
            info.Address = read["address"].ToString();
            info.Password = read["password"].ToString();
            info.E_Mail = read["e_mail"].ToString();
            info.Mobile = read["mobile"].ToString();
            info.Nob = int.Parse(read["nob"].ToString());
            info.Phot = read["phot"].ToString();
            info.Usrname = read["usrname"].ToString();
        }
        
        
        
        
        read.Close();
        con.Close();
        return info;
    }
   
    
    
    
    public DataTable ViewAllMembers()
    {
        SqlDataAdapter da = new SqlDataAdapter("ViewAllMembers", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();

        da.Fill(ds);
        return ds.Tables[0];

    }

    
    //public DataTable ViewLatestMember()
   // {
     //   int id = (GetMaxCode() - 1);

       // ViewMember(id);
                
    
    //}
   
    
    
    public DataView ViewAuthorisedMembers()
    {
        DataView dv = new DataView(ViewAllMembers());
        dv.RowFilter = "authorised=2";
        return dv;
    }
    
    
    
    public DataView ViewOwnerDetailsByNoOfBusses(int no)
    {
        DataView dv = new DataView(ViewAllMembers());
        dv.RowFilter = "nob="+no ;
        return dv;
    }
    


   
        //public DataTable  Show_OwnerDetails()//FOR OWNERS VIEW(GRID)
    //{
    //    //con.Open();

       
    //    SqlDataAdapter da = new SqlDataAdapter("LoadOwnerDetails", con);
    //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
    //    DataSet ds= new DataSet();

    //    da.Fill(ds);
    //    return ds.Tables[0];

    //    //con.Close();

    //    }
    
    
    
    public int GetMaxCode()//FOR PHOTO LOADING
    {
        con.Open();
        string str = "SELECT     MAX(no) + 1 AS id FROM         memb_regn_tab";
        SqlCommand cmd=new SqlCommand(str,con);
        object obj=cmd.ExecuteScalar();
        con.Close();
        if(obj==DBNull.Value){
            return 1;
        }else
        {
            return int.Parse(obj.ToString());

        }
        

    }





    public int Compareusername(string newusrname)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("CompareUserName", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@username", SqlDbType.VarChar);
        p.Value = newusrname;
                
        object ob = new object();
        ob = cmd.ExecuteScalar();
        con.Close();
        if (ob == DBNull.Value)
        {
            return 0;
        }
        else
        { 
            return int.Parse(ob.ToString());        
        }
              
    }




    public Memb_Info logcheck_1(string send_usrname)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("LogCheck_Authorisation", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@username", SqlDbType.VarChar);
        p.Value = send_usrname;
        SqlDataReader read = cmd.ExecuteReader();
        
        Memb_Info inf = new Memb_Info();
        read.Read();
     
        if (read.HasRows)
        {
            
            inf.Password = read["password"].ToString();
            inf.Authorised=int.Parse(read["authorised"].ToString());
            inf.Type = int.Parse(read["type"].ToString());
            inf.MemberName = read["nam"].ToString();
        }
        else
        {
            
            //since no data in dbase
            inf.Authorised = 1000;// reurn these values to show
                // invalid entry,(may be any string,int,int )

        }
        read.Close();
        con.Close();
        return inf;

    }

   // public int logcheck_1(string p)
    //{
     //   throw new Exception("The method or operation is not implemented.");
    //}








    public int return_nob(string recieved_username)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("return_nob", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@usrname", SqlDbType.VarChar);
        p.Value = recieved_username;
        object obj = new object();
        obj = cmd.ExecuteScalar();
        con.Close();
        if (obj == DBNull.Value)
        {
            return 0;
        }
        else
        {
            return int.Parse(obj.ToString());
        }
    }

    public void Delete_Memb(string newusrname)
    {
        con.Open();

        SqlCommand cmd = new SqlCommand("delete_memb", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter p = new SqlParameter();
        p = cmd.Parameters.Add("@username", SqlDbType.VarChar);
        p.Value = newusrname;

        cmd.ExecuteNonQuery();
        con.Close();
    }


}
