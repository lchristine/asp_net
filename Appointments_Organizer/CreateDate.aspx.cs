using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class CreateDate : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        MySqlConnection conn;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string specialty = Session["Specialty"].ToString();
                string location = Session["Location"].ToString();
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    if (specialty.Equals("Any"))
                    {
                        query = "select * from doctors ;";
                    }
                    else
                    {
                        query = "select * from doctors where specialty='" + specialty + "' and location='"+location+"';";
                    }
                    MySqlCommand sql = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = sql.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListBox1.Items.Add(reader.GetString(0)+ Server.HtmlDecode("&nbsp;&nbsp;&nbsp;&nbsp;") + reader.GetString(1)+ Server.HtmlDecode("&nbsp;&nbsp;&nbsp;&nbsp;") 
                                + reader.GetString(2)+ Server.HtmlDecode("&nbsp;&nbsp;&nbsp;&nbsp;") + reader.GetString(3)+ Server.HtmlDecode("&nbsp;&nbsp;") + reader.GetString(4));
                        }

                    }
                    conn.Close();
                }
                ListBox1.SelectedIndex = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Doctor"] = ListBox1.Text;
            Response.Redirect("DateTime.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Services.aspx");
        }
    }
}