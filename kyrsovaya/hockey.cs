using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace kyrsovaya
{
    public partial class hockey : Form
    {
        public hockey()
        {
            InitializeComponent();
        }

        private void повернутисяНаГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            golovna form1 = new golovna();
            form1.Show();
            this.Hide();
        }

        private void закритиПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 100;
            string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";

            try
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                var data = JsonSerializer.Deserialize<ShaibaData>(jsonText);

                List<HockeyPlayer> hockeyPlayers = data.HockeyPlayers;

                HockeyPlayer playerWithHighestAchievement = hockeyPlayers.OrderByDescending(p => p.Achievement).FirstOrDefault();

                if (playerWithHighestAchievement != null)
                {
                    ListViewItem item = new ListViewItem(playerWithHighestAchievement.Name);
                    item.SubItems.Add(playerWithHighestAchievement.Years.ToString());
                    item.SubItems.Add(playerWithHighestAchievement.Club);
                    item.SubItems.Add(playerWithHighestAchievement.Achievement.ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message);
            }
        }

        private void hockey_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    public class HockeyPlayer
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public string Club { get; set; }
        public int Achievement { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
    }
    public class ShaibaData
    {
        public List<HockeyPlayer> HockeyPlayers { get; set; }
    }
}
