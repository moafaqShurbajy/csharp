using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pro2111.Models;

namespace pro2111
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();

            double salary = Convert.ToDouble(txtSalary.Text);
            double commision = Convert.ToDouble(txtCommission.Text);
            double bonce = Convert.ToDouble(txtBonce.Text);
            double overtime = Convert.ToDouble(txtOvertime.Text);

            lblResult.Text = Convert.ToString(pro.Calc(salary, commision, bonce, overtime));
        }
    }
}