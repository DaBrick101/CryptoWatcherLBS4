using System;
using System.Windows;
using System.Windows.Input;
using CryptoWatcherLib;
using CryptoWatcherLib.DataAccess.Graph;
using LiveCharts;
using LiveCharts.Wpf;

namespace CryptoWatcherWPF.View
{
    /// <summary>
    /// Interaction logic for GraphWindow.xaml
    /// </summary>
    public partial class GraphWindow : Window
    {
        public SeriesCollection SeriesCollectionCryptoCourse { get; set; }
        public string[] XLabelsCryptoCourse { get; set; }
        public Func<double, string> YFormatterCryptoCourse { get; set; }
        public GraphWindow()
        {
            InitializeComponent();
            InitializeCryptoCourseGraph();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void InitializeCryptoCourseGraph()
        {
            var btcData = ServiceFactory.Instance.Resolve<IGraphData>().BtcValues;
            //var ethData = ServiceFactory.Instance.Resolve<IGraphData>().EthValues;
            //var dogeData = ServiceFactory.Instance.Resolve<IGraphData>().DogeValues;

            SeriesCollectionCryptoCourse = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Bitcoin",
                    Values = new ChartValues<double>(btcData),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255,0,0))
                   
                },
                ////new LineSeries
                ////{
                ////    Title = "Ehterum",
                ////    Values = new ChartValues<double>(ethData),
                ////    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0,0,255))
                ////},
                ////new LineSeries
                ////{
                ////    Title = "Dogecoin",
                ////    Values = new ChartValues<double>(dogeData),
                ////    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0,255,0))
                ////}
            };

            //Defining Labels of Graph
            var datesList = ServiceFactory.Instance.Resolve<IGraphData>().Dates;  
            XLabelsCryptoCourse = datesList;
            YFormatterCryptoCourse = value => value.ToString();
            DataContext = this;
        }

        private void btnDashboardWindow_Click(object sender, RoutedEventArgs e)
        {

            DashboardWindow dbw = new DashboardWindow();
            dbw.Show();
            this.Close();
        }
    }
}
