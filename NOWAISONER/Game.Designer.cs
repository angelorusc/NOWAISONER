namespace NOWAISONER
{
    partial class Game
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
            this.drawbtn = new System.Windows.Forms.Button();
            this.playersnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cooplist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.defelist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeofplayers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.iter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawbtn
            // 
            this.drawbtn.BackColor = System.Drawing.Color.Yellow;
            this.drawbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drawbtn.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.drawbtn.Location = new System.Drawing.Point(1056, 44);
            this.drawbtn.Name = "drawbtn";
            this.drawbtn.Size = new System.Drawing.Size(129, 70);
            this.drawbtn.TabIndex = 20;
            this.drawbtn.Text = "Draw";
            this.drawbtn.UseVisualStyleBackColor = false;
            this.drawbtn.Click += new System.EventHandler(this.drawbtn_Click);
            // 
            // playersnum
            // 
            this.playersnum.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersnum.Location = new System.Drawing.Point(1143, 263);
            this.playersnum.Name = "playersnum";
            this.playersnum.Size = new System.Drawing.Size(105, 29);
            this.playersnum.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1122, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number of Prisoner";
            // 
            // cooplist
            // 
            this.cooplist.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cooplist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cooplist.Location = new System.Drawing.Point(1066, 331);
            this.cooplist.Name = "cooplist";
            this.cooplist.Size = new System.Drawing.Size(101, 29);
            this.cooplist.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1053, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cooperator List";
            // 
            // defelist
            // 
            this.defelist.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defelist.ForeColor = System.Drawing.Color.Red;
            this.defelist.Location = new System.Drawing.Point(1219, 331);
            this.defelist.Name = "defelist";
            this.defelist.Size = new System.Drawing.Size(100, 29);
            this.defelist.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(1215, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Defector List";
            // 
            // typeofplayers
            // 
            this.typeofplayers.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeofplayers.Location = new System.Drawing.Point(1049, 555);
            this.typeofplayers.Multiline = true;
            this.typeofplayers.Name = "typeofplayers";
            this.typeofplayers.Size = new System.Drawing.Size(285, 167);
            this.typeofplayers.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1114, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Type of Players";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(16, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 1000);
            this.panel1.TabIndex = 36;
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Green;
            this.btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnplay.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnplay.Location = new System.Drawing.Point(1203, 44);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(125, 70);
            this.btnplay.TabIndex = 37;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Crimson;
            this.btnstop.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstop.Location = new System.Drawing.Point(1056, 129);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(278, 73);
            this.btnstop.TabIndex = 38;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = false;
            // 
            // iter
            // 
            this.iter.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iter.Location = new System.Drawing.Point(1170, 404);
            this.iter.Name = "iter";
            this.iter.Size = new System.Drawing.Size(78, 22);
            this.iter.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1102, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Iteration N.";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1346, 1045);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iter);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawbtn);
            this.Controls.Add(this.playersnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeofplayers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.defelist);
            this.Controls.Add(this.cooplist);
            this.Controls.Add(this.label4);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawbtn;
        private System.Windows.Forms.TextBox playersnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cooplist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox defelist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typeofplayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.TextBox iter;
        private System.Windows.Forms.Label label2;
    }
}