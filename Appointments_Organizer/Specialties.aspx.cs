using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class Specialties : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        string s;
        MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListBox1.Items.Clear();
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    string query = "select distinct specialty from doctors;";
                    MySqlCommand sql = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = sql.ExecuteReader())
                    {
                        ListBox1.Items.Add("Any");
                        while (reader.Read())
                        {
                            ListBox1.Items.Add(reader.GetString(0));
                        }

                    }
                    ListBox1.SelectedIndex = 0;
                    conn.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Specialty"] = ListBox1.SelectedValue.ToString();
            // Response.Redirect("Location.aspx");
           // Button1.Text = Session["Specialty"].ToString();
            Response.Redirect("Location.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}