using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
using System.Data.OleDb;

namespace Reflex_Master

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            game1.LabelText = "Usted jugará como: " + user;
            
        }
        public void UpdateGameLabel(string labelText)
        {
            game1.LabelText = labelText;
        }
        
        

        

        public string user = "Invitado";

        public bool loggedin = false;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            AudioHelper.InitializeMusic("menumusic.wav");
            AudioHelper.InitializeClickSound("click.wav");
            AudioHelper.PlayMusic();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (loggedin == false)
            {
                AudioHelper.PlayClickSound();
                logins1.Enabled = true;
                logins1.Visible = true;
            }
            else
            {
                AudioHelper.PlayClickSound();
                logout1.Enabled = true;
                logout1.Visible = true;
            }
            
        }

        private void credits_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            credits1.Enabled = true;
            credits1.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            this.Close();
        }

        private void options_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            config1.Enabled = true;
            config1.Visible = true;
        }

        private void play_Click(object sender, EventArgs e)
        {
            AudioHelper.PlayClickSound();
            game1.Enabled = true;
            game1.Visible = true;
            game1.DisplayBestTime();
            if (game1.Enabled == true && loggedin == false)
            {
                game1.LabelText = "Usted jugará como: Invitado";
                game1.BestText = "No hay";
            }
            
        }

        public void SetMusicVolume(float volume)
        {
            AudioHelper.SetMusicVolume(volume);
        }

        public void SetSoundVolume(float volume)
        {
            AudioHelper.SetClickSoundVolume(volume);
        }

        public bool IngameEnabled
        {
            get => ingame1.Enabled;
            set => ingame1.Enabled = value;
        }

        public bool IngameVisible
        {
            get => ingame1.Visible;
            set => ingame1.Visible = value;
        }
        
        public bool GameEnabled
        {
            get => game1.Enabled;
            set => game1.Enabled = value;
        }

        public bool GameVisible
        {
            get => game1.Visible;
            set => game1.Visible = value;
        }
        
        public bool RegisterEnabled
        {
            get => register1.Enabled;
            set => register1.Enabled = value;
        }

        public bool RegisterVisible
        {
            get => register1.Visible;
            set => register1.Visible = value;
        }
        
        public bool LoginEnabled
        {
            get => logins1.Enabled;
            set => logins1.Enabled = value;
        }
        
        public bool LoginVisible
        {
            get => logins1.Visible;
            set => logins1.Visible = value;
        }

        public bool ChangepassVisible
        {
            get => cambiarpass1.Visible;
            set => cambiarpass1.Visible = value;
        }
        
        public bool ChangepassEnabled
        {
            get => cambiarpass1.Enabled;
            set => cambiarpass1.Enabled = value;
        }

        

        
    }
}