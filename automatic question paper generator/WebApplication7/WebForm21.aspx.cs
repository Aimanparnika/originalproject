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
    public partial class WebForm21 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (RadioButtonList4.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("Insert into Eng10 values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList4.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("Insert into Sst10 values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList4.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("Insert into Maths10 values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList4.SelectedIndex == 3)
            {
                SqlCommand cmd = new SqlCommand("Insert into Sci10 values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList4.SelectedIndex == 4)
            {
                SqlCommand cmd = new SqlCommand("Insert into Comp10 values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList5.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("Insert into Phys values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList5.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("Insert into Chem values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList5.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("Insert into Maths values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList5.SelectedIndex == 3)
            {
                SqlCommand cmd = new SqlCommand("Insert into Bio values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            if (RadioButtonList5.SelectedIndex == 4)
            {
                SqlCommand cmd = new SqlCommand("Insert into Educa values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + RadioButtonList3.SelectedValue + "')");
                cmd.ExecuteNonQuery();

            }
            con.Close();


        }
    }
}