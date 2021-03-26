using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eLearning.student
{
    public partial class student_logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("student_login.aspx");

            if (Session["student"] == null)
            {
                Response.Redirect("student_login.aspx");
            }
        }
    }
}