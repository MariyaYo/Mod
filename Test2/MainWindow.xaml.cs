using System.Windows;

namespace Test2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		private Options twitchFile;


		public MainWindow()
		{
			Init();
		}

		private void Init()
		{
			InitializeComponent();

			twitchFile = OptionsFile.readFile("twitch.xml");

			InitTwitchTab();
		}

		private void InitTwitchTab()
		{
			enable_twitch_voting.IsChecked = twitchFile.enableTwitchVoting.Equals("True");
			twitch_channel_oauth.Password = twitchFile.oAuth;
			twitch_channel_name.Text = twitchFile.twitchChannelName;
			twitch_user_name.Text = twitchFile.twitchUserName;

			initializeTwitchFieldEditability();
        }

		private void enable_twitch_voting_clicked_event(object sender, RoutedEventArgs e)
		{
			initializeTwitchFieldEditability();
		}


        void initializeTwitchFieldEditability()
        {
            bool agreed = enable_twitch_voting.IsChecked.GetValueOrDefault();

			//chenge the editability of other twitch related fields
			twitch_channel_name.IsEnabled = agreed;
            twitch_channel_oauth.IsEnabled = agreed;
            twitch_user_name.IsEnabled = agreed;
        }

		private void save_click_event(object sender, RoutedEventArgs e)
		{
			twitchFile.enableTwitchVoting =  enable_twitch_voting.IsChecked.GetValueOrDefault().ToString();
			twitchFile.oAuth = twitch_channel_oauth.Password;
			twitchFile.twitchChannelName = twitch_channel_name.Text;
			twitchFile.twitchUserName = twitch_user_name.Text;

			OptionsFile.writeFile(twitchFile);
			MessageBox.Show("To see the changes refresh the index.html file in the browser and re-add it to OBS.");
		}

	}
}
