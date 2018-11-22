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
    public partial class renew_page : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MAIN\SQLEXPRESS;Initial Catalog=License;User ID=sa;Password=hesoyam123");
        string LNO = RandomString(7) + "R";
        int AccNO;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Init the page and load all user info else show default values.(non garbage)
            conn.Open();
            string usrid = (string)Session["user"];
            string selectQuery = "SELECT * FROM Applicants, License WHERE Applicants.Ano = License.Ano and License.Lno = '" + usrid + "'";

            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                AccNO = (int) r.GetValue(0);
                NameLabel.Text = (string)r.GetValue(1);
                DOBLabel.Text = r.GetValue(2).ToString();
                
            }
            LicenseLabel.Text = LNO;

            conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string phnumner = phbox.Text;
            string address = addbox.Text;

            conn.Open();

            string update_query = "UPDATE Applicants SET PNumber = @phnumber, adress=@addres WHERE Ano = @ano";
            // Update the Applicants table
            SqlCommand cmd = new SqlCommand(update_query, conn);
            cmd.Parameters.AddWithValue("@phnumber", phnumner);
            cmd.Parameters.AddWithValue("@addres", address);
            cmd.Parameters.AddWithValue("@ano", AccNO);
            cmd.ExecuteNonQuery();

            // Update the License table
            update_query = "UPDATE License SET Lno = @lno, issuedate=@issdate WHERE Ano = @ano";
            cmd = new SqlCommand(update_query, conn);
            cmd.Parameters.AddWithValue("@lno", LNO);
            cmd.Parameters.AddWithValue("@issdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@ano", AccNO);
            cmd.ExecuteNonQuery();

            // Insert into renewal table
            update_query = "INSERT INTO Renewal(renewaldate,Lno) values(@rdate, @lno)";
            cmd = new SqlCommand(update_query, conn);
            cmd.Parameters.AddWithValue("@rdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@lno", LNO);
            cmd.ExecuteNonQuery();

            conn.Close();

            Response.Redirect("profile_page.aspx");
        }

        // Function to generate a psedo-random license number
        // R.N no checks to check if number already exists. lol!
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}