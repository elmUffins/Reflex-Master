using System;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;

namespace Reflex_Master
{
    public partial class config : UserControl
    {
        public config()
        {
            InitializeComponent();
        }

        private void config_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Enabled = false;
            this.Visible = false;
        }

        private void menuvolume_Scroll(object sender, ScrollEventArgs e)
        {
            float volume = menuvolume.Value / 100.0f;
            if (this.ParentForm is Form1 form)
            {
                form.SetSoundVolume(volume);
            }
        }

        private void musicbar_Scroll(object sender, ScrollEventArgs e)
        {
            float volume = musicbar.Value / 100.0f;
            if (this.ParentForm is Form1 form)
            {
                form.SetMusicVolume(volume);
            }
        }
    }
}