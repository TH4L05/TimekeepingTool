

using System.Diagnostics;
using System.Web;

namespace Timekeeping
{
    internal class Timekeeper
    {
        #region Fields

        public List<TimeData> DataList {  get; private set; }
        public List<TimeData> DataListMonth { get; private set; }
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
                return "Data/" + DateTime.Now.Year + "_" + CurrentMonth + ".txt";
            }
        }

        public string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        #endregion

        public Timekeeper()
        {
            DataList = new List<TimeData>();
            DataListMonth = new List<TimeData>();
            Month = DateTime.Now.Month;
        }

        #region Setup

        public void Setup()
        {
            string[] data = LoadDataFromFile("tempData.txt");
            SetDataList(data, false);

            data = LoadDataFromFile(FileName);
            SetDataList(data, true);
        }

        private void SetDataList(string[] data, bool month)
        {
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

                if (month)
                {
                    DataListMonth.Add(newTimeData);
                }
                else
                {
                    DataList.Add(newTimeData);
                }             
            };                      
        }

        private TimeData CreateNewTimeData()
        {
            TimeData newTimeData = new TimeData()
            {
                date = DateTime.Today.Date.ToShortDateString(),
                weekday = DateTime.Today.DayOfWeek.ToString(),
                startTime = 0.ToString(),
                endTime = 0.ToString(),
                pauseTime = 0.ToString(),
                totalTime = 0.ToString()
            };
            return newTimeData;
        }

        #endregion

        #region Set

        public void SetStartTime()
        {
            string startTime = DateTime.Now.ToString("HH:mm");

            if (DateAlreadyExists())
            {
                Debug.WriteLine("Date already exists");
                //bool overide = true;
                int index = GetDataListEntryIndexFromDate(false);
                //if (dataList[index].startTime != "0") overide = OverrideData($"There is already a start time for {dataList[index].date} \n Overwrite time?");
                //if (!overide) return;
                TimeData tempData = DataList[index];
                tempData.startTime = startTime;
                DataList[index] = tempData;

                index = GetDataListEntryIndexFromDate(true);
                tempData = DataListMonth[index];
                tempData.startTime = startTime;
                DataListMonth[index] = tempData;
            }
            else
            {
                Debug.WriteLine("Date not exists -> new Entry");
                TimeData newData = CreateNewTimeData();
                newData.startTime = startTime;
                AddTimeDataToList(newData,true);

                if (DataList.Count > 4)
                {
                    DataList.RemoveAt(0);
                }
                AddTimeDataToList(newData,false);
            }
        }

        public void SetEndTime()
        {
            string endTime = DateTime.Now.ToString("HH:mm");

            if (DateAlreadyExists())
            {
                Debug.WriteLine("Date already exists");
                //bool overide = true;
                int index = GetDataListEntryIndexFromDate(false);
                //if (dataList[index].startTime != "0") overide = OverrideData($"There is already a end time for {dataList[index].date} \n Overwrite time?");
                //if (!overide) return;
                TimeData tempData = DataList[index];
                tempData.endTime = endTime;
                DataList[index] = tempData;

                index = GetDataListEntryIndexFromDate(true);
                tempData = DataListMonth[index];
                tempData.endTime = endTime;
                DataListMonth[index] = tempData;
            }
            else
            {
                Debug.WriteLine("Date not exists -> new Entry");
                TimeData newData = CreateNewTimeData();
                newData.startTime = endTime;
                newData.endTime = endTime;
                AddTimeDataToList(newData, false);
                AddTimeDataToList(newData, true);
            }

            SetTotalTime();
            SetPauseTime();
        }

        private void SetPauseTime()
        {
            int index = GetDataListEntryIndexFromDate(false);
            TimeSpan duration = GetDuration(DataList[index].endTime, DataList[index].startTime);
            string timeValue = "00:00";

            if (duration.TotalHours > 6 && duration.TotalHours < 9)
            {
                timeValue = "00:30";
            }
            else if (duration.TotalHours > 9)
            {
                timeValue = "00:45";
            }
        
            TimeData tempData = DataList[index];
            tempData.pauseTime = timeValue;
            DataList[index] = tempData;

            index = GetDataListEntryIndexFromDate(true);
            tempData = DataListMonth[index];
            tempData.pauseTime = timeValue;
            DataListMonth[index] = tempData;
        }

        private void SetTotalTime()
        {
            int index = GetDataListEntryIndexFromDate(false);

            Debug.WriteLine(DataList[index].endTime + " -- " + DataList[index].startTime);

            TimeSpan duration = GetDuration(DataList[index].endTime, DataList[index].startTime);
            string timeValue = duration.ToString("hh':'mm");
                
            TimeData tempData = DataList[index];
            tempData.totalTime = timeValue;
            DataList[index] = tempData;

            index = GetDataListEntryIndexFromDate(true);
            tempData = DataListMonth[index];
            tempData.totalTime = timeValue;
            DataListMonth[index] = tempData;
        }
     
        public void AddTimeDataToList(TimeData timeData, bool month)
        {
            if(month)
            {
                DataListMonth.Add(timeData);
            }
            else
            {
                DataList.Add(timeData);
            }       
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

        private TimeSpan GetDuration(string time1, string time2)
        {
           return DateTime.Parse(time1).Subtract(DateTime.Parse(time2));
        }

        private int GetDataListEntryIndexFromDate(bool month)
        {
            List<TimeData> data;

            if(month)
            {
                data = DataListMonth;
            }
            else
            {
                data = DataList;
            }

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
     
        public List<TimeData> GetTimeDataFromFile(string path)
        {
            List<TimeData> timeData = new List<TimeData>();
            string[] data = LoadDataFromFile(path);

            if (data.Length == 0) return timeData;

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
                
                 timeData.Add(newTimeData);
                
            };
            return timeData;
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
            if (DataList.Count > 0)
            {
                string dataString = SetSaveData(false);
                SaveToFile(dataString, "tempData.txt");
            }

            if (DataListMonth.Count > 0)
            {
                string dataString = SetSaveData(true);
                SaveToFile(dataString, FileName);
            }           
        }

        private string SetSaveData(bool month)
        {
            string dataString = "Date;Weekday;StartTime;EndTime;PauseTime;TotalTime";
            dataString += "\n";

            List<TimeData> data;
            if (month)
            {
                data = DataListMonth;
            }
            else
            {
                data = DataList;
            }

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
            foreach (var timeData in DataList)
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
