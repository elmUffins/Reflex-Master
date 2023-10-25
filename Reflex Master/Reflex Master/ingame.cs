using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Reflex_Master
{
    public partial class ingame : UserControl
    {
        SerialPort serialPort;
        public ingame()
        {
            InitializeComponent();
            if (this.ParentForm is Form1 myForm)
            {
                if (myForm.gameon == true)
                {
                    serialPort = new SerialPort("COM6", 9600);
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