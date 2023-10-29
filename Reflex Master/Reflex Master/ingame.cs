using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Reflex_Master
{
    public partial class ingame : UserControl
    {
        SerialPort serialPort;
        Label[] labels; // Array to hold your labels

        int receivedCount = 0;
        double finaltime = 0;

        public ingame()
        {
            InitializeComponent();

            // Initialize your labels array
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
            }
        }

        private void SerialPortErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            // Handle errors (e.g., display an error message)
            MessageBox.Show("Error en la comunicación serie: " + e.EventType);
        }
    }
}
