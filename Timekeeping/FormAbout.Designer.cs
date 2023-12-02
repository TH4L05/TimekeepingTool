namespace Timekeeping
{
    partial class FormAbout
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
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(67, 114);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 17);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.github.com/th4l05";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.Click += OnAboutPanelLinkLabelClick;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(53, 71);
            label3.Name = "label3";
            label3.Size = new Size(172, 43);
            label3.TabIndex = 8;
            label3.Text = "2023\r\n Thomas Krahl";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(50, 32);
            label2.Name = "label2";
            label2.Size = new Size(172, 23);
            label2.TabIndex = 7;
            label2.Text = "Version: 1.05";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(94, 153);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 5;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += OnCloseButtonClick;
            // 
            // label1
            // 
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 10;
            label1.Text = "Timekeeping Tool";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(269, 201);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MaximumSize = new Size(285, 240);
            MinimizeBox = false;
            MinimumSize = new Size(285, 240);
            Name = "FormAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Label label1;
    }
}