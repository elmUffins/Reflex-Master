using System.Windows.Forms;
using System;
using System.Data.OleDb;
using System.Data;

namespace Reflex_Master
{
    public partial class cambiarpass : UserControl
    {
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Users.accdb;";
        OleDbConnection connection = new OleDbConnection(connectionString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();	
        string query = "SELECT username, password FROM Users";
        public cambiarpass()
        {
            InitializeComponent();
        }

    private void button1_Click(object sender, EventArgs e)
    {
        AudioHelper.PlayClickSound();

        string enteredUsername = textBox1.Text;
        string enteredPassword = textBox2.Text;
        string newPassword = textBox3.Text;

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM [Users] WHERE [username] = @username AND [password] = @password";
            using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@username", enteredUsername);
                selectCommand.Parameters.AddWithValue("@password", enteredPassword);

                int count = (int)selectCommand.ExecuteScalar();
                
                if (count > 0)
                {
                    try
                    {
                        string updateQuery = "UPDATE [Users] SET [password] = '" + newPassword +
                                             "' WHERE [username] = '" + enteredUsername + "'";
                        OleDbCommand cmd = new OleDbCommand(updateQuery, connection);
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        
                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("La contraseña ha sido cambiada exitosamente.");
                            this.Enabled = false;
                            this.Visible = false;
                            if (this.ParentForm is Form1 myForm)
                            {
                                myForm.loggedin = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(Convert.ToString(rowsUpdated));
                            MessageBox.Show(enteredUsername);
                            MessageBox.Show(enteredPassword);
                            MessageBox.Show(newPassword);
                            MessageBox.Show("No se pudo cambiar la contraseña. Por favor, inténtelo de nuevo.");
                        }

                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show((exp.ToString()));
                    }

                }
                else
                {
                    MessageBox.Show("La combinación de nombre de usuario y contraseña actual no es válida.");
                }
            }
        }
    }


        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
            if (this.ParentForm is Form1 myForm)
            {
                myForm.LogoutEnabled = true;
                myForm.LogoutVisible = true;
            }
        }
    }
}