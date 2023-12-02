namespace Timekeeping
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("1");
            ListViewItem listViewItem2 = new ListViewItem("2");
            ListViewItem listViewItem3 = new ListViewItem("3");
            ListViewItem listViewItem4 = new ListViewItem("4");
            ListViewItem listViewItem5 = new ListViewItem("5");
            ListViewItem listViewItem6 = new ListViewItem("6");
            ListViewItem listViewItem7 = new ListViewItem("7");
            ListViewItem listViewItem8 = new ListViewItem("8");
            ListViewItem listViewItem9 = new ListViewItem("9");
            ListViewItem listViewItem10 = new ListViewItem("10");
            ListViewItem listViewItem11 = new ListViewItem("11");
            ListViewItem listViewItem12 = new ListViewItem("12");
            ListViewItem listViewItem13 = new ListViewItem("13");
            ListViewItem listViewItem14 = new ListViewItem("14");
            ListViewItem listViewItem15 = new ListViewItem("15");
            ListViewItem listViewItem16 = new ListViewItem("16");
            ListViewItem listViewItem17 = new ListViewItem("17");
            ListViewItem listViewItem18 = new ListViewItem("18");
            ListViewItem listViewItem19 = new ListViewItem("19");
            ListViewItem listViewItem20 = new ListViewItem("20");
            ListViewItem listViewItem21 = new ListViewItem("21");
            ListViewItem listViewItem22 = new ListViewItem("22");
            ListViewItem listViewItem23 = new ListViewItem("23");
            ListViewItem listViewItem24 = new ListViewItem("24");
            ListViewItem listViewItem25 = new ListViewItem("25");
            ListViewItem listViewItem26 = new ListViewItem("26");
            ListViewItem listViewItem27 = new ListViewItem("27");
            ListViewItem listViewItem28 = new ListViewItem("28");
            ListViewItem listViewItem29 = new ListViewItem("29");
            ListViewItem listViewItem30 = new ListViewItem("30");
            ListViewItem listViewItem31 = new ListViewItem("31");
            ListViewItem listViewItem32 = new ListViewItem("1");
            ListViewItem listViewItem33 = new ListViewItem("2");
            ListViewItem listViewItem34 = new ListViewItem("3");
            ListViewItem listViewItem35 = new ListViewItem("4");
            ListViewItem listViewItem36 = new ListViewItem("5");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listViewMonth = new ListView();
            columnDate = new ColumnHeader();
            columnWeekday = new ColumnHeader();
            columnTstart = new ColumnHeader();
            columnTend = new ColumnHeader();
            columnTpause = new ColumnHeader();
            columnTtotal = new ColumnHeader();
            comboBoxYear = new ComboBox();
            comboBoxMonth = new ComboBox();
            groupBox1 = new GroupBox();
            labelTotalMonth = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            listViewLastFive = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewMonth
            // 
            listViewMonth.Columns.AddRange(new ColumnHeader[] { columnDate, columnWeekday, columnTstart, columnTend, columnTpause, columnTtotal });
            listViewMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewMonth.GridLines = true;
            listViewMonth.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24, listViewItem25, listViewItem26, listViewItem27, listViewItem28, listViewItem29, listViewItem30, listViewItem31 });
            listViewMonth.Location = new Point(32, 76);
            listViewMonth.MultiSelect = false;
            listViewMonth.Name = "listViewMonth";
            listViewMonth.Size = new Size(638, 234);
            listViewMonth.TabIndex = 3;
            listViewMonth.UseCompatibleStateImageBehavior = false;
            listViewMonth.View = View.Details;
            listViewMonth.DoubleClick += OnOverviewListDoubleClick;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 100;
            // 
            // columnWeekday
            // 
            columnWeekday.Text = "Weekday";
            columnWeekday.TextAlign = HorizontalAlignment.Center;
            columnWeekday.Width = 100;
            // 
            // columnTstart
            // 
            columnTstart.Text = "Time Start";
            columnTstart.TextAlign = HorizontalAlignment.Center;
            columnTstart.Width = 100;
            // 
            // columnTend
            // 
            columnTend.Text = "Time End";
            columnTend.TextAlign = HorizontalAlignment.Center;
            columnTend.Width = 100;
            // 
            // columnTpause
            // 
            columnTpause.Text = "Pause";
            columnTpause.TextAlign = HorizontalAlignment.Center;
            columnTpause.Width = 100;
            // 
            // columnTtotal
            // 
            columnTtotal.Text = "Time Total";
            columnTtotal.TextAlign = HorizontalAlignment.Center;
            columnTtotal.Width = 100;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FlatStyle = FlatStyle.Flat;
            comboBoxYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(32, 35);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(121, 25);
            comboBoxYear.TabIndex = 4;
            comboBoxYear.SelectedIndexChanged += OnComboBoxChanged;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FlatStyle = FlatStyle.Flat;
            comboBoxMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMonth.Location = new Point(159, 35);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(121, 25);
            comboBoxMonth.TabIndex = 5;
            comboBoxMonth.SelectedIndexChanged += OnComboBoxChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTotalMonth);
            groupBox1.Controls.Add(comboBoxMonth);
            groupBox1.Controls.Add(comboBoxYear);
            groupBox1.Controls.Add(listViewMonth);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(701, 322);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overview";
            // 
            // labelTotalMonth
            // 
            labelTotalMonth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotalMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalMonth.ForeColor = Color.SteelBlue;
            labelTotalMonth.Location = new Point(498, 35);
            labelTotalMonth.Name = "labelTotalMonth";
            labelTotalMonth.Size = new Size(172, 26);
            labelTotalMonth.TabIndex = 6;
            labelTotalMonth.Text = "Month Total  (hh:mm): 000:00";
            labelTotalMonth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(724, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += OnMenuFileSaveItemClick;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += OnMenuFileCloseItemClick;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += OnMenuHelpAboutItemClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 579);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(724, 22);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(12, 17);
            toolStripStatusLabel1.Text = "-";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(listViewLastFive);
            flowLayoutPanel1.Location = new Point(-1, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(40, 10, 0, 0);
            flowLayoutPanel1.Size = new Size(726, 202);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(43, 13);
            button1.Name = "button1";
            button1.Size = new Size(156, 35);
            button1.TabIndex = 0;
            button1.Text = "Day Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += OnTimeStartClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(205, 13);
            button2.Name = "button2";
            button2.Size = new Size(156, 35);
            button2.TabIndex = 1;
            button2.Text = "Day End";
            button2.UseVisualStyleBackColor = false;
            button2.Click += OnTimeEndClick;
            // 
            // listViewLastFive
            // 
            listViewLastFive.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewLastFive.GridLines = true;
            listViewLastFive.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewLastFive.Items.AddRange(new ListViewItem[] { listViewItem32, listViewItem33, listViewItem34, listViewItem35, listViewItem36 });
            listViewLastFive.Location = new Point(43, 54);
            listViewLastFive.MultiSelect = false;
            listViewLastFive.Name = "listViewLastFive";
            listViewLastFive.Size = new Size(639, 130);
            listViewLastFive.TabIndex = 2;
            listViewLastFive.UseCompatibleStateImageBehavior = false;
            listViewLastFive.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Weekday";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Time Start";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Time End";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Pause";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "TotalTime";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 601);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(740, 640);
            MinimumSize = new Size(740, 640);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timekeeping";
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewMonth;
        private ColumnHeader columnDate;
        private ColumnHeader columnWeekday;
        private ColumnHeader columnTstart;
        private ColumnHeader columnTend;
        private ColumnHeader columnTpause;
        private ColumnHeader columnTtotal;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxMonth;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private ListView listViewLastFive;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label labelTotalMonth;
    }
}
