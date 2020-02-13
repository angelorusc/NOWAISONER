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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.drawbtn = new System.Windows.Forms.Button();
            this.playersnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cooplist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.defelist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.iter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.graphcombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.exgrid = new System.Windows.Forms.Button();
            this.exgraph = new System.Windows.Forms.Button();
            this.settingstxt = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawbtn
            // 
            this.drawbtn.BackColor = System.Drawing.Color.Transparent;
            this.drawbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawbtn.BackgroundImage")));
            this.drawbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawbtn.FlatAppearance.BorderSize = 0;
            this.drawbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.drawbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawbtn.Font = new System.Drawing.Font("OCR A Extended", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawbtn.ForeColor = System.Drawing.Color.Black;
            this.drawbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drawbtn.Location = new System.Drawing.Point(938, 171);
            this.drawbtn.Name = "drawbtn";
            this.drawbtn.Size = new System.Drawing.Size(531, 97);
            this.drawbtn.TabIndex = 20;
            this.drawbtn.Text = "DRAW";
            this.drawbtn.UseVisualStyleBackColor = false;
            this.drawbtn.Click += new System.EventHandler(this.drawbtn_Click);
            // 
            // playersnum
            // 
            this.playersnum.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersnum.Location = new System.Drawing.Point(1175, 573);
            this.playersnum.Name = "playersnum";
            this.playersnum.ReadOnly = true;
            this.playersnum.Size = new System.Drawing.Size(121, 26);
            this.playersnum.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(952, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number of Prisoner:";
            // 
            // cooplist
            // 
            this.cooplist.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cooplist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cooplist.Location = new System.Drawing.Point(963, 654);
            this.cooplist.Name = "cooplist";
            this.cooplist.ReadOnly = true;
            this.cooplist.Size = new System.Drawing.Size(143, 33);
            this.cooplist.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(963, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cooperator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defelist
            // 
            this.defelist.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defelist.ForeColor = System.Drawing.Color.Red;
            this.defelist.Location = new System.Drawing.Point(963, 725);
            this.defelist.Name = "defelist";
            this.defelist.ReadOnly = true;
            this.defelist.Size = new System.Drawing.Size(143, 33);
            this.defelist.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(963, 692);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 34);
            this.label5.TabIndex = 29;
            this.label5.Text = "Defector";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(19, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 900);
            this.panel1.TabIndex = 36;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Transparent;
            this.btnplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnplay.BackgroundImage")));
            this.btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnplay.FlatAppearance.BorderSize = 0;
            this.btnplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.White;
            this.btnplay.Location = new System.Drawing.Point(1210, 273);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(227, 85);
            this.btnplay.TabIndex = 37;
            this.btnplay.Text = "PLAY";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Transparent;
            this.btnstop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstop.BackgroundImage")));
            this.btnstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstop.FlatAppearance.BorderSize = 0;
            this.btnstop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstop.Location = new System.Drawing.Point(971, 273);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(227, 85);
            this.btnstop.TabIndex = 38;
            this.btnstop.Text = "PAUSE";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // iter
            // 
            this.iter.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iter.Location = new System.Drawing.Point(963, 798);
            this.iter.Name = "iter";
            this.iter.ReadOnly = true;
            this.iter.Size = new System.Drawing.Size(143, 28);
            this.iter.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(952, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(807, 116);
            this.label3.TabIndex = 41;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(948, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Instructions: ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(56, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 47);
            this.label8.TabIndex = 43;
            this.label8.Text = "Defector from Defectors";
            // 
            // graphcombo
            // 
            this.graphcombo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphcombo.FormattingEnabled = true;
            this.graphcombo.Items.AddRange(new object[] {
            "Line",
            "Column",
            "Stacked Column"});
            this.graphcombo.Location = new System.Drawing.Point(1539, 570);
            this.graphcombo.Name = "graphcombo";
            this.graphcombo.Size = new System.Drawing.Size(213, 29);
            this.graphcombo.TabIndex = 49;
            this.graphcombo.Text = "Lined";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(1366, 570);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 29);
            this.label12.TabIndex = 50;
            this.label12.Text = "Graph Type:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(963, 776);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Iteration N.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 30;
            chartArea1.Area3DStyle.WallWidth = 2;
            chartArea1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.BorderColor = System.Drawing.Color.Gray;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(952, 600);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.ForestGreen;
            series1.Legend = "Legend1";
            series1.Name = "Cooperators";
            series1.YValuesPerPoint = 4;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.LightCoral;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Defectors";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(799, 328);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Yu Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(1413, 912);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Iterations";
            // 
            // exgrid
            // 
            this.exgrid.BackColor = System.Drawing.Color.Transparent;
            this.exgrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exgrid.BackgroundImage")));
            this.exgrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exgrid.FlatAppearance.BorderSize = 0;
            this.exgrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exgrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exgrid.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exgrid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exgrid.Location = new System.Drawing.Point(1539, 202);
            this.exgrid.Name = "exgrid";
            this.exgrid.Size = new System.Drawing.Size(175, 49);
            this.exgrid.TabIndex = 54;
            this.exgrid.Text = "Export Grid";
            this.exgrid.UseVisualStyleBackColor = false;
            this.exgrid.Click += new System.EventHandler(this.exgrid_Click);
            // 
            // exgraph
            // 
            this.exgraph.BackColor = System.Drawing.Color.Transparent;
            this.exgraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exgraph.BackgroundImage")));
            this.exgraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exgraph.FlatAppearance.BorderSize = 0;
            this.exgraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exgraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exgraph.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exgraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exgraph.Location = new System.Drawing.Point(1539, 263);
            this.exgraph.Name = "exgraph";
            this.exgraph.Size = new System.Drawing.Size(175, 49);
            this.exgraph.TabIndex = 55;
            this.exgraph.Text = "Export Graph";
            this.exgraph.UseVisualStyleBackColor = false;
            this.exgraph.Click += new System.EventHandler(this.exgraph_Click);
            // 
            // settingstxt
            // 
            this.settingstxt.AutoSize = true;
            this.settingstxt.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingstxt.Location = new System.Drawing.Point(16, 931);
            this.settingstxt.Name = "settingstxt";
            this.settingstxt.Size = new System.Drawing.Size(688, 17);
            this.settingstxt.TabIndex = 56;
            this.settingstxt.Text = "Lattice Size =  Neighbours =  Iterations =  Boundaries = Updating = \r\n";
            // 
            // dd
            // 
            this.dd.BackColor = System.Drawing.Color.Red;
            this.dd.Location = new System.Drawing.Point(20, 38);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(30, 30);
            this.dd.TabIndex = 57;
            this.dd.Text = " ";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(20, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 30);
            this.label13.TabIndex = 58;
            this.label13.Text = " ";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(242, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 30);
            this.label15.TabIndex = 59;
            this.label15.Text = " ";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(242, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 30);
            this.label16.TabIndex = 60;
            this.label16.Text = " ";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(56, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 47);
            this.label17.TabIndex = 61;
            this.label17.Text = "Defector from Cooperator";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(278, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 47);
            this.label18.TabIndex = 62;
            this.label18.Text = "Cooperator from Defector";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(278, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(190, 47);
            this.label19.TabIndex = 63;
            this.label19.Text = "Cooperator from Cooperator";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(963, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 148);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legend ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1771, 974);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playersnum);
            this.Controls.Add(this.settingstxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.exgraph);
            this.Controls.Add(this.exgrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.graphcombo);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.iter);
            this.Controls.Add(this.cooplist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.defelist);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawbtn);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.TextBox iter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox graphcombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button exgrid;
        private System.Windows.Forms.Button exgraph;
        private System.Windows.Forms.Label settingstxt;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}