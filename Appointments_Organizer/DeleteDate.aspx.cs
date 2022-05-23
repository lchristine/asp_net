using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        string s;
        MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string amka = Session["AMKA"].ToString();
                Label1.Text = "All dates for:\t" + amka;
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    string query = "select * from dates where patient_amka='" + amka + "';";
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
                string query = "delete from dates where doctor_amka='"+values[0]+ "' and patient_amka='" + values[1] + "' and date_time='" + values[2] + "' and date_date='"+Convert.ToDateTime(values[3]).ToString("yyyy-MM-dd")+"';";
                MySqlCommand sql = new MySqlCommand(query, conn);
                sql.ExecuteNonQuery();
                conn.Close();
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Date deleted successfully')", true);
            Response.Redirect("Services.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Services.aspx");
        }
    }
}