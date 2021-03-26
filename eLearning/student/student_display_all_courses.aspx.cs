using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace eLearning.student
{
    public partial class student_display_all_books : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\lms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if (Session["student"] == null)
            {
                Response.Redirect("student_login.aspx");
            }

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from courses";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            r1.DataSource = dt;
            r1.DataBind();


        }
        public string checkvideo(object myvalue, object id)
        {
            if (myvalue == "")
            {
                return "Not Available";
            }
            else
            {
                myvalue = "../admin/" + myvalue.ToString();
                return "<a href='"+myvalue.ToString()+"' style='color:green'>view video</a>";
            }
        }
        public string checkppt(object myvalue1, object id)
        {
            if (myvalue1 == "")
            {
                return "Not Available";
            }
            else
            {
                myvalue1 = "../admin/" + myvalue1.ToString();
                return "<a href='" + myvalue1.ToString() + "' style='color:green'>view ppt</a>";
            }
        }
        public string checkpdf(object myvalue2, object id)
        {
            if (myvalue2 == "")
            {
                return "Not Availabe";
            }
            else
            {
                myvalue2 = "../admin/" + myvalue2.ToString();
                return "<a href='" + myvalue2.ToString() + "' style='color:green'>view pdf</a>";
            }
        }
    }
}