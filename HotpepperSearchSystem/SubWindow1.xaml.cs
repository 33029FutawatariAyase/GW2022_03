using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static HotpepperSearchSystem.MainWindow;

namespace HotpepperSearchSystem {
    /// <summary>
    /// SubWindow1.xaml の相互作用ロジック
    /// </summary>
    public partial class SubWindow1 : Window {
        public SubWindow1() {
            InitializeComponent();
            var axIWebBrowser2 = typeof(WebBrowser).GetProperty("AxIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            var comObj = axIWebBrowser2.GetValue(webbrowser, null);
            comObj.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, comObj, new object[] { true });
            //webbrowser.AllowNavigation = false;
        }

        public bool AllowBrowserDrop { get; set; }
        private void Grid_Loaded(object sender, RoutedEventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            
            webbrowser.Source = new Uri(MainWindow.shopurl);
            AllowBrowserDrop = false;




        }
        
    }
}
