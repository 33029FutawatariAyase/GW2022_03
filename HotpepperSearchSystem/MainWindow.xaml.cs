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
        private NavigationService _navi;
        public MainWindow() {
            InitializeComponent();
            _navi = this.myFrame.NavigationService;
        }

        private List<Uri> _uriList = new List<Uri>() {
            new Uri("Page1.xaml",UriKind.Relative)
            //new Uri("Page2.xaml",UriKind.Relative)
        };

        private void myFrame_Loaded(object sender, RoutedEventArgs e) {
            _navi.Navigate(_uriList[0]);    //初期ページの表示
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e) {
            int index = _uriList.IndexOf(_navi.CurrentSource);
            //if (index <= 0)
            //    prevButton.IsEnabled = false;
            //else
            //    prevButton.IsEnabled = true;
            if (index == _uriList.Count)
                searchButton.IsEnabled = false;
            else
                searchButton.IsEnabled = true;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e) {

            if (_navi.CanGoForward)
                _navi.GoForward();
            else {
                int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
                _navi.Navigate(_uriList[index]);    //ページの移動
            }

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            //var dString = " ";
            //dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=dce4542a04b9085c&large_area=Z017&format=json");
            //var json = JsonConvert.DeserializeObject<Results[]>(dString);
            //SearchTB.Text = json[0].shop[0].access;
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
