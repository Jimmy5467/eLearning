using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace eLearning.student
{
    public partial class my_enrolled_courses : System.Web.UI.Page
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


            DataTable dt = new DataTable();
            dt.Columns.Add("student_username");
            dt.Columns.Add("course_title");
            dt.Columns.Add("course_start");
            dt.Columns.Add("course_end_date");
            dt.Columns.Add("is_course_ended");
            dt.Columns.Add("course_ended");


            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select * from issue_course";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach(DataRow dr1 in dt1.Rows)
            {

            }

        }
    }
}