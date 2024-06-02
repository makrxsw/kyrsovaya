using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace kyrsovaya
{
    public partial class sportsmen : Form
    {
        public class PlayerInfo
        {
            public string Name { get; set; }
            public string Nationality { get; set; }
            public string Gender { get; set; }
            public int Years { get; set; }
            public string Club { get; set; }
            public int Achievement { get; set; }
        }

        public class FootballPlayer : PlayerInfo { }
        public class HockeyPlayer : PlayerInfo { }
        public class BasketballPlayer : PlayerInfo { }

        public class SportsData
        {
            public List<FootballPlayer> FootballPlayers { get; set; } = new List<FootballPlayer>();
            public List<HockeyPlayer> HockeyPlayers { get; set; } = new List<HockeyPlayer>();
            public List<BasketballPlayer> BasketballPlayers { get; set; } = new List<BasketballPlayer>();
        }

        public sportsmen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configure ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Add columns
            listView1.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Nationality", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Gender", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Years", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Club", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Achievement", -2, HorizontalAlignment.Left);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
            LoadDataFromFile();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(new[] { "Football", "Hockey", "Basketball" });
        }

        private void LoadDataFromFile()
        {
            string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";

            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                var data = JsonSerializer.Deserialize<SportsData>(jsonData);

                PopulateListView(data);
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }

        private void PopulateListView(SportsData data)
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();

            foreach (var player in data.FootballPlayers)
            {
                AddPlayerToListView(player, "забитих голів");
            }

            foreach (var player in data.HockeyPlayers)
            {
                AddPlayerToListView(player, "забитих шайб");
            }

            foreach (var player in data.BasketballPlayers)
            {
                AddPlayerToListView(player, "забитих м'ячів");
            }

            // Adjust column width
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2; // Auto-resize to fit content
            }

            listView1.EndUpdate();
        }

        private void AddPlayerToListView(PlayerInfo player, string achievementLabel)
        {
            var listViewItem = new ListViewItem(player.Name);
            listViewItem.SubItems.Add($"Національність: {player.Nationality}");
            listViewItem.SubItems.Add(player.Gender);
            listViewItem.SubItems.Add($"{player.Years} років");
            listViewItem.SubItems.Add($"Клуб: {player.Club}");
            listViewItem.SubItems.Add($"{player.Achievement} {achievementLabel}");
            listView1.Items.Add(listViewItem);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            listView1.Items.Clear();
            string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            var data = JsonSerializer.Deserialize<SportsData>(jsonData);
            string searchText = richTextBox1.Text.ToLower();

            SearchPlayers(data.FootballPlayers, searchText, "забитих голів");
            SearchPlayers(data.HockeyPlayers, searchText, "забитих шайб");
            SearchPlayers(data.BasketballPlayers, searchText, "забитих м'ячів");

            toolStripProgressBar1.Value = 100;
            MessageBox.Show("Ваш результат пошуку виведено");
            toolStripProgressBar1.Value = 0;
        }


        private void SearchPlayers<T>(List<T> players, string searchText, string achievementLabel) where T : PlayerInfo
        {
            foreach (var player in players)
            {
                if (player.Name.ToLower().Contains(searchText) || player.Club.ToLower().Contains(searchText))
                {
                    AddPlayerToListView(player, achievementLabel);
                }
            }
        }


        private void повернутисяНаГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new golovna();
            form1.Show();
            this.Hide();
        }

        private void видалитиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void DeleteFile()
        {
            string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";

            if (File.Exists(jsonFilePath))
            {
                File.Delete(jsonFilePath);
                MessageBox.Show("Файл успішно видалено. \n \n Повернення на головну");
                var form1 = new golovna();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Файл не існує.");
            }
        }

        private void зберегтиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void SaveToFile()
        {
            try
            {
                string FilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\players.txt";
                List<PlayerInfo> players = ExtractPlayersFromListView();
                using (var writer = new StreamWriter(FilePath))
                {
                    foreach (var player in players)
                    {
                        writer.WriteLine("Name: " + player.Name);
                        writer.WriteLine("Nationality: " + player.Nationality);
                        writer.WriteLine("Gender: " + player.Gender);
                        writer.WriteLine("Years: " + player.Years);
                        writer.WriteLine("Club: " + player.Club);
                        writer.WriteLine("Achievement: " + player.Achievement);
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Дані успішно збережено в файлі.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message);
            }
        }

        private List<PlayerInfo> ExtractPlayersFromListView()
        {
            var players = new List<PlayerInfo>();

            foreach (ListViewItem item in listView1.Items)
            {
                var player = new PlayerInfo
                {
                    Name = item.SubItems[0].Text,
                    Nationality = item.SubItems[1].Text.Replace("Національність: ", ""),
                    Gender = item.SubItems[2].Text,
                    Years = int.Parse(item.SubItems[3].Text.Replace(" років", "")),
                    Club = item.SubItems[4].Text.Replace("Клуб: ", ""),
                    Achievement = int.Parse(item.SubItems[5].Text.Split(' ')[0])
                };
                players.Add(player);
            }

            return players;
        }


        private void закритиПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewPlayer();
        }

        private void AddNewPlayer()
        {
            try
            {
                string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";
                string jsonData = File.ReadAllText(jsonFilePath);
                var data = JsonSerializer.Deserialize<SportsData>(jsonData);
                string[] lines = richTextBox2.Lines;

                if (comboBox1.SelectedItem != null)
                {
                    string selectedSport = comboBox1.SelectedItem.ToString();
                    AddPlayerToData(data, selectedSport, lines);
                    SaveUpdatedData(jsonFilePath, data);
                    toolStripProgressBar1.Value = 100;
                    MessageBox.Show("Гравця успішно додано");
                    toolStripProgressBar1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Для початку оберіть вид спорту.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void AddPlayerToData(SportsData data, string selectedSport, string[] lines)
        {
            switch (selectedSport)
            {
                case "Football":
                    data.FootballPlayers.Add(CreateFootballPlayer(lines));
                    break;
                case "Hockey":
                    data.HockeyPlayers.Add(CreateHockeyPlayer(lines));
                    break;
                case "Basketball":
                    data.BasketballPlayers.Add(CreateBasketballPlayer(lines));
                    break;
            }
        }

        private FootballPlayer CreateFootballPlayer(string[] lines)
        {
            return new FootballPlayer
            {
                Name = lines[0],
                Nationality = lines[1],
                Gender = lines[2],
                Years = int.Parse(lines[3]),
                Club = lines[4],
                Achievement = int.Parse(lines[5])
            };
        }

        private HockeyPlayer CreateHockeyPlayer(string[] lines)
        {
            return new HockeyPlayer
            {
                Name = lines[0],
                Nationality = lines[1],
                Gender = lines[2],
                Years = int.Parse(lines[3]),
                Club = lines[4],
                Achievement = int.Parse(lines[5])
            };
        }

        private BasketballPlayer CreateBasketballPlayer(string[] lines)
        {
            return new BasketballPlayer
            {
                Name = lines[0],
                Nationality = lines[1],
                Gender = lines[2],
                Years = int.Parse(lines[3]),
                Club = lines[4],
                Achievement = int.Parse(lines[5])
            };
        }

        private void SaveUpdatedData(string jsonFilePath, SportsData data)
        {
            string updatedJsonData = JsonSerializer.Serialize(data);
            File.WriteAllText(jsonFilePath, updatedJsonData);
        }

        private void створитиНовуБазуДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDatabase();
        }

        private void CreateNewDatabase()
        {
            try
            {
                string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";

                var newData = new SportsData();
                string jsonData = JsonSerializer.Serialize(newData);
                File.WriteAllText(jsonFilePath, jsonData);

                MessageBox.Show("Нову базу даних успішно створено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeletePlayer();
        }

        private void DeletePlayer()
        {
            try
            {
                string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";
                string jsonData = File.ReadAllText(jsonFilePath);
                var data = JsonSerializer.Deserialize<SportsData>(jsonData);
                string playerNameToDelete = richTextBox2.Text.ToLower();

                if (comboBox1.SelectedItem != null)
                {
                    string selectedSport = comboBox1.SelectedItem.ToString();
                    bool playerDeleted = RemovePlayerFromData(data, selectedSport, playerNameToDelete);

                    if (playerDeleted)
                    {
                        SaveUpdatedData(jsonFilePath, data);
                        toolStripProgressBar1.Value = 100;
                        MessageBox.Show("Гравця успішно видалено");
                        toolStripProgressBar1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Гравця не знайдено.");
                    }
                }
                else
                {
                    MessageBox.Show("Для початку оберіть вид спорту.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private bool RemovePlayerFromData(SportsData data, string selectedSport, string playerNameToDelete)
        {
            bool playerDeleted = false;

            switch (selectedSport)
            {
                case "Football":
                    playerDeleted = RemovePlayer(data.FootballPlayers, playerNameToDelete);
                    break;
                case "Hockey":
                    playerDeleted = RemovePlayer(data.HockeyPlayers, playerNameToDelete);
                    break;
                case "Basketball":
                    playerDeleted = RemovePlayer(data.BasketballPlayers, playerNameToDelete);
                    break;
            }

            return playerDeleted;
        }

        private bool RemovePlayer<T>(List<T> players, string playerNameToDelete) where T : PlayerInfo
        {
            var playerToDelete = players.FirstOrDefault(p => p.Name.ToLower() == playerNameToDelete);
            if (playerToDelete != null)
            {
                players.Remove(playerToDelete);
                return true;
            }
            return false;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                string name = selectedItem.SubItems[0].Text;
                string nationality = selectedItem.SubItems[1].Text.Replace("Національність: ", "");
                string gender = selectedItem.SubItems[2].Text;
                int years = int.Parse(selectedItem.SubItems[3].Text.Replace(" років", ""));
                string club = selectedItem.SubItems[4].Text.Replace("Клуб: ", "");
                int achievement = int.Parse(selectedItem.SubItems[5].Text.Split(' ')[0]);

                string sportCategory = "FootballPlayers";
                if (selectedItem.SubItems[5].Text.Contains("забитих голів"))
                {
                    sportCategory = "FootballPlayers";
                }
                else if (selectedItem.SubItems[5].Text.Contains("забитих шайб"))
                {
                    sportCategory = "HockeyPlayers";
                }
                else if (selectedItem.SubItems[5].Text.Contains("забитих м'ячів"))
                {
                    sportCategory = "BasketballPlayers";
                }

                var redagyvannya = new Redagyvannya(name, nationality, gender, years, club, achievement, sportCategory);
                redagyvannya.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Оберіть спортсмена");
            }
        }


        private void sportsmen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
