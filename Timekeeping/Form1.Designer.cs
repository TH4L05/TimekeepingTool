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
            ListViewItem listViewItem6 = new ListViewItem("1");
            ListViewItem listViewItem7 = new ListViewItem("2");
            ListViewItem listViewItem8 = new ListViewItem("3");
            ListViewItem listViewItem9 = new ListViewItem("4");
            ListViewItem listViewItem10 = new ListViewItem("5");
            ListViewItem listViewItem11 = new ListViewItem("6");
            ListViewItem listViewItem12 = new ListViewItem("7");
            ListViewItem listViewItem13 = new ListViewItem("8");
            ListViewItem listViewItem14 = new ListViewItem("9");
            ListViewItem listViewItem15 = new ListViewItem("10");
            ListViewItem listViewItem16 = new ListViewItem("11");
            ListViewItem listViewItem17 = new ListViewItem("12");
            ListViewItem listViewItem18 = new ListViewItem("13");
            ListViewItem listViewItem19 = new ListViewItem("14");
            ListViewItem listViewItem20 = new ListViewItem("15");
            ListViewItem listViewItem21 = new ListViewItem("16");
            ListViewItem listViewItem22 = new ListViewItem("17");
            ListViewItem listViewItem23 = new ListViewItem("18");
            ListViewItem listViewItem24 = new ListViewItem("19");
            ListViewItem listViewItem25 = new ListViewItem("20");
            ListViewItem listViewItem26 = new ListViewItem("21");
            ListViewItem listViewItem27 = new ListViewItem("22");
            ListViewItem listViewItem28 = new ListViewItem("23");
            ListViewItem listViewItem29 = new ListViewItem("24");
            ListViewItem listViewItem30 = new ListViewItem("25");
            ListViewItem listViewItem31 = new ListViewItem("26");
            ListViewItem listViewItem32 = new ListViewItem("27");
            ListViewItem listViewItem33 = new ListViewItem("28");
            ListViewItem listViewItem34 = new ListViewItem("29");
            ListViewItem listViewItem35 = new ListViewItem("30");
            ListViewItem listViewItem36 = new ListViewItem("31");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            listViewLastFive = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
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
            buttonEditEntry = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(33, 13);
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
            button2.Location = new Point(195, 13);
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
            listViewLastFive.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            listViewLastFive.Location = new Point(33, 63);
            listViewLastFive.Name = "listViewLastFive";
            listViewLastFive.Size = new Size(505, 130);
            listViewLastFive.TabIndex = 2;
            listViewLastFive.UseCompatibleStateImageBehavior = false;
            listViewLastFive.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Weekday";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Time Start";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Time End";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Pause";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "TotalTime";
            columnHeader6.Width = 80;
            // 
            // listViewMonth
            // 
            listViewMonth.Columns.AddRange(new ColumnHeader[] { columnDate, columnWeekday, columnTstart, columnTend, columnTpause, columnTtotal });
            listViewMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewMonth.Items.AddRange(new ListViewItem[] { listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24, listViewItem25, listViewItem26, listViewItem27, listViewItem28, listViewItem29, listViewItem30, listViewItem31, listViewItem32, listViewItem33, listViewItem34, listViewItem35, listViewItem36 });
            listViewMonth.Location = new Point(32, 76);
            listViewMonth.Name = "listViewMonth";
            listViewMonth.Size = new Size(506, 238);
            listViewMonth.TabIndex = 3;
            listViewMonth.UseCompatibleStateImageBehavior = false;
            listViewMonth.View = View.Details;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 90;
            // 
            // columnWeekday
            // 
            columnWeekday.Text = "Weekday";
            columnWeekday.Width = 70;
            // 
            // columnTstart
            // 
            columnTstart.Text = "Time Start";
            columnTstart.Width = 80;
            // 
            // columnTend
            // 
            columnTend.Text = "Time End";
            columnTend.Width = 80;
            // 
            // columnTpause
            // 
            columnTpause.Text = "Pause";
            columnTpause.Width = 80;
            // 
            // columnTtotal
            // 
            columnTtotal.Text = "Time Total";
            columnTtotal.Width = 80;
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
            groupBox1.Controls.Add(buttonEditEntry);
            groupBox1.Controls.Add(comboBoxMonth);
            groupBox1.Controls.Add(comboBoxYear);
            groupBox1.Controls.Add(listViewMonth);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 338);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overview";
            // 
            // buttonEditEntry
            // 
            buttonEditEntry.BackColor = SystemColors.Control;
            buttonEditEntry.Cursor = Cursors.Hand;
            buttonEditEntry.Enabled = false;
            buttonEditEntry.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditEntry.Location = new Point(453, 35);
            buttonEditEntry.Name = "buttonEditEntry";
            buttonEditEntry.Size = new Size(85, 30);
            buttonEditEntry.TabIndex = 6;
            buttonEditEntry.Text = "Edit Entry";
            buttonEditEntry.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewLastFive);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(558, 208);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 591);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(600, 630);
            MinimumSize = new Size(600, 630);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timekeeping";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListView listViewLastFive;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
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
        private GroupBox groupBox2;
        private ColumnHeader columnHeader6;
        private Button buttonEditEntry;
    }
}
