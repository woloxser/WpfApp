using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using WpfApp1.Commands;

namespace WpfApp1.ModelViews
{
    public class MainWindowModelView : INotifyPropertyChanged
    {
        public MainWindowModelView()
        {

            NwdCommand = new RelayCommand(nwd);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string outNwd;

        public string OutNwd
        {
            get { return outNwd; }
            set 
            { 
                outNwd = value; 
                OnPropertyChanged(nameof(OutNwd));
            }
        }
        private string arg1;
        public string Arg1
        {
            get { return arg1; }
            set
            {
                arg1 = value;
                OnPropertyChanged(nameof(Arg1));
            }
        }
        private string arg2;

        public string Arg2
        {
            get { return arg2; } 
            set
            {
                arg2 = value;
                OnPropertyChanged(nameof(Arg2));
            }
        }
        public ICommand NwdCommand { get; set; }
        public void nwd(Object obj)
        {
            try
            {
                double x = Convert.ToDouble(Arg1);
                double y = Convert.ToDouble(Arg2);

                while(x!=y)
                {
                    if(x > y)
                    {
                        x = x - y;
                    }
                    else
                    {
                        y = y - x;
                    }
                }
                OutNwd = x.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
