namespace MemoryPicture
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxuserlog = new System.Windows.Forms.TextBox();
            this.textBoxpasslog = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.usernamelog = new System.Windows.Forms.Label();
            this.passlog = new System.Windows.Forms.Label();
            this.nameup = new System.Windows.Forms.Label();
            this.usernameup = new System.Windows.Forms.Label();
            this.sigupbtn = new System.Windows.Forms.Button();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.boxusername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passup = new System.Windows.Forms.Label();
            this.textBoxpassup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 120);
            this.button1.TabIndex = 0;
            this.button1.Text = "כניסה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(126, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 120);
            this.button2.TabIndex = 1;
            this.button2.Text = "הרשמה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(126, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 120);
            this.button3.TabIndex = 2;
            this.button3.Text = "בלי הרשמה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(844, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "יצאה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxuserlog
            // 
            this.textBoxuserlog.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxuserlog.Location = new System.Drawing.Point(416, 158);
            this.textBoxuserlog.Name = "textBoxuserlog";
            this.textBoxuserlog.Size = new System.Drawing.Size(165, 36);
            this.textBoxuserlog.TabIndex = 5;
            this.textBoxuserlog.Visible = false;
            // 
            // textBoxpasslog
            // 
            this.textBoxpasslog.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpasslog.Location = new System.Drawing.Point(416, 225);
            this.textBoxpasslog.Name = "textBoxpasslog";
            this.textBoxpasslog.Size = new System.Drawing.Size(165, 36);
            this.textBoxpasslog.TabIndex = 6;
            this.textBoxpasslog.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(422, 278);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(159, 52);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "כניסה";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Visible = false;
//            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // usernamelog
            // 
            this.usernamelog.AutoSize = true;
            this.usernamelog.BackColor = System.Drawing.Color.Transparent;
            this.usernamelog.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelog.Location = new System.Drawing.Point(600, 158);
            this.usernamelog.Name = "usernamelog";
            this.usernamelog.Size = new System.Drawing.Size(137, 25);
            this.usernamelog.TabIndex = 8;
            this.usernamelog.Text = "שם משתמש";
            this.usernamelog.Visible = false;
            // 
            // passlog
            // 
            this.passlog.AutoSize = true;
            this.passlog.BackColor = System.Drawing.Color.Transparent;
            this.passlog.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlog.Location = new System.Drawing.Point(600, 225);
            this.passlog.Name = "passlog";
            this.passlog.Size = new System.Drawing.Size(85, 25);
            this.passlog.TabIndex = 9;
            this.passlog.Text = "סיסמה";
            this.passlog.Visible = false;
            this.passlog.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameup
            // 
            this.nameup.AutoSize = true;
            this.nameup.BackColor = System.Drawing.Color.Transparent;
            this.nameup.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameup.Location = new System.Drawing.Point(600, 404);
            this.nameup.Name = "nameup";
            this.nameup.Size = new System.Drawing.Size(46, 25);
            this.nameup.TabIndex = 14;
            this.nameup.Text = "שם";
            this.nameup.Visible = false;
            // 
            // usernameup
            // 
            this.usernameup.AutoSize = true;
            this.usernameup.BackColor = System.Drawing.Color.Transparent;
            this.usernameup.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameup.Location = new System.Drawing.Point(600, 337);
            this.usernameup.Name = "usernameup";
            this.usernameup.Size = new System.Drawing.Size(137, 25);
            this.usernameup.TabIndex = 13;
            this.usernameup.Text = "שם משתמש";
            this.usernameup.Visible = false;
            // 
            // sigupbtn
            // 
            this.sigupbtn.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigupbtn.Location = new System.Drawing.Point(416, 539);
            this.sigupbtn.Name = "sigupbtn";
            this.sigupbtn.Size = new System.Drawing.Size(159, 52);
            this.sigupbtn.TabIndex = 12;
            this.sigupbtn.Text = "הרשמה";
            this.sigupbtn.UseVisualStyleBackColor = true;
            this.sigupbtn.Visible = false;
       //     this.sigupbtn.Click += new System.EventHandler(this.sigupbtn_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(416, 404);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(165, 36);
            this.textBoxname.TabIndex = 11;
            this.textBoxname.Visible = false;
            // 
            // boxusername
            // 
            this.boxusername.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxusername.Location = new System.Drawing.Point(416, 337);
            this.boxusername.Name = "boxusername";
            this.boxusername.Size = new System.Drawing.Size(165, 36);
            this.boxusername.TabIndex = 10;
            this.boxusername.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(817, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(541, 569);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // passup
            // 
            this.passup.AutoSize = true;
            this.passup.BackColor = System.Drawing.Color.Transparent;
            this.passup.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passup.Location = new System.Drawing.Point(600, 475);
            this.passup.Name = "passup";
            this.passup.Size = new System.Drawing.Size(85, 25);
            this.passup.TabIndex = 17;
            this.passup.Text = "סיסמה";
            this.passup.Visible = false;
            // 
            // textBoxpassup
            // 
            this.textBoxpassup.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassup.Location = new System.Drawing.Point(416, 475);
            this.textBoxpassup.Name = "textBoxpassup";
            this.textBoxpassup.Size = new System.Drawing.Size(165, 36);
            this.textBoxpassup.TabIndex = 16;
            this.textBoxpassup.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.passup);
            this.Controls.Add(this.textBoxpassup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nameup);
            this.Controls.Add(this.usernameup);
            this.Controls.Add(this.sigupbtn);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.boxusername);
            this.Controls.Add(this.passlog);
            this.Controls.Add(this.usernamelog);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textBoxpasslog);
            this.Controls.Add(this.textBoxuserlog);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxuserlog;
        private System.Windows.Forms.TextBox textBoxpasslog;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label usernamelog;
        private System.Windows.Forms.Label passlog;
        private System.Windows.Forms.Label nameup;
        private System.Windows.Forms.Label usernameup;
        private System.Windows.Forms.Button sigupbtn;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox boxusername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label passup;
        private System.Windows.Forms.TextBox textBoxpassup;
    }
}