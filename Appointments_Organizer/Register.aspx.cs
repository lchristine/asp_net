using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointments_Organizer
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=user_data";
        MySqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender,EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text) || String.IsNullOrEmpty(TextBox3.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('All fields must me filled')", true);
            }
            else
            {
                if (!TextBox2.Text.Equals(TextBox3.Text))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('The two passwords do not match')", true);
                }
                else
                {
                    string username = TextBox1.Text;
                    Boolean isFound = false;
                    using (conn = new MySqlConnection())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        string query = "select exists(select * from patients where AMKA='" + username + "');";
                        MySqlCommand sql = new MySqlCommand(query, conn);
                        using (MySqlDataReader reader = sql.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) == 1)
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('The user is already registered')", true);
                                    isFound = true;
                                }
                                else
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('New user created')", true);

                                }
                            }

                        }
                        if (isFound == false)
                        {
                            query = "insert into patients values('" + username + "','" + TextBox2.Text + "');";
                            sql = new MySqlCommand(query, conn);
                            sql.ExecuteNonQuery();
                            Response.Redirect("Login.aspx");
                        }
                        conn.Close();
                    }
                }
            }
        }
    }
}