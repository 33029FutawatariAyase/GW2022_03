using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HotpepperSearchSystem {
    class DataGridItems {

    }
    public class Shoplist {
        //public Uri Status { get; set; }
        public BitmapImage Picture { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public string Phone { get; set; }
        public string Open { get; set; }
        public string Room { get; set; }
        public string Parking { get; set; }

        public Shoplist(BitmapImage picture, string name,string address,string open,string room,string parking) {
            Picture = picture; 
            //Status = status;
            Name = name;
            Address = address;
            Open = open;
            Room = room;
            Parking = parking;
        }        
    }

    public class Favshoplist {
        public BitmapImage Picture { get; set; }
        public string Name { get; set; }

        public Favshoplist(BitmapImage picture1,string name1) {
            Picture = picture1;
            Name = name1;
        }
    }
}
