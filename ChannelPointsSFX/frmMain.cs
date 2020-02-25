using System;
using System.Windows.Forms;
using TwitchLib.PubSub;
using TwitchLib.PubSub.Events;
using System.Collections.Generic;
using System.Windows.Media;
using System.IO;

#if DEBUG
using System.Diagnostics;
#endif

namespace ChannelPointsSFX
{
    public partial class frmMain : Form
    {
        private static TwitchPubSub client;
        private static Dictionary<string, string> bindings = new Dictionary<string, string>();
        private static MediaPlayer thePlayer;
        private int volumeLevel = 50; 
        private int boxSelection = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            client = new TwitchPubSub();

            client.OnPubSubServiceConnected += onPubSubServiceConnected;
            client.OnListenResponse += onListenResponse;
            client.OnRewardRedeemed += OnRewardRedeemed;

            client.ListenToRewards("");

            client.Connect();

            if(File.Exists("settings.txt"))
            {
                String[] loadSettings = File.ReadAllLines("settings.txt");
                foreach(string line in loadSettings)
                {
                    string[] split = line.Split('|');
                    bindings.Add(split[0], split[1]);
                }
            }

            reloadListItems();

            txtVolume.Text = volumeLevel.ToString();
            trkVolume.Value = volumeLevel;
        }

        private static void onPubSubServiceConnected(object sender, EventArgs e)
        {
            // SendTopics accepts an oauth optionally, which is necessary for some topics
            client.SendTopics();
        }

        private static void onListenResponse(object sender, OnListenResponseArgs e)
        {
            if (!e.Successful)
                throw new Exception($"Failed to listen! Response: {e.Response}");
        }

        private void OnRewardRedeemed(object sender, OnRewardRedeemedArgs e)
        {
#if DEBUG
            Debug.WriteLine("Reward Redeemed:");
            Debug.WriteLine("\tTitle:"+e.RewardTitle);
            Debug.WriteLine("\tPrompt:"+e.RewardPrompt);
            Debug.WriteLine("\tUser:" + e.DisplayName);
            Debug.WriteLine("----------------");
#endif
            if(bindings.ContainsKey(e.RewardTitle))
            {
                string output;
                bindings.TryGetValue(e.RewardTitle, out output);
#if DEBUG
                Debug.WriteLine(output);
#endif
                this.PlaySound(output);
            }
        }

        private void trkVolume_Scroll(object sender, EventArgs e)
        {
            this.volumeLevel = trkVolume.Value;
            txtVolume.Text = this.volumeLevel.ToString();
            if (thePlayer != null)
            {
                this.SetVolume(this.volumeLevel);
            }
        }

        // `volume` is assumed to be between 0 and 100.
        public void SetVolume(int volume)
        {
            // MediaPlayer volume is a float value between 0 and 1.
            thePlayer.Volume = volume / 100.0f;
        }

        public void PlaySound(string filename)
        {
#if DEBUG
            Debug.WriteLine("Playing sound from \"" + filename + "\".");
#endif
            thePlayer = new MediaPlayer();
            thePlayer.Open(new Uri(filename));
            this.SetVolume(this.volumeLevel);
            thePlayer.MediaEnded += ThePlayer_MediaEnded;
            thePlayer.Play();
            
        }

        private void ThePlayer_MediaEnded(object sender, EventArgs e)
        {
#if DEBUG
            Debug.WriteLine("Sound playing ended.");
#endif
            thePlayer.Close();
        }

        private void reloadListItems()
        {
            lstbxSoundsRewards.Items.Clear();
            lstbxSoundsPaths.Items.Clear();

            foreach (KeyValuePair<string, string> kvp in bindings)
            {
                lstbxSoundsRewards.Items.Add(kvp.Key);
                string[] val = kvp.Value.Split('\\');
                lstbxSoundsPaths.Items.Add(val[val.Length-1]);
            }

            if (boxSelection > (bindings.Count - 1)) boxSelection = (bindings.Count - 1);

            if(bindings.Count == 0)
            {
                btnUp.Enabled = false;
                btnDown.Enabled = false;
                btnRemove.Enabled = false;
                btnTest.Enabled = false;
            } 
            else
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
                btnRemove.Enabled = true;
                btnTest.Enabled = true;
                lstbxSoundsRewards.SelectedIndex = boxSelection;
                lstbxSoundsPaths.SelectedIndex = boxSelection;
                saveBindings();
            }
        }

        private void saveBindings()
        {
            String buildString = "";
            foreach (KeyValuePair<string, string> kvp in bindings)
            {
                buildString += kvp.Key + "|" + kvp.Value + "\n";
            }
            File.WriteAllText("settings.txt", buildString);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            boxSelection--;
            if (boxSelection < 0) boxSelection = 0;
            lstbxSoundsRewards.SelectedIndex = boxSelection;
            lstbxSoundsPaths.SelectedIndex = boxSelection;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            boxSelection++;
            if (boxSelection > (bindings.Count-1)) boxSelection = (bindings.Count - 1);
            lstbxSoundsRewards.SelectedIndex = boxSelection;
            lstbxSoundsPaths.SelectedIndex = boxSelection;
        }

        private void lstbxSoundsRewards_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxSoundsRewards.SelectedIndex = boxSelection;
        }

        private void lstbxSoundsPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxSoundsPaths.SelectedIndex = boxSelection;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bindings.Remove(lstbxSoundsRewards.SelectedItem.ToString());
            reloadListItems();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string output;
            bindings.TryGetValue(lstbxSoundsRewards.SelectedItem.ToString(), out output);
            PlaySound(output);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string rewardName = Prompt.ShowDialog("Enter the twitch Channel Points reward name EXACTLY as it is on twitch.", "Channel Reward Name");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    bindings.Add(rewardName, filePath);
                    reloadListItems();
                }
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, AutoSize = true, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
