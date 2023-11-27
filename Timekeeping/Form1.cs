/// <author>Thomas Krahl</author>

using System.Diagnostics;

namespace Timekeeping
{
    public partial class Form1 : Form
    {
        private Timekeeper? timekeeper;
        private bool setupDone = false;

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            timekeeper = new Timekeeper();
            timekeeper.Setup();
            listViewMonth.Items.Clear();
            string[] month = timekeeper.monthNames;

            for (int i = 0; i < month.Length; i++)
            {
                comboBoxMonth.Items.Add(month[i]);
                comboBoxMonth.SelectedItem = timekeeper.CurrentMonth;
            }

            int year = 2023;
            for (int i = year; i < year + 100; i++)
            {
                comboBoxYear.Items.Add(i);
                comboBoxYear.SelectedItem = DateTime.Now.Year;
            }

            UpdateListView();
            UpdateListViewMonth();
            setupDone = true;
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dddd - dd/MM/yyyy");
        }

        private void OnTimeStartClick(object sender, EventArgs e)
        {
            if (timekeeper == null) return;
            timekeeper.SetStartTime();
            UpdateListView();
        }

        private void OnTimeEndClick(object sender, EventArgs e)
        {
            if (timekeeper == null) return;
            timekeeper.SetEndTime();
            UpdateListView();
            UpdateListViewMonth();
        }

        private void OnComboBoxChanged(object sender, EventArgs e)
        {
            if (!setupDone) return;
            UpdateListViewMonth();
        }

        private void UpdateListView()
        {
            listViewLastFive.Items.Clear();
            if (timekeeper == null) return;
            List<TimeData> dataList = timekeeper.DataList;
            if (dataList.Count < 1)
            {
                ListViewItem newItem = new ListViewItem("no data");
                listViewLastFive.Items.Add(newItem);
                return;
            }

            int max = 5;
            if (dataList.Count < max)
            {
                max = dataList.Count;
            }
            else
            {
                max -= 1;
            }

            for (int i = max; i > -1; i--)
            {
                ListViewItem newItem = new ListViewItem(dataList[i].date);
                newItem.SubItems.Add(dataList[i].weekday);
                newItem.SubItems.Add(dataList[i].startTime);
                newItem.SubItems.Add(dataList[i].endTime);
                newItem.SubItems.Add(dataList[i].pauseTime);
                newItem.SubItems.Add(dataList[i].totalTime);
                listViewLastFive.Items.Add(newItem);
            }
        }

        private void UpdateListViewMonth()
        {
            listViewMonth.Items.Clear();
            if (timekeeper == null) return;
            List<TimeData> dataList;

            if (1 + comboBoxMonth.SelectedIndex == timekeeper.Month)
            {
                dataList = timekeeper.DataListMonth;
            }
            else
            {
                dataList = timekeeper.GetTimeDataFromFile($"Data/{comboBoxYear.Text}_{1 + comboBoxMonth.SelectedIndex}.txt");
            }
            SetListViewItems(dataList);
        }

        private void SetListViewItems(List<TimeData> timeDataList)
        {
            if (timeDataList.Count < 1)
            {
                ListViewItem newItem = new ListViewItem("no data");
                listViewMonth.Items.Add(newItem);
                return;
            }

            for (int i = 0; i < timeDataList.Count; i++)
            {
                ListViewItem newItem = new ListViewItem(timeDataList[i].date);
                newItem.SubItems.Add(timeDataList[i].weekday);
                newItem.SubItems.Add(timeDataList[i].startTime);
                newItem.SubItems.Add(timeDataList[i].endTime);
                newItem.SubItems.Add(timeDataList[i].pauseTime);
                newItem.SubItems.Add(timeDataList[i].totalTime);
                listViewMonth.Items.Add(newItem);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            timekeeper?.Save();
            base.OnClosed(e);
        }

        #region MenuItems

        private void OnMenuFileSaveItemClick(object sender, EventArgs e)
        {
            timekeeper?.Save();
        }

        private void OnMenuFileCloseItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnMenuHelpAboutItemClick(object sender, EventArgs e)
        {
            panelAbout.Visible = true;
        }

        #endregion

        #region AboutPanel

        private void OnAboutPanelCloseCLick(object sender, EventArgs e)
        {
            panelAbout.Visible = false;
        }

        #endregion
    }
}
