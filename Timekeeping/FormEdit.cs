/// <author>Thomas Krahl</author>

using System.Diagnostics;

namespace Timekeeping
{
    public partial class FormEdit : Form
    {
        private TimeData timeData;
        private readonly Timekeeper timekeeper;
        private bool setupDone;

        public FormEdit(TimeData data, Timekeeper timekeeper)
        {
            InitializeComponent();
            timeData = data;
            this.timekeeper = timekeeper ?? throw new NullReferenceException("timekeeper reference is missing");
            Setup();
        }

        private void Setup()
        {
            SetTextBoxText();
            setupDone = true;
            label1.Text = $"Edit Data for {timeData.date}";
        }

        private void SetTextBoxText()
        {
            string[] start = timeData.startTime.Split(':');
            string[] end = timeData.endTime.Split(':');
            string[] pause = timeData.pauseTime.Split(':');
            string[] total = timeData.totalTime.Split(':');

            textBox1.Text = start[0];
            textBox2.Text = start[1];
            textBox4.Text = end[0];
            textBox3.Text = end[1];
            textBox6.Text = pause[0];
            textBox5.Text = pause[1];
            textBox8.Text = total[0];
            textBox7.Text = total[1];
        }

        private void OnButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            if (timeData.date == "") return;

            timeData.startTime = int.Parse(textBox1.Text).ToString("00") + ":" + int.Parse(textBox2.Text).ToString("00");
            timeData.endTime = int.Parse(textBox4.Text).ToString("00") + ":" + int.Parse(textBox3.Text).ToString("00");
            timeData.pauseTime = int.Parse(textBox6.Text).ToString("00") + ":" + int.Parse(textBox5.Text).ToString("00");
            timeData.totalTime = int.Parse(textBox8.Text).ToString("00") + ":" + int.Parse(textBox7.Text).ToString("00");

            int index = -1;
            foreach (var item in timekeeper.DataListMonthTemp)
            {
                index++;
                if (item.date == timeData.date)
                {
                    Debug.WriteLine("Found Date ...");
                    break;
                }
            }

            if (index != -1)
            {
                Debug.WriteLine("SetData");
                timekeeper.DataListMonthTemp[index] = timeData;
                timekeeper.Save();             
            }           
            Close();
        }

        private void OnTextBoxChanged(object sender, EventArgs e)
        {
            if (!setupDone) return;
            if (timeData.date == "") return;
            SetTotalTime();
        }

        private void SetTotalTime()
        {
            string startTime = textBox1.Text + ":" + textBox2.Text;
            string endTime = textBox4.Text + ":" + textBox3.Text;
            string pauseTime = textBox6.Text + ":" + textBox5.Text;

            if (startTime == "00:00" || endTime == "00:00") return;
            Debug.WriteLine("Set Total Time");

            TimeSpan duration = timekeeper.GetDuration(endTime, startTime);
            string timeValue = duration.ToString("hh':'mm");

            duration = timekeeper.GetDuration(timeValue, pauseTime);
            timeValue = duration.ToString("hh':'mm");
            string[] total = timeValue.Split(':');

            textBox8.Text = total[0];
            textBox7.Text = total[1];
        }
    }
}
