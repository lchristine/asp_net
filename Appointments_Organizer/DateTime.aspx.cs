using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class DateTime : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        MySqlConnection conn;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = Session["Doctor"].ToString();
                for (int i = 5; i < 10; i++)
                {
                    DropDownList1.Items.Add(i.ToString() + ":00");
                    DropDownList1.Items.Add(i.ToString() + ":30");
                    //Button1.Text= Calendar1.SelectedDate.ToString("dd-MM-yyyy");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string time = DropDownList1.SelectedValue;
            string date = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            string[] values = Label1.Text.Split();
            string query = "insert into dates values('" + values[0] + "','" + Session["AMKA"].ToString() + "','" + time + "','" + date + "');";
            using (conn = new MySqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                // Button1.Text = specialty;
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
            Response.Redirect("Services.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Services.aspx");
        }
    }
}