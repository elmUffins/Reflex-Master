using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Reflex_Master
{
    public partial class register : UserControl
    {
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Users.accdb;";
        OleDbConnection connection = new OleDbConnection(connectionString);

        public register()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
            if (this.ParentForm is Form1 myForm)
            {
                myForm.LoginEnabled = true;
                myForm.LoginVisible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();

            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;
            
            string checkQuery = "SELECT COUNT(*) FROM [Users] WHERE [username] = @username";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@username", enteredUsername);

                connection.Open();
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Nombre de usuario ya existente. Por favor, utilizar otro.");
                }
                else
                {
                    string insertQuery = "INSERT INTO [Users] ([username], [password]) VALUES (@username, @password);";
                    using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@username", enteredUsername);
                        insertCommand.Parameters.AddWithValue("@password", enteredPassword);

                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Se ha registrado exitosamente. Puede iniciar sesión.");
                    this.Visible = false;
                    this.Enabled = false;
                    if (this.ParentForm is Form1 myForm)
                    {
                        myForm.LoginVisible = true;
                        myForm.LoginEnabled = true;
                    }
                }
            }
        }
    }
}

