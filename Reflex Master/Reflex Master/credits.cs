using System;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;

namespace Reflex_Master
{
    public partial class credits : UserControl
    {
        SoundPlayer click = new SoundPlayer("click.wav");
        public credits()
        {
            InitializeComponent();
        }


        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
        }
    }
}