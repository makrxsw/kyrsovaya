using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovaya
{
    public partial class Redagyvannya : Form
    {
        private string _name;
        private string _nationality;
        private string _gender;
        private int _years;
        private string _club;
        private int _achievement;
        private string _sportCategory;

        public Redagyvannya(string name, string nationality, string gender, int years, string club, int achievement, string sportCategory)
        {
            InitializeComponent();
            _name = name;
            _nationality = nationality;
            _gender = gender;
            _years = years;
            _club = club;
            _achievement = achievement;
            _sportCategory = sportCategory;
            txtOldName.Text = _name;
            txtOldNationality.Text = _nationality;
            txtGender.Text = _gender;
            txtOldYears.Text = Convert.ToString(_years);
            txtOldClub.Text = _club;
            Category.Text = _sportCategory;
            txtOldAchievement.Text = Convert.ToString(_achievement);
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sportsmen form3 = new sportsmen();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string oldName = _name;
                int oldYears = _years;
                string oldClub = _club;
                int oldAchievement = _achievement;
                string oldNationality = _nationality;
                string sportCategory = _sportCategory;

                string newName = string.IsNullOrWhiteSpace(txtNewName.Text) ? oldName : txtNewName.Text;
                int newYears = string.IsNullOrWhiteSpace(txtNewYears.Text) ? oldYears : Convert.ToInt32(txtNewYears.Text);
                string newClub = string.IsNullOrWhiteSpace(txtNewClub.Text) ? oldClub : txtNewClub.Text;
                int newAchievement = string.IsNullOrWhiteSpace(txtNewAchievement.Text) ? oldAchievement : Convert.ToInt32(txtNewAchievement.Text);
                string newNationality = string.IsNullOrWhiteSpace(txtNewNationality.Text) ? oldNationality : txtNewNationality.Text;



                string jsonFilePath = "C:\\Users\\drmak\\OneDrive\\Рабочий стол\\kyrsovaya(1)\\json1.json";

                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    var jsonObj = JsonConvert.DeserializeObject<Dictionary<string, List<Dictionary<string, object>>>>(json);

                    if (jsonObj != null && jsonObj.ContainsKey(sportCategory))
                    {
                        var players = jsonObj[sportCategory];
                        var playerToEdit = players.FirstOrDefault(player =>
                            player["Name"].ToString() == oldName &&
                            Convert.ToInt32(player["Years"]) == oldYears &&
                            player["Club"].ToString() == oldClub &&
                            Convert.ToInt32(player["Achievement"]) == oldAchievement &&
                            player["Nationality"].ToString() == oldNationality
                        );

                        if (playerToEdit != null)
                        {
                            playerToEdit["Name"] = newName;
                            playerToEdit["Years"] = newYears;
                            playerToEdit["Club"] = newClub;
                            playerToEdit["Achievement"] = newAchievement;
                            playerToEdit["Nationality"] = newNationality;

                            string updatedJson = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                            File.WriteAllText(jsonFilePath, updatedJson);

                            MessageBox.Show("Спортсмен було відредаговано успішно!");
                        }
                        else
                        {
                            MessageBox.Show("Спортсмен не знайдений.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Дані не знайдені.");
                    }
                }
                else
                {
                    MessageBox.Show("Файл не знайдено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
            }
        }

        private void Redagyvannya_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
