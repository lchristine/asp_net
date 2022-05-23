using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class Location : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        MySqlConnection conn;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string specialty = Session["Specialty"].ToString();
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                   // Button1.Text = specialty;
                    if (specialty.Equals("Any"))
                    {
                        query = "select distinct location from doctors ;";
                    }
                    else
                    {
                        query = "select distinct location from doctors where specialty='" + specialty + "';";
                    }
                    MySqlCommand sql = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = sql.ExecuteReader())
                    {
                        ListBox1.Items.Add("Any");
                        while (reader.Read())
                        {
                            ListBox1.Items.Add(reader.GetString(0));
                        }

                    }
                    conn.Close();
                }
                ListBox1.SelectedIndex = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Location"] = ListBox1.SelectedValue;
            //Button1.Text = Session["Location"].ToString() + Session["Specialty"].ToString() + Session["AMKA"];
            Response.Redirect("CreateDate.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Services.aspx");
        }
    }
}