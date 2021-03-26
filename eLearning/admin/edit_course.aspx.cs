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
    public partial class edit_course : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\internship\sannibh Software\Implementation\eLearning\eLearning\App_Data\lms.mdf;Integrated Security=True");
        int id;
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

            id = Convert.ToInt32( Request.QueryString["id"].ToString());

            if (IsPostBack) return;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from courses where id = "+ id +"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                coursetitle.Text = dr["course_name"].ToString();
                lect.Text = dr["course_lecturer"].ToString();
                content.Text = dr["course_content"].ToString();
                courseimage.Text = dr["course_image"].ToString();
                coursepdf.Text = dr["course_pdf"].ToString();
                courseppt.Text = dr["course_ppt"].ToString();
                coursevideo.Text = dr["course_videos"].ToString();

            }
        }
        public class Class1
        {

            public static string GetRandomPassword(int length)
            {
                char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                string password = string.Empty;
                Random random = new Random();

                for (int i = 0; i < length; i++)
                {
                    int x = random.Next(1, chars.Length);
                    //For avoiding Repetation of Characters
                    if (!password.Contains(chars.GetValue(x).ToString()))
                        password += chars.GetValue(x);
                    else
                        i = i - 1;
                }
                return password;
            }

        }

        protected void b1_Click(object sender, EventArgs a)
        {

            string course_name_img = "";
            string course_name_pdf = "";
            string course_name_ppt = "";
            string course_name_video = "";
            string path_img = "";
            string path_pdf = "";
            string path_ppt = "";
            string path_video = "";

            if (img.FileName.ToString() != "")
            {
                course_name_img = Class1.GetRandomPassword(10) + ".jpg";
                img.SaveAs(Request.PhysicalApplicationPath + "admin/course_img/" + course_name_img.ToString());
                path_img = "course_img/" + course_name_img.ToString();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_name ='"+coursetitle.Text + "' course_lecturer ='" + lect.Text + "' course_content ='" + content.Text + "' course_image = " + path_img.ToString() +" where id="+id+"";
                cmd.ExecuteNonQuery();
            }
            if (pdf.FileName.ToString() != "")
            {
                course_name_pdf = Class1.GetRandomPassword(10) + ".pdf";
                path_pdf = "course_pdf/" + course_name_pdf.ToString();
                pdf.SaveAs(Request.PhysicalApplicationPath + "admin/course_pdf/" + course_name_pdf.ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_name ='" + coursetitle.Text + "' course_lecturer ='" + lect.Text + "' course_content ='" + content.Text + "' course_pdf = " + path_pdf.ToString() + " where id=" + id + "";
                cmd.ExecuteNonQuery();
            }
            if (ppt.FileName.ToString() != "")
            {
                course_name_ppt = Class1.GetRandomPassword(10) + ".ppt";
                path_ppt = "course_ppt/" + course_name_ppt.ToString();
                ppt.SaveAs(Request.PhysicalApplicationPath + "admin/course_ppt/" + course_name_ppt.ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_name ='" + coursetitle.Text + "' course_lecturer ='" + lect.Text + "' course_content ='" + content.Text + "' course_ppt = " + path_ppt.ToString() + " where id=" + id + "";
                cmd.ExecuteNonQuery();
            }
            if (video.FileName.ToString() != "")
            {
                course_name_video = Class1.GetRandomPassword(10) + ".mp4";
                path_video = "course_video/" + course_name_video.ToString();
                video.SaveAs(Request.PhysicalApplicationPath + "admin/course_video/" + course_name_video.ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_name ='" + coursetitle.Text + "' course_lecturer ='" + lect.Text + "' course_content ='" + content.Text + "' course_videos = " + path_video.ToString() + " where id=" + id + "";
                cmd.ExecuteNonQuery();
            }
           

            if(img.FileName.ToString()=="" && pdf.FileName.ToString() == "" && ppt.FileName.ToString() == ""  && video.FileName.ToString() == "")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update courses set course_name='"+ coursetitle.Text + "', course_lecturer='" + lect.Text + "',course_content='" + content.Text + "' where id="+id+"";
                cmd.ExecuteNonQuery();
            }

            Response.Redirect("display_all_courses.aspx");
        }
    }
}