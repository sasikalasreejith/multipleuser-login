using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace multipleuser_login
{
    public partial class adminreg : System.Web.UI.Page
    {
        concls objcls = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_id) from LoginTab";
            string maxregid = objcls.Fn_Scalar(sel);
            int reg_id = 0;
            if(maxregid=="6")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(maxregid);
                reg_id = newregid + 1;
            }

            string ins = "insert into  AdminRegTab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = objcls.Fun_Non_Query(ins);
            if(i==1)
            {
                string inlog = "insert into LoginTab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','admin','active')";
                int j = objcls.Fun_Non_Query(inlog);
            }
        }
    }
}