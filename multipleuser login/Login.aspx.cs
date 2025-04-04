using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace multipleuser_login
{
    public partial class Login : System.Web.UI.Page
    {
        concls objcls = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_id)from LoginTab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            string cid = objcls.Fn_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if(cid1==1)
            {
                string str1 = "select Reg_id from LoginTab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string regid = objcls.Fn_Scalar(str1);
                Session["userid"] = regid;

                string str2= "select Log_type from LoginTab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logtype = objcls.Fn_Scalar(str2);

                if(logtype=="admin")
                {
                    Label1.Text = "Admin";
                }
                else if(logtype=="user")
                {
                    Label1.Text = "User";
                }

            }

        }
    }
}