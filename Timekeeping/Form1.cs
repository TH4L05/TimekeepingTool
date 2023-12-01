/// <author>Thomas Krahl</author>

using System.Diagnostics;

namespace Timekeeping
{
    public partial class Form1 : Form
    {
        private Timekeeper? timekeeper;
        private bool setupDone = false;
        private FormEdit? form;

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
            UpdateListViewMonth();
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
            timekeeper?.SetTempListMonth($"Data/{comboBoxYear.Text}_{1 + comboBoxMonth.SelectedIndex}.txt");
            UpdateListViewMonth();
        }

        #region View

        private void UpdateListView()
        {
            listViewLastFive.Items.Clear();
            if (timekeeper == null) return;
            List<TimeData> dataList = timekeeper.DataListCurrentMonth;
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


            for (int i = 0; i < max; i++)
            {
                int index = dataList.Count - i - 1;
                ListViewItem newItem = new ListViewItem(dataList[index].date);
                newItem.SubItems.Add(dataList[index].weekday);
                newItem.SubItems.Add(dataList[index].startTime);
                newItem.SubItems.Add(dataList[index].endTime);
                newItem.SubItems.Add(dataList[index].pauseTime);
                newItem.SubItems.Add(dataList[index].totalTime);
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
                dataList = timekeeper.DataListCurrentMonth;
            }
            else
            {
                dataList = timekeeper.DataListMonthTemp;
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

        #endregion

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

        private void OnOverviewListDoubleClick(object sender, EventArgs e)
        {
            if (timekeeper == null) return;
            if (listViewMonth.SelectedItems[0].Text == "no data") return;

            int selectedIndex = -1;
            if (listViewMonth.SelectedIndices.Count > 0)
            {
                selectedIndex = listViewMonth.SelectedIndices[0];
            }

            List<TimeData> dataList;
            if (1 + comboBoxMonth.SelectedIndex == timekeeper.Month)
            {
                dataList = timekeeper.DataListCurrentMonth;
            }
            else
            {
                dataList = timekeeper.DataListMonthTemp;
            }
            

            form = new FormEdit(dataList[selectedIndex], timekeeper);
            form.Show();
            Point location = Location;
            location.X += Location.X / 4;
            location.Y += Location.Y / 2;
            form.Location = location;
            form.FormClosed += FormEditClosed;
        }
        
        protected override void OnClosed(EventArgs e)
        {
            timekeeper?.Save();
            base.OnClosed(e);
        }

        private void FormEditClosed(object? sender, FormClosedEventArgs e)
        {
            Debug.Write("FormClosed");
            UpdateListView();
            UpdateListViewMonth();
            if(form == null) return;
            form.FormClosed -= FormEditClosed;
        }
    }
}
