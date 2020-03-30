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
        public int Max_duration { get; set; }
        public int Setup_time { get; set; }

        // Niet geimplementeerd in orgineel
        public override void Edit() {
            throw new System.NotImplementedException();
        }

        public override void Save() {
            JsonManager.SaveData(this, this.Name);
        }

        public override string ToString()
        {
            return string.Format(
                $"\tName: {this.Name}, \n" +
                $"\tTheme; {this.Theme}, \n" +
                $"\tPrice: {this.Price}, \n" +
                $"\tDuration: {this.Max_duration}, \n" +
                $"\tSetup: {this.Setup_time}");
        } 
    }
}
