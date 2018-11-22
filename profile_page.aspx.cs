using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Licence
{
    public partial class profile_page : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MAIN\SQLEXPRESS;Initial Catalog=License;User ID=sa;Password=hesoyam123");

        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            string usrid = (string) Session["user"];
            string selectQuery = "SELECT * FROM Applicants, License WHERE Applicants.Ano = License.Ano and License.Lno = '"+usrid+"'";

            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) {
                NameLabel.Text = (string)r.GetValue(1);
                DOBLabel.Text = r.GetValue(2).ToString();
                AddressLabel.Text = (string)r.GetValue(4);
                PHLabel.Text = (string)r.GetValue(3);
                IssueDateLabel.Text = r.GetValue(8).ToString();
                LicenseLabel.Text = (string)r.GetValue(7);
            }

            conn.Close();

        }

        private string GetAccountName(string name)
        {
            string q = "SELECT Aname FROM Applicants, License WHERE License.Lno = '"+name+"' and Applicants.Ano = License.Ano";
            SqlCommand cmd = new SqlCommand(q, conn);
            return (string) cmd.ExecuteScalar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("sign_in_page.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("renew_page.aspx");
        }
    }
}