using System;
using System.Windows.Forms;

namespace Reflex_Master
{
    public partial class logout : UserControl
    {
        public logout()
        {
            InitializeComponent();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            if (this.ParentForm is Form1 myForm)
            {
                myForm.loggedin = false;
                this.Enabled = false;
                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
            if (this.ParentForm is Form1 myForm)
            {
                myForm.ChangepassEnabled = true;
                myForm.ChangepassVisible = true;
            }
        }
    }
}