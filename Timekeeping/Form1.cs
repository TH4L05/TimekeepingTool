/// <author>Thomas Krahl</author>

using System.Diagnostics;

namespace Timekeeping
{
    public partial class Form1 : Form
    {
        private Timekeeper? timekeeper;
        private bool setupDone = false;

        #region SetupAndInitialize

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

            CheckForDataFolder();
            FillComboBoxes();
            UpdateListView();
            UpdateListViewMonth();

            toolStripStatusLabel1.Text = DateTime.Now.ToString("dddd - dd/MM/yyyy");
            setupDone = true;
        }

        private void CheckForDataFolder()
        {
            if (!Serialization.FolderExistenceCheck("Data"))
            {
                Debug.WriteLine("Create Data Folder");
                Serialization.CreateFolder("Data");
            }
        }

        private void FillComboBoxes()
        {
            if (timekeeper == null) return;

            string[] month = timekeeper.monthNames;

            for (int i = 0; i < month.Length; i++)
            {
                comboBoxMonth.Items.Add(month[i]);
                comboBoxMonth.SelectedItem = timekeeper.CurrentMonth;
            }

            for (int year = 2023; year < 2100; year++)
            {
                comboBoxYear.Items.Add(year);
                comboBoxYear.SelectedItem = DateTime.Now.Year;
            }
        }

        #endregion

        #region Elements

        private void OnTimeStartClick(object sender, EventArgs e)
        {
            if (timekeeper == null) return;
            timekeeper.SetStartTime();
            UpdateListView();
            UpdateListViewMonth();
            timekeeper.Save();
        }

        private void OnTimeEndClick(object sender, EventArgs e)
        {
            if (timekeeper == null) return;
            timekeeper.SetEndTime();
            UpdateListView();
            UpdateListViewMonth();
            timekeeper.Save();
        }

        private void OnComboBoxChanged(object sender, EventArgs e)
        {
            if (!setupDone) return;
            timekeeper?.SetTempListMonth($"Data/{comboBoxYear.Text}_{1 + comboBoxMonth.SelectedIndex}.txt");
            UpdateListViewMonth();
        }


        #endregion

        #region MenuElements

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
            ShowFormAbout();
        }

        #endregion

        #region View

        private void UpdateListView()
        {
            if (timekeeper == null) return;

            listViewLastFive.Items.Clear();
            List<TimeData> dataList = timekeeper.DataListCurrentMonth;

            if (dataList.Count == 0)
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
            SetMonthTotal(dataList);
        }

        private void SetMonthTotal(List<TimeData> dataList)
        {
            if (dataList.Count == 0)
            {
                labelTotalMonth.Text = "";
                return;
            }

            TimeSpan duration = new TimeSpan(0, 0, 0);
            for (int i = 0; i < dataList.Count; i++)
            {
                TimeSpan temp = TimeSpan.Parse(dataList[i].totalTime);
                duration += temp;
                Debug.WriteLine(duration.ToString());

            }
            labelTotalMonth.Text = $"Total (hh:mm): {(int)duration.TotalHours}:{duration.Minutes.ToString("00")}";
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

        private void ShowFormAbout()
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
            Point location = Location;
            location.X += Height / 2 - formAbout.Height / 2;
            location.Y += Width / 2 - formAbout.Width / 2;
            formAbout.Location = location;
        }

        #region FormEdit

        private void OnOverviewListDoubleClick(object sender, EventArgs e)
        {
            if (timekeeper == null) return;
            if (listViewMonth.SelectedItems[0].Text == "no data") return;
            if (listViewMonth.SelectedIndices.Count == 0) return;

            ShowFormEdit(timekeeper.DataListMonthTemp[listViewMonth.SelectedIndices[0]]);          
        }
        
        private void ShowFormEdit(TimeData timeData)
        {
            if (timekeeper == null) return;

            FormEdit form = new FormEdit(timeData, timekeeper);
            form.Show();
            Point location = Location;
            location.X += Height / 2 - form.Height / 2;
            location.Y += Width / 2 - form.Width / 2;
            form.Location = location;
            form.FormClosed += FormEditClosed;
        }
        
        private void FormEditClosed(object? sender, FormClosedEventArgs e)
        {
            UpdateListView();
            UpdateListViewMonth();
            FormEdit? form = sender as FormEdit;
            if (form == null) return;
            Debug.WriteLine(form.Name + "= Closed");
            form.FormClosed -= FormEditClosed;
        }

        #endregion

        protected override void OnClosed(EventArgs e)
        {
            timekeeper?.Save();
            base.OnClosed(e);
        }
    }
}
