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
using System.Collections;
using System.IO;
using System.Drawing;



namespace WebApplication7
{
    public partial class WebForm30 : System.Web.UI.Page
    {
        static int TotalRecords;
        SqlConnection con;
        SqlDataAdapter sqlda;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (true)
            {
                if (RadioButtonList2.SelectedIndex == 0)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Phys";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList1.SelectedIndex == 0)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Sci10";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList2.SelectedIndex == 1)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Chem";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList1.SelectedIndex == 1)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Maths10";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList2.SelectedIndex == 2)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Maths";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList1.SelectedIndex == 2)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Sst10";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList2.SelectedIndex == 3)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Bbio";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList1.SelectedIndex == 3)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Eng10";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList2.SelectedIndex == 4)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Eng";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList1.SelectedIndex == 4)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Comp10";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }
                else if (RadioButtonList2.SelectedIndex == 5)
                {
                    string query = "SELECT COUNT(*) AS TotalRecords FROM Educa";
                    DataTable dt = GetRecords(query);
                    TotalRecords = Convert.ToInt32(dt.Rows[0]["TotalRecords"]);
                }


            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            bool IsInt;
            int RequiredRecords;
            string CSVData, query;
            IsInt = Int32.TryParse(TxtRequiredRecords.Text, out RequiredRecords);
            if (IsInt)
            {

                if (RadioButtonList2.SelectedIndex == 0)
                {
                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Phys)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                }
                else if (RadioButtonList1.SelectedIndex == 0)
                {
                    if (TotalRecords >= RequiredRecords)
                    {

                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Sci10)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }
                if (RadioButtonList2.SelectedIndex == 1)
                {
                    if (TotalRecords >= RequiredRecords)
                    {

                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Chem)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Total Records must be greater than Requried Records.");
                    }
                }
                else if (RadioButtonList1.SelectedIndex == 1)
                {
                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Maths10)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }
                if (RadioButtonList2.SelectedIndex == 2)
                {
                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Maths)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }
                else if (RadioButtonList1.SelectedIndex == 2)
                {

                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Sst10)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }
                if (RadioButtonList2.SelectedIndex == 3)
                {
                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Bio)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }
                else if (RadioButtonList1.SelectedIndex == 3)
                {

                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Eng10)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }

                }

                if (RadioButtonList2.SelectedIndex == 4)
                {

                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Eng)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }
                if (RadioButtonList1.SelectedIndex == 4)
                {

                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Comp10)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }
                if (RadioButtonList2.SelectedIndex == 5)
                {
                    if (TotalRecords >= RequiredRecords)
                    {
                        CSVData = GetRandomNumbersCSV(TotalRecords, RequiredRecords);
                        query = "SELECT Questions FROM (SELECT ROW_NUMBER() OVER(ORDER BY Serial_no) AS RowID,* FROM Educa)TempTable WHERE RowID IN(" + CSVData + ")";
                        dt = GetRecords(query);
                        GvResults.DataSource = dt;
                        GvResults.DataBind();
                    }
                    else
                    {
                        Response.Write("Required Records must be greater than Requried Records.");
                    }
                }




            }
            else
            {
                Response.Write("Invalid Number");
            }

        }
        public ArrayList RandomNumbers(int max)
        {
            ArrayList lstNumbers = new ArrayList();
            Random rndNumber = new Random();
            int number = rndNumber.Next(1, max + 1);
            lstNumbers.Add(number);
            int count = 0;
            do
            {
                number = rndNumber.Next(1, max + 1);
                if (!lstNumbers.Contains(number))
                {
                    lstNumbers.Add(number);
                }
                count++;
            }
            while (count <= 10 * max);
            return lstNumbers;
        }

        public string GetRandomNumbersCSV(int max, int req)
        {
            string CSV = "";
            ArrayList lstNumbers = RandomNumbers(max);
            for (int i = 0; i < req; i++)
                CSV += lstNumbers[i].ToString() + ",";
            CSV = CSV.Remove(CSV.Length - 1);
            return CSV;
        }

        public DataTable GetRecords(string Query)
        {
            con = GetConnection();
            con.Open();
            sqlda = new SqlDataAdapter(Query, con);
            dt = new DataTable();
            sqlda.Fill(dt);
            con.Close();
            return dt;
        }

        public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True");
            return con;
        }


        protected void BtnDisplayRecords_OnClick(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }
    }
}

