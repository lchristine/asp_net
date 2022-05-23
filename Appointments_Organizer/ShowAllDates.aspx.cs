using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class ShowAllDates : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data;";
        MySqlConnection conn;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "ALL ARRANGED APPOINTMENTS FOR USER:\t" + Session["AMKA"];
            List<string[]> values = new List<string[]>();
            using (conn = new MySqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                query= query = "Select * from dates where patient_amka='" + Session["AMKA"].ToString() + "';";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] v = new string[3] {reader.GetString(0),reader.GetString(2),reader.GetString(3)};
                        values.Add(v);
                    }
                }
            }
            conn.Close();
            foreach(string[] i in values)
            {
                TableCell name = new TableCell();
                TableCell specialty = new TableCell();
                TableCell location = new TableCell();
                TableCell time= new TableCell();
                TableCell date = new TableCell();
                string dname = "";
                string dspecialty = "";
                string dlocation = "";
                query = "select * from doctors where AMKA='" + i[0] + "';";
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dname = reader.GetString(1);
                            dspecialty = reader.GetString(2);
                            dlocation = reader.GetString(4);
                        }
                    }
                }
                name.Text = dname;
                specialty.Text = dspecialty;
                location.Text = dlocation;
                time.Text = i[1];
                string[] var = i[2].Split();
                date.Text = var[0];
                TableRow row = new TableRow();
                row.Cells.Add(name);
                row.Cells.Add(specialty);
                row.Cells.Add(location);
                row.Cells.Add(date);
                row.Cells.Add(time);
                Table1.Rows.Add(row);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Services.aspx");
        }
    }
}