using System;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
using System.Data.OleDb;
using System.Data;

namespace Reflex_Master
{
    public partial class logins : UserControl
    {
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Users.accdb;";
        OleDbConnection connection = new OleDbConnection(connectionString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();	
        string query = "SELECT username, password FROM Users";
        public logins()
        {
            InitializeComponent();
        }


        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
            if (this.ParentForm is Form1 myForm)
            {
                myForm.RegisterEnabled = true;
                myForm.RegisterVisible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;
            
            string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";
    
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", enteredUsername);
                command.Parameters.AddWithValue("@password", enteredPassword);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    if (this.ParentForm is Form1 myForm)
                    {
                        myForm.user = enteredUsername;
                        myForm.loggedin = true;
                        MessageBox.Show("Se ha iniciado sesión exitosamente.");
                        this.Enabled = false;
                        this.Visible = false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se ha podido iniciar sesión.");
                }
            }
        }

    }
}