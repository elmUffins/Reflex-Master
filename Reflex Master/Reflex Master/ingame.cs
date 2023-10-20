﻿using System;
using System.Windows.Forms;

namespace Reflex_Master
{
    public partial class ingame : UserControl
    {
        public ingame()
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
                myForm.GameEnabled = true;
                myForm.GameVisible = true;
            }
        }
    }
}