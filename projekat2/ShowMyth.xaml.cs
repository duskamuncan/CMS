using projekat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
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

namespace projekat2
{
    /// <summary>
    /// Interaction logic for ShowMyth.xaml
    /// </summary>
    public partial class ShowMyth : Page
    {
        public ObservableCollection<Myth> Myths { get; set; }
        User user = new User();
        Myth myth2 = new Myth();

        public ShowMyth()
        {
            InitializeComponent();

        }
        public ShowMyth( Myth myth)
        {
            InitializeComponent();
            user.Role = new UserRole();
            DataTable dt = new DataTable(user.Role);
           // Myths = dt.Myths;
           

            this.myth2 = myth;

            GodTextBlock.Text = myth2.God;

            Uri uri = new Uri(myth2.PathToPhoto, UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uri);

            TextRange textRange;
            System.IO.FileStream fileStream;


            if (System.IO.File.Exists(myth2.PathToDescriptionRtf))
            {
                textRange = new TextRange(DescriptionRichTextBox.Document.ContentStart, DescriptionRichTextBox.Document.ContentEnd);
                using (fileStream = new System.IO.FileStream(myth2.PathToDescriptionRtf, System.IO.FileMode.OpenOrCreate))
                {
                    textRange.Load(fileStream, System.Windows.DataFormats.Rtf);
                }
            }

            RatingTextBlock.Text = myth2.Rating.ToString();

            DateTextBlock.Text = myth2.Date.ToString();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.Yes)
            {

                NavigationService navService = NavigationService.GetNavigationService(this);

                // Vratite se na prethodnu stranicu
                navService.GoBack();



            }
        }

    }
}
