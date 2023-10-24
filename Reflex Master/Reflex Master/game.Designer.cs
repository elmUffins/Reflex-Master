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
            this.nivel1 = new System.Windows.Forms.Button();
            this.nivel2 = new System.Windows.Forms.Button();
            this.nivel3 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
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
            // nivel1
            // 
            this.nivel1.BackColor = System.Drawing.Color.Transparent;
            this.nivel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nivel1.Image = ((System.Drawing.Image)(resources.GetObject("nivel1.Image")));
            this.nivel1.Location = new System.Drawing.Point(121, 400);
            this.nivel1.Name = "nivel1";
            this.nivel1.Size = new System.Drawing.Size(296, 126);
            this.nivel1.TabIndex = 1;
            this.nivel1.UseVisualStyleBackColor = false;
            this.nivel1.Click += new System.EventHandler(this.nivel1_Click);
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
            // nivel3
            // 
            this.nivel3.BackColor = System.Drawing.Color.Transparent;
            this.nivel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nivel3.Image = ((System.Drawing.Image)(resources.GetObject("nivel3.Image")));
            this.nivel3.Location = new System.Drawing.Point(969, 400);
            this.nivel3.Name = "nivel3";
            this.nivel3.Size = new System.Drawing.Size(296, 126);
            this.nivel3.TabIndex = 3;
            this.nivel3.UseVisualStyleBackColor = false;
            this.nivel3.Click += new System.EventHandler(this.nivel3_Click);
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
            this.usernamelabel.Location = new System.Drawing.Point(15, 703);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(1364, 51);
            this.usernamelabel.TabIndex = 12;
            this.usernamelabel.Text = "Usted jugará como:";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.nivel3);
            this.Controls.Add(this.nivel2);
            this.Controls.Add(this.nivel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "game";
            this.Size = new System.Drawing.Size(1386, 788);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label usernamelabel;

        private System.Windows.Forms.Button back;

        private System.Windows.Forms.Button nivel2;
        private System.Windows.Forms.Button nivel3;

        private System.Windows.Forms.Button nivel1;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}