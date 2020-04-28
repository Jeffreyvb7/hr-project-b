using System.Linq;

namespace Applicatie
{
    // We maken hier gebruik van een abstracte class genaamd "AJsonable"
    // Door gebruik te maken van een abstracte class verplicht je de implementatie van Edit() en Save()
    // Als je ooit meer wilt gaan opslaan dan kun je op deze manier dit makkelijker realiseren
    class EscapeRoom : AJsonable
    {
        public string Name { get; set; }
        public string Theme { get; set; }
        public float Price { get; set; }
        public int MaxPlayers { get; set; }
        public int MaxDuration { get; set; }
        public int SetupTime { get; set; }

        // Niet geimplementeerd in orgineel
        public override void Edit() {
            throw new System.NotImplementedException();
        }

        public override void Save() {
            JsonManager.SaveData(this, "EscapeRooms", this.Name);
        }

        public override string ToString()
        {
            return string.Format(
                $"\tName: {this.Name}, \n" +
                $"\tTheme; {this.Theme}, \n" +
                $"\tPrice: {this.Price}, \n" +
                $"\tMax players: {this.MaxPlayers}, \n" +
                $"\tDuration: {this.MaxDuration}, \n" +
                $"\tSetup: {this.SetupTime}");
        } 
    }
}
