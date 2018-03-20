using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication7
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string s = "select Username,Password from Register where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(s,con);
            con.Open();
            SqlDataReader rs;
            rs = cmd.ExecuteReader();
            if (rs.Read())
            {
                Response.Redirect("WebForm20.aspx");
            }
            else
            {
                Label1.Text = "Wrong username or Password";
            }
            con.Close();
        }
            
        }
    }
