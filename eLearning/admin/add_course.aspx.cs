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
     public partial class add_course : System.Web.UI.Page
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
            }
            if (pdf.FileName.ToString() != "")
            {
                course_name_pdf = Class1.GetRandomPassword(10) + ".pdf";
                path_pdf = "course_pdf/" + course_name_pdf.ToString();
                pdf.SaveAs(Request.PhysicalApplicationPath + "admin/course_pdf/" + course_name_pdf.ToString());
            }
            if (ppt.FileName.ToString() != "")
            {
                course_name_ppt = Class1.GetRandomPassword(10) + ".ppt"; 
                path_ppt = "course_ppt/" + course_name_ppt.ToString();
                ppt.SaveAs(Request.PhysicalApplicationPath + "admin/course_ppt/" + course_name_ppt.ToString());
            }
            if (video.FileName.ToString() != "")
            {
                course_name_video = Class1.GetRandomPassword(10) + ".mp4";               
                path_video = "course_video/" + course_name_video.ToString();
                video.SaveAs(Request.PhysicalApplicationPath + "admin/course_video/" + course_name_video.ToString());
            }
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into courses values('"+coursetitle.Text+"','"+lect.Text+"','"+ content.Text+"','"+ path_img.ToString() +"','"+path_pdf.ToString()+"','"+path_ppt.ToString()+"','"+path_video.ToString()+"')";
            cmd.ExecuteNonQuery();

            msg.Style.Add("display","block");
        }
    }
}