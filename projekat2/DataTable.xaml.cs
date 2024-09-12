using Notification.Wpf;
using projekat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
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
    /// Interaction logic for DataTable.xaml
    /// </summary>
    public partial class DataTable : Page, INotifyPropertyChanged
    {
        public ObservableCollection<Myth> Myths { get; set; }
        public UserRole Role2 { get; set; }
        Helper helper = new Helper();
        private bool _isSelected;
        public event PropertyChangedEventHandler PropertyChanged;
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

        string photo = "";

        public DataTable(UserRole role)
        {
            InitializeComponent();
            this.Role2 = role;

            if (Role2 != UserRole.Admin)
            {
                AddButton.Visibility = Visibility.Hidden;
            }

            if (Role2 != UserRole.Admin)
            {
                DeleteButton.Visibility = Visibility.Hidden;
            }

            DataContext = this;

            Myths = helper.DeSerializeObject<ObservableCollection<Myth>>("Myths.xml");
            if (Myths == null)
            {
                Myths = new ObservableCollection<Myth>();
            }

           MythsDataGrid.ItemsSource = Myths;
            MythsDataGrid.Items.Refresh();

            //ovde imam pristup jel admin ili visitor
        }

        private void SaveDataAsXML()
        {
            helper.SerializeObject<ObservableCollection<Myth>>(Myths, "Myths.xml");
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
               
                SaveDataAsXML();


                this.NavigationService.Navigate(new Uri("AddOrChangeMyth.xaml", UriKind.RelativeOrAbsolute));

                this.NavigationService.Refresh();
                 NavigationService navService = NavigationService.GetNavigationService(this);

                // Vratite se na prethodnu stranicu
                navService.GoBack();



            }

        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddOrChangeMyth ac = new AddOrChangeMyth(Myths);
            ac.ShowDialog();
            
            
        }

        private void RemoveItem(Myth myth)
        {
            if (Myths.Contains(myth))
            {
                Myths.Remove(myth);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            var itemsToDelete = new ObservableCollection<Myth>();

            foreach (var myth in Myths)
            {
                if (myth.IsSelected)
                {
                    itemsToDelete.Add(myth);
                }
            }

            foreach (var item in itemsToDelete)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to delete item?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    RemoveItem(item);
                    mainWindow.ShowToastNotification(new ToastNotification("Success", "Myth deleted from Data Table", NotificationType.Success));


                }
                
            }
            MythsDataGrid.ItemsSource = null;
            MythsDataGrid.ItemsSource = Myths;
        }



        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            if (Role2 == UserRole.Admin)
            {
                DataGridRow row = (DataGridRow)MythsDataGrid.ItemContainerGenerator.ContainerFromIndex(MythsDataGrid.SelectedIndex);
                Myth selectedMyth = (Myth)row.Item;
                AddOrChangeMyth ac = new AddOrChangeMyth(Myths );
                ac.GodTextBox.Text = selectedMyth.God;
                photo = selectedMyth.PathToPhoto;
                Uri uri = new Uri(photo,UriKind.RelativeOrAbsolute);
                ac.imgPhoto.Source = new BitmapImage(uri);


                string fileName = "..\\..\\RTF\\" + selectedMyth.God + ".rtf";
                TextRange range;
                FileStream fStream;
                if (File.Exists(fileName))
                {
                    range = new TextRange(ac.DescriptionRichTextBox.Document.ContentStart, ac.DescriptionRichTextBox.Document.ContentEnd);
                    fStream = new FileStream(fileName, FileMode.OpenOrCreate);
                    range.Load(fStream, DataFormats.Rtf);
                    fStream.Close();
                }



                TextRange textRange;
                System.IO.FileStream fileStream;


                if (System.IO.File.Exists(selectedMyth.PathToDescriptionRtf))
                {
                    textRange = new TextRange(ac.DescriptionRichTextBox.Document.ContentStart, ac.DescriptionRichTextBox.Document.ContentEnd);
                    using (fileStream = new System.IO.FileStream(selectedMyth.PathToDescriptionRtf, System.IO.FileMode.OpenOrCreate))
                    {
                        textRange.Load(fileStream, System.Windows.DataFormats.Rtf);
                    }
                }

                
                ac.RatingBox.Text = selectedMyth.Rating.ToString();
                RemoveItem(selectedMyth);
                ac.ShowDialog();
            }
            else
            {
                

                DataGridRow row = (DataGridRow)MythsDataGrid.ItemContainerGenerator.ContainerFromIndex(MythsDataGrid.SelectedIndex);
                Myth selectedMyth = (Myth)row.Item;
                ShowMyth sm = new ShowMyth(selectedMyth);
                this.NavigationService.Navigate(sm);

            }
        }

        private void MythsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MythsDataGrid.SelectedItem != null)
            {
                _isSelected = true;

            }
        }
    }
}
