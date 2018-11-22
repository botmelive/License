using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace Licence
{
    public partial class newlicense : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MAIN\SQLEXPRESS;Initial Catalog=License;User ID=sa;Password=hesoyam123"); 

        protected void Page_Load(object sender, EventArgs e)
        {
            // no load for u :(
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string name = namebox.Text;
            string dob = dobbox.Text;
            string address = addressbox.Text;
            string password = passwdbox.Text;
            string phnumber = phnumberbox.Text;
            string branch = DropDownList1.SelectedItem.Text;

            // Looks complicated but is the most s1mple thing I've written.
            password = GetHashString(password);

            System.Diagnostics.Debug.WriteLine(password);
  
            conn.Open();
            string insertQuery = "insert into Applicants(Aname,DOB,PNumber,adress, passwd) values (@name,@dob,@pnumber,@address,@passwd)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@pnumber", phnumber);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@passwd", password);
            cmd.ExecuteNonQuery();

            string LNO = RandomString(8);
            int ano = GetAccountNumber();
            int bno = GetBranchID(branch);

            insertQuery = "INSERT INTO License(Lno, issuedate, Ano, Bno) values(@lno, @issdate, @ano, @bno)";

            SqlCommand cmd2 = new SqlCommand(insertQuery, conn);
            cmd2.Parameters.AddWithValue("@lno", LNO);
            cmd2.Parameters.AddWithValue("@issdate", DateTime.Now);
            cmd2.Parameters.AddWithValue("@ano", ano);
            cmd2.Parameters.AddWithValue("@bno", bno);
            cmd2.ExecuteNonQuery();

            conn.Close();

            Session["user"] = LNO;
            Response.Redirect("profile_page.aspx");


        }
        //SVPGQSW4

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

        private int GetAccountNumber() {
            // pls work
            string q = "SELECT MAX(Ano) FROM Applicants";
            SqlCommand cmd = new SqlCommand(q, conn);
            int id = (int) cmd.ExecuteScalar();
            return id;
        }

        private int GetBranchID(string bname)
        {
            string q = "SELECT Bno FROM Branch WHERE Branch.BName = '" + bname + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            int id = (int)cmd.ExecuteScalar();
            return id;
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}