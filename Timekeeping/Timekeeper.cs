/// <author>Thomas Krahl</author>

using System.Diagnostics;

namespace Timekeeping
{
    public class Timekeeper
    {
        #region Fields

        //public List<TimeData> DataList {  get; private set; }

        public List<TimeData> DataListCurrentMonth { get; private set; }

        public List<TimeData> DataListMonthTemp { get; private set; }
        
        public int Month { get; private set; }
        
        public string CurrentMonth
        {
            get
            {
                return monthNames[Month -1];
            }
        }
        
        private string FileName
        {
            get
            {
                return $"Data/{ DateTime.Now.Year}_{Month}.txt";
            }
        }

        private string FileNameTempListMonth;

        public string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        #endregion

        public Timekeeper()
        {
            DataListCurrentMonth = new List<TimeData>();
            DataListMonthTemp = new List<TimeData>();
            Month = DateTime.Now.Month;
            FileNameTempListMonth = FileName;
        }

        #region Setup

        public void Setup()
        {
            string[] data = LoadDataFromFile(FileName);
            DataListCurrentMonth = SetDataList(data);
            DataListMonthTemp = DataListCurrentMonth;
        }

        private TimeData CreateNewTimeData()
        {
            TimeData newTimeData = new TimeData()
            {
                date = DateTime.Today.Date.ToShortDateString(),
                weekday = DateTime.Today.DayOfWeek.ToString(),
                startTime = "00:00",
                endTime = "00:00",
                pauseTime = "00:00",
                totalTime = "00:00",
            };
            return newTimeData;
        }

        #endregion

        #region Set
        private List<TimeData> SetDataList(string[] data)
        {
            List<TimeData> dataList = new List<TimeData>();
            for (int i = 1; i < data.Length; i++)
            {
                string[] line = data[i].Split(';', StringSplitOptions.TrimEntries);
                TimeData newTimeData = new TimeData()
                {
                    date = line[0],
                    weekday = line[1],
                    startTime = line[2],
                    endTime = line[3],
                    pauseTime = line[4],
                    totalTime = line[5]
                };

                dataList.Add(newTimeData);    
            };   
            return dataList;
        }

        public void SetStartTime()
        {
            string startTime = DateTime.Now.ToString("HH:mm");

            if (DateAlreadyExists())
            {
                Debug.WriteLine("Date already exists");
                int index = GetDataListEntryIndexFromDate();
                TimeData tempData = DataListCurrentMonth[index];
                tempData.startTime = startTime;
                DataListCurrentMonth[index] = tempData;
            }
            else
            {
                Debug.WriteLine("Date not exists -> new Entry");
                TimeData newData = CreateNewTimeData();
                newData.startTime = startTime;
                AddTimeDataToList(newData);
            }
        }

        public void SetEndTime()
        {
            string endTime = DateTime.Now.ToString("HH:mm");

            if (DateAlreadyExists())
            {
                Debug.WriteLine("Date already exists");
                int index = GetDataListEntryIndexFromDate();
                TimeData tempData = DataListCurrentMonth[index];
                tempData.endTime = endTime;
                DataListCurrentMonth[index] = tempData;
            }
            else
            {
                Debug.WriteLine("Date not exists -> new Entry");
                TimeData newData = CreateNewTimeData();
                newData.startTime = endTime;
                newData.endTime = endTime;
                AddTimeDataToList(newData);
            }

            SetPauseTime();
            SetTotalTime();
        }

        private void SetPauseTime()
        {
            int index = GetDataListEntryIndexFromDate();
            TimeSpan duration = GetDuration(DataListCurrentMonth[index].endTime, DataListCurrentMonth[index].startTime);
            string timeValue = "00:00";

            if (duration.TotalHours > 6 && duration.TotalHours < 9)
            {
                timeValue = "00:30";
            }
            else if (duration.TotalHours > 9)
            {
                timeValue = "00:45";
            }
        
            TimeData tempData = DataListCurrentMonth[index];
            tempData.pauseTime = timeValue;
            DataListCurrentMonth[index] = tempData;
        }

