using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Applicatie
{
    class Information
    {
        public string companyName { get; set; }
        public string companyInfo { get; set; }
        public string twitterInfo { get; set; }
        public string facebookInfo { get; set; }
        public string emailInfo { get; set; }
        public string phoneNum { get; set; }
        public string location { get; set; }

        public static void showinfo()
        {
            var information = JsonManager.GetData<Information>("InfoPage", "information");

            // hier wordt alles geprint naar console
            Console.WriteLine("======================================" +
            "\nAlle informatie over het bedrijf: \n\n" +
            $"{information.companyName}\n" +
            $"{information.companyInfo}\n\n" +
            "if you have a question, you can always contact us through:\n" +
            $"Twitter: {information.twitterInfo}\n" +
            $"Facebook: {information.facebookInfo}\n" +
            $"E-mail: {information.emailInfo}\n" +
            $"Phone number: {information.phoneNum}\n" +
            $"Location: {information.location}\n" +
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
                        EditInfoJson(information, "companyName");
                        break;
                    case "2":
                        EditInfoJson(information, "companyInfo");
                        break;
                    case "3":
                        EditInfoJson(information, "twitterInfo");
                        break;
                    case "4":
                        EditInfoJson(information, "facebookInfo");
                        break;
                    case "5":
                        EditInfoJson(information, "emailInfo");
                        break;
                    case "6":
                        EditInfoJson(information, "phoneNum");
                        break;
                    case "7":
                        EditInfoJson(information, "location");
                        break;
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

