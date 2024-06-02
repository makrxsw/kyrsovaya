using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace kyrsovaya
{
    public partial class clubs : Form
    {
        public clubs()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 100;
            string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json"; 

            string jsonText = File.ReadAllText(jsonFilePath);
            ClubsData data = JsonSerializer.Deserialize<ClubsData>(jsonText);

            AddClubsToListView(data.FootballPlayers);
            AddClubsToListView(data.HockeyPlayers);
            AddClubsToListView(data.BasketballPlayers);
        }

        private void AddClubsToListView(List<Player> players)
        {
            foreach (Player player in players)
            {
                if (!listView1.Items.ContainsKey(player.Club))
                {
                    listView1.Items.Add(player.Club, player.Club, -1);
                }
            }
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

        private void clubs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public string Club { get; set; }
        public int Achievement { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
    }

    public class ClubsData
    {
        public List<Player> FootballPlayers { get; set; }
        public List<Player> HockeyPlayers { get; set; }
        public List<Player> BasketballPlayers { get; set; }
    }
}
