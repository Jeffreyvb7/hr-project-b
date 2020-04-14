using System;
namespace Applicatie
{
    public class Menuscherm
    {
        public static void FoodDrinkMenu()
        {
            Tuple<string, double>[] menuDrinks = {
            Tuple.Create("Water", 0.0),
            Tuple.Create("Juice (Orange/Apple)", 2.0),
            Tuple.Create("Soda", 2.0),
            Tuple.Create("Beer", 4.0),
            Tuple.Create("Aquarius", 3.50)
            };
            Tuple<string, double>[] menuFoods = {
            Tuple.Create("Sandwich", 5.0),
            Tuple.Create("Bifi", 0.5),
            Tuple.Create("Frikandel", 2.0),
            Tuple.Create("Bitterballs (4)", 4.0),
            Tuple.Create("Jodenkoek", 1.0)
            };

        Console.WriteLine("Food and drinks can be purchased on location. Please see the menu below.\n");
        Console.WriteLine("Drinks: \n==========");
        for(int i = 0; i < menuDrinks.Length; i++) { //Drinks 
            Console.WriteLine(menuDrinks[i]);
            }
        Console.WriteLine("==========\n\nFoods: \n==========");
        for(int i = 0; i < menuFoods.Length; i++) { //Foods   
            Console.WriteLine(menuFoods[i]);
            }
        Console.WriteLine("==========");
            
        }//end
    }
}
