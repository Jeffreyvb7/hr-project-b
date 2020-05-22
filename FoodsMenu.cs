using System;
using System.Linq;
using System.IO;

namespace Applicatie
{
    public class FoodsMenu
    {
        public string[] Foods { get; set; }
        public string[] Beverages { get; set; }

        public static void DisplayMenu()
        {
            var FoodsMenu = JsonManager.GetData<FoodsMenu>("FoodsMenu", "Menu");

            Console.WriteLine("Foods: ");
            foreach (string item in FoodsMenu.Foods)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nBeverages: ");
            foreach (string item in FoodsMenu.Beverages)
            {
                Console.WriteLine($"\t{item}");
            }
        }

        public static void MenuForFoodsMenu()
        {
            var foodsMenu = JsonManager.GetData<FoodsMenu>("FoodsMenu", "Menu");

            Console.Clear();
            Console.Write(
                "Managing Foods and Beverages:\n" +
                "\t1 - Add Food\n" +
                "\t2 - Remove Food\n" +
                "\t3 - Add Drink\n" +
                "\t4 - Remove Drink\n" +
                "\t= - Cancel\n" +
                "\nPlease choose one of the following options:\n"
            );

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        AddFoodItem(foodsMenu);
                        Program.PressEnterToContinueInConsole();
                        return;
                    case "2":
                        RemoveFoodItem(foodsMenu);
                        Program.PressEnterToContinueInConsole();
                        return;
                    case "3":
                        AddBeverageItem(foodsMenu);
                        Program.PressEnterToContinueInConsole();
                        return;
                    case "4":
                        RemoveBeverageItem(foodsMenu);
                        Program.PressEnterToContinueInConsole();
                        return;
                    case "=":
                        return;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            }

        }

        public static void AddFoodItem(FoodsMenu foodsMenu)
        {
            Console.WriteLine($"You have chosen to add a food");

            string item         = AskForMenuItem($"Enter food name: ");
            double price        = AskForMenuItemPrice($"Enter price for {item}: ");
            string[] newArray   = new string[(foodsMenu.Foods.Length + 1)];

            int i = 0;
            foreach (string menuItem in foodsMenu.Foods)
            {
                newArray[i] = menuItem;
                i++;
            }

            while (item.Length < 15)
            {
                item = item + " ";
            }

            string foodItem = $"{item} - {price}";
            newArray[i]     = foodItem;
            foodsMenu.Foods = newArray;

            JsonManager.SaveData<FoodsMenu>(foodsMenu, "FoodsMenu", "Menu");
            Console.WriteLine($"{foodItem} added");
        }

        public static void RemoveFoodItem(FoodsMenu foodsMenu)
        {
            Console.Clear();
            Console.WriteLine("Removing food item: ");
            int i = 1;
            foreach (string item in foodsMenu.Foods)
            {
                Console.WriteLine($"\t{i} : {item}");
                i++;
            }

            Console.WriteLine("\nChoose number you want to delete: ");

            int awnser      = Int32.Parse(Console.ReadLine()) - 1;
            foodsMenu.Foods = foodsMenu.Foods.Where(val => val != foodsMenu.Foods[awnser]).ToArray();
            JsonManager.SaveData<FoodsMenu>(foodsMenu, "FoodsMenu", "Menu");
            Console.WriteLine("Food removed");
        }

        public static void AddBeverageItem(FoodsMenu foodsMenu)
        {
            Console.WriteLine($"You have chosen to add a beverage");

            string item         = AskForMenuItem($"Enter berage name: ");
            double price        = AskForMenuItemPrice($"Enter price for {item}: ");
            string[] newArray   = new string[(foodsMenu.Beverages.Length + 1)];

            int i = 0;
            foreach (string menuItem in foodsMenu.Beverages)
            {
                newArray[i] = menuItem;
                i++;
            }

            while (item.Length < 15)
            {
                item = item + " ";
            }

            string foodItem     = $"{item} - {price}";
            newArray[i]         = foodItem;
            foodsMenu.Beverages = newArray;

            JsonManager.SaveData<FoodsMenu>(foodsMenu, "FoodsMenu", "Menu");
            Console.WriteLine($"{foodItem} added");
        }

        public static void RemoveBeverageItem(FoodsMenu foodsMenu)
        {
            Console.Clear();
            Console.WriteLine("Removing beverage item: ");
            int i = 1;
            foreach (string item in foodsMenu.Beverages)
            {
                Console.WriteLine($"\t{i} : {item}");
                i++;
            }

            Console.WriteLine("\nChoose number you want to delete: ");

            int awnser          = Int32.Parse(Console.ReadLine()) - 1;
            foodsMenu.Beverages = foodsMenu.Beverages.Where(val => val != foodsMenu.Beverages[awnser]).ToArray();
            JsonManager.SaveData<FoodsMenu>(foodsMenu, "FoodsMenu", "Menu");
            Console.WriteLine("Beverage removed");
        }

        public static string AskForMenuItem(string question)
        {
            Console.Write(question);
            while (true)
            {
                string answer = Console.ReadLine();

                if (answer.Any() && answer.Length < 15)
                    return answer;
                else
                    Console.WriteLine("You need to awnser the question with a name with less then 15 chars");
            }
        }

        public static double AskForMenuItemPrice(string question)
        {
            Console.Write(question);
            while (true)
            {
                double answer = double.Parse(Console.ReadLine());

                try
                {
                    return answer;
                }

                catch
                {
                    Console.WriteLine("Please enter a valid price");
                    continue;
                }

            }
        }

    }
}
