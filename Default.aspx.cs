using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginClass login = new LoginClass(txtPassword.Text, txtUserName.Text);
        int personkey = login.ValidateLogin();
        if (personkey != 0)
        {
            Session["personKey"] = personkey;
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            lblResult.Text = "Invalid Login";
        }
    }
}