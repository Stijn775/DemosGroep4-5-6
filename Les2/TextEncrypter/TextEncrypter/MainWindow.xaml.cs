using System.Diagnostics.Eventing.Reader;
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

namespace TextEncrypter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IEncryptor encryptor = new ReverseEncryptor();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           
            if (sender == reverseRadioButton)
            {
                encryptor = new ReverseEncryptor();
            } else if(sender == shiftOneRadioButton)
            {
                encryptor = new ShiftOneEncryptor();
            } else if(sender == reverseAlphabetRadioButton)
            {
                encryptor = new ReverseAlphabetEncryptor();
            }
        }

        private void Encrypt_Clicked(object sender, RoutedEventArgs e)
        {
            string decrypted = encryptor.Encrypt(encryptTextBox.Text);
            decryptTextBox.Text = decrypted;
        }


        private void Decrypt_Clicked(object sender, RoutedEventArgs e)
        {
            string encrypted = encryptor.Decrypt(decryptTextBox.Text);
            encryptTextBox.Text = encrypted;
        }
    }
}