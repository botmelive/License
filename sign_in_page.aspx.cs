using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;

namespace Licence
{
    public partial class sign_in_page : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MAIN\SQLEXPRESS;Initial Catalog=License;User ID=sa;Password=hesoyam123");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = namebox.Text;
            string passwd = passwdbox.Text;
            passwd = GetHashString(passwd);

            conn.Open();

            // Ahh the bad way to write a query still exists!
            string checkQuery = "SELECT * FROM License, Applicants WHERE License.Lno = '" + name + "' and Applicants.Ano = License.Ano and Applicants.passwd='"+passwd+"'";
            SqlCommand cmd = new SqlCommand(checkQuery, conn);
            SqlDataReader r = cmd.ExecuteReader();

            bool status = false;
            while (r.Read()) {
                string mname = (string) r.GetValue(1);
                string mpasswd = (string) r.GetValue(10);
                //System.Diagnostics.Debug.WriteLine(mname + mpasswd);
                status = true;
            }
            
            conn.Close();
            if (status)
            {
                Session["user"] = name;

                Response.Redirect("profile_page.aspx");
            }
            else {
                Session["user"] = "failed";
                Response.Redirect("sign_in_page.aspx");
            }

        }

        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();  //or use MD5.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

    }
}