using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Applicatie
{
    class Information
    {
        public string CompanyName { get; set; }
        public string CompanyInfo { get; set; }
        public string TwitterInfo { get; set; }
        public string FacebookInfo { get; set; }
        public string EmailInfo { get; set; }
        public string PhoneNum { get; set; }
        public string Location { get; set; }

        public static void ShowInfo()
        {
            var information = JsonManager.GetData<Information>("InfoPage", "information");

            // hier wordt alles geprint naar console
            Console.WriteLine("======================================" +
            "\nAlle informatie over het bedrijf: \n\n" +
            $"{information.CompanyName}\n" +
            $"{information.CompanyInfo}\n\n" +
            "if you have a question, you can always contact us through:\n" +
            $"Twitter: {information.TwitterInfo}\n" +
            $"Facebook: {information.FacebookInfo}\n" +
            $"E-mail: {information.EmailInfo}\n" +
            $"Phone number: {information.PhoneNum}\n" +
            $"Location: {information.Location}\n" +
            "======================================\n"
            );
        }

        public static void EditInfo()
        {
            var information = JsonManager.GetData<Information>("InfoPage", "information");
            Console.Clear();
            Console.Write(
                "Choose what you want to edit:\n" +
                "\t1 - Company Name\n" +
                "\t2 - Company Info\n" +
                "\t3 - Twitter\n" +
                "\t4 - Facebook\n" +
                "\t5 - Email\n" +
                "\t6 - Phone Number\n" +
                "\t7 - Location\n" +
                "\t= - Cancel\n" +
                "\nPlease choose one of the following options:\n"
            );

            while(true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        EditInfoJson(information, "CompanyName");
                        return;
                    case "2":
                        EditInfoJson(information, "CompanyInfo");
                        return;
                    case "3":
                        EditInfoJson(information, "TwitterInfo");
                        return;
                    case "4":
                        EditInfoJson(information, "FacebookInfo");
                        return;
                    case "5":
                        EditInfoJson(information, "EmailInfo");
                        return;
                    case "6":
                        EditInfoJson(information, "PhoneNum");
                        return;
                    case "7":
                        EditInfoJson(information, "Location");
                        return;
                    case "=":
                        return;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            }
        }

        private static void EditInfoJson(Information information, string property)
        {
            Console.Clear();
            var currentValue = information.GetType().GetProperty(property).GetValue(information);

            Console.Write(
                $"Editing {property}, currently: {currentValue}\n" +
                $"Please enter new {property}: \n"
            );

            while(true)
            {
                string value = Console.ReadLine();
                if(value.Any())
                {
                    information.GetType().GetProperty(property).SetValue(information, value, null);
                    Console.Clear();
                    Console.WriteLine($"New {property}: {value}");
                    JsonManager.SaveData<Information>(information, "InfoPage", "information");
                    return;
                } else {
                    Console.WriteLine("You need to enter something");
                }
            }

        }

    }
}

