using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabularMvvm.Model
{
    public class EmployeeData:INotifyPropertyChanged
    {
        private long id;
        private string name;
        private string role;

        public long Id { 
            get => id   ;
            set
            {
                id = value;
                OnPropertyChange(nameof(Id));
            } 
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChange(nameof(name));
            }
        }
        public string Role
        {
            get => role;
            set
            {
                role = value;
                OnPropertyChange(nameof(role));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
