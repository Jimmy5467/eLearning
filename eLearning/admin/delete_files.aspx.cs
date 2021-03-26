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
    public partial class delete_files : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\internship\sannibh Software\Implementation\eLearning\eLearning\App_Data\lms.mdf;Integrated Security=True");

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

            if (Request.QueryString["id"] != null)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_pdf='' where id='"+Request.QueryString["id"].ToString() +"'";
                cmd.ExecuteNonQuery();
            }
            else if(Request.QueryString["id1"] != null) { 
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_ppt='' where id='" + Request.QueryString["id1"].ToString() + "'";
                cmd.ExecuteNonQuery();
            }
            else if (Request.QueryString["id2"] != null)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_videos='' where id='" + Request.QueryString["id2"].ToString() + "'";
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete courses where id='" + Request.QueryString["id3"].ToString() + "'";
                cmd.ExecuteNonQuery();
            }

            Response.Redirect("display_all_courses.aspx");
        }
    }
}