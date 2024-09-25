using konsola;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int index = 0;
        static List<DataRecord> records = new(FileHandling.GetRecords());
        public MainWindow()
        {
            InitializeComponent();
            DisplayContent(records[index]);
        }
        public void DisplayContent(DataRecord data)
        {
            Album.Content = data.Album;
            Quantity.Content = data.SongsNumber + " utworów";
            Artist.Content = data.Artist;
            Year.Content = data.Year;
            DownloadNumber.Content = data.DownloadNumber.ToString();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            index = index - 1 < 0 ? records.Count-1 : index - 1;
            DisplayContent(records[index]);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            index = index + 1;
            DisplayContent(records[index % records.Count]);
        }

        private void Download_Click(object sender, RoutedEventArgs e)
        {
            records[index].DownloadNumber += 1;
            DisplayContent(records[index]);
        }
    }
}