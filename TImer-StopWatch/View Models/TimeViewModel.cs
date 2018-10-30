using System.ComponentModel;
using System.Configuration;
using Timer_StopWatch.Models;

namespace Timer_StopWatch.View_Models
{
    class TimeViewModel : INotifyPropertyChanged
    {
        #region Properties
        // Properties
        private int daysOnePlace;
        public int DaysPlaceOne
        {
            get { return daysOnePlace; }
            set
            {
                daysOnePlace = value;
                OnPropertyChanged("DaysOnePlace");
            }
        }

        private int daysPlaceTwo;

        public int DaysPlaceTwo
        {
            get { return daysPlaceTwo; }
            set
            {
                daysPlaceTwo = value;
                OnPropertyChanged("DaysPlaceTwo");
            }
        }

        private int hoursPlaceOne;

        public int HoursPlaceOne
        {
            get { return hoursPlaceOne; }
            set
            {
                hoursPlaceOne = value;
                OnPropertyChanged("HoursPlaceOne");
            }    
        }

        private int hoursPlaceTwo;

        public int HoursPlaceTwo
        {
            get { return hoursPlaceTwo; }
            set
            {
                hoursPlaceTwo = value;
                OnPropertyChanged("HoursPlaceTwo");
            }
        }

        private int minutesPlaceOne;

        public int MinutesPlaceOne
        {
            get { return minutesPlaceOne; }
            set
            {
                minutesPlaceOne = value;
                OnPropertyChanged("MinutesPlaceOne");
            }
        }

        private int minutesPlaceTwo;

        public int MinutesPlaceTwo
        {
            get { return minutesPlaceTwo; }
            set
            {
                minutesPlaceTwo = value;
                OnPropertyChanged("MinutesPlaceTwo");
            }
        }

        private int secondsPlaceOne;

        public int SecondsPlaceOne
        {
            get { return secondsPlaceOne; }
            set
            {
                secondsPlaceOne = value;
                OnPropertyChanged("SecondsPlaceOne");
            }
        }

        private int secondsPlaceTwo;

        public int SecondsPlaceTwo
        {
            get { return secondsPlaceTwo; }
            set
            {
                secondsPlaceTwo = value;
                OnPropertyChanged("SecondsPlaceTwo");
            }
        }

        #endregion

        public TimeViewModel()
        {
            var appSettings = ConfigurationManager.AppSettings;

            daysOnePlace = 0;

            //if(appSettings[0] == null)
            //{
            //    daysOnePlace = 0;
            //}
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
