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
    public partial class issue_course : System.Web.UI.Page
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

            if (IsPostBack) return;

            username.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username from student_registration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                username.Items.Add(dr["username"].ToString());
            }


            
            title.Items.Clear();
            title.Items.Add("Select");
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select course_name from courses";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                title.Items.Add(dr1["course_name"].ToString());
            }


        }
        protected void b1_Click(object sender, EventArgs s)
        {

            if (title.SelectedItem.ToString() == "Select")
            {
                Response.Write("<script>alert('plese select course'); window.location.href=window.location.href</script>");
            }
            else
            {
                // this is for checking student have this books or not
                int found = 0;
                SqlCommand cmd0 = con.CreateCommand();
                cmd0.CommandType = CommandType.Text;
                cmd0.CommandText = "select * from issue_course where student_username='" + username.SelectedItem.ToString() + "' and course_title='" + title.SelectedItem.ToString() + "' and is_course_ended='no'";
                cmd0.ExecuteNonQuery();
                DataTable dt0 = new DataTable();
                SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
                da0.Fill(dt0);
                found = Convert.ToInt32(dt0.Rows.Count.ToString());

                if (found > 0)
                {
                    Response.Write("<script>alert('this course is already available with this student'); </script>");
                }
                else
                {

                        //this is for insert
                        string course_isseue_date = DateTime.Now.ToString("yyyy/MM/dd");
                        string course_return_date = DateTime.Now.AddDays(60).ToString("yyyy/MM/dd");
                        string username_ = "";
                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "select * from student_registration where username='"+username.SelectedItem.ToString()+"'";
                        cmd2.ExecuteNonQuery();
                        DataTable dt2 = new DataTable();
                        SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                        da2.Fill(dt2);
                        foreach (DataRow dr2 in dt2.Rows)
                        {
                            username_ = dr2["username"].ToString();
                        }

                        SqlCommand cmd3 = con.CreateCommand();
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "insert into issue_course values('" + username.SelectedItem.ToString() + "','" + title.SelectedItem.ToString() + "','" + course_isseue_date.ToString() + "','" + course_return_date.ToString() + "','no','no')";
                        cmd3.ExecuteNonQuery();


                        Response.Write("<script>alert('course enrolled successfully'); window.location.href=window.location.href;</script>");
                    
                }
            }
        }

        protected void title_SelectedIndexChanged(object sender, EventArgs e)
        {
            i1.ImageUrl = "";
            un.Text = "";
           
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from courses where course_name='" + title.SelectedItem.ToString() + "'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                i1.ImageUrl = dr2["course_image"].ToString();
                un.Text = dr2["course_name"].ToString();
            }


        }

    }
}