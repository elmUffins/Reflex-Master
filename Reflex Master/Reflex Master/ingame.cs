using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Reflex_Master
{
    public partial class ingame : UserControl
    {
        SerialPort serialPort;
        int receivedDataCount = 0;
        public ingame()
        {
            InitializeComponent();
            if (this.ParentForm is Form1 myForm)
            {
                if (myForm.gameon == true)
                {
                    serialPort = new SerialPort("COM6", 9600);
                    serialPort.DataReceived += SerialPort_DataReceived; // Add event handler
                    try
                    {
                        serialPort.Open();
                    }
                    catch
                    {
                        MessageBox.Show("No se ha podido establecer una conexión.");
                    }
                }
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Assuming the Arduino sends data as comma-separated values
            string data = serialPort.ReadLine(); // Read a line of data

            if (!string.IsNullOrEmpty(data))
            {
                // Split the received data by commas
                string[] values = data.Split(',');

                if (values.Length == 10 && receivedDataCount < 10)
                {
                    // Display the received numbers in labels
                    // this.Invoke(new Action(() => label1.Text = values[0]));
                    // this.Invoke(new Action(() => label2.Text = values[1]));
                    // Repeat for label3, label4, ..., label10

                    receivedDataCount++;
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
                myForm.gameon = false;
                myForm.GameEnabled = true;
                myForm.GameVisible = true;
            }
        }
    }
}