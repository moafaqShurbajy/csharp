using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pro2111.Models;

namespace pro2111
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            lblResult.Text = pro.getFullName(txtfname.Text, txtmname.Text, txtlname.Text);

        }
    }
}