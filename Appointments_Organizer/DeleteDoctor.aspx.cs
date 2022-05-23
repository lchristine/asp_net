using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    string query = "select * from doctors";
                    MySqlCommand sql = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = sql.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListBox1.Items.Add(reader.GetString(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t" + reader.GetString(3));
                        }
                    }
                    conn.Close();
                }
                ListBox1.SelectedIndex = -1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string date = ListBox1.SelectedValue;
            using (conn = new MySqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string[] values = date.Split();
                string query = "delete from doctors where AMKA='" + values[0] +"';";
                MySqlCommand sql = new MySqlCommand(query, conn);
                sql.ExecuteNonQuery();
                conn.Close();
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Date deleted successfully')", true);
            Response.Redirect("Administration.aspx");
        }
    }
}