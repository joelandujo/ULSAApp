using POSUNO.Helpers;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ULSAApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void BtnClick(object sender, RoutedEventArgs e)
        {
            bool isValid = await ValidForm();

            if (!isValid)
            {
                return;
            }
            MessageDialog Msg = new MessageDialog("Correcto.", "Ok");
            await Msg.ShowAsync();

        }

        private async Task<bool> ValidForm()
        {
            MessageDialog Msg;
            if (!RegexUtilities.IsValidEmail(EMailGet.Text))
            {
                Msg = new MessageDialog("Debes ingresar un EMail válido.", "Error");
                await Msg.ShowAsync();
                return false;
            }
            if (string.IsNullOrEmpty(PasswordGet.Password))
            {
                Msg = new MessageDialog("Debes ingresar tu Password.", "Error");
                await Msg.ShowAsync();
                return false;
            }
            return true;
        }
    }

}
