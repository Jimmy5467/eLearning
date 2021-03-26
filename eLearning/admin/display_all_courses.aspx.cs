using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace eLearning.admin
{
    public partial class display_all_courses : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\lms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();


            if (Session["admin"] == null)
            {
                Response.Redirect("login.aspx");
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

        public string checkvideo(object myvalue , object id)
        {
            if (myvalue == "")
            {
                return myvalue.ToString();
            }
            else
            {
                return "<a href='delete_files.aspx?id2="+id+"' style='color:red'>delete video</a>";
            }
        }
        public string checkppt(object myvalue, object id)
        {
            if (myvalue == "")
            {
                return myvalue.ToString();
            }
            else
            {
                return "<a href='delete_files.aspx?id1=" + id + "' style='color:red'>delete ppt</a>";
            }
        }
        public string checkpdf(object myvalue, object id)
        {
            if (myvalue == "")
            {
                return myvalue.ToString();
            }
            else
            {
                return "<a href='delete_files.aspx?id=" + id + "' style='color:red'>delete pdf</a>";
            }
        }
    }
}