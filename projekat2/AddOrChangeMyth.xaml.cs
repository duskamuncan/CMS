using Microsoft.Win32;
using Notification.Wpf;
using projekat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
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
using Brush = System.Windows.Media.Brush;
using Brushes = System.Windows.Media.Brushes;

namespace projekat2
{
    /// <summary>
    /// Interaction logic for AddOrChangeMyth.xaml
    /// </summary>
    public partial class AddOrChangeMyth : Window, INotifyPropertyChanged
    {
        private Brush toolBarBrush;
        public bool IsSelected;
        Helper helper = new Helper();

        ObservableCollection<Photo> photoItems = new ObservableCollection<Photo>();

        User user = new User();


        string photo = "";

        // public ObservableCollection<Myth> Myths { get; set; }
        private ObservableCollection<Myth> Myths = new ObservableCollection<Myth>();


        public AddOrChangeMyth(ObservableCollection<Myth> Myths)
        {

            InitializeComponent();
            FontFamilyComboBox.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            toolBarBrush = EditorToolBar.Background;
            EditorToolBar.Background = Brushes.Beige;
            user.Role = new UserRole();
            DataTable dt = new DataTable(user.Role);
            this.Myths = Myths;

            foreach (var colorProperty in typeof(Colors).GetProperties())
            {
                Color color = (Color)colorProperty.GetValue(null, null);
               
               Colors.Items.Add(new ComboBoxItem() { Content = colorProperty.Name, Background = new SolidColorBrush(color) });
            }

            Myths = helper.DeSerializeObject<ObservableCollection<Myth>>("Myths.xml");
            if (Myths == null)
            {
                Myths = new ObservableCollection<Myth>();
            }

             Myths = dt.Myths;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void SaveDataAsXML()
        {
            helper.SerializeObject<ObservableCollection<Myth>>(Myths, "Myths.xml");
        }

        private string SaveRtfFile(string rtfContent, string fileName)
        {
            string folderPath = @"C:\Users\Duska\Desktop\3.godina\iuis\projekat2\projekat2\RTF\"; // Update this with your desired folder path

            // Combine the folder path with the file name
            string filePath = System.IO.Path.Combine(folderPath, fileName);

            try
            {
                // Write the RTF content to the new .rtf file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(rtfContent);
                }

                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving RTF file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }

        
        private void AddChangeButton_Click(object sender, RoutedEventArgs e)
        {
            user.Role = new UserRole();
            DataTable dt = new DataTable(user.Role);
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;



            if (ValidateFormData())
            {
                Myth newMyth = new Myth()
                {
                    Rating = int.Parse(RatingBox.Text),
                    God = GodTextBox.Text,
                   PathToPhoto = photo,
                    PathToDescriptionRtf = SaveRtfFile(new TextRange(DescriptionRichTextBox.Document.ContentStart, DescriptionRichTextBox.Document.ContentEnd).Text, GodTextBox.Text + ".rtf"),
                    Date = DateTime.Now
                };

                


                Myths.Add(newMyth);
                SaveDataAsXML();


                this.Close();
                mainWindow.ShowToastNotification(new ToastNotification("Success", "Myth added to the Data Table", NotificationType.Success));
               
                
            }
            else
            {
                mainWindow.ShowToastNotification(new ToastNotification("Error", "Form fields are not correctly filled!", NotificationType.Error));

            }
        }

      

        private bool ValidateFormData()
        {
            bool isValid = true;
            if (GodTextBox.Text.Trim().Equals(string.Empty))
            {
                isValid = false;
                GodErrorLabel.Content = "Form field cannot be left empty";
                GodTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                GodErrorLabel.Content = string.Empty;
                GodTextBox.BorderBrush = Brushes.SaddleBrown;
            }

            if (imgPhoto.Source == null)
            {
                isValid = false;
                PhotoErrorLabel.Content = "Must choose photo";
                AddPhotoButton.BorderBrush = Brushes.Red;
            }
            else
            {
                PhotoErrorLabel.Content = string.Empty;
                AddPhotoButton.BorderBrush = Brushes.SaddleBrown;
            }

            if (string.IsNullOrWhiteSpace(new TextRange(DescriptionRichTextBox.Document.ContentStart, DescriptionRichTextBox.Document.ContentEnd).Text))
            {
                isValid = false;
                DescriptonErrorLabel.Content = "Form field cannot be empty";
                DescriptionRichTextBox.BorderBrush = Brushes.Red;
            }
            else
            {
                DescriptonErrorLabel.Content = string.Empty;
                DescriptionRichTextBox.BorderBrush = Brushes.SaddleBrown;
            }

            if (RatingBox.Text.Trim().Equals(string.Empty))
            {
                isValid = false;
                RatingErrorLabel.Content = "Form field cannot be left empty";
                RatingBox.BorderBrush = Brushes.Red;
            }
            else
            {
                RatingErrorLabel.Content = string.Empty;
                RatingBox.BorderBrush = Brushes.SaddleBrown;
            }

            return isValid;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DescriptionRichTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object fontWeight = DescriptionRichTextBox.Selection.GetPropertyValue(Inline.FontWeightProperty);
            BoldToggleButton.IsChecked = (fontWeight != DependencyProperty.UnsetValue) && (fontWeight.Equals(FontWeights.Bold));

            object fontFamily = DescriptionRichTextBox.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            FontFamilyComboBox.SelectedItem = fontFamily;
        }

        private void FontFamilyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontFamilyComboBox.SelectedItem != null && !DescriptionRichTextBox.Selection.IsEmpty)
            {
                DescriptionRichTextBox.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, FontFamilyComboBox.SelectedItem);
            }
        }


        private void DisplayImagePreview(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath);
            bitmap.DecodePixelWidth = 100; // Resize image to fit the preview area
            bitmap.EndInit();
            imgPhoto.Source = bitmap;
        }

        private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            openFileDialog1.Filter = "Image Files|.jpg;.jpeg;.png;.gif;.bmp|All Files|.*";
            if (openFileDialog1.ShowDialog() == true)
            {
                photo = openFileDialog1.FileName;
                DisplayImagePreview(openFileDialog1.FileName);
            }


            
        }

       
        private void Colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedColorName = ((ComboBoxItem)(sender as ComboBox).SelectedItem).Content.ToString();
            var selectedColor = (Color)typeof(Colors).GetProperty(selectedColorName).GetValue(null, null);
            if (DescriptionRichTextBox!=null && DescriptionRichTextBox.Selection.Text.Length >0)
            {
               
                DescriptionRichTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(selectedColor));
            }

        }

        private void WordCount()
        {
            int wcount = 0;
            int index = 0;
            string richText = new TextRange(DescriptionRichTextBox.Document.ContentStart, DescriptionRichTextBox.Document.ContentEnd).Text;

            while (index < richText.Length && char.IsWhiteSpace(richText[index]))
            {
                index++;
            }

            while (index < richText.Length)
            {
                while (index < richText.Length && !char.IsWhiteSpace(richText[index]))
                {
                    index++;
                }

                wcount++;

                while (index < richText.Length && char.IsWhiteSpace(richText[index]))
                {
                    index++;
                }
            }
            WordCountTextBlock.Text = wcount.ToString();
        }

        private void DescriptionRichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            WordCount();
        }

        
        
    }
}
