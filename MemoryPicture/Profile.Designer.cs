namespace MemoryPicture
{
    partial class Profile
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
            this.nameplayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lfalse = new System.Windows.Forms.Label();
            this.lpoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameplayer
            // 
            this.nameplayer.BackColor = System.Drawing.Color.Transparent;
            this.nameplayer.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameplayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nameplayer.Location = new System.Drawing.Point(571, 120);
            this.nameplayer.Name = "nameplayer";
            this.nameplayer.Size = new System.Drawing.Size(291, 73);
            this.nameplayer.TabIndex = 0;
            this.nameplayer.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = ":רמה";
            // 
            // levels
            // 
            this.levels.AutoSize = true;
            this.levels.BackColor = System.Drawing.Color.Transparent;
            this.levels.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levels.Location = new System.Drawing.Point(446, 240);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(37, 42);
            this.levels.TabIndex = 2;
            this.levels.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(773, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = ":טעות";
            // 
            // lfalse
            // 
            this.lfalse.AutoSize = true;
            this.lfalse.BackColor = System.Drawing.Color.Transparent;
            this.lfalse.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfalse.Location = new System.Drawing.Point(446, 353);
            this.lfalse.Name = "lfalse";
            this.lfalse.Size = new System.Drawing.Size(37, 42);
            this.lfalse.TabIndex = 5;
            this.lfalse.Text = "1";
            // 
            // lpoints
            // 
            this.lpoints.AutoSize = true;
            this.lpoints.BackColor = System.Drawing.Color.Transparent;
            this.lpoints.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpoints.Location = new System.Drawing.Point(446, 446);
            this.lpoints.Name = "lpoints";
            this.lpoints.Size = new System.Drawing.Size(37, 42);
            this.lpoints.TabIndex = 7;
            this.lpoints.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(754, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = ":נקודות";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lpoints);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lfalse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameplayer);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameplayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lfalse;
        private System.Windows.Forms.Label lpoints;
        private System.Windows.Forms.Label label7;
    }
}