using System.ComponentModel;
using System.Net.Http;

namespace Reflex_Master
{
    partial class game
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nivel2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.besttimelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nivel2
            // 
            this.nivel2.BackColor = System.Drawing.Color.Transparent;
            this.nivel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nivel2.Image = ((System.Drawing.Image)(resources.GetObject("nivel2.Image")));
            this.nivel2.Location = new System.Drawing.Point(545, 400);
            this.nivel2.Name = "nivel2";
            this.nivel2.Size = new System.Drawing.Size(296, 126);
            this.nivel2.TabIndex = 2;
            this.nivel2.UseVisualStyleBackColor = false;
            this.nivel2.Click += new System.EventHandler(this.nivel2_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(15, 19);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(96, 58);
            this.back.TabIndex = 11;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(43, 654);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(1239, 51);
            this.usernamelabel.TabIndex = 12;
            this.usernamelabel.Text = "Usted jugará como:";
            // 
            // besttimelbl
            // 
            this.besttimelbl.BackColor = System.Drawing.SystemColors.Control;
            this.besttimelbl.Enabled = false;
            this.besttimelbl.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.besttimelbl.Location = new System.Drawing.Point(668, 463);
            this.besttimelbl.Name = "besttimelbl";
            this.besttimelbl.Size = new System.Drawing.Size(157, 54);
            this.besttimelbl.TabIndex = 13;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.besttimelbl);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.nivel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "game";
            this.Size = new System.Drawing.Size(1386, 788);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label besttimelbl;

        private System.Windows.Forms.Label usernamelabel;

        private System.Windows.Forms.Button back;

        private System.Windows.Forms.Button nivel2;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}