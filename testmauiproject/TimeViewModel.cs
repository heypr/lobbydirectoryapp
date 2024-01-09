using System.ComponentModel;
using System.Timers;
using Timer = System.Timers.Timer;

namespace testmauiproject
{
    public class TimeViewModel : INotifyPropertyChanged
    {
        private string _currentDateTime;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string CurrentDateTime
        {
            get => _currentDateTime;

            set
            {
                _currentDateTime = value;
                OnPropertyChanged(nameof(CurrentDateTime));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TimeViewModel()
        {
            Timer timer = new(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CurrentDateTime = DateTime.Now.ToString("dd MMMM yyyy,\nhh:mm:ss tt");
        }
    }
}
