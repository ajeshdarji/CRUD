using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace CRUD
{

    public partial class Register : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String p = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            String str = "insert into crudapp values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + p + "','" + TextBox5.Text + "')";
            int x = obj.Fn_Executenonquery(str);
            if (x != 0)
            {
                Response.Redirect("Login.aspx");
            }

        }
    }
}