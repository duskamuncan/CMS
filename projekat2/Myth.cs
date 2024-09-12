using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat2
{
    public class Myth : INotifyPropertyChanged
    {
        public int rating {  get; set; }
        public string god { get; set; }
        public string pathToPhoto { get; set; }
        public string pathToDescriptionRtf { get; set; }
        public DateTime Date { get; set; }

        public bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                if (rating != value)
                {
                    rating = value;
                    OnPropertyChanged(nameof(Rating));
                }
            }
        }

        public string God
        {
            get { return god; }
            set
            {
                if (god != value)
                {
                    god = value;
                    OnPropertyChanged(nameof(God));
                }
            }
        }

        public string PathToPhoto
        {
            get { return pathToPhoto; }
            set
            {
                if (pathToPhoto != value)
                {
                    pathToPhoto = value;
                    OnPropertyChanged(nameof(PathToPhoto));
                }
            }
        }

        public string PathToDescriptionRtf
        {
            get { return pathToDescriptionRtf; }
            set
            {
                if (pathToDescriptionRtf != value)
                {
                    pathToDescriptionRtf = value;
                    OnPropertyChanged(nameof(PathToDescriptionRtf));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Myth() { }

        public Myth (int rating, string god, string pathToPhoto, string pathToDescriptionRtf, DateTime date)
        {
            this.Rating = rating;
            this.god = god;
            this.pathToPhoto = pathToPhoto;
            this.pathToDescriptionRtf = pathToDescriptionRtf;
            this.Date = date;
        }   
    }
}
