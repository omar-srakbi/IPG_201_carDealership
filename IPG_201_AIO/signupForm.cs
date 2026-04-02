using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carDealershipProject.datasets;



namespace carDealershipProject
{
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }


        private void saveNewUserButton_Click(object sender, EventArgs e)
        {
            string newEmailInput = emailInput.Text;
            string newUsernameInput = usernameInput.Text;
            string newPasswordInput = passwordInput.Text;
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\datasets\carDealershipDB.mdf;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO login (username, password, email) VALUES (@username, @password, @email)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", newUsernameInput);
                    command.Parameters.AddWithValue("@password", newPasswordInput);
                    command.Parameters.AddWithValue("@email", newEmailInput);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("تم إضافة المستخدم بنجاح.");
                    }
                }
            }
        }
    }
}
