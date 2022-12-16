using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotpepperSearchSystem {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        BitmapImage m_bitmap = null;

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            //var dString = " ";
            //dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=dce4542a04b9085c&large_area=Z017&format=json");
            //var json = JsonConvert.DeserializeObject<Results[]>(dString);
            //SearchTB.Text = json[0].shop[0].name;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e) {
            //var wc = new WebClient() {
            //    Encoding = Encoding.UTF8
            //};

            var path = "https://webservice.recruit.co.jp/banner/hotpepper-m.gif";

            m_bitmap = new BitmapImage();
            m_bitmap.BeginInit();
            m_bitmap.UriSource = new Uri(path);
            m_bitmap.EndInit();
            creditImage.Source = m_bitmap;
            
        }
    }
}
