using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        string s;
        MySqlConnection conn;
        private string username;
        private string password;
        protected void Page_Load(object sender, EventArgs e)
        {

         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            username=TextBox1.Text;
            password = TextBox2.Text;
            using (conn= new MySqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string query = "select exists(select * from patients where AMKA='" + username + "' and safeword='" + password + "');";
                MySqlCommand sql = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = sql.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        if (reader.GetInt32(0) == 1)
                        {
                            Session["AMKA"] = username;
                            Response.Redirect("Services.aspx");
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('The password is incorrect')", true);
                        }
                    } 
                }
                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}