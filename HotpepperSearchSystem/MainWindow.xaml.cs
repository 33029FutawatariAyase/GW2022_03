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
            new Uri("Page1.xaml",UriKind.Relative),
            new Uri("Page2.xaml",UriKind.Relative)
        };

        private void myFrame_Loaded(object sender, RoutedEventArgs e) {
            _navi.Navigate(_uriList[0]);    //初期ページの表示
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e) {
            int index = _uriList.IndexOf(_navi.CurrentSource);
            if (index <= 0)
                prevButton.IsEnabled = false;
            else
                prevButton.IsEnabled = true;
            if (index + 1 == _uriList.Count)
                searchButton.IsEnabled = false;
            else
                searchButton.IsEnabled = true;
        }

        private void prevButton_Click(object sender, RoutedEventArgs e) {
            int index = _uriList.FindIndex(p => p == _navi.CurrentSource) - 1;
            _navi.Navigate(_uriList[index]);    //ページの移動
        }

        private void searchButton_Click(object sender, RoutedEventArgs e) {

            //if (_navi.CanGoForward)
            //    _navi.GoForward();
            //else {
            //    int index = _uriList.FindIndex(p => p == _navi.CurrentSource) + 1;
            //    _navi.Navigate(_uriList[index]);    //ページの移動
            //}

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            string url = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=dce4542a04b9085c&format=json&count=100";
            string prefecture = " ";
            var dString = " ";
            switch (prefectureComboBox.Text) {
                case "北海道":
                    dString = wc.DownloadString(url+"&large_area=Z041");
                    prefecture = url + "&large_area=Z041";                  
                    break;
                    
                case "青森":
                    dString = wc.DownloadString(url + "&large_area=Z051");
                    prefecture = url + "&large_area=Z051";
                    break;

                case "秋田":
                    dString = wc.DownloadString(url + "&large_area=Z054");
                    prefecture = url + "&large_area=Z054";
                    break;

                case "山形":
                    dString = wc.DownloadString(url + "&large_area=Z055");
                    prefecture = url + "&large_area=Z055";
                    break;

                case "岩手":
                    dString = wc.DownloadString(url + "&large_area=Z052");
                    prefecture = url + "&large_area=Z052";
                    break;

                case "宮城":
                    dString = wc.DownloadString(url + "&large_area=Z053");
                    prefecture = url + "&large_area=Z053";
                    break;

                case "福島":
                    dString = wc.DownloadString(url + "&large_area=Z056");
                    prefecture = url + "&large_area=Z056";
                    break;

                case "東京":
                    dString = wc.DownloadString(url + "&large_area=Z011");
                    prefecture = url + "&large_area=Z011";
                    break;

                case "神奈川":
                    dString = wc.DownloadString(url + "&large_area=Z012");
                    prefecture = url + "&large_area=Z012";                    
                    break;

                case "埼玉":
                    dString = wc.DownloadString(url + "&large_area=Z013");
                    prefecture = url + "&large_area=Z013";
                    break;

                case "千葉":
                    dString = wc.DownloadString(url + "&large_area=Z014");
                    prefecture = url + "&large_area=Z014";                    
                    break;

                case "栃木":
                    dString = wc.DownloadString(url + "&large_area=Z016");
                    prefecture = url + "&large_area=Z016";                   
                    break;

                case "茨城":
                    dString = wc.DownloadString(url + "&large_area=Z015");
                    prefecture = url + "&large_area=Z015";                    
                    break;

                case "群馬":
                    dString = wc.DownloadString(url + "&large_area=Z017");
                    prefecture = url + "&large_area=Z017";                    
                    break;

                case "新潟":
                    dString = wc.DownloadString(url + "&large_area=Z061");
                    prefecture = url + "&large_area=Z061";                    
                    break;

                case "山梨":
                    dString = wc.DownloadString(url + "&large_area=Z065");
                    prefecture = url + "&large_area=Z065";                    
                    break;

                case "長野":
                    dString = wc.DownloadString(url + "&large_area=Z066");
                    prefecture = url + "&large_area=Z066";                    
                    break;

                case "石川":
                    dString = wc.DownloadString(url + "&large_area=Z063");
                    prefecture = url + "&large_area=Z063";                    
                    break;

                case "富山":
                    dString = wc.DownloadString(url + "&large_area=Z062");
                    prefecture = url + "&large_area=Z062";                    
                    break;

                case "福井":
                    dString = wc.DownloadString(url + "&large_area=Z064");
                    prefecture = url + "&large_area=Z064";                    
                    break;

                case "愛知":
                    dString = wc.DownloadString(url + "&large_area=Z033");
                    prefecture = url + "&large_area=Z033";                    
                    break;

                case "岐阜":
                    dString = wc.DownloadString(url + "&large_area=Z031");
                    prefecture = url + "&large_area=Z031";                    
                    break;

                case "静岡":
                    dString = wc.DownloadString(url + "&large_area=Z032");
                    prefecture = url + "&large_area=Z032";                  
                    break;

                case "三重":
                    dString = wc.DownloadString(url + "&large_area=Z034");
                    prefecture = url + "&large_area=Z034";                    
                    break;

                case "大阪":
                    dString = wc.DownloadString(url + "&large_area=Z023");
                    prefecture = url + "&large_area=Z023";                    
                    break;

                case "兵庫":
                    dString = wc.DownloadString(url + "&large_area=Z024");
                    prefecture = url + "&large_area=Z024";                   
                    break;

                case "京都":
                    dString = wc.DownloadString(url + "&large_area=Z022");
                    prefecture = url + "&large_area=Z022";                    
                    break;

                case "滋賀":
                    dString = wc.DownloadString(url + "&large_area=Z021");
                    prefecture = url + "&large_area=Z021";                    
                    break;

                case "奈良":
                    dString = wc.DownloadString(url + "&large_area=Z025");
                    prefecture = url + "&large_area=Z025";                   
                    break;

                case "和歌山":
                    dString = wc.DownloadString(url + "&large_area=Z026");
                    prefecture = url + "&large_area=Z026";                   
                    break;

                case "岡山":
                    dString = wc.DownloadString(url + "&large_area=Z073");
                    prefecture = url + "&large_area=Z073";                    
                    break;

                case "広島":
                    dString = wc.DownloadString(url + "&large_area=Z074");
                    prefecture = url + "&large_area=Z074";                   
                    break;

                case "鳥取":
                    dString = wc.DownloadString(url + "&large_area=Z071");
                    prefecture = url + "&large_area=Z071";                    
                    break;

                case "島根":
                    dString = wc.DownloadString(url + "&large_area=Z072");
                    prefecture = url + "&large_area=Z072";                    
                    break;

                case "山口":
                    dString = wc.DownloadString(url + "&large_area=Z075");
                    prefecture = url + "&large_area=Z075";                    
                    break;

                case "香川":
                    dString = wc.DownloadString(url + "&large_area=Z082");
                    prefecture = url + "&large_area=Z082";                    
                    break;

                case "徳島":
                    dString = wc.DownloadString(url + "&large_area=Z081");
                    prefecture = url + "&large_area=Z081";                    
                    break;

                case "愛媛":
                    dString = wc.DownloadString(url + "&large_area=Z083");
                    prefecture = url + "&large_area=Z083";                    
                    break;

                case "高知":
                    dString = wc.DownloadString(url + "&large_area=Z084");
                    prefecture = url + "&large_area=Z084";                    
                    break;

                case "福岡":
                    dString = wc.DownloadString(url + "&large_area=Z091");
                    prefecture = url + "&large_area=Z091";                    
                    break;

                case "佐賀":
                    dString = wc.DownloadString(url + "&large_area=Z092");
                    prefecture = url + "&large_area=Z092";                    
                    break;
                case "長崎":
                    dString = wc.DownloadString(url + "&large_area=Z093");
                    prefecture = url + "&large_area=Z093";                    
                    break;

                case "熊本":
                    dString = wc.DownloadString(url + "&large_area=Z094");
                    prefecture = url + "&large_area=Z094";                    
                    break;

                case "大分":
                    dString = wc.DownloadString(url + "&large_area=Z095");
                    prefecture = url + "&large_area=Z095";                    
                    break;

                case "宮崎":
                    dString = wc.DownloadString(url + "&large_area=Z096");
                    prefecture = url + "&large_area=Z096";                    
                    break;

                case "鹿児島":
                    dString = wc.DownloadString(url + "&large_area=Z097");
                    prefecture = url + "&large_area=Z097";                    
                    break;

                case "沖縄":
                    dString = wc.DownloadString(url + "&large_area=Z098");
                    prefecture = url + "&large_area=Z098";                   
                    break;

            }
            switch (genreComboBox.Text) {
                case "居酒屋":
                    dString = wc.DownloadString(prefecture + "&genre=G001");
                    prefecture = prefecture + "&genre=G001";
                    break;
                case "ダイニングバー・バル":
                    dString = wc.DownloadString(prefecture + "&genre=G002");
                    prefecture = prefecture + "&genre=G002";
                    break;
                case "創作料理":
                    dString = wc.DownloadString(prefecture + "&genre=G003");
                    prefecture = prefecture + "&genre=G003";
                    break;
                case "和食":
                    dString = wc.DownloadString(prefecture + "&genre=G004");
                    prefecture = prefecture + "&genre=G004";
                    break;
                case "洋食":
                    dString = wc.DownloadString(prefecture + "&genre=G005");
                    prefecture = prefecture + "&genre=G005";
                    break;
                case "イタリアン・フレンチ":
                    dString = wc.DownloadString(prefecture + "&genre=G006");
                    prefecture = prefecture + "&genre=G006";
                    break;
                case "中華":
                    dString = wc.DownloadString(prefecture + "&genre=G007");
                    prefecture = prefecture + "&genre=G007";
                    break;
                case "焼肉・ホルモン":
                    dString = wc.DownloadString(prefecture + "&genre=G008");
                    prefecture = prefecture + "&genre=G008";
                    break;
                case "韓国料理":
                    dString = wc.DownloadString(prefecture + "&genre=G017");
                    prefecture = prefecture + "&genre=G017";
                    break;
                case "アジア・エスニック料理":
                    dString = wc.DownloadString(prefecture + "&genre=G009");
                    prefecture = prefecture + "&genre=G009";
                    break;
                case "各国料理":
                    dString = wc.DownloadString(prefecture + "&genre=G010");
                    prefecture = prefecture + "&genre=G010";
                    break;
                case "カラオケ・パーティ":
                    dString = wc.DownloadString(prefecture + "&genre=G011");
                    prefecture = prefecture + "&genre=G011";
                    break;
                case "バー・カクテル":
                    dString = wc.DownloadString(prefecture + "&genre=G012");
                    prefecture = prefecture + "&genre=G012";
                    break;
                case "ラーメン":
                    dString = wc.DownloadString(prefecture + "&genre=G013");
                    prefecture = prefecture + "&genre=G013";
                    break;
                case "お好み焼き・もんじゃ":
                    dString = wc.DownloadString(prefecture + "&genre=G016");
                    prefecture = prefecture + "&genre=G016";
                    break;
                case "カフェ・スイーツ":
                    dString = wc.DownloadString(prefecture + "&genre=G014");
                    prefecture = prefecture + "&genre=G014";
                    break;
                case "その他グルメ":
                    dString = wc.DownloadString(prefecture + "&genre=G015");
                    prefecture = prefecture + "&genre=G015";
                    break;
            }
            if (parkingCheckBox.IsChecked == true) {
                dString = wc.DownloadString(prefecture + "&parking=1");
                prefecture = prefecture + "&parking=1";
            }
            if (roomCheckBox.IsChecked == true) {
                dString = wc.DownloadString(prefecture + "&private_room=1");
                prefecture = prefecture + "&private_room=1";
            }
            
            dString = wc.DownloadString(prefecture + "&name=" + SearchTB.Text);

            var shopnum = 100;

            //var dString = wc.DownloadString("http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?key=dce4542a04b9085c&large_area=Z017&format=json");
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            SearchTB.Text = json.results.shop[shopnum].name;



            List<DataGridItems> items = new List<DataGridItems>() {

            };
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
