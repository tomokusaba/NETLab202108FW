using NETLab202108FW.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETLab202108FW
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBAccess access = new DBAccess();
            GridView1.DataSource = access.SelectTable(TextBox1.Text);
            GridView1.DataBind();
        }
    }
}