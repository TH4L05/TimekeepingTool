namespace Timekeeping
{
    partial class FormEdit
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 194);
            button1.Name = "button1";
            button1.Size = new Size(117, 30);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnButtonSaveClick;
            // 
            // button2
            // 
            button2.Location = new Point(147, 194);
            button2.Name = "button2";
            button2.Size = new Size(117, 30);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnButtonCloseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Edit Data for \"Date\"";
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(111, 58);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(25, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += OnTextBoxChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 4;
            label2.Text = "StartTime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 88);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 5;
            label3.Text = "EndTime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 117);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 6;
            label4.Text = "PauseTime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 151);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 7;
            label5.Text = "TotalTime";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(140, 60);
            label6.Name = "label6";
            label6.Size = new Size(11, 17);
            label6.TabIndex = 8;
            label6.Text = ":";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 58);
            textBox2.MaxLength = 2;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(25, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = "00";
            textBox2.TextChanged += OnTextBoxChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 88);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(25, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "00";
            textBox3.TextChanged += OnTextBoxChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(140, 90);
            label7.Name = "label7";
            label7.Size = new Size(11, 17);
            label7.TabIndex = 11;
            label7.Text = ":";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(111, 88);
            textBox4.MaxLength = 2;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(25, 23);
            textBox4.TabIndex = 10;
            textBox4.Text = "00";
            textBox4.TextAlign = HorizontalAlignment.Right;
            textBox4.TextChanged += OnTextBoxChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 117);
            textBox5.MaxLength = 2;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(25, 23);
            textBox5.TabIndex = 15;
            textBox5.Text = "00";
            textBox5.TextChanged += OnTextBoxChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(140, 119);
            label8.Name = "label8";
            label8.Size = new Size(11, 17);
            label8.TabIndex = 14;
            label8.Text = ":";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(111, 117);
            textBox6.MaxLength = 2;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(25, 23);
            textBox6.TabIndex = 13;
            textBox6.Text = "00";
            textBox6.TextAlign = HorizontalAlignment.Right;
            textBox6.TextChanged += OnTextBoxChanged;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(152, 146);
            textBox7.MaxLength = 2;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(25, 23);
            textBox7.TabIndex = 18;
            textBox7.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(140, 148);
            label9.Name = "label9";
            label9.Size = new Size(11, 17);
            label9.TabIndex = 17;
            label9.Text = ":";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(111, 146);
            textBox8.MaxLength = 2;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(25, 23);
            textBox8.TabIndex = 16;
            textBox8.Text = "00";
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 239);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEdit";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "EditData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
    }
}