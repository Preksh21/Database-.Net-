using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DbTrial03Nov
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string cnctstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Db1.mdf;Integrated Security=True";



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnctstring);
            con.Open();
            if(con.State == System.Data.ConnectionState.Open)
            {
                string a = "insert into Tb1(Id,fname,lname,contact,email,address)values('" + TextBox6.Text.ToString() + "','" + TextBox1.Text.ToString() + "','" + TextBox2.Text.ToString() + "','" + TextBox3.Text.ToString() + "','" + TextBox4.Text.ToString() + "','" + TextBox5.Text.ToString() + "')";



                SqlCommand cmd = new SqlCommand(a,con);
                cmd.ExecuteNonQuery();
                Response.Write("Connected Successfully");


            }
        }
    }
}