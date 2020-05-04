using System;
using System.Collections.Generic;
using System.Linq;

namespace Applicatie
{
    class Information
    {
        public static void showinfo()
        {
            // hier komen alle details over ons bedrijf
            string companyName = "420 Inch Spacebarz";
            string companyInfo = "We make Escape Rooms for everyone who enjoys puzzling and problem solving!";
            string twitterInfo = "@420inchspacebarz";
            string facebookInfo = "420 Inch Spacebarz";
            string emailInfo = "420inchspacebarz@hotmail.com";
            string phoneNum = "0612345678";
            string location = "Wijnhaven 107  3011 WN";

            // hier wordt alles geprint naar console
            Console.WriteLine("======================================" +
            "\nAlle informatie over het bedrijf: \n\n" +
            $"{companyName}\n" +
            $"{companyInfo}\n\n" + 
            "if you have a question, you can always contact us through:\n" +
            $"Twitter: {twitterInfo}\n" +
            $"Facebook: {facebookInfo}\n" +
            $"E-mail: {emailInfo}\n" +
            $"Phone number: {phoneNum}\n" +
            $"Location: {location}\n" +
            "======================================\n" +
            "Please press enter to return to the menu"
            );
        }

    }
}

