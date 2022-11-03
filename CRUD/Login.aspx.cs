using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = "select count(Username) from crudapp where Username ='" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";
            String c = obj.Fn_ExecuteScalar(str);
            if ( c == "1")
            {
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Label4.Text = " Incorrect Username or Password";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}