using System.Windows;

namespace Mod
{
	public partial class ModConfigs : Window
	{

		private Options twitchFile;


		public ModConfigs()
		{
			Init();
		}

		private void Init()
		{
            InitializeComponent();

			twitchFile = OptionsFile.readFile();

			//twitch tab
			initializeTwitchDocumentValues();
			setEditabilityOfTwitchFields();

		}

		void setEditabilityOfTwitchFields()
        {
            bool agreed = enable_twitch_voting.IsChecked.GetValueOrDefault();
            //chenge the editability of other twitch related fields
            twitch_channel_name.IsEnabled = agreed;
            twitch_channel_oauth.IsEnabled = agreed;
            twitch_user_name.IsEnabled = agreed;
        }


		//TWITCH FILE
		private void initializeTwitchDocumentValues()
		{
			enable_twitch_voting.IsChecked = Utils.isValueTrue(twitchFile.enableTwitchVoting);
			twitch_channel_oauth.Password = twitchFile.oAuth;
			twitch_channel_name.Text = twitchFile.twitchChannelName;
			twitch_user_name.Text = twitchFile.twitchUserName;
		}

		private void setTwittchDocumentValues()
        {
			twitchFile.enableTwitchVoting = enable_twitch_voting.IsChecked.GetValueOrDefault().ToString();
			twitchFile.oAuth = twitch_channel_oauth.Password;
			twitchFile.twitchChannelName = twitch_channel_name.Text;
			twitchFile.twitchUserName = twitch_user_name.Text;
		}


		//EVENTS
		private void enable_twitch_voting_clicked_event(object sender, RoutedEventArgs e)
		{
			setEditabilityOfTwitchFields();
		}

		private void save_click_event(object sender, RoutedEventArgs e)
		{
			setTwittchDocumentValues();
			OptionsFile.writeFile(twitchFile);
			MessageBox.Show("To see the changes refresh the index.html file in the browser and re-add it to OBS.");
		}
	}
}
