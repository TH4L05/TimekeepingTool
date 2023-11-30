﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timekeeping
{
    public partial class FormEdit : Form
    {
        private TimeData timeData;
        private Timekeeper timekeeper;
        private bool setupDone;

        public FormEdit(TimeData data, Timekeeper timekeeper)
        {
            InitializeComponent();
            if (timekeeper == null) throw new NullReferenceException("timekeeper reference is missing");
            timeData = data;
            this.timekeeper = timekeeper;
            Setup();
        }

        private void Setup()
        {
            SetTextBoxText();
            setupDone = true;
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

            Debug.WriteLine("SaveData");
            timeData.startTime = textBox1.Text + ":" + textBox2.Text;
            timeData.endTime = textBox4.Text + ":" + textBox3.Text;
            timeData.pauseTime = textBox6.Text + ":" + textBox5.Text;
            timeData.totalTime = textBox8.Text + ":" + textBox7.Text;

            int index = -1;
            foreach (var item in timekeeper.DataListMonthTemp)
            {
                if (item.date == timeData.date)
                {
                    Debug.WriteLine("Found Date ...");
                    break;
                }
                index++;
            }

            if (index != -1)
            {
                timekeeper.DataListMonthTemp[1 + index] = timeData;
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
            Debug.WriteLine("Set Total Time");

            string startTime = textBox1.Text + ":" + textBox2.Text;
            string endTime = textBox4.Text + ":" + textBox3.Text;
            string pauseTime = textBox6.Text + ":" + textBox5.Text;

            TimeSpan duration = timekeeper.GetDuration(endTime, startTime);
            string timeValue = duration.ToString("hh':'mm");
            Debug.WriteLine(timeValue);

            duration = timekeeper.GetDuration(timeValue, pauseTime);
            timeValue = duration.ToString("hh':'mm");
            Debug.WriteLine(timeValue);

            string[] total = timeValue.Split(':');

            textBox8.Text = total[0];
            textBox7.Text = total[1];
        }
    }
}
