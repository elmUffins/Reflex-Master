using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
using System.Data.OleDb;
using System.Data;
using System.Globalization;

namespace Reflex_Master
{
    public partial class game : UserControl
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Users.accdb";
        public game()
        {
            InitializeComponent();
            besttimelbl.BackColor = Color.FromArgb(255, 199, 211, 236);
            besttimelbl.ForeColor = Color.FromArgb(255, 0, 0, 0);

        }

        public string LabelText
        {
            get { return usernamelabel.Text; }
            set { usernamelabel.Text = value; }
        }

        public string BestText
        {
            get { return besttimelbl.Text; }
            set { besttimelbl.Text = value; }
        }

        public void DisplayBestTime()
        {
            double bestTime = 0;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT besttime FROM Users WHERE username = @username";
                using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                {
                    if (this.ParentForm is Form1 myForm)
                    {
                        selectCommand.Parameters.AddWithValue("@username", myForm.user);
                        bestTime = Convert.ToDouble(selectCommand.ExecuteScalar());
                    }
                    
                }
            }

            if (bestTime > 0)
            {
                besttimelbl.Text = bestTime.ToString(CultureInfo.InvariantCulture); 
            }
            else
            {
                besttimelbl.Text = "No hay";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
        }

        private void nivel2_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
            if (this.ParentForm is Form1 myForm)
            {
                myForm.IngameEnabled = true;
                myForm.IngameVisible = true;
            }
        }
    }
}

