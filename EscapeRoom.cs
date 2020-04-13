using System.Linq;

namespace Applicatie
{
    // We maken hier gebruik van een abstracte class genaamd "AJsonable"
    // Door gebruik te maken van een abstracte class verplicht je de implementatie van Edit() en Save()
    // Als je ooit meer wilt gaan opslaan dan kun je op deze manier dit makkelijker realiseren
    class EscapeRoom : AJsonable
    {
        public string name { get; set; }
        public string theme { get; set; }
        public float price { get; set; }
        public int maxPlayers { get; set; }
        public int maxDuration { get; set; }
        public int setupTime { get; set; }

        // Niet geimplementeerd in orgineel
        public override void Edit() {
            throw new System.NotImplementedException();
        }

        public override void Save() {
            JsonManager.SaveData(this, "EscapeRooms", this.name);
        }

        public override string ToString()
        {
            return string.Format(
                $"\tName: {this.name}, \n" +
                $"\tTheme; {this.theme}, \n" +
                $"\tPrice: {this.price}, \n" +
                $"\tMax players: {this.maxPlayers}, \n" +
                $"\tDuration: {this.maxDuration}, \n" +
                $"\tSetup: {this.setupTime}");
        } 
    }
}
