using System.Windows;
using System.Windows.Input;

namespace Test2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		private OptionsFile twitchFile = new OptionsFile("twitch.ini");


		public MainWindow()
		{
			InitializeComponent();

			InitTwitchTab();
		}

		private void InitTwitchTab()
		{
			TwitchTabHandleAgreed();
        }

		private void twitch_user_agreed_Clicked(object sender, RoutedEventArgs e)
		{
			TwitchTabHandleAgreed();
		}


        void TwitchTabHandleAgreed()
        {
            bool agreed = twitch_user_agreed.IsChecked.GetValueOrDefault();

            twitch_user_channel_name_label.IsEnabled = agreed;
            twitch_user_channel_name.IsEnabled = agreed;
            twitch_user_channel_oauth_label.IsEnabled = agreed;
            twitch_user_channel_oauth.IsEnabled = agreed;
            twitch_user_user_name_label.IsEnabled = agreed;
            twitch_user_user_name.IsEnabled = agreed;
        }

		private void OnlyNumbersPreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			Utils.HandleOnlyNumbersPreviewTextInput(e);
		}


		private void NoSpacePreviewKeyDown(object sender, KeyEventArgs e)
		{
			Utils.HandleNoSpacePreviewKeyDown(e);
		}

		private void NoCopyPastePreviewExecuted(object sender, ExecutedRoutedEventArgs e)
		{
			Utils.HandleNoCopyPastePreviewExecuted(e);
		}
	}
}
