using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace kyrsovaya
{
    public partial class football : Form
    {
        public football()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 100;
            string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";

            string jsonText = File.ReadAllText(jsonFilePath);

            List<FootballPlayer> players = JsonSerializer.Deserialize<PlayersData>(jsonText).FootballPlayers;

            FootballPlayer playerWithHighestAchievement = players.OrderByDescending(p => p.Achievement).FirstOrDefault();

            if (playerWithHighestAchievement != null)
            {
                ListViewItem item = new ListViewItem(playerWithHighestAchievement.Name);
                item.SubItems.Add(playerWithHighestAchievement.Years.ToString());
                item.SubItems.Add(playerWithHighestAchievement.Club);
                item.SubItems.Add(playerWithHighestAchievement.Achievement.ToString());
                listView1.Items.Add(item);
            }
        }

        private void повернутисяНаГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            golovna form1 = new golovna();
            form1.Show();
            this.Hide();
        }

        private void вийтиЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void football_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    public class FootballPlayer
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public string Club { get; set; }
        public int Achievement { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
    }

    public class PlayersData
    {
        public List<FootballPlayer> FootballPlayers { get; set; }

    }
}
