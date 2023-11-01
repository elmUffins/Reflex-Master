using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;

namespace Reflex_Master
{
    public partial class ingame : UserControl
    {
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Users.accdb;";
        SerialPort serialPort;
        Label[] labels;
        int receivedCount = 0;
        double finaltime = 0;

        public ingame()
        {
            InitializeComponent();

            labels = new Label[10];
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            labels[6] = label7;
            labels[7] = label8;
            labels[8] = label9;
            labels[9] = label10;
        }

        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
            if (this.ParentForm is Form1 myForm)
            {
                myForm.GameEnabled = true;
                myForm.GameVisible = true;
                CloseSerialPort();
            }
        }

        private void CloseSerialPort()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            if (receivedCount < 10)
            {
                this.Invoke(new Action(() => labels[receivedCount].Text = data));
                receivedCount++;
                finaltime += Convert.ToDouble(data);
            }
            else
            {
                CloseSerialPort();
                MessageBox.Show("Su tiempo final es de: " + finaltime + ".");

                if (finaltime > 0)
                {
                    if (this.ParentForm is Form1 myForm && myForm.loggedin)
                    {
                        double besttime = 0;
                        using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            connection.Open();
                            string selectQuery = "SELECT besttime FROM Users WHERE username = @username";
                            using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                            {
                                selectCommand.Parameters.AddWithValue("@username", myForm.user);
                                besttime = Convert.ToDouble(selectCommand.ExecuteScalar());
                            }
                        }

                        if (finaltime < besttime || besttime == 0)
                        {
                            using (OleDbConnection connection = new OleDbConnection(connectionString))
                            {
                                connection.Open();
                                string updateQuery = "UPDATE Users SET besttime = @besttime WHERE username = @username";
                                using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@username", myForm.user);
                                    updateCommand.Parameters.AddWithValue("@besttime", finaltime);
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void SerialPortErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Error en la comunicación serie: " + e.EventType);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                serialPort = new SerialPort("COM6", 9600);
                try
                {
                    serialPort.Open();
                    serialPort.DataReceived += SerialPortDataReceived;
                    serialPort.ErrorReceived += SerialPortErrorReceived;
                }
                catch
                {
                    MessageBox.Show("No se ha podido establecer una conexión.");
                }
            }
            else
            {
                CloseSerialPort();
            }
        }
    }
}
