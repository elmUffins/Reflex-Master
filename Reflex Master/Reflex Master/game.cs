﻿using System;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;

namespace Reflex_Master
{
    public partial class game : UserControl
    {
        public game()
        {
            InitializeComponent();
        }

        
        
        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
        }

        private void nivel1_Click(object sender, EventArgs e)
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

        private void nivel3_Click(object sender, EventArgs e)
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