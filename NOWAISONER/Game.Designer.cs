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
            this.SuspendLayout();
            // 
            // drawbtn
            // 
            this.drawbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawbtn.Location = new System.Drawing.Point(766, 30);
            this.drawbtn.Name = "drawbtn";
            this.drawbtn.Size = new System.Drawing.Size(84, 48);
            this.drawbtn.TabIndex = 20;
            this.drawbtn.Text = "Draw";
            this.drawbtn.UseVisualStyleBackColor = true;
            this.drawbtn.Click += new System.EventHandler(this.drawbtn_Click);
            // 
            // playersnum
            // 
            this.playersnum.Location = new System.Drawing.Point(812, 109);
            this.playersnum.Name = "playersnum";
            this.playersnum.Size = new System.Drawing.Size(94, 20);
            this.playersnum.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(809, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number of Prisoner";
            // 
            // cooplist
            // 
            this.cooplist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cooplist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cooplist.Location = new System.Drawing.Point(783, 162);
            this.cooplist.Name = "cooplist";
            this.cooplist.Size = new System.Drawing.Size(67, 26);
            this.cooplist.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(780, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cooperator List";
            // 
            // defelist
            // 
            this.defelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defelist.ForeColor = System.Drawing.Color.Red;
            this.defelist.Location = new System.Drawing.Point(876, 162);
            this.defelist.Name = "defelist";
            this.defelist.Size = new System.Drawing.Size(67, 26);
            this.defelist.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(873, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Defector List";
            // 
            // typeofplayers
            // 
            this.typeofplayers.Location = new System.Drawing.Point(770, 298);
            this.typeofplayers.Multiline = true;
            this.typeofplayers.Name = "typeofplayers";
            this.typeofplayers.Size = new System.Drawing.Size(180, 107);
            this.typeofplayers.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(811, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Type of Players";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(16, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 726);
            this.panel1.TabIndex = 36;
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Beige;
            this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Location = new System.Drawing.Point(866, 30);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(84, 48);
            this.btnplay.TabIndex = 37;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(962, 775);
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
    }
}