        private void SetTotalTime()
        {
            int index = GetDataListEntryIndexFromDate();

            TimeSpan duration = GetDuration(DataListCurrentMonth[index].endTime, DataListCurrentMonth[index].startTime);        
            string timeValue = duration.ToString("hh':'mm");
            duration = GetDuration(timeValue, DataListCurrentMonth[index].pauseTime);
            timeValue = duration.ToString("hh':'mm");

            TimeData tempData = DataListCurrentMonth[index];
            tempData.totalTime = timeValue;
            DataListCurrentMonth[index] = tempData;
        }
    
        public void AddTimeDataToList(TimeData timeData)
        {
            DataListCurrentMonth.Add(timeData);           
        }
        
        /*private bool OverrideData(string text)
        {
            DialogResult dialog = MessageBox.Show(text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }*/

        #endregion

        #region Get

        public TimeSpan GetDuration(string time1, string time2)
        {
           return DateTime.Parse(time1).Subtract(DateTime.Parse(time2));
        }

        private int GetDataListEntryIndexFromDate()
        {
            List<TimeData> data = DataListCurrentMonth;

            int index = -1;
            foreach (var timeData in data)
            {
                index++;
                if (timeData.date == DateTime.Today.Date.ToShortDateString())
                {
                    break;
                }
            }
            return index;
        }
     
        /*public void GetTimeDataFromFile(string path)
        {
            List<TimeData> timeData = new List<TimeData>();
            string[] data = LoadDataFromFile(path);

            if (data.Length == 0) return;
            timeData = SetDataList(data);                   
        }*/

        public void SetTempListMonth(string path)
        {
            FileNameTempListMonth = path;
            string[] data = LoadDataFromFile(path);
            DataListMonthTemp = SetDataList(data);
        }

        public TimeData GetTimeDataFromList(int index, bool currentMonth)
        {
            if (index == -1) return new TimeData();
            if (!currentMonth)
            {
                if (index > DataListMonthTemp.Count) return new TimeData();
                return DataListMonthTemp[index];
            }
            if (index > DataListCurrentMonth.Count) return new TimeData();
            return DataListCurrentMonth[index];
        }

        #endregion

        #region Load/Save

        private string[] LoadDataFromFile(string fileName)
        {
            if (!Serialization.FileExistenceCheck(fileName)) return Array.Empty<string>();
            return Serialization.ReadTextFileByLine(fileName);
        }

        public void Save()
        {
            Debug.WriteLine("SaveData");
            if (DataListCurrentMonth.Count > 0)
            {
                string dataString = SetSaveData(DataListCurrentMonth);
                SaveToFile(dataString, FileName);
            }      
            
            if (DataListMonthTemp.Count > 0)
            {
                string dataString = SetSaveData(DataListMonthTemp);
                SaveToFile(dataString, FileNameTempListMonth);
            }
        }

        private string SetSaveData(List<TimeData> data)
        {
            string dataString = "Date;Weekday;StartTime;EndTime;PauseTime;TotalTime";
            dataString += "\n";

            foreach (var timeData in data)
            {
                dataString += timeData.date + ";";
                dataString += timeData.weekday + ";";
                dataString += timeData.startTime + ";";
                dataString += timeData.endTime + ";";
                dataString += timeData.pauseTime + ";";
                dataString += timeData.totalTime;
                dataString += "\n";
            }
            return dataString;
        }

        private void SaveToFile(string content, string fileName)
        {
            Serialization.SaveToTextFile(content, fileName);
        }

        #endregion

        private bool DateAlreadyExists()
        {
            foreach (var timeData in DataListCurrentMonth)
            {
                if (timeData.date == DateTime.Today.Date.ToShortDateString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
