using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            int[] yearlist = new int[115];
            int yr = 1900;
            for (int i = 0; i < yearlist.Length; i++)
            {

                yearlist[i] = yr;
                yr++;
            }
            //ddYear.DataSource = yearlist;
            //ddYear.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {

            CommunityAssistEntities ce = new CommunityAssistEntities();


            Person p = new Person();
            p.PersonFirstName = txtFirstName.Text;
            p.PersonLastName = txtLastName.Text;
            p.PersonUsername = txtEmail.Text;
           
            p.PersonPlainPassword = txtConfirm.Text;

            PasscodeGenerator pg = new PasscodeGenerator();
            int passcode = pg.GetPasscode();
            PasswordHash ph = new PasswordHash();
            p.Personpasskey = passcode;
            p.PersonUserPassword = ph.Hashit(txtConfirm.Text, passcode.ToString());

            ce.People.Add(p);

            //vehicle v = new vehicle();
            //v.LicenseNumber = txtLicense.Text;
            //v.VehicleMake = txtMake.Text;
            //v.VehicleYear = ddYear.SelectedItem.ToString();
            //v.Person = p;
            //ce.vehicles.Add(v);

            //PasscodeGenerator pg = new PasscodeGenerator();
            //int passcode = pg.GetPasscode();


            //PasswordHash ph = new PasswordHash();
            //RegisteredCustomer rc = new RegisteredCustomer();
            //rc.Person = p;
            //rc.Email = txtEmail.Text;
            //rc.CustomerPassCode = passcode;
            //rc.CustomerPassword = txtConfirm.Text;
            //rc.CustomerHashedPassword = ph.Hashit(txtConfirm.Text, passcode.ToString());


            //ce.Person.Add(p);
            ce.SaveChanges();
            Response.Redirect("Welcome.aspx");

        }
        catch (Exception ex)
        {
            lblResult.Text = ex.Message;
        }



    }
}