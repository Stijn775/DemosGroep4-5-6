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

        //public delegate string EncryptorDelegate(string s);

        Func<string,string> encrypt;
        Func<string, string> decrypt;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           
            if (sender == reverseRadioButton)
            {
                encrypt = ReverseEncryptor.Encrypt;
                decrypt = ReverseEncryptor.Decrypt;
                //encryptor = new ReverseEncryptor();
            } else if(sender == shiftOneRadioButton)
            {
                encrypt = ShiftOneEncryptor.Encrypt;
                decrypt = ShiftOneEncryptor.Decrypt;
                //encryptor = new ShiftOneEncryptor();
            } else if(sender == reverseAlphabetRadioButton)
            {
                encrypt = ReverseAlphabetEncryptor.Encrypt;
                decrypt = ReverseAlphabetEncryptor.Decrypt;
                //encryptor = new ReverseAlphabetEncryptor();
            }
        }

        private void Encrypt_Clicked(object sender, RoutedEventArgs e)
        {
            string ecrypted = encrypt(decryptTextBox.Text);
            encryptTextBox.Text = ecrypted;
        }


        private void Decrypt_Clicked(object sender, RoutedEventArgs e)
        {
            string decrypted = decrypt(encryptTextBox.Text);
            decryptTextBox.Text = decrypted;
        }
    }
}