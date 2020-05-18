using System;
using System.Collections.Generic;
using System.Linq;

namespace Applicatie
{
    class Information
    {
        public static void showinfo()
        {
            var information = JsonManager.GetData<InformationItems>("InfoPage", "information");

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

    }

    class InformationItems
    {
        public string companyName { get; set; }
        public string companyInfo { get; set; }
        public string twitterInfo { get; set; }
        public string facebookInfo { get; set; }
        public string emailInfo { get; set; }
        public string phoneNum { get; set; }
        public string location { get; set; }

    }
}

