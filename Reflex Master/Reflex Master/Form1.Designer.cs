namespace Reflex_Master
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.logins1 = new Reflex_Master.logins();
            this.credits1 = new Reflex_Master.credits();
            this.game1 = new Reflex_Master.game();
            this.config1 = new Reflex_Master.config();
            this.ingame1 = new Reflex_Master.ingame();
            this.register1 = new Reflex_Master.register();
            this.usernamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(508, 339);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(369, 144);
            this.play.TabIndex = 1;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.options.Image = ((System.Drawing.Image)(resources.GetObject("options.Image")));
            this.options.Location = new System.Drawing.Point(563, 507);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(260, 45);
            this.options.TabIndex = 2;
            this.options.UseVisualStyleBackColor = false;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.Transparent;
            this.credits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.credits.Image = ((System.Drawing.Image)(resources.GetObject("credits.Image")));
            this.credits.Location = new System.Drawing.Point(563, 584);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(260, 45);
            this.credits.TabIndex = 3;
            this.credits.UseVisualStyleBackColor = false;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1237, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 105);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(563, 657);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(260, 45);
            this.exit.TabIndex = 6;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // logins1
            // 
            this.logins1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logins1.BackgroundImage")));
            this.logins1.Enabled = false;
            this.logins1.Location = new System.Drawing.Point(0, 35);
            this.logins1.Name = "logins1";
            this.logins1.Size = new System.Drawing.Size(1187, 713);
            this.logins1.TabIndex = 7;
            this.logins1.Visible = false;
            // 
            // credits1
            // 
            this.credits1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credits1.BackgroundImage")));
            this.credits1.Enabled = false;
            this.credits1.Location = new System.Drawing.Point(0, 90);
            this.credits1.Name = "credits1";
            this.credits1.Size = new System.Drawing.Size(1187, 657);
            this.credits1.TabIndex = 8;
            this.credits1.Visible = false;
            // 
            // game1
            // 
            this.game1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game1.BackgroundImage")));
            this.game1.Enabled = false;
            this.game1.Location = new System.Drawing.Point(1, 115);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(1177, 632);
            this.game1.TabIndex = 9;
            this.game1.Visible = false;
            // 
            // config1
            // 
            this.config1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("config1.BackgroundImage")));
            this.config1.Enabled = false;
            this.config1.Location = new System.Drawing.Point(1, 163);
            this.config1.Name = "config1";
            this.config1.Size = new System.Drawing.Size(1153, 584);
            this.config1.TabIndex = 10;
            this.config1.Visible = false;
            // 
            // ingame1
            // 
            this.ingame1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingame1.BackgroundImage")));
            this.ingame1.Enabled = false;
            this.ingame1.Location = new System.Drawing.Point(0, 172);
            this.ingame1.Name = "ingame1";
            this.ingame1.Size = new System.Drawing.Size(1129, 576);
            this.ingame1.TabIndex = 11;
            this.ingame1.Visible = false;
            // 
            // register1
            // 
            this.register1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("register1.BackgroundImage")));
            this.register1.Enabled = false;
            this.register1.Location = new System.Drawing.Point(2, 172);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(1110, 575);
            this.register1.TabIndex = 12;
            this.register1.Visible = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(1220, 116);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(149, 28);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Guest";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.ingame1);
            this.Controls.Add(this.config1);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.credits1);
            this.Controls.Add(this.logins1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.options);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label usernamelabel;

        private Reflex_Master.register register1;

        private Reflex_Master.ingame ingame1;

        private Reflex_Master.config config1;

        private Reflex_Master.game game1;

        private Reflex_Master.credits credits1;

        private Reflex_Master.logins logins1;

        private System.Windows.Forms.Button exit;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button credits;

        private System.Windows.Forms.Button options;

        private System.Windows.Forms.Button play;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}