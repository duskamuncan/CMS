using Notification.Wpf;
using Notifications.Wpf.Annotations;
using projekat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Helper helper = new Helper();

        private MainWindow mainWindow;

        private NotificationManager notificationManager;

        public ObservableCollection<Myth> Myths { get; set; }

        public MainWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        public MainWindow()
        {
            InitializeComponent();

             new ObservableCollection<Myth>
           {
               new Myth (5, "Atalanta", "C:\\Users\\Duska\\Desktop\\3.godina\\iuis\\projekat2\\projekat2\\Atalanta.jpg","C:\\Users\\Duska\\Desktop\\iuis\\projekat2\\projekat2\\RTF\\Atalanta.rtf", DateTime.Now ),
               new Myth (7, "Pandora", "C:\\Users\\Duska\\Desktop\\3.godina\\iuis\\projekat2\\projekat2\\MythPhoto\\Pandora.jpg","C:\\Users\\Duska\\Desktop\\iuis\\projekat2\\projekat2\\RTF\\Pandora.rtf", DateTime.Now ),
               new Myth (3, "Dedal i Ikar", "C:\\Users\\Duska\\Desktop\\3.godina\\iuis\\projekat2\\projekat2\\MythPhoto\\dedal-ikar.jpg","C:\\Users\\Duska\\Desktop\\iuis\\projekat2\\projekat2\\RTF\\Dedal_i_Ikar.rtf", DateTime.Now )

           };

            notificationManager = new NotificationManager();

           

            helper.SerializeObject(Myths, "Myths.xml");

            User user1 = new User("duska", "ftn", UserRole.Admin);
            User user2 = new User("visitor1", "ftn1", UserRole.Visitor);

            List<User> users = new List<User>() { user1, user2 };

            helper.SerializeObject(users, "Users.xml");
        }
        
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                this.Close();
            }

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {


            if (ValidateFormData())
            {

                //Funkcije za proveru username-a i password-a
                List<User> defaultUsers = helper.DeSerializeObject<List<User>>("Users.xml");
                foreach (User user in defaultUsers)
                {
                    if (user.Username == UsernameTextBox.Text && user.Password == PasswordTextBox.Password)
                    {
                        DataTable dt = new DataTable(user.Role);

                         LoginFrame.NavigationService.Navigate(dt);
                        //ako postoji sta je admin ili visitor 
                        break;
                    }
                }
            }
        }

        public void ShowToastNotification(ToastNotification toastNotification)
        {
            notificationManager.Show(toastNotification.Title, toastNotification.Message, toastNotification.Type, "WindowNotificationArea");
        }

        

        private bool ValidateFormData()
        {
            bool isValid = true;

            if (UsernameTextBox.Text.Trim().Equals(string.Empty) )
            {
                isValid = false;
                UsernameErrorLabel.Content = "Form field cannot be left empty";
                UsernameTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                UsernameErrorLabel.Content = string.Empty;
                UsernameTextBox.BorderBrush = Brushes.SaddleBrown;
            }

            if (PasswordTextBox.Password.Trim().Equals(string.Empty))
            {
                isValid = false;
                PasswordErrorLabel.Content = "Form field cannot be left empty";
                PasswordTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                PasswordErrorLabel.Content = string.Empty;
                PasswordTextBox.BorderBrush = Brushes.SaddleBrown;
            }

            return isValid;
        }

        
    }
}
