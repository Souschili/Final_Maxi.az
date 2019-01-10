using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_Maxi.az
{
    public class Laptop: INotifyPropertyChanged
    {
        //по умолчанию нонэйм и общая пикча 
        private string _image { get; set; } = "image/nout.jpg";
        public string _Image { get { return _image; } set { _image = value; OnPropChanged(); } } 
        private string _name { get ; set; } = "Noname";
        public string _Name { get { return _name; } set { _name = value; OnPropChanged(); } }
        //операционая система
        private string _os { get; set; } = "Unknown";
        public string _Os { get {  return String.Format("Operation System {0}", _os); } set { this._os = value; OnPropChanged(); } }
        //ОЗУ
        private int _ram { get; set; } = 8;
        public string _Ram { get
                                 { return String.Format("RAM is {0} Gb ", _ram ); }
                             set {
                                  if (Int32.TryParse(_Ram, out int a)) _ram = a; OnPropChanged();
            }
                             }

        //HDD
        private int _hdd { get; set; } = 500;
        public string _Hdd
        {
            get
            { return String.Format("HDD capasity is {0} Gb ", _hdd); }
            set
            {
                if (Int32.TryParse(_Hdd, out int a)) _hdd = a; OnPropChanged();
            }
        }

        //Monitor size in inch(взял инты для простоты по хорошему децимал надо бы)
        private int _monitorSize { get; set; } = 21;
        public string _MonitorSize
        {
            get
            { return String.Format("Monitor size {0} inch ", _monitorSize); }
            set
            {
                if (Int32.TryParse(_MonitorSize, out int a)) _monitorSize = a; OnPropChanged();
            }
        }

        //веб камера да\нет по умолчанию да
        private string _web { get; set; } = "Yes";
        public string _Web { get { return String.Format("WebCamera {0}", _web); }
                             set { _web = value; OnPropChanged(); } }


        //старая цена
        private double _oldPrice { get; set; } = 100.0d;
        public string _OldPrice { get { return String.Format("{0:c}", _oldPrice); }
                                  set { if (Double.TryParse(_Hdd, out double a)) _oldPrice = a; OnPropChanged(); } }

        //новая цена
        private double _newPrice { get; set; } = 200.0d;
        public string _NewPrice { get { return String.Format("{0:c}", _newPrice); }
                                  set { if (Double.TryParse(_Hdd, out double a)) _newPrice = a; OnPropChanged(); } }
        public Laptop() { }
        
        public Laptop(string image, string name,string os="DOS")
        {
            this._image = image;
            this._name = name;
            this._os = os;
        }

        public Laptop(string image, string name, string os, int ram, int hdd,
                      int monitorSize, string web, double oldPrice, double newPrice) : this(image, name, os)
        {
            _ram = ram;
            _hdd = hdd;
            _monitorSize = monitorSize;
            _web = web;
            _oldPrice = oldPrice;
            _newPrice = newPrice;
        }




        //оповещатель укороченый через ? проверка на нулл
        void OnPropChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }


}

