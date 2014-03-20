using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["personkey"] != null)
        {
            GetCustomerInfo();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }

    private void GetCustomerInfo()
    {
        CommunityAssistEntities ce = new CommunityAssistEntities();
        int pk = (int)Session["personkey"];
        var customer = from c in ce.People
                       where c.PersonKey == pk
                       select new { c.PersonLastName, c.PersonFirstName, c.PersonUsername };

        GridView1.DataSource = customer.ToList();
        GridView1.DataBind();

    }

}