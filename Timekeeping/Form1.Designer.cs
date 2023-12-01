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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panelAbout = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
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
            panelAbout.SuspendLayout();
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
            listViewMonth.Location = new Point(46, 127);
            listViewMonth.Margin = new Padding(4, 5, 4, 5);
            listViewMonth.MultiSelect = false;
            listViewMonth.Name = "listViewMonth";
            listViewMonth.Size = new Size(707, 388);
            listViewMonth.TabIndex = 3;
            listViewMonth.UseCompatibleStateImageBehavior = false;
            listViewMonth.View = View.Details;
            listViewMonth.DoubleClick += OnOverviewListDoubleClick;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 110;
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
            comboBoxYear.Location = new Point(46, 58);
            comboBoxYear.Margin = new Padding(4, 5, 4, 5);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(171, 36);
            comboBoxYear.TabIndex = 4;
            comboBoxYear.SelectedIndexChanged += OnComboBoxChanged;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FlatStyle = FlatStyle.Flat;
            comboBoxMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMonth.Location = new Point(227, 58);
            comboBoxMonth.Margin = new Padding(4, 5, 4, 5);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(171, 36);
            comboBoxMonth.TabIndex = 5;
            comboBoxMonth.SelectedIndexChanged += OnComboBoxChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxMonth);
            groupBox1.Controls.Add(comboBoxYear);
            groupBox1.Controls.Add(listViewMonth);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 417);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(797, 537);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overview";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(828, 35);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(157, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += OnMenuFileSaveItemClick;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(157, 34);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += OnMenuFileCloseItemClick;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += OnMenuHelpAboutItemClick;
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.SteelBlue;
            panelAbout.BorderStyle = BorderStyle.FixedSingle;
            panelAbout.Controls.Add(label3);
            panelAbout.Controls.Add(label2);
            panelAbout.Controls.Add(label1);
            panelAbout.Controls.Add(button3);
            panelAbout.Location = new Point(250, 333);
            panelAbout.Margin = new Padding(4, 5, 4, 5);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(321, 249);
            panelAbout.TabIndex = 15;
            panelAbout.Visible = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(50, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 65);
            label3.TabIndex = 3;
            label3.Text = "2023\r\n Thomas Krahl";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(47, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 33);
            label2.TabIndex = 2;
            label2.Text = "Version: 1.03";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(47, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 33);
            label1.TabIndex = 1;
            label1.Text = "Timekeeping Tool";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(101, 197);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(116, 45);
            button3.TabIndex = 0;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnAboutPanelCloseCLick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 967);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(828, 32);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(19, 25);
            toolStripStatusLabel1.Text = "-";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(listViewLastFive);
            flowLayoutPanel1.Location = new Point(-1, 45);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(57, 17, 0, 0);
            flowLayoutPanel1.Size = new Size(836, 335);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(61, 22);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(223, 58);
            button1.TabIndex = 0;
            button1.Text = "Day Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += OnTimeStartClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(292, 22);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(223, 58);
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
            listViewLastFive.Location = new Point(61, 90);
            listViewLastFive.Margin = new Padding(4, 5, 4, 5);
            listViewLastFive.MultiSelect = false;
            listViewLastFive.Name = "listViewLastFive";
            listViewLastFive.Size = new Size(709, 214);
            listViewLastFive.TabIndex = 2;
            listViewLastFive.UseCompatibleStateImageBehavior = false;
            listViewLastFive.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 110;
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 999);
            Controls.Add(panelAbout);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimumSize = new Size(850, 1006);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timekeeping";
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelAbout.ResumeLayout(false);
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
        private Panel panelAbout;
        private Label label1;
        private Button button3;
        private Label label3;
        private Label label2;
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
    }
}
