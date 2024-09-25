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
        public MainWindow()
        {
            InitializeComponent();
            DisplayContent(FileHandling.GetRecords()[index]);
        }
        public void DisplayContent(DataRecord data)
        {
            Album.Content = data.Album;
            Quantity.Content = data.SongsNumber;
            Artist.Content = data.Artist;
            Year.Content = data.Year;
            Number.Content = data.DownloadTime.ToString();
        }
    }
}