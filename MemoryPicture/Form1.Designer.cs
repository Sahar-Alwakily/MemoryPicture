﻿namespace MemoryPicture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerQut = new System.Windows.Forms.PictureBox();
            this.Q = new System.Windows.Forms.Label();
            this.QBox1 = new System.Windows.Forms.PictureBox();
            this.QBox3 = new System.Windows.Forms.PictureBox();
            this.QBox5 = new System.Windows.Forms.PictureBox();
            this.QBox2 = new System.Windows.Forms.PictureBox();
            this.QBox4 = new System.Windows.Forms.PictureBox();
            this.QBox6 = new System.Windows.Forms.PictureBox();
            this.PICtimer = new System.Windows.Forms.PictureBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.Dice = new System.Windows.Forms.PictureBox();
            this.timerpic = new System.Windows.Forms.Timer(this.components);
            this.leblClick = new System.Windows.Forms.Label();
            this.timerDice = new System.Windows.Forms.Timer(this.components);
            this.Qlabel = new System.Windows.Forms.Label();
            this.choice3 = new System.Windows.Forms.Button();
            this.choice4 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.choice1 = new System.Windows.Forms.Button();
            this.bkgQ = new System.Windows.Forms.PictureBox();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.timerNextQ = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelHQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerQut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICtimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkgQ)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "חזרה";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 625);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1370, 124);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timerQut
            // 
            this.timerQut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timerQut.Image = ((System.Drawing.Image)(resources.GetObject("timerQut.Image")));
            this.timerQut.Location = new System.Drawing.Point(44, 182);
            this.timerQut.Name = "timerQut";
            this.timerQut.Size = new System.Drawing.Size(83, 37);
            this.timerQut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.timerQut.TabIndex = 7;
            this.timerQut.TabStop = false;
            this.timerQut.Visible = false;
            // 
            // Q
            // 
            this.Q.AutoSize = true;
            this.Q.BackColor = System.Drawing.Color.Transparent;
            this.Q.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Q.Location = new System.Drawing.Point(487, 46);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(109, 42);
            this.Q.TabIndex = 8;
            this.Q.Text = "שאלות";
            this.Q.Click += new System.EventHandler(this.label1_Click);
            // 
            // QBox1
            // 
            this.QBox1.BackColor = System.Drawing.Color.Transparent;
            this.QBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QBox1.Image = ((System.Drawing.Image)(resources.GetObject("QBox1.Image")));
            this.QBox1.Location = new System.Drawing.Point(439, 112);
            this.QBox1.Name = "QBox1";
            this.QBox1.Size = new System.Drawing.Size(211, 49);
            this.QBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QBox1.TabIndex = 9;
            this.QBox1.TabStop = false;
            // 
            // QBox3
            // 
            this.QBox3.Image = ((System.Drawing.Image)(resources.GetObject("QBox3.Image")));
            this.QBox3.Location = new System.Drawing.Point(439, 248);
            this.QBox3.Name = "QBox3";
            this.QBox3.Size = new System.Drawing.Size(211, 49);
            this.QBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QBox3.TabIndex = 10;
            this.QBox3.TabStop = false;
            // 
            // QBox5
            // 
            this.QBox5.Image = ((System.Drawing.Image)(resources.GetObject("QBox5.Image")));
            this.QBox5.Location = new System.Drawing.Point(439, 378);
            this.QBox5.Name = "QBox5";
            this.QBox5.Size = new System.Drawing.Size(211, 53);
            this.QBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QBox5.TabIndex = 11;
            this.QBox5.TabStop = false;
            // 
            // QBox2
            // 
            this.QBox2.BackColor = System.Drawing.Color.Transparent;
            this.QBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QBox2.Image = ((System.Drawing.Image)(resources.GetObject("QBox2.Image")));
            this.QBox2.Location = new System.Drawing.Point(439, 182);
            this.QBox2.Name = "QBox2";
            this.QBox2.Size = new System.Drawing.Size(211, 49);
            this.QBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QBox2.TabIndex = 12;
            this.QBox2.TabStop = false;
            // 
            // QBox4
            // 
            this.QBox4.Image = ((System.Drawing.Image)(resources.GetObject("QBox4.Image")));
            this.QBox4.Location = new System.Drawing.Point(439, 310);
            this.QBox4.Name = "QBox4";
            this.QBox4.Size = new System.Drawing.Size(211, 53);
            this.QBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QBox4.TabIndex = 13;
            this.QBox4.TabStop = false;
            // 
            // QBox6
            // 
            this.QBox6.Image = ((System.Drawing.Image)(resources.GetObject("QBox6.Image")));
            this.QBox6.Location = new System.Drawing.Point(439, 448);
            this.QBox6.Name = "QBox6";
            this.QBox6.Size = new System.Drawing.Size(211, 44);
            this.QBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QBox6.TabIndex = 14;
            this.QBox6.TabStop = false;
            // 
            // PICtimer
            // 
            this.PICtimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PICtimer.Image = ((System.Drawing.Image)(resources.GetObject("PICtimer.Image")));
            this.PICtimer.Location = new System.Drawing.Point(894, 540);
            this.PICtimer.Name = "PICtimer";
            this.PICtimer.Size = new System.Drawing.Size(83, 37);
            this.PICtimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICtimer.TabIndex = 15;
            this.PICtimer.TabStop = false;
            this.PICtimer.Visible = false;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(666, 46);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(692, 488);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 16;
            this.picture.TabStop = false;
            // 
            // Dice
            // 
            this.Dice.BackColor = System.Drawing.Color.Transparent;
            this.Dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dice.Image = ((System.Drawing.Image)(resources.GetObject("Dice.Image")));
            this.Dice.Location = new System.Drawing.Point(722, 279);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(84, 84);
            this.Dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice.TabIndex = 17;
            this.Dice.TabStop = false;
            this.Dice.Visible = false;
            this.Dice.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // timerpic
            // 
            this.timerpic.Enabled = true;
            this.timerpic.Interval = 10000;
            this.timerpic.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // leblClick
            // 
            this.leblClick.AutoSize = true;
            this.leblClick.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leblClick.Location = new System.Drawing.Point(704, 258);
            this.leblClick.Name = "leblClick";
            this.leblClick.Size = new System.Drawing.Size(113, 18);
            this.leblClick.TabIndex = 18;
            this.leblClick.Text = "לחץ על הקוביה";
            this.leblClick.Visible = false;
            // 
            // timerDice
            // 
            this.timerDice.Enabled = true;
            this.timerDice.Interval = 3000;
            this.timerDice.Tick += new System.EventHandler(this.timerDice_Tick);
            // 
            // Qlabel
            // 
            this.Qlabel.AutoSize = true;
            this.Qlabel.BackColor = System.Drawing.Color.Maroon;
            this.Qlabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Qlabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qlabel.ForeColor = System.Drawing.Color.White;
            this.Qlabel.Location = new System.Drawing.Point(39, 258);
            this.Qlabel.Name = "Qlabel";
            this.Qlabel.Size = new System.Drawing.Size(19, 25);
            this.Qlabel.TabIndex = 19;
            this.Qlabel.Text = ".";
            // 
            // choice3
            // 
            this.choice3.BackColor = System.Drawing.Color.White;
            this.choice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice3.Location = new System.Drawing.Point(230, 422);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(117, 50);
            this.choice3.TabIndex = 25;
            this.choice3.Text = "button3";
            this.choice3.UseVisualStyleBackColor = false;
            this.choice3.Visible = false;
            this.choice3.Click += new System.EventHandler(this.choice3_Click);
            // 
            // choice4
            // 
            this.choice4.BackColor = System.Drawing.Color.White;
            this.choice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice4.Location = new System.Drawing.Point(56, 422);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(115, 50);
            this.choice4.TabIndex = 26;
            this.choice4.Text = "button4";
            this.choice4.UseVisualStyleBackColor = false;
            this.choice4.Visible = false;
            this.choice4.Click += new System.EventHandler(this.choice4_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.Color.White;
            this.choice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.Location = new System.Drawing.Point(56, 355);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(115, 44);
            this.choice2.TabIndex = 27;
            this.choice2.Text = "button5";
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Visible = false;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.White;
            this.choice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.Location = new System.Drawing.Point(230, 355);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(117, 44);
            this.choice1.TabIndex = 28;
            this.choice1.Text = "button6";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Visible = false;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // bkgQ
            // 
            this.bkgQ.BackColor = System.Drawing.Color.Maroon;
            this.bkgQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bkgQ.Location = new System.Drawing.Point(-17, 141);
            this.bkgQ.Name = "bkgQ";
            this.bkgQ.Size = new System.Drawing.Size(424, 409);
            this.bkgQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bkgQ.TabIndex = 29;
            this.bkgQ.TabStop = false;
            this.bkgQ.Visible = false;
            // 
            // timerQuestion
            // 
            this.timerQuestion.Enabled = true;
            this.timerQuestion.Interval = 10000;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // timerNextQ
            // 
            this.timerNextQ.Tick += new System.EventHandler(this.timerNextQ_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "שאלה הבא";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelHQ
            // 
            this.labelHQ.AutoSize = true;
            this.labelHQ.BackColor = System.Drawing.Color.Maroon;
            this.labelHQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHQ.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHQ.ForeColor = System.Drawing.Color.White;
            this.labelHQ.Location = new System.Drawing.Point(133, 182);
            this.labelHQ.Name = "labelHQ";
            this.labelHQ.Size = new System.Drawing.Size(239, 25);
            this.labelHQ.TabIndex = 32;
            this.labelHQ.Text = "יש לך 10 שניות לענות";
            this.labelHQ.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(983, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 42);
            this.label1.TabIndex = 33;
            this.label1.Text = "זמן הצפייה";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHQ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.Qlabel);
            this.Controls.Add(this.leblClick);
            this.Controls.Add(this.Dice);
            this.Controls.Add(this.PICtimer);
            this.Controls.Add(this.QBox6);
            this.Controls.Add(this.QBox4);
            this.Controls.Add(this.QBox2);
            this.Controls.Add(this.QBox5);
            this.Controls.Add(this.QBox3);
            this.Controls.Add(this.QBox1);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.timerQut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bkgQ);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerQut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICtimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkgQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox timerQut;
        private System.Windows.Forms.Label Q;
        private System.Windows.Forms.PictureBox QBox1;
        private System.Windows.Forms.PictureBox QBox3;
        private System.Windows.Forms.PictureBox QBox5;
        private System.Windows.Forms.PictureBox QBox2;
        private System.Windows.Forms.PictureBox QBox4;
        private System.Windows.Forms.PictureBox QBox6;
        private System.Windows.Forms.PictureBox PICtimer;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox Dice;
        private System.Windows.Forms.Timer timerpic;
        private System.Windows.Forms.Label leblClick;
        private System.Windows.Forms.Label Qlabel;
        private System.Windows.Forms.Button choice3;
        private System.Windows.Forms.Button choice4;
        private System.Windows.Forms.Button choice2;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.PictureBox bkgQ;
        private System.Windows.Forms.Timer timerQuestion;
        private System.Windows.Forms.Timer timerDice;
        private System.Windows.Forms.Timer timerNextQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHQ;
        private System.Windows.Forms.Label label1;
    }
}